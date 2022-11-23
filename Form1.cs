using System.Text;

namespace FileNameManipulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeForm();

        }

        private void btnOpenFiles_Click(object sender, EventArgs e)
        {
            ofdFilebrowse.Multiselect = true;
            ofdFilebrowse.Title = "Select File(s)";

            DialogResult dr = ofdFilebrowse.ShowDialog();
            if (dr == DialogResult.OK)
            {
                List<string> lstFileNames = new List<string>();
                lstFileNames.AddRange((chkShowPath.Checked) ? ofdFilebrowse.FileNames : ofdFilebrowse.SafeFileNames);
                if (lstFileNames.Count > 0)
                {
                    lvResultsApplied.Clear();
                    lvOpenedFiles.Clear();
                    lvOpenedFiles.Columns.Add("File Name");
                    lvOpenedFiles.Columns[0].Width = lvOpenedFiles.Width;
                    lvOpenedFiles.GridLines = true;
                    lvOpenedFiles.Enabled = true;

                    foreach (String file in lstFileNames)
                    {
                        try
                        {
                            lvOpenedFiles.Items.Add(file);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }

                    grpOps.Show();
                    btnClear.Show();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            InitializeForm();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            InitializeResultsView();

            if (rdoStrip.Checked)
            {
                StripDelimiters();
            }
            else if (rdoRemove.Checked)
            {
                StripText();
            }
            else if (rdoPrepend.Checked)
            {
                PrependText();
            }
            else if (rdoAppend.Checked)
            {
                AppendText();
            }
            else if (rdoInsert.Checked)
            {
                InsertText();
            }
        }

        private void rdoAppend_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                ShowControls("Append Text");
            }
            else
            {
                ResetRadio();
            }
        }

        private void rdoInsert_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                txtPosition.Show();
                lblInsert.Show();
                ShowControls("Insert Text");
            }
            else
            {
                ResetRadio();
            }
        }

        private void rdoPrepend_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                ShowControls("Prepend Text");
            }
            else
            {
                ResetRadio();
            }
        }

        private void rdoRemove_CheckedChanged(object sender, EventArgs e)
        {

            if (((RadioButton)sender).Checked)
            {
                ShowControls("Remove Text");
            }
            else
            {
                ResetRadio();
            }
        }

        private void rdoStrip_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                btnRun.Show();
            }
            else
            {
                ResetRadio();
            }

        }

        private void ShowControls(string labelText)
        {
            lblText.Text = labelText;
            lblText.Show();
            txtApply.Show();
            btnRun.Show();
        }

        private void AppendText()
        {
            foreach (var file in ofdFilebrowse.FileNames)
            {
                FileInfo fi = new FileInfo(file);

                string newName = String.Empty;
                fi.Name.Contains(fi.Extension);

                var extIndex = fi.Name.IndexOf(fi.Extension);

                if (fi.Name.Contains(fi.Extension))
                {
                    newName = fi.Name.Remove(extIndex);
                    newName = String.Format("{0}{1}{2}", newName, txtApply.Text, fi.Extension);
                }
                else
                {
                    newName = String.Format("{0}{1}", fi.Name, txtApply.Text);
                }

                UpdateFileName(fi, newName);
            }
        }

        private void InsertText()
        {
            foreach (var file in ofdFilebrowse.FileNames)
            {
                FileInfo fi = new FileInfo(file);

                var nameLength = fi.Name.Length;
                var position = Convert.ToInt32(txtPosition.Text);
                
                if (nameLength >= position)
                {
                    string newName = fi.Name;
                    newName = newName.Insert(position, txtApply.Text.Trim() + " ");

                    UpdateFileName(fi, newName);
                }
            }
        }

        private void PrependText()
        {
            foreach (var file in ofdFilebrowse.FileNames)
            {
                FileInfo fi = new FileInfo(file);
                //File.Move(fi.FullName, ;
                //

                string newName = String.Empty;
                fi.Name.Contains(fi.Extension);

                var extIndex = fi.Name.IndexOf(fi.Extension);

                newName = fi.Name.Remove(extIndex);
                newName = String.Format("{1}{0}", newName, txtApply.Text);

                UpdateFileName(fi, newName);
            }
        }

        private void StripDelimiters()
        {

            foreach (var file in ofdFilebrowse.FileNames)
            {
                FileInfo fi = new FileInfo(file);
                //File.Move(fi.FullName, Path.Combine(fi.Directory.ToString(), "1" + fi.Name));
                //

                string newName = String.Empty;
                fi.Name.Contains(fi.Extension);

                var extIndex =  fi.Name.IndexOf(fi.Extension);

                newName = fi.Name.Remove(extIndex);                
                newName = newName.Replace(".", " ");
                newName += fi.Extension.ToString();

                UpdateFileName(fi, newName);
            }
        }

        private void StripText()
        {

            foreach (var file in ofdFilebrowse.FileNames)
            {
                FileInfo fi = new FileInfo(file);
                //File.Move(fi.FullName, Path.Combine(fi.Directory.ToString(), "1" + fi.Name));
                //

                if (fi.Name.Contains(txtApply.Text))
                {
                    string newName = String.Empty;
                    newName = fi.Name.Replace(txtApply.Text, "");
                    UpdateFileName(fi, newName);
                }
            }
        }

        private void AddToResultsView(string original, string updated)
        {
            var lvItem = new ListViewItem(new[] { original, updated });
            lvResultsApplied.Items.Add(lvItem);
        }

        private void InitializeForm()
        {
            grpOps.Hide();
            lblText.Hide();
            lblInsert.Hide();
            btnClear.Hide();
            btnRun.Hide();
            txtApply.Hide();
            txtPosition.Hide();

            txtApply.Text = String.Empty;
            txtPosition.Text = String.Empty;

            chkShowPath.Checked = false;

            lvOpenedFiles.View = View.Details;
            lvOpenedFiles.Enabled = false;

            lvResultsApplied.View = View.Details;
            lvResultsApplied.Enabled = false;

            lvOpenedFiles.Clear();
            lvResultsApplied.Clear();

            rdoAppend.Checked = false;
            rdoPrepend.Checked = false;
            rdoRemove.Checked = false;
            rdoStrip.Checked = false;
            rdoInsert.Checked = false;
        }

        private void InitializeResultsView()
        {
            lvResultsApplied.Clear();
            lvResultsApplied.Columns.Add("File Name");
            lvResultsApplied.Columns.Add("Updated Name");

            lvResultsApplied.Columns[0].Width = lvResultsApplied.Width / lvResultsApplied.Columns.Count;
            lvResultsApplied.Columns[1].Width = lvResultsApplied.Width / lvResultsApplied.Columns.Count;

            lvResultsApplied.GridLines = true;
            lvResultsApplied.Enabled = true;
        }

        private void UpdateFileName(FileInfo fileInfo, string updatedFileName)
        {
            try
            {
                File.Move(fileInfo.FullName, Path.Combine(fileInfo.Directory.ToString(), updatedFileName));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "We're all Fucked up here", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StreamWriter sw = new StreamWriter("C:\\debug.txt", true, Encoding.ASCII);
                sw.Write(e.StackTrace);
                sw.Close();
                throw;
            }
            finally
            {
                AddToResultsView(fileInfo.Name, updatedFileName);
            }
        }

        private void ResetRadio()
        {
            txtApply.Text = String.Empty;
            txtPosition.Text = "0";
            lblInsert.Hide();
            txtPosition.Hide();
        }

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPosition.Text, "[^0-9]"))
            {
                txtPosition.Text = txtPosition.Text.Remove(txtPosition.Text.Length - 1);
            }
        }
    }
}