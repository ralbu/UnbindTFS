using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace UnbindTFS
{
    public partial class Form1 : Form
    {
        Unbind _unbind = new Unbind();

        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (dlgFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                tbLocation.Text = dlgFolderBrowser.SelectedPath;
            }

            
        }

        private void Unbind_Click(object sender, EventArgs e)
        {
            btUnbind.Enabled = false;
            btOpen.Enabled = false;
            try
            {
                if (String.IsNullOrEmpty(tbLocation.Text))
                    throw new ArgumentNullException("Location path was not provided");

                _unbind.RunUnbind(tbLocation.Text, tbIgnore.Text);

                lbStatus.Text = "Done successfully";
            }
            catch (Exception ex)
            {
                lbStatus.Text = "Done with error";
                _unbind.Log(ex.ToString());
            }
            finally
            {
                btUnbind.Enabled = true;
                btOpen.Enabled = true;
                
                lkLogFile.Text = _unbind.LogFileName;
            }
        }

        private void LogFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(lkLogFile.Text);
            }
            catch
            {
                MessageBox.Show("Can't open log file");
            }
        }
    }
}
