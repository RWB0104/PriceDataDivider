namespace PriceDataDivider
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.radioButtonAuto = new System.Windows.Forms.RadioButton();
            this.radioButtonInput = new System.Windows.Forms.RadioButton();
            this.textBoxSave = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.radioButtonXLSX = new System.Windows.Forms.RadioButton();
            this.radioButtonXLS = new System.Windows.Forms.RadioButton();
            this.groupBoxExtension = new System.Windows.Forms.GroupBox();
            this.labelWarn = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelProgress = new System.Windows.Forms.Label();
            this.groupBoxSave = new System.Windows.Forms.GroupBox();
            this.labelLogo = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.buttonData = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.groupBoxExtension.SuspendLayout();
            this.groupBoxSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(12, 68);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(258, 21);
            this.textBoxFilePath.TabIndex = 2;
            this.textBoxFilePath.TabStop = false;
            this.textBoxFilePath.TextChanged += new System.EventHandler(this.TextBoxFilePath_TextChanged);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile.Location = new System.Drawing.Point(276, 67);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(23, 23);
            this.buttonOpenFile.TabIndex = 1;
            this.buttonOpenFile.Text = "..";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.ButtonOpenFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // textBoxNum
            // 
            this.textBoxNum.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxNum.Location = new System.Drawing.Point(347, 68);
            this.textBoxNum.MaxLength = 10;
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(52, 21);
            this.textBoxNum.TabIndex = 0;
            this.textBoxNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNum_KeyPress);
            // 
            // radioButtonAuto
            // 
            this.radioButtonAuto.AutoSize = true;
            this.radioButtonAuto.Location = new System.Drawing.Point(15, 28);
            this.radioButtonAuto.Name = "radioButtonAuto";
            this.radioButtonAuto.Size = new System.Drawing.Size(68, 16);
            this.radioButtonAuto.TabIndex = 3;
            this.radioButtonAuto.Text = "Desktop";
            this.radioButtonAuto.UseVisualStyleBackColor = true;
            this.radioButtonAuto.CheckedChanged += new System.EventHandler(this.RadioButtonAuto_CheckedChanged);
            // 
            // radioButtonInput
            // 
            this.radioButtonInput.AutoSize = true;
            this.radioButtonInput.Location = new System.Drawing.Point(15, 51);
            this.radioButtonInput.Name = "radioButtonInput";
            this.radioButtonInput.Size = new System.Drawing.Size(50, 16);
            this.radioButtonInput.TabIndex = 4;
            this.radioButtonInput.Text = "Input";
            this.radioButtonInput.UseVisualStyleBackColor = true;
            // 
            // textBoxSave
            // 
            this.textBoxSave.Location = new System.Drawing.Point(15, 76);
            this.textBoxSave.Name = "textBoxSave";
            this.textBoxSave.Size = new System.Drawing.Size(198, 21);
            this.textBoxSave.TabIndex = 5;
            this.textBoxSave.TabStop = false;
            this.textBoxSave.TextChanged += new System.EventHandler(this.TextBoxSave_TextChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Location = new System.Drawing.Point(219, 75);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(23, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "..";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // radioButtonXLSX
            // 
            this.radioButtonXLSX.AutoSize = true;
            this.radioButtonXLSX.Location = new System.Drawing.Point(21, 32);
            this.radioButtonXLSX.Name = "radioButtonXLSX";
            this.radioButtonXLSX.Size = new System.Drawing.Size(51, 16);
            this.radioButtonXLSX.TabIndex = 8;
            this.radioButtonXLSX.TabStop = true;
            this.radioButtonXLSX.Text = ".xlsx";
            this.radioButtonXLSX.UseVisualStyleBackColor = true;
            this.radioButtonXLSX.CheckedChanged += new System.EventHandler(this.RadioButtonXLSX_CheckedChanged);
            // 
            // radioButtonXLS
            // 
            this.radioButtonXLS.AutoSize = true;
            this.radioButtonXLS.Location = new System.Drawing.Point(21, 63);
            this.radioButtonXLS.Name = "radioButtonXLS";
            this.radioButtonXLS.Size = new System.Drawing.Size(44, 16);
            this.radioButtonXLS.TabIndex = 9;
            this.radioButtonXLS.TabStop = true;
            this.radioButtonXLS.Text = ".xls";
            this.radioButtonXLS.UseVisualStyleBackColor = true;
            // 
            // groupBoxExtension
            // 
            this.groupBoxExtension.Controls.Add(this.labelWarn);
            this.groupBoxExtension.Controls.Add(this.radioButtonXLS);
            this.groupBoxExtension.Controls.Add(this.radioButtonXLSX);
            this.groupBoxExtension.Location = new System.Drawing.Point(300, 109);
            this.groupBoxExtension.Name = "groupBoxExtension";
            this.groupBoxExtension.Size = new System.Drawing.Size(99, 108);
            this.groupBoxExtension.TabIndex = 10;
            this.groupBoxExtension.TabStop = false;
            this.groupBoxExtension.Text = "Extension";
            // 
            // labelWarn
            // 
            this.labelWarn.AutoSize = true;
            this.labelWarn.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelWarn.Location = new System.Drawing.Point(19, 82);
            this.labelWarn.Name = "labelWarn";
            this.labelWarn.Size = new System.Drawing.Size(51, 12);
            this.labelWarn.TabIndex = 10;
            this.labelWarn.Text = "(불안정)";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 24);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(387, 23);
            this.progressBar.TabIndex = 11;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(363, 9);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(9, 12);
            this.labelCount.TabIndex = 12;
            this.labelCount.Text = " ";
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(12, 9);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(9, 12);
            this.labelProgress.TabIndex = 13;
            this.labelProgress.Text = " ";
            // 
            // groupBoxSave
            // 
            this.groupBoxSave.Controls.Add(this.radioButtonAuto);
            this.groupBoxSave.Controls.Add(this.radioButtonInput);
            this.groupBoxSave.Controls.Add(this.textBoxSave);
            this.groupBoxSave.Controls.Add(this.buttonSave);
            this.groupBoxSave.Location = new System.Drawing.Point(14, 105);
            this.groupBoxSave.Name = "groupBoxSave";
            this.groupBoxSave.Size = new System.Drawing.Size(256, 112);
            this.groupBoxSave.TabIndex = 14;
            this.groupBoxSave.TabStop = false;
            this.groupBoxSave.Text = "Save";
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Location = new System.Drawing.Point(158, 245);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(112, 12);
            this.labelLogo.TabIndex = 16;
            this.labelLogo.Text = "Developed by RWB";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Location = new System.Drawing.Point(116, 6);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(192, 12);
            this.labelCopyright.TabIndex = 17;
            this.labelCopyright.Text = "© 2019. RWB. All Right Reserved.";
            // 
            // buttonData
            // 
            this.buttonData.BackgroundImage = global::PriceDataDivider.Properties.Resources.data_logo;
            this.buttonData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonData.Location = new System.Drawing.Point(14, 228);
            this.buttonData.Name = "buttonData";
            this.buttonData.Size = new System.Drawing.Size(65, 48);
            this.buttonData.TabIndex = 15;
            this.buttonData.UseVisualStyleBackColor = true;
            this.buttonData.Click += new System.EventHandler(this.ButtonData_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.BackgroundImage = global::PriceDataDivider.Properties.Resources.Excel;
            this.buttonRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRun.Location = new System.Drawing.Point(347, 228);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(53, 48);
            this.buttonRun.TabIndex = 7;
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(161, 264);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(102, 12);
            this.labelEmail.TabIndex = 18;
            this.labelEmail.Text = "psj1789@ksic.net";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(412, 286);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.buttonData);
            this.Controls.Add(this.groupBoxSave);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBoxExtension);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.textBoxFilePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "공시지가 자동분할";
            this.groupBoxExtension.ResumeLayout(false);
            this.groupBoxExtension.PerformLayout();
            this.groupBoxSave.ResumeLayout(false);
            this.groupBoxSave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.RadioButton radioButtonAuto;
        private System.Windows.Forms.RadioButton radioButtonInput;
        private System.Windows.Forms.TextBox textBoxSave;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.RadioButton radioButtonXLSX;
        private System.Windows.Forms.RadioButton radioButtonXLS;
        private System.Windows.Forms.GroupBox groupBoxExtension;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.GroupBox groupBoxSave;
        private System.Windows.Forms.Label labelWarn;
        private System.Windows.Forms.Button buttonData;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelEmail;
    }
}