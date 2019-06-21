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
            this.buttonRun = new System.Windows.Forms.Button();
            this.radioButtonXLSX = new System.Windows.Forms.RadioButton();
            this.radioButtonXLS = new System.Windows.Forms.RadioButton();
            this.groupBoxExtension = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelProgress = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxExtension.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(12, 68);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(258, 21);
            this.textBoxFilePath.TabIndex = 0;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(276, 66);
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
            this.textBoxNum.Location = new System.Drawing.Point(381, 68);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(52, 21);
            this.textBoxNum.TabIndex = 2;
            this.textBoxNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNum_KeyPress);
            // 
            // radioButtonAuto
            // 
            this.radioButtonAuto.AutoSize = true;
            this.radioButtonAuto.Location = new System.Drawing.Point(15, 32);
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
            this.radioButtonInput.Location = new System.Drawing.Point(15, 54);
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
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(219, 76);
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
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(358, 240);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 7;
            this.buttonRun.Text = "button1";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // radioButtonXLSX
            // 
            this.radioButtonXLSX.AutoSize = true;
            this.radioButtonXLSX.Location = new System.Drawing.Point(21, 28);
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
            this.radioButtonXLS.Location = new System.Drawing.Point(21, 72);
            this.radioButtonXLS.Name = "radioButtonXLS";
            this.radioButtonXLS.Size = new System.Drawing.Size(44, 16);
            this.radioButtonXLS.TabIndex = 9;
            this.radioButtonXLS.TabStop = true;
            this.radioButtonXLS.Text = ".xls";
            this.radioButtonXLS.UseVisualStyleBackColor = true;
            // 
            // groupBoxExtension
            // 
            this.groupBoxExtension.Controls.Add(this.radioButtonXLS);
            this.groupBoxExtension.Controls.Add(this.radioButtonXLSX);
            this.groupBoxExtension.Location = new System.Drawing.Point(314, 114);
            this.groupBoxExtension.Name = "groupBoxExtension";
            this.groupBoxExtension.Size = new System.Drawing.Size(99, 108);
            this.groupBoxExtension.TabIndex = 10;
            this.groupBoxExtension.TabStop = false;
            this.groupBoxExtension.Text = "Extension";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 27);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(421, 23);
            this.progressBar.TabIndex = 11;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(414, 11);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(9, 12);
            this.labelCount.TabIndex = 12;
            this.labelCount.Text = " ";
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(12, 12);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(9, 12);
            this.labelProgress.TabIndex = 13;
            this.labelProgress.Text = " ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonAuto);
            this.groupBox1.Controls.Add(this.radioButtonInput);
            this.groupBox1.Controls.Add(this.textBoxSave);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Location = new System.Drawing.Point(26, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 112);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 282);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBoxExtension);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.textBoxFilePath);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.groupBoxExtension.ResumeLayout(false);
            this.groupBoxExtension.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}