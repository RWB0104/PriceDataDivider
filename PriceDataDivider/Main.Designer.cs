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
			this.backgroundWorkerPrice = new System.ComponentModel.BackgroundWorker();
			this.radioButtonXLSX = new System.Windows.Forms.RadioButton();
			this.radioButtonXLS = new System.Windows.Forms.RadioButton();
			this.groupBoxExtension = new System.Windows.Forms.GroupBox();
			this.labelWarn = new System.Windows.Forms.Label();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.labelCount = new System.Windows.Forms.Label();
			this.labelProgress = new System.Windows.Forms.Label();
			this.groupBoxSave = new System.Windows.Forms.GroupBox();
			this.labelLogo = new System.Windows.Forms.Label();
			this.buttonData = new System.Windows.Forms.Button();
			this.buttonRun = new System.Windows.Forms.Button();
			this.labelEmail = new System.Windows.Forms.Label();
			this.radioButtonPrice = new System.Windows.Forms.RadioButton();
			this.radioButtonAddress = new System.Windows.Forms.RadioButton();
			this.backgroundWorkerAddress = new System.ComponentModel.BackgroundWorker();
			this.groupBoxExtension.SuspendLayout();
			this.groupBoxSave.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxFilePath
			// 
			this.textBoxFilePath.Location = new System.Drawing.Point(12, 79);
			this.textBoxFilePath.Name = "textBoxFilePath";
			this.textBoxFilePath.Size = new System.Drawing.Size(251, 21);
			this.textBoxFilePath.TabIndex = 2;
			this.textBoxFilePath.TabStop = false;
			this.textBoxFilePath.TextChanged += new System.EventHandler(this.TextBoxFilePath_TextChanged);
			// 
			// buttonOpenFile
			// 
			this.buttonOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonOpenFile.Location = new System.Drawing.Point(269, 77);
			this.buttonOpenFile.Name = "buttonOpenFile";
			this.buttonOpenFile.Size = new System.Drawing.Size(23, 23);
			this.buttonOpenFile.TabIndex = 1;
			this.buttonOpenFile.Text = "..";
			this.buttonOpenFile.UseVisualStyleBackColor = true;
			this.buttonOpenFile.Click += new System.EventHandler(this.ButtonOpenFile_Click);
			// 
			// textBoxNum
			// 
			this.textBoxNum.BackColor = System.Drawing.SystemColors.Info;
			this.textBoxNum.Location = new System.Drawing.Point(347, 79);
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
			this.radioButtonInput.Checked = true;
			this.radioButtonInput.Location = new System.Drawing.Point(15, 51);
			this.radioButtonInput.Name = "radioButtonInput";
			this.radioButtonInput.Size = new System.Drawing.Size(50, 16);
			this.radioButtonInput.TabIndex = 4;
			this.radioButtonInput.TabStop = true;
			this.radioButtonInput.Text = "Input";
			this.radioButtonInput.UseVisualStyleBackColor = true;
			// 
			// textBoxSave
			// 
			this.textBoxSave.Location = new System.Drawing.Point(15, 76);
			this.textBoxSave.Name = "textBoxSave";
			this.textBoxSave.Size = new System.Drawing.Size(234, 21);
			this.textBoxSave.TabIndex = 5;
			this.textBoxSave.TabStop = false;
			this.textBoxSave.TextChanged += new System.EventHandler(this.TextBoxSave_TextChanged);
			// 
			// buttonSave
			// 
			this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonSave.Location = new System.Drawing.Point(255, 74);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(23, 23);
			this.buttonSave.TabIndex = 6;
			this.buttonSave.Text = "..";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
			// 
			// backgroundWorkerPrice
			// 
			this.backgroundWorkerPrice.WorkerReportsProgress = true;
			this.backgroundWorkerPrice.WorkerSupportsCancellation = true;
			this.backgroundWorkerPrice.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerPrice_DoWork);
			this.backgroundWorkerPrice.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerPrice_RunWorkerCompleted);
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
			this.radioButtonXLS.Location = new System.Drawing.Point(21, 74);
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
			this.groupBoxExtension.Location = new System.Drawing.Point(316, 116);
			this.groupBoxExtension.Name = "groupBoxExtension";
			this.groupBoxExtension.Size = new System.Drawing.Size(83, 112);
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
			this.labelWarn.Size = new System.Drawing.Size(0, 12);
			this.labelWarn.TabIndex = 10;
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(12, 23);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(387, 23);
			this.progressBar.TabIndex = 11;
			// 
			// labelCount
			// 
			this.labelCount.Location = new System.Drawing.Point(313, 8);
			this.labelCount.Name = "labelCount";
			this.labelCount.Size = new System.Drawing.Size(83, 12);
			this.labelCount.TabIndex = 12;
			this.labelCount.Text = " ";
			this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelProgress
			// 
			this.labelProgress.AutoSize = true;
			this.labelProgress.Location = new System.Drawing.Point(12, 8);
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
			this.groupBoxSave.Location = new System.Drawing.Point(14, 116);
			this.groupBoxSave.Name = "groupBoxSave";
			this.groupBoxSave.Size = new System.Drawing.Size(285, 112);
			this.groupBoxSave.TabIndex = 14;
			this.groupBoxSave.TabStop = false;
			this.groupBoxSave.Text = "Save";
			// 
			// labelLogo
			// 
			this.labelLogo.AutoSize = true;
			this.labelLogo.Location = new System.Drawing.Point(158, 256);
			this.labelLogo.Name = "labelLogo";
			this.labelLogo.Size = new System.Drawing.Size(112, 12);
			this.labelLogo.TabIndex = 16;
			this.labelLogo.Text = "Developed by RWB";
			// 
			// buttonData
			// 
			this.buttonData.BackgroundImage = global::PriceDataDivider.Properties.Resources.data_logo;
			this.buttonData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonData.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonData.Location = new System.Drawing.Point(14, 239);
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
			this.buttonRun.Location = new System.Drawing.Point(347, 239);
			this.buttonRun.Name = "buttonRun";
			this.buttonRun.Size = new System.Drawing.Size(53, 48);
			this.buttonRun.TabIndex = 7;
			this.buttonRun.UseVisualStyleBackColor = true;
			this.buttonRun.Click += new System.EventHandler(this.ButtonRun_Click);
			// 
			// labelEmail
			// 
			this.labelEmail.AutoSize = true;
			this.labelEmail.Location = new System.Drawing.Point(161, 275);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(102, 12);
			this.labelEmail.TabIndex = 18;
			this.labelEmail.Text = "psj1789@ksic.net";
			// 
			// radioButtonPrice
			// 
			this.radioButtonPrice.AutoSize = true;
			this.radioButtonPrice.Location = new System.Drawing.Point(14, 54);
			this.radioButtonPrice.Name = "radioButtonPrice";
			this.radioButtonPrice.Size = new System.Drawing.Size(71, 16);
			this.radioButtonPrice.TabIndex = 19;
			this.radioButtonPrice.Text = "공시지가";
			this.radioButtonPrice.UseVisualStyleBackColor = true;
			this.radioButtonPrice.CheckedChanged += new System.EventHandler(this.RadioButtonPrice_CheckedChanged);
			// 
			// radioButtonAddress
			// 
			this.radioButtonAddress.AutoSize = true;
			this.radioButtonAddress.Checked = true;
			this.radioButtonAddress.Location = new System.Drawing.Point(91, 54);
			this.radioButtonAddress.Name = "radioButtonAddress";
			this.radioButtonAddress.Size = new System.Drawing.Size(47, 16);
			this.radioButtonAddress.TabIndex = 20;
			this.radioButtonAddress.TabStop = true;
			this.radioButtonAddress.Text = "주소";
			this.radioButtonAddress.UseVisualStyleBackColor = true;
			this.radioButtonAddress.CheckedChanged += new System.EventHandler(this.RadioButtonAddress_CheckedChanged);
			// 
			// backgroundWorkerAddress
			// 
			this.backgroundWorkerAddress.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerAddress_DoWork);
			this.backgroundWorkerAddress.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerAddress_RunWorkerCompleted);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(412, 295);
			this.Controls.Add(this.radioButtonAddress);
			this.Controls.Add(this.radioButtonPrice);
			this.Controls.Add(this.labelEmail);
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
			this.Text = "데이터 자동분할";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.Load += new System.EventHandler(this.Main_Load);
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
        private System.ComponentModel.BackgroundWorker backgroundWorkerPrice;
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
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.RadioButton radioButtonPrice;
        private System.Windows.Forms.RadioButton radioButtonAddress;
        private System.ComponentModel.BackgroundWorker backgroundWorkerAddress;
    }
}