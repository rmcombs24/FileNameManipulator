namespace FileNameManipulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblInsert = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.txtApply = new System.Windows.Forms.TextBox();
            this.grpOps = new System.Windows.Forms.GroupBox();
            this.rdoInsert = new System.Windows.Forms.RadioButton();
            this.rdoStrip = new System.Windows.Forms.RadioButton();
            this.rdoAppend = new System.Windows.Forms.RadioButton();
            this.rdoRemove = new System.Windows.Forms.RadioButton();
            this.rdoPrepend = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkShowPath = new System.Windows.Forms.CheckBox();
            this.btnOpenFiles = new System.Windows.Forms.Button();
            this.lvResultsApplied = new System.Windows.Forms.ListView();
            this.lvOpenedFiles = new System.Windows.Forms.ListView();
            this.ofdFilebrowse = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpOps.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblInsert);
            this.splitContainer1.Panel1.Controls.Add(this.txtPosition);
            this.splitContainer1.Panel1.Controls.Add(this.btnRun);
            this.splitContainer1.Panel1.Controls.Add(this.lblText);
            this.splitContainer1.Panel1.Controls.Add(this.txtApply);
            this.splitContainer1.Panel1.Controls.Add(this.grpOps);
            this.splitContainer1.Panel1.Controls.Add(this.btnClear);
            this.splitContainer1.Panel1.Controls.Add(this.chkShowPath);
            this.splitContainer1.Panel1.Controls.Add(this.btnOpenFiles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvResultsApplied);
            this.splitContainer1.Panel2.Controls.Add(this.lvOpenedFiles);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblInsert
            // 
            this.lblInsert.AutoSize = true;
            this.lblInsert.Location = new System.Drawing.Point(93, 224);
            this.lblInsert.Name = "lblInsert";
            this.lblInsert.Size = new System.Drawing.Size(82, 15);
            this.lblInsert.TabIndex = 3;
            this.lblInsert.Text = "Insert Position";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(181, 221);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(40, 23);
            this.txtPosition.TabIndex = 2;
            this.txtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPosition.TextChanged += new System.EventHandler(this.txtPosition_TextChanged);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(120, 57);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(97, 23);
            this.btnRun.TabIndex = 7;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(12, 224);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(38, 15);
            this.lblText.TabIndex = 6;
            this.lblText.Text = "label1";
            // 
            // txtApply
            // 
            this.txtApply.Location = new System.Drawing.Point(12, 250);
            this.txtApply.Multiline = true;
            this.txtApply.Name = "txtApply";
            this.txtApply.Size = new System.Drawing.Size(211, 94);
            this.txtApply.TabIndex = 5;
            // 
            // grpOps
            // 
            this.grpOps.Controls.Add(this.rdoInsert);
            this.grpOps.Controls.Add(this.rdoStrip);
            this.grpOps.Controls.Add(this.rdoAppend);
            this.grpOps.Controls.Add(this.rdoRemove);
            this.grpOps.Controls.Add(this.rdoPrepend);
            this.grpOps.Location = new System.Drawing.Point(12, 99);
            this.grpOps.Name = "grpOps";
            this.grpOps.Size = new System.Drawing.Size(211, 99);
            this.grpOps.TabIndex = 4;
            this.grpOps.TabStop = false;
            this.grpOps.Text = "Operations";
            // 
            // rdoInsert
            // 
            this.rdoInsert.AutoSize = true;
            this.rdoInsert.Location = new System.Drawing.Point(8, 72);
            this.rdoInsert.Name = "rdoInsert";
            this.rdoInsert.Size = new System.Drawing.Size(78, 19);
            this.rdoInsert.TabIndex = 4;
            this.rdoInsert.TabStop = true;
            this.rdoInsert.Text = "Insert Text";
            this.toolTip1.SetToolTip(this.rdoInsert, "Insert a text to a file name at a given position");
            this.rdoInsert.UseVisualStyleBackColor = true;
            this.rdoInsert.CheckedChanged += new System.EventHandler(this.rdoInsert_CheckedChanged);
            // 
            // rdoStrip
            // 
            this.rdoStrip.AutoSize = true;
            this.rdoStrip.Location = new System.Drawing.Point(8, 22);
            this.rdoStrip.Name = "rdoStrip";
            this.rdoStrip.Size = new System.Drawing.Size(100, 19);
            this.rdoStrip.TabIndex = 0;
            this.rdoStrip.TabStop = true;
            this.rdoStrip.Text = "Delimiter Strip";
            this.toolTip1.SetToolTip(this.rdoStrip, "Remove known delimiters and replace with whitespace");
            this.rdoStrip.UseVisualStyleBackColor = true;
            this.rdoStrip.CheckedChanged += new System.EventHandler(this.rdoStrip_CheckedChanged);
            // 
            // rdoAppend
            // 
            this.rdoAppend.AutoSize = true;
            this.rdoAppend.Location = new System.Drawing.Point(114, 47);
            this.rdoAppend.Name = "rdoAppend";
            this.rdoAppend.Size = new System.Drawing.Size(91, 19);
            this.rdoAppend.TabIndex = 3;
            this.rdoAppend.TabStop = true;
            this.rdoAppend.Text = "Append Text";
            this.toolTip1.SetToolTip(this.rdoAppend, "Add text to the end of a file name");
            this.rdoAppend.UseVisualStyleBackColor = true;
            this.rdoAppend.CheckedChanged += new System.EventHandler(this.rdoAppend_CheckedChanged);
            // 
            // rdoRemove
            // 
            this.rdoRemove.AutoSize = true;
            this.rdoRemove.Location = new System.Drawing.Point(8, 47);
            this.rdoRemove.Name = "rdoRemove";
            this.rdoRemove.Size = new System.Drawing.Size(92, 19);
            this.rdoRemove.TabIndex = 1;
            this.rdoRemove.TabStop = true;
            this.rdoRemove.Text = "Remove Text";
            this.toolTip1.SetToolTip(this.rdoRemove, "Remove a specific line of text from a file name");
            this.rdoRemove.UseVisualStyleBackColor = true;
            this.rdoRemove.CheckedChanged += new System.EventHandler(this.rdoRemove_CheckedChanged);
            // 
            // rdoPrepend
            // 
            this.rdoPrepend.AutoSize = true;
            this.rdoPrepend.Location = new System.Drawing.Point(114, 22);
            this.rdoPrepend.Name = "rdoPrepend";
            this.rdoPrepend.Size = new System.Drawing.Size(93, 19);
            this.rdoPrepend.TabIndex = 2;
            this.rdoPrepend.TabStop = true;
            this.rdoPrepend.Text = "Prepend Text";
            this.toolTip1.SetToolTip(this.rdoPrepend, "Add text to the beginning of a file name");
            this.rdoPrepend.UseVisualStyleBackColor = true;
            this.rdoPrepend.CheckedChanged += new System.EventHandler(this.rdoPrepend_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 58);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkShowPath
            // 
            this.chkShowPath.AutoSize = true;
            this.chkShowPath.Location = new System.Drawing.Point(120, 32);
            this.chkShowPath.Name = "chkShowPath";
            this.chkShowPath.Size = new System.Drawing.Size(103, 19);
            this.chkShowPath.TabIndex = 1;
            this.chkShowPath.Text = "Show File Path";
            this.chkShowPath.UseVisualStyleBackColor = true;
            // 
            // btnOpenFiles
            // 
            this.btnOpenFiles.Location = new System.Drawing.Point(12, 29);
            this.btnOpenFiles.Name = "btnOpenFiles";
            this.btnOpenFiles.Size = new System.Drawing.Size(102, 23);
            this.btnOpenFiles.TabIndex = 0;
            this.btnOpenFiles.Text = "Open Files";
            this.btnOpenFiles.UseVisualStyleBackColor = true;
            this.btnOpenFiles.Click += new System.EventHandler(this.btnOpenFiles_Click);
            // 
            // lvResultsApplied
            // 
            this.lvResultsApplied.Location = new System.Drawing.Point(3, 232);
            this.lvResultsApplied.Name = "lvResultsApplied";
            this.lvResultsApplied.Size = new System.Drawing.Size(515, 215);
            this.lvResultsApplied.TabIndex = 1;
            this.lvResultsApplied.UseCompatibleStateImageBehavior = false;
            // 
            // lvOpenedFiles
            // 
            this.lvOpenedFiles.Location = new System.Drawing.Point(3, 12);
            this.lvOpenedFiles.Name = "lvOpenedFiles";
            this.lvOpenedFiles.Size = new System.Drawing.Size(515, 215);
            this.lvOpenedFiles.TabIndex = 0;
            this.lvOpenedFiles.UseCompatibleStateImageBehavior = false;
            // 
            // ofdFilebrowse
            // 
            this.ofdFilebrowse.FileName = "ofdFilebrowse";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpOps.ResumeLayout(false);
            this.grpOps.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnOpenFiles;
        private ListView lvResultsApplied;
        private ListView lvOpenedFiles;
        private OpenFileDialog ofdFilebrowse;
        private CheckBox chkShowPath;
        private Button btnClear;
        private Label lblText;
        private TextBox txtApply;
        private GroupBox grpOps;
        private RadioButton rdoStrip;
        private RadioButton rdoAppend;
        private RadioButton rdoRemove;
        private RadioButton rdoPrepend;
        private ToolTip toolTip1;
        private Button btnRun;
        private RadioButton rdoInsert;
        private Label lblInsert;
        private TextBox txtPosition;
    }
}