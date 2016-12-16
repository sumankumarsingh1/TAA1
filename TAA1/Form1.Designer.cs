namespace TAA1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.cmbInputTable = new System.Windows.Forms.ComboBox();
            this.lblInputTable = new System.Windows.Forms.Label();
            this.tbSumTable = new System.Windows.Forms.TextBox();
            this.tbDetTable = new System.Windows.Forms.TextBox();
            this.lblSumTable = new System.Windows.Forms.Label();
            this.lblDetTable = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ofdStopWords = new System.Windows.Forms.OpenFileDialog();
            this.tbStopWords = new System.Windows.Forms.TextBox();
            this.lblStopWords = new System.Windows.Forms.Label();
            this.btnStopWords = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.msgBox = new System.Windows.Forms.RichTextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pbHPELogo = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHPELogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "TEXT ANALYSIS TOOL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(79, 238);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(124, 30);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // cmbInputTable
            // 
            this.cmbInputTable.FormattingEnabled = true;
            this.cmbInputTable.Location = new System.Drawing.Point(180, 79);
            this.cmbInputTable.Name = "cmbInputTable";
            this.cmbInputTable.Size = new System.Drawing.Size(170, 21);
            this.cmbInputTable.TabIndex = 2;
            this.cmbInputTable.SelectedIndexChanged += new System.EventHandler(this.cmbInputTable_SelectedIndexChanged);
            // 
            // lblInputTable
            // 
            this.lblInputTable.AutoSize = true;
            this.lblInputTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputTable.Location = new System.Drawing.Point(40, 79);
            this.lblInputTable.Name = "lblInputTable";
            this.lblInputTable.Size = new System.Drawing.Size(97, 20);
            this.lblInputTable.TabIndex = 3;
            this.lblInputTable.Text = "Select Table";
            // 
            // tbSumTable
            // 
            this.tbSumTable.Location = new System.Drawing.Point(180, 108);
            this.tbSumTable.Name = "tbSumTable";
            this.tbSumTable.ReadOnly = true;
            this.tbSumTable.Size = new System.Drawing.Size(170, 20);
            this.tbSumTable.TabIndex = 4;
            // 
            // tbDetTable
            // 
            this.tbDetTable.Location = new System.Drawing.Point(180, 138);
            this.tbDetTable.Name = "tbDetTable";
            this.tbDetTable.ReadOnly = true;
            this.tbDetTable.Size = new System.Drawing.Size(170, 20);
            this.tbDetTable.TabIndex = 5;
            // 
            // lblSumTable
            // 
            this.lblSumTable.AutoSize = true;
            this.lblSumTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumTable.Location = new System.Drawing.Point(40, 108);
            this.lblSumTable.Name = "lblSumTable";
            this.lblSumTable.Size = new System.Drawing.Size(123, 20);
            this.lblSumTable.TabIndex = 6;
            this.lblSumTable.Text = "Summary Table ";
            // 
            // lblDetTable
            // 
            this.lblDetTable.AutoSize = true;
            this.lblDetTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetTable.Location = new System.Drawing.Point(40, 138);
            this.lblDetTable.Name = "lblDetTable";
            this.lblDetTable.Size = new System.Drawing.Size(105, 20);
            this.lblDetTable.TabIndex = 7;
            this.lblDetTable.Text = "Details Table ";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(38, 197);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(381, 23);
            this.progressBar.TabIndex = 8;
            // 
            // ofdStopWords
            // 
            this.ofdStopWords.FileName = "openFileDialog1";
            // 
            // tbStopWords
            // 
            this.tbStopWords.Location = new System.Drawing.Point(181, 169);
            this.tbStopWords.Name = "tbStopWords";
            this.tbStopWords.ReadOnly = true;
            this.tbStopWords.Size = new System.Drawing.Size(170, 20);
            this.tbStopWords.TabIndex = 9;
            // 
            // lblStopWords
            // 
            this.lblStopWords.AutoSize = true;
            this.lblStopWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopWords.Location = new System.Drawing.Point(41, 167);
            this.lblStopWords.Name = "lblStopWords";
            this.lblStopWords.Size = new System.Drawing.Size(122, 20);
            this.lblStopWords.TabIndex = 10;
            this.lblStopWords.Text = "Stop Words File";
            // 
            // btnStopWords
            // 
            this.btnStopWords.Location = new System.Drawing.Point(351, 168);
            this.btnStopWords.Name = "btnStopWords";
            this.btnStopWords.Size = new System.Drawing.Size(28, 23);
            this.btnStopWords.TabIndex = 11;
            this.btnStopWords.Text = "...";
            this.btnStopWords.UseVisualStyleBackColor = true;
            this.btnStopWords.Click += new System.EventHandler(this.btnStopWords_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(235, 238);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 30);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // msgBox
            // 
            this.msgBox.Enabled = false;
            this.msgBox.HideSelection = false;
            this.msgBox.Location = new System.Drawing.Point(45, 311);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(374, 75);
            this.msgBox.TabIndex = 13;
            this.msgBox.Text = "";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(41, 288);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(78, 20);
            this.lblMessage.TabIndex = 14;
            this.lblMessage.Text = "Message:";
            // 
            // pbHPELogo
            // 
            this.pbHPELogo.Image = global::TAA1.Properties.Resources.HPE_Logo_1;
            this.pbHPELogo.Location = new System.Drawing.Point(-1, 0);
            this.pbHPELogo.Name = "pbHPELogo";
            this.pbHPELogo.Size = new System.Drawing.Size(100, 50);
            this.pbHPELogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHPELogo.TabIndex = 15;
            this.pbHPELogo.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(353, 75);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 29);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 412);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pbHPELogo);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStopWords);
            this.Controls.Add(this.lblStopWords);
            this.Controls.Add(this.tbStopWords);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblDetTable);
            this.Controls.Add(this.lblSumTable);
            this.Controls.Add(this.tbDetTable);
            this.Controls.Add(this.tbSumTable);
            this.Controls.Add(this.lblInputTable);
            this.Controls.Add(this.cmbInputTable);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "HPE MWS Text Analysis Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHPELogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.ComboBox cmbInputTable;
        private System.Windows.Forms.Label lblInputTable;
        private System.Windows.Forms.TextBox tbSumTable;
        private System.Windows.Forms.TextBox tbDetTable;
        private System.Windows.Forms.Label lblSumTable;
        private System.Windows.Forms.Label lblDetTable;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.OpenFileDialog ofdStopWords;
        private System.Windows.Forms.TextBox tbStopWords;
        private System.Windows.Forms.Label lblStopWords;
        private System.Windows.Forms.Button btnStopWords;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox msgBox;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pbHPELogo;
        private System.Windows.Forms.Button btnRefresh;
    }
}

