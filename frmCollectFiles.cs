using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileCollector
{
    public partial class frmCollectFiles : Form
    {
        public frmCollectFiles()
        {
            InitializeComponent();
        }

        private void btnCopyFiles_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (fnValidateInputs() == true)
                {
                    if (Directory.Exists(txtDestinationPath.Text) == false)
                        Directory.CreateDirectory(txtDestinationPath.Text);

                    int iFileCount = 0;

                    string[] sFileNames;
                    sFileNames = txtFileNames.Text.Split(new char[] { ',', ';', '\r', '\n' });


                    StringBuilder sblog = new StringBuilder();
                    sblog.AppendLine("Missing file(s)");


                    foreach (string sFileName in sFileNames)
                    {
                        if (sFileName == "") continue;

                        string sFilePath = txtFileDirectoryPath.Text + "\\" + string.Format(txtFileExt.Text.ToString().Trim(), sFileName);

                        if (File.Exists(sFilePath) == true)
                        {
                            CopyFile(sFilePath, txtDestinationPath.Text + "\\" + Path.GetFileName(sFilePath), true);
                            iFileCount++;
                        }
                        else if (chkSearch.Checked == true)
                        {
                            string dirPath = Path.GetDirectoryName(sFileName);
                            string[] files = null;
                            if (string.IsNullOrEmpty(dirPath) == true)
                                files = Directory.GetFiles(txtFileDirectoryPath.Text, Path.GetFileName(string.Format(txtFileExt.Text.ToString().Trim(), sFileName)), SearchOption.AllDirectories);
                            else
                                files = Directory.GetFiles(dirPath, Path.GetFileName(string.Format(txtFileExt.Text.ToString().Trim(), sFileName)), SearchOption.AllDirectories);

                            foreach (string sfile in files)
                            {
                                string sDestipath = sfile.Replace(txtFileDirectoryPath.Text, txtDestinationPath.Text + "\\");
                                CopyFile(sfile, sDestipath, true);

                                iFileCount++;
                            }
                            if (files.Length == 0)
                            {
                                sblog.AppendLine(sFileName);
                            }
                        }
                        else
                        {
                            sblog.AppendLine(sFileName);
                        }
                    }
                    File.WriteAllText("MissingFiles.log", sblog.ToString());
                    MessageBox.Show("[" + iFileCount + "] File(s) Collected successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnMoveFiles_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (fnValidateInputs() == true && MessageBox.Show("Are you sure want to move files?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (Directory.Exists(txtDestinationPath.Text) == false)
                        Directory.CreateDirectory(txtDestinationPath.Text);

                    int iFileCount = 0;

                    string[] sFileNames;
                    sFileNames = txtFileNames.Text.Split(new char[] { ',', ';', '\r', '\n' });

                    StringBuilder sblog = new StringBuilder();
                    sblog.AppendLine("Missing file(s)");


                    foreach (string sFileName in sFileNames)
                    {
                        if (sFileName == "") continue;

                        string sFilePath = txtFileDirectoryPath.Text + "\\" + string.Format(txtFileExt.Text.ToString().Trim(), sFileName);

                        if (File.Exists(sFilePath) == true)
                        {
                            MoveFile(sFilePath, txtDestinationPath.Text + "\\" + Path.GetFileName(sFilePath), true);
                            iFileCount++;
                        }
                        else if (chkSearch.Checked == true)
                        {
                            string dirPath = Path.GetDirectoryName(sFileName);
                            string[] files = null;
                            if (string.IsNullOrEmpty(dirPath) == true)
                                files = Directory.GetFiles(txtFileDirectoryPath.Text, Path.GetFileName(string.Format(txtFileExt.Text.ToString().Trim(), sFileName)), SearchOption.AllDirectories);
                            else
                                files = Directory.GetFiles(dirPath, Path.GetFileName(string.Format(txtFileExt.Text.ToString().Trim(), sFileName)), SearchOption.AllDirectories);

                            foreach (string sfile in files)
                            {
                                string sDestipath = sfile.Replace(txtFileDirectoryPath.Text, txtDestinationPath.Text + "\\");
                                MoveFile(sfile, sDestipath, true);

                                iFileCount++;
                            }
                            if (files.Length == 0)
                            {
                                sblog.AppendLine(sFileName);
                            }
                        }
                        else
                        {
                            sblog.AppendLine(sFileName);
                        }
                    }
                    File.WriteAllText("MissingFiles.log", sblog.ToString());
                    MessageBox.Show("[" + iFileCount + "] File(s) moved successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (fnValidateInputs() == true && MessageBox.Show("Are you sure want to rename file(s)?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (Directory.Exists(txtDestinationPath.Text) == false)
                        Directory.CreateDirectory(txtDestinationPath.Text);

                    string[] sFileNames;
                    sFileNames = txtFileNames.Text.Split(new char[] { ';', '\r', '\n' });

                    string[] Token;

                    int iFileCount = 0;
                    foreach (string item in sFileNames)
                    {
                        if (item == "") continue;
                        Token = item.Split(new char[] { ',', '\t' });
                        if (Token.Length >= 2)
                        {
                            string sFilePath = txtFileDirectoryPath.Text + "\\" + string.Format(txtFileExt.Text.ToString().Trim(), Token[0]);
                            string sNewFilePath = txtFileDirectoryPath.Text + "\\" + string.Format(txtFileExt.Text.ToString().Trim(), Token[1]);

                            if (File.Exists(sFilePath) == true)
                            {
                                MoveFile(sFilePath, sNewFilePath, true);
                                iFileCount++;
                            }
                        }

                    }
                    MessageBox.Show("[" + iFileCount + "] File(s) renamed successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private bool fnValidateInputs()
        {
            try
            {
                if (txtFileExt.Text.Trim() == "")
                    txtFileExt.Text = "{0}";

                if (txtFileDirectoryPath.Text == "" || Directory.Exists(txtFileDirectoryPath.Text) == false)
                {
                    MessageBox.Show("Please enter valid input directory path", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFileDirectoryPath.Focus();
                    return false;
                }
                else if (txtFileExt.Text == "")
                {
                    MessageBox.Show("Please enter valid file extension", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFileExt.Focus();
                    return false;
                }
                else if (txtDestinationPath.Text == "")
                {
                    MessageBox.Show("Please enter valid Destination directory", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDestinationPath.Focus();
                    return false;
                }
                else if (txtFileNames.Text == "")
                {
                    MessageBox.Show("Please enter valid file name(s)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFileNames.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmCollectFiles_Load(object sender, EventArgs e)
        {
            try
            {
                txtFileDirectoryPath.Text = FileCollector.Properties.Settings.Default.DirectoryPath.ToString();
                txtFileExt.Text = FileCollector.Properties.Settings.Default.FileExtention.ToString();
                txtDestinationPath.Text = FileCollector.Properties.Settings.Default.DestinationPath.ToString();

                if (txtFileExt.Text.Trim() == "")
                    txtFileExt.Text = "{0}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmCollectFiles_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                FileCollector.Properties.Settings.Default.DirectoryPath = txtFileDirectoryPath.Text.ToString();
                FileCollector.Properties.Settings.Default.FileExtention = txtFileExt.Text.ToString();
                FileCollector.Properties.Settings.Default.DestinationPath = txtDestinationPath.Text.ToString();
                FileCollector.Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CopyFile(string SourcePath, string DestPath, bool Overwrite)
        {
            try
            {
                if (Directory.Exists(Path.GetDirectoryName(DestPath)) == false)
                    Directory.CreateDirectory(Path.GetDirectoryName(DestPath));
                File.Copy(SourcePath, DestPath, Overwrite);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void MoveFile(string SourcePath, string DestPath, bool Overwrite)
        {
            try
            {
                if (Directory.Exists(Path.GetDirectoryName(DestPath)) == false)
                    Directory.CreateDirectory(Path.GetDirectoryName(DestPath));
                if (Overwrite == true && File.Exists(DestPath) == true)
                {
                    File.Delete(DestPath);
                }
                if (File.Exists(DestPath) == false)
                {
                    File.Move(SourcePath, DestPath);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/kanji-keraliya");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
