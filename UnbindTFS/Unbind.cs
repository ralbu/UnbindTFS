using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace UnbindTFS
{
    internal class Unbind
    {
        private StreamWriter _logStream;
        private string _folderName;
        private string _logFileName;
        private List<string> _ignorePaths = new List<string>();
        
        internal string LogFileName
        {
            get
            {
                if (_logFileName == null)
                {
                    DirectoryInfo info = new DirectoryInfo(_folderName);
                    _logFileName = Path.Combine(info.FullName, "Unbind-log.txt");
                }
                return _logFileName;
            }
        }

        internal void RunUnbind(string folderName, string ignorePaths = null)
        {
            _folderName = folderName;
            
            try
            {
                if (ignorePaths != null) FillIgnorePaths(ignorePaths);

                Log("Start unbind");

                var solutionFiles = FilterFiles(Directory.GetFiles(folderName, "*.sln", SearchOption.AllDirectories));
                var projectFiles = FilterFiles(Directory.GetFiles(folderName, "*.csproj", SearchOption.AllDirectories));
                var slnAndProj = new List<string>(solutionFiles);
                slnAndProj.AddRange(projectFiles);
                
                UnbindSolutionsOrProjects(new List<string>(slnAndProj));

                var slnScc = FilterFiles(Directory.GetFiles(folderName, "*.vssscc", SearchOption.AllDirectories));
                var prjScc = FilterFiles(Directory.GetFiles(folderName, "*.vspscc", SearchOption.AllDirectories));
                var allScc = new List<string>(slnScc);
                allScc.AddRange(prjScc);
                
                DeleteFiles(allScc);
            }
            catch (Exception ex)
            {
                Log(ex.ToString());
            }
            finally
            {
                _logStream.Close();
            }
        }

        private List<string> FilterFiles(IEnumerable<string> files)
        {
            return files.Where(file => !IgnoreFile(file)).ToList();
        }

        private void UnbindSolutionsOrProjects(IEnumerable<string> files)
        {
            Log("================== Start unbinding ==================");
            
            foreach (var file in files)
            {
                Log("Unbind file {0}", file);
                
                var lines = new List<string>();
                bool delete = false;
                
                using (var input = File.OpenText(file))
                {
                    string line = null;
                    while ((line = input.ReadLine()) != null)
                    {
                        // start deleting
                        if (line.Trim().ToLower().Contains("globalsection(teamfoundationversioncontrol)"))
                        {
                            delete = true;
                            Log("----- Start deleting solution lines----");
                            Log("Delete line: {0}", line);
                        }
                        else if (delete && line.Trim().ToLower().Contains("endglobalsection"))
                        {
                            delete = false;
                            Log("Delete line: {0}", line);
                            Log("----- End deleting solution lines for file {0}----", file);
                        }
                        else if (delete)
                        {
                            Log("Delete line: {0}", line);
                        }
                        else if (line.Trim().ToLower().Contains("<scc"))
                        {
                            Log("Delete line: {0}", line);
                        }
                        else
                        {
                            lines.Add(line);
                        }
                    }
                }
                SaveFile(file, lines);
            }

            Log("================== End unbinding ==================");
        }

        private void SaveFile(string file, IEnumerable<string> output)
        {

            using (var writer = new StreamWriter(file))
            {
                foreach (var line in output)
                {
                    writer.WriteLine(line);
                }
                writer.Close();
            }
        }

        private void DeleteFiles(List<string> deleteFiles)
        {
            Log("================== Start deleting ==================");
            foreach (var file in deleteFiles)
            {
                Log("Delete file: {0}", file);
                File.Delete(file);
            }
            Log("================== End deleting ==================");
        }

        private bool IgnoreFile(string fileName)
        {
            return _ignorePaths.Any(ignorePath => fileName.Contains(ignorePath));
        }

        private void FillIgnorePaths(string ignorePaths)
         {
             var lines = ignorePaths.Split(';');

             _ignorePaths = lines.ToList();
         }

        internal void Log(string log, params object[] args)
         {
             if (_logStream == null)
             {
                 _logStream = new StreamWriter(LogFileName, true);
             }

             if (args != null)
             {
                 _logStream.WriteLine(log, args);
             }
             else
             {
                 _logStream.WriteLine(log);
             }
         }
    }
}
