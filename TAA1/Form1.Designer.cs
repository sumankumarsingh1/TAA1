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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ofdStopWords = new System.Windows.Forms.OpenFileDialog();
            this.btnClose = new System.Windows.Forms.Button();
            this.msgBox = new System.Windows.Forms.RichTextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pbHPELogo = new System.Windows.Forms.PictureBox();
            this.gbDatabaseConnection = new System.Windows.Forms.GroupBox();
            this.tbDBPassword = new System.Windows.Forms.TextBox();
            this.lbDBPassword = new System.Windows.Forms.Label();
            this.tbDBUsername = new System.Windows.Forms.TextBox();
            this.lbDBUsername = new System.Windows.Forms.Label();
            this.lblConnState = new System.Windows.Forms.Label();
            this.btnDBConnect = new System.Windows.Forms.Button();
            this.tbDBCatalog = new System.Windows.Forms.TextBox();
            this.lbDBCatalog = new System.Windows.Forms.Label();
            this.tbDBSource = new System.Windows.Forms.TextBox();
            this.lbDBSource = new System.Windows.Forms.Label();
            this.gbTableSelection = new System.Windows.Forms.GroupBox();
            this.btnDropTables = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblDetTable = new System.Windows.Forms.Label();
            this.lblSumTable = new System.Windows.Forms.Label();
            this.tbDetTable = new System.Windows.Forms.TextBox();
            this.tbSumTable = new System.Windows.Forms.TextBox();
            this.lblInputTable = new System.Windows.Forms.Label();
            this.cmbInputTable = new System.Windows.Forms.ComboBox();
            this.gbFieldSelection = new System.Windows.Forms.GroupBox();
            this.tbOptSearchString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStopWords = new System.Windows.Forms.Button();
            this.lblStopWords = new System.Windows.Forms.Label();
            this.tbStopWords = new System.Windows.Forms.TextBox();
            this.btnTextFieldsMFUnselect = new System.Windows.Forms.Button();
            this.btnTextFieldsSFUnselect = new System.Windows.Forms.Button();
            this.btnTktSrcUnSelect = new System.Windows.Forms.Button();
            this.btnTktNoUnSelect = new System.Windows.Forms.Button();
            this.lbTktSrcAnalyze = new System.Windows.Forms.Label();
            this.btnTextFieldsMFSelect = new System.Windows.Forms.Button();
            this.btnTextFieldsSFSelect = new System.Windows.Forms.Button();
            this.btnTktSrcSelect = new System.Windows.Forms.Button();
            this.lbTktSrc = new System.Windows.Forms.Label();
            this.lbTktNo = new System.Windows.Forms.Label();
            this.btnTktNoSelect = new System.Windows.Forms.Button();
            this.tbTktSrcField = new System.Windows.Forms.TextBox();
            this.tbTktNoField = new System.Windows.Forms.TextBox();
            this.lbAllFields = new System.Windows.Forms.Label();
            this.lbxTextFields = new System.Windows.Forms.ListBox();
            this.lbxAllFields = new System.Windows.Forms.ListBox();
            this.msgBox2 = new System.Windows.Forms.TextBox();
            this.tbInputRecords = new System.Windows.Forms.TextBox();
            this.tbOutputRecords = new System.Windows.Forms.TextBox();
            this.tbCurrRecord = new System.Windows.Forms.TextBox();
            this.loadCSV = new System.Windows.Forms.Button();
            this.lblMessage2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHPELogo)).BeginInit();
            this.gbDatabaseConnection.SuspendLayout();
            this.gbTableSelection.SuspendLayout();
            this.gbFieldSelection.SuspendLayout();
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
            this.btnProcess.Location = new System.Drawing.Point(780, 482);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(124, 30);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(512, 454);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(405, 23);
            this.progressBar.TabIndex = 8;
            // 
            // ofdStopWords
            // 
            this.ofdStopWords.FileName = "openFileDialog1";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(780, 527);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 30);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // msgBox
            // 
            this.msgBox.HideSelection = false;
            this.msgBox.Location = new System.Drawing.Point(18, 482);
            this.msgBox.Name = "msgBox";
            this.msgBox.ReadOnly = true;
            this.msgBox.Size = new System.Drawing.Size(756, 75);
            this.msgBox.TabIndex = 13;
            this.msgBox.Text = "";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(14, 457);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(149, 16);
            this.lblMessage.TabIndex = 14;
            this.lblMessage.Text = "System Log Messages:";
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
            // gbDatabaseConnection
            // 
            this.gbDatabaseConnection.Controls.Add(this.tbDBPassword);
            this.gbDatabaseConnection.Controls.Add(this.lbDBPassword);
            this.gbDatabaseConnection.Controls.Add(this.tbDBUsername);
            this.gbDatabaseConnection.Controls.Add(this.lbDBUsername);
            this.gbDatabaseConnection.Controls.Add(this.lblConnState);
            this.gbDatabaseConnection.Controls.Add(this.btnDBConnect);
            this.gbDatabaseConnection.Controls.Add(this.tbDBCatalog);
            this.gbDatabaseConnection.Controls.Add(this.lbDBCatalog);
            this.gbDatabaseConnection.Controls.Add(this.tbDBSource);
            this.gbDatabaseConnection.Controls.Add(this.lbDBSource);
            this.gbDatabaseConnection.Location = new System.Drawing.Point(18, 66);
            this.gbDatabaseConnection.Name = "gbDatabaseConnection";
            this.gbDatabaseConnection.Size = new System.Drawing.Size(307, 220);
            this.gbDatabaseConnection.TabIndex = 37;
            this.gbDatabaseConnection.TabStop = false;
            this.gbDatabaseConnection.Text = "Data Connection";
            // 
            // tbDBPassword
            // 
            this.tbDBPassword.Location = new System.Drawing.Point(114, 133);
            this.tbDBPassword.Name = "tbDBPassword";
            this.tbDBPassword.PasswordChar = '#';
            this.tbDBPassword.Size = new System.Drawing.Size(173, 20);
            this.tbDBPassword.TabIndex = 44;
            // 
            // lbDBPassword
            // 
            this.lbDBPassword.AutoSize = true;
            this.lbDBPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDBPassword.Location = new System.Drawing.Point(16, 131);
            this.lbDBPassword.Name = "lbDBPassword";
            this.lbDBPassword.Size = new System.Drawing.Size(68, 16);
            this.lbDBPassword.TabIndex = 43;
            this.lbDBPassword.Text = "Password";
            // 
            // tbDBUsername
            // 
            this.tbDBUsername.Location = new System.Drawing.Point(114, 100);
            this.tbDBUsername.Name = "tbDBUsername";
            this.tbDBUsername.Size = new System.Drawing.Size(173, 20);
            this.tbDBUsername.TabIndex = 42;
            // 
            // lbDBUsername
            // 
            this.lbDBUsername.AutoSize = true;
            this.lbDBUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDBUsername.Location = new System.Drawing.Point(16, 98);
            this.lbDBUsername.Name = "lbDBUsername";
            this.lbDBUsername.Size = new System.Drawing.Size(77, 16);
            this.lbDBUsername.TabIndex = 41;
            this.lbDBUsername.Text = "User Name";
            // 
            // lblConnState
            // 
            this.lblConnState.AutoSize = true;
            this.lblConnState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnState.Location = new System.Drawing.Point(137, 181);
            this.lblConnState.Name = "lblConnState";
            this.lblConnState.Size = new System.Drawing.Size(109, 16);
            this.lblConnState.TabIndex = 46;
            this.lblConnState.Text = "Connection State";
            // 
            // btnDBConnect
            // 
            this.btnDBConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBConnect.Location = new System.Drawing.Point(23, 176);
            this.btnDBConnect.Name = "btnDBConnect";
            this.btnDBConnect.Size = new System.Drawing.Size(96, 30);
            this.btnDBConnect.TabIndex = 45;
            this.btnDBConnect.Text = "Connect";
            this.btnDBConnect.UseVisualStyleBackColor = true;
            this.btnDBConnect.Click += new System.EventHandler(this.btnDBConnect_Click);
            // 
            // tbDBCatalog
            // 
            this.tbDBCatalog.Location = new System.Drawing.Point(114, 65);
            this.tbDBCatalog.Name = "tbDBCatalog";
            this.tbDBCatalog.Size = new System.Drawing.Size(173, 20);
            this.tbDBCatalog.TabIndex = 40;
            // 
            // lbDBCatalog
            // 
            this.lbDBCatalog.AutoSize = true;
            this.lbDBCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDBCatalog.Location = new System.Drawing.Point(16, 63);
            this.lbDBCatalog.Name = "lbDBCatalog";
            this.lbDBCatalog.Size = new System.Drawing.Size(87, 16);
            this.lbDBCatalog.TabIndex = 39;
            this.lbDBCatalog.Text = "Data Catalog";
            // 
            // tbDBSource
            // 
            this.tbDBSource.Location = new System.Drawing.Point(114, 32);
            this.tbDBSource.Name = "tbDBSource";
            this.tbDBSource.Size = new System.Drawing.Size(173, 20);
            this.tbDBSource.TabIndex = 38;
            this.tbDBSource.TextChanged += new System.EventHandler(this.tbDBSource_TextChanged);
            // 
            // lbDBSource
            // 
            this.lbDBSource.AutoSize = true;
            this.lbDBSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDBSource.Location = new System.Drawing.Point(16, 30);
            this.lbDBSource.Name = "lbDBSource";
            this.lbDBSource.Size = new System.Drawing.Size(83, 16);
            this.lbDBSource.TabIndex = 37;
            this.lbDBSource.Text = "Data Source";
            // 
            // gbTableSelection
            // 
            this.gbTableSelection.Controls.Add(this.btnDropTables);
            this.gbTableSelection.Controls.Add(this.btnRefresh);
            this.gbTableSelection.Controls.Add(this.lblDetTable);
            this.gbTableSelection.Controls.Add(this.lblSumTable);
            this.gbTableSelection.Controls.Add(this.tbDetTable);
            this.gbTableSelection.Controls.Add(this.tbSumTable);
            this.gbTableSelection.Controls.Add(this.lblInputTable);
            this.gbTableSelection.Controls.Add(this.cmbInputTable);
            this.gbTableSelection.Location = new System.Drawing.Point(18, 292);
            this.gbTableSelection.Name = "gbTableSelection";
            this.gbTableSelection.Size = new System.Drawing.Size(307, 143);
            this.gbTableSelection.TabIndex = 38;
            this.gbTableSelection.TabStop = false;
            this.gbTableSelection.Text = "Table Selection";
            // 
            // btnDropTables
            // 
            this.btnDropTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDropTables.Location = new System.Drawing.Point(162, 51);
            this.btnDropTables.Name = "btnDropTables";
            this.btnDropTables.Size = new System.Drawing.Size(125, 29);
            this.btnDropTables.TabIndex = 24;
            this.btnDropTables.Text = "Drop Table";
            this.btnDropTables.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(9, 51);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(125, 29);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "Refresh Tables";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // lblDetTable
            // 
            this.lblDetTable.AutoSize = true;
            this.lblDetTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetTable.Location = new System.Drawing.Point(6, 116);
            this.lblDetTable.Name = "lblDetTable";
            this.lblDetTable.Size = new System.Drawing.Size(92, 16);
            this.lblDetTable.TabIndex = 22;
            this.lblDetTable.Text = "Details Table ";
            // 
            // lblSumTable
            // 
            this.lblSumTable.AutoSize = true;
            this.lblSumTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumTable.Location = new System.Drawing.Point(6, 86);
            this.lblSumTable.Name = "lblSumTable";
            this.lblSumTable.Size = new System.Drawing.Size(107, 16);
            this.lblSumTable.TabIndex = 21;
            this.lblSumTable.Text = "Summary Table ";
            // 
            // tbDetTable
            // 
            this.tbDetTable.Location = new System.Drawing.Point(114, 116);
            this.tbDetTable.Name = "tbDetTable";
            this.tbDetTable.ReadOnly = true;
            this.tbDetTable.Size = new System.Drawing.Size(173, 20);
            this.tbDetTable.TabIndex = 20;
            // 
            // tbSumTable
            // 
            this.tbSumTable.Location = new System.Drawing.Point(114, 86);
            this.tbSumTable.Name = "tbSumTable";
            this.tbSumTable.ReadOnly = true;
            this.tbSumTable.Size = new System.Drawing.Size(173, 20);
            this.tbSumTable.TabIndex = 19;
            // 
            // lblInputTable
            // 
            this.lblInputTable.AutoSize = true;
            this.lblInputTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputTable.Location = new System.Drawing.Point(6, 27);
            this.lblInputTable.Name = "lblInputTable";
            this.lblInputTable.Size = new System.Drawing.Size(85, 16);
            this.lblInputTable.TabIndex = 47;
            this.lblInputTable.Text = "Select Table";
            // 
            // cmbInputTable
            // 
            this.cmbInputTable.FormattingEnabled = true;
            this.cmbInputTable.Location = new System.Drawing.Point(114, 27);
            this.cmbInputTable.Name = "cmbInputTable";
            this.cmbInputTable.Size = new System.Drawing.Size(173, 21);
            this.cmbInputTable.TabIndex = 48;
            this.cmbInputTable.SelectedIndexChanged += new System.EventHandler(this.cmbInputTable_SelectedIndexChanged);
            // 
            // gbFieldSelection
            // 
            this.gbFieldSelection.Controls.Add(this.tbOptSearchString);
            this.gbFieldSelection.Controls.Add(this.label2);
            this.gbFieldSelection.Controls.Add(this.btnStopWords);
            this.gbFieldSelection.Controls.Add(this.lblStopWords);
            this.gbFieldSelection.Controls.Add(this.tbStopWords);
            this.gbFieldSelection.Controls.Add(this.btnTextFieldsMFUnselect);
            this.gbFieldSelection.Controls.Add(this.btnTextFieldsSFUnselect);
            this.gbFieldSelection.Controls.Add(this.btnTktSrcUnSelect);
            this.gbFieldSelection.Controls.Add(this.btnTktNoUnSelect);
            this.gbFieldSelection.Controls.Add(this.lbTktSrcAnalyze);
            this.gbFieldSelection.Controls.Add(this.btnTextFieldsMFSelect);
            this.gbFieldSelection.Controls.Add(this.btnTextFieldsSFSelect);
            this.gbFieldSelection.Controls.Add(this.btnTktSrcSelect);
            this.gbFieldSelection.Controls.Add(this.lbTktSrc);
            this.gbFieldSelection.Controls.Add(this.lbTktNo);
            this.gbFieldSelection.Controls.Add(this.btnTktNoSelect);
            this.gbFieldSelection.Controls.Add(this.tbTktSrcField);
            this.gbFieldSelection.Controls.Add(this.tbTktNoField);
            this.gbFieldSelection.Controls.Add(this.lbAllFields);
            this.gbFieldSelection.Controls.Add(this.lbxTextFields);
            this.gbFieldSelection.Controls.Add(this.lbxAllFields);
            this.gbFieldSelection.Location = new System.Drawing.Point(361, 66);
            this.gbFieldSelection.Name = "gbFieldSelection";
            this.gbFieldSelection.Size = new System.Drawing.Size(543, 369);
            this.gbFieldSelection.TabIndex = 39;
            this.gbFieldSelection.TabStop = false;
            this.gbFieldSelection.Text = "Select Fields";
            // 
            // tbOptSearchString
            // 
            this.tbOptSearchString.Location = new System.Drawing.Point(165, 342);
            this.tbOptSearchString.Name = "tbOptSearchString";
            this.tbOptSearchString.Size = new System.Drawing.Size(173, 20);
            this.tbOptSearchString.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Optional Search String";
            // 
            // btnStopWords
            // 
            this.btnStopWords.Location = new System.Drawing.Point(464, 309);
            this.btnStopWords.Name = "btnStopWords";
            this.btnStopWords.Size = new System.Drawing.Size(28, 23);
            this.btnStopWords.TabIndex = 51;
            this.btnStopWords.Text = "...";
            this.btnStopWords.UseVisualStyleBackColor = true;
            this.btnStopWords.Click += new System.EventHandler(this.btnStopWords_Click);
            // 
            // lblStopWords
            // 
            this.lblStopWords.AutoSize = true;
            this.lblStopWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopWords.Location = new System.Drawing.Point(10, 312);
            this.lblStopWords.Name = "lblStopWords";
            this.lblStopWords.Size = new System.Drawing.Size(192, 16);
            this.lblStopWords.TabIndex = 50;
            this.lblStopWords.Text = "Optional - Add Stop Words File";
            // 
            // tbStopWords
            // 
            this.tbStopWords.Location = new System.Drawing.Point(208, 310);
            this.tbStopWords.Name = "tbStopWords";
            this.tbStopWords.ReadOnly = true;
            this.tbStopWords.Size = new System.Drawing.Size(256, 20);
            this.tbStopWords.TabIndex = 49;
            // 
            // btnTextFieldsMFUnselect
            // 
            this.btnTextFieldsMFUnselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextFieldsMFUnselect.Location = new System.Drawing.Point(201, 167);
            this.btnTextFieldsMFUnselect.Name = "btnTextFieldsMFUnselect";
            this.btnTextFieldsMFUnselect.Size = new System.Drawing.Size(39, 27);
            this.btnTextFieldsMFUnselect.TabIndex = 48;
            this.btnTextFieldsMFUnselect.Text = "<<";
            this.btnTextFieldsMFUnselect.UseVisualStyleBackColor = true;
            this.btnTextFieldsMFUnselect.Click += new System.EventHandler(this.btnTextFieldsMFUnselect_Click);
            // 
            // btnTextFieldsSFUnselect
            // 
            this.btnTextFieldsSFUnselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextFieldsSFUnselect.Location = new System.Drawing.Point(201, 134);
            this.btnTextFieldsSFUnselect.Name = "btnTextFieldsSFUnselect";
            this.btnTextFieldsSFUnselect.Size = new System.Drawing.Size(39, 27);
            this.btnTextFieldsSFUnselect.TabIndex = 47;
            this.btnTextFieldsSFUnselect.Text = "<";
            this.btnTextFieldsSFUnselect.UseVisualStyleBackColor = true;
            this.btnTextFieldsSFUnselect.Click += new System.EventHandler(this.btnTextFieldsSFUnselect_Click);
            // 
            // btnTktSrcUnSelect
            // 
            this.btnTktSrcUnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTktSrcUnSelect.Location = new System.Drawing.Point(201, 77);
            this.btnTktSrcUnSelect.Name = "btnTktSrcUnSelect";
            this.btnTktSrcUnSelect.Size = new System.Drawing.Size(39, 27);
            this.btnTktSrcUnSelect.TabIndex = 46;
            this.btnTktSrcUnSelect.Text = "<";
            this.btnTktSrcUnSelect.UseVisualStyleBackColor = true;
            this.btnTktSrcUnSelect.Click += new System.EventHandler(this.btnTktSrcUnSelect_Click);
            // 
            // btnTktNoUnSelect
            // 
            this.btnTktNoUnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTktNoUnSelect.Location = new System.Drawing.Point(201, 41);
            this.btnTktNoUnSelect.Name = "btnTktNoUnSelect";
            this.btnTktNoUnSelect.Size = new System.Drawing.Size(39, 27);
            this.btnTktNoUnSelect.TabIndex = 45;
            this.btnTktNoUnSelect.Text = "<";
            this.btnTktNoUnSelect.UseVisualStyleBackColor = true;
            this.btnTktNoUnSelect.Click += new System.EventHandler(this.btnTktNoUnSelect_Click);
            // 
            // lbTktSrcAnalyze
            // 
            this.lbTktSrcAnalyze.AutoSize = true;
            this.lbTktSrcAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTktSrcAnalyze.Location = new System.Drawing.Point(293, 111);
            this.lbTktSrcAnalyze.Name = "lbTktSrcAnalyze";
            this.lbTktSrcAnalyze.Size = new System.Drawing.Size(140, 16);
            this.lbTktSrcAnalyze.TabIndex = 44;
            this.lbTktSrcAnalyze.Text = "Text Fields to Analyse";
            // 
            // btnTextFieldsMFSelect
            // 
            this.btnTextFieldsMFSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextFieldsMFSelect.Location = new System.Drawing.Point(246, 167);
            this.btnTextFieldsMFSelect.Name = "btnTextFieldsMFSelect";
            this.btnTextFieldsMFSelect.Size = new System.Drawing.Size(39, 27);
            this.btnTextFieldsMFSelect.TabIndex = 43;
            this.btnTextFieldsMFSelect.Text = ">>";
            this.btnTextFieldsMFSelect.UseVisualStyleBackColor = true;
            this.btnTextFieldsMFSelect.Click += new System.EventHandler(this.btnTextFieldsMFSelect_Click);
            // 
            // btnTextFieldsSFSelect
            // 
            this.btnTextFieldsSFSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextFieldsSFSelect.Location = new System.Drawing.Point(246, 134);
            this.btnTextFieldsSFSelect.Name = "btnTextFieldsSFSelect";
            this.btnTextFieldsSFSelect.Size = new System.Drawing.Size(39, 27);
            this.btnTextFieldsSFSelect.TabIndex = 42;
            this.btnTextFieldsSFSelect.Text = ">";
            this.btnTextFieldsSFSelect.UseVisualStyleBackColor = true;
            this.btnTextFieldsSFSelect.Click += new System.EventHandler(this.btnTextFieldsSFSelect_Click);
            // 
            // btnTktSrcSelect
            // 
            this.btnTktSrcSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTktSrcSelect.Location = new System.Drawing.Point(246, 77);
            this.btnTktSrcSelect.Name = "btnTktSrcSelect";
            this.btnTktSrcSelect.Size = new System.Drawing.Size(39, 27);
            this.btnTktSrcSelect.TabIndex = 41;
            this.btnTktSrcSelect.Text = ">";
            this.btnTktSrcSelect.UseVisualStyleBackColor = true;
            this.btnTktSrcSelect.Click += new System.EventHandler(this.btnTktSrcSelect_Click);
            // 
            // lbTktSrc
            // 
            this.lbTktSrc.AutoSize = true;
            this.lbTktSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTktSrc.Location = new System.Drawing.Point(293, 82);
            this.lbTktSrc.Name = "lbTktSrc";
            this.lbTktSrc.Size = new System.Drawing.Size(91, 16);
            this.lbTktSrc.TabIndex = 40;
            this.lbTktSrc.Text = "Ticket Source";
            // 
            // lbTktNo
            // 
            this.lbTktNo.AutoSize = true;
            this.lbTktNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTktNo.Location = new System.Drawing.Point(293, 46);
            this.lbTktNo.Name = "lbTktNo";
            this.lbTktNo.Size = new System.Drawing.Size(66, 16);
            this.lbTktNo.TabIndex = 39;
            this.lbTktNo.Text = "Ticket No";
            // 
            // btnTktNoSelect
            // 
            this.btnTktNoSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTktNoSelect.Location = new System.Drawing.Point(246, 41);
            this.btnTktNoSelect.Name = "btnTktNoSelect";
            this.btnTktNoSelect.Size = new System.Drawing.Size(39, 27);
            this.btnTktNoSelect.TabIndex = 38;
            this.btnTktNoSelect.Text = ">";
            this.btnTktNoSelect.UseVisualStyleBackColor = true;
            this.btnTktNoSelect.Click += new System.EventHandler(this.btnTktNoSelect_Click);
            // 
            // tbTktSrcField
            // 
            this.tbTktSrcField.Location = new System.Drawing.Point(390, 80);
            this.tbTktSrcField.Name = "tbTktSrcField";
            this.tbTktSrcField.ReadOnly = true;
            this.tbTktSrcField.Size = new System.Drawing.Size(143, 20);
            this.tbTktSrcField.TabIndex = 37;
            // 
            // tbTktNoField
            // 
            this.tbTktNoField.Location = new System.Drawing.Point(390, 44);
            this.tbTktNoField.Name = "tbTktNoField";
            this.tbTktNoField.ReadOnly = true;
            this.tbTktNoField.Size = new System.Drawing.Size(143, 20);
            this.tbTktNoField.TabIndex = 36;
            // 
            // lbAllFields
            // 
            this.lbAllFields.AutoSize = true;
            this.lbAllFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAllFields.Location = new System.Drawing.Point(10, 18);
            this.lbAllFields.Name = "lbAllFields";
            this.lbAllFields.Size = new System.Drawing.Size(63, 16);
            this.lbAllFields.TabIndex = 35;
            this.lbAllFields.Text = "All Fields";
            // 
            // lbxTextFields
            // 
            this.lbxTextFields.FormattingEnabled = true;
            this.lbxTextFields.Location = new System.Drawing.Point(295, 133);
            this.lbxTextFields.Name = "lbxTextFields";
            this.lbxTextFields.Size = new System.Drawing.Size(238, 160);
            this.lbxTextFields.TabIndex = 34;
            // 
            // lbxAllFields
            // 
            this.lbxAllFields.FormattingEnabled = true;
            this.lbxAllFields.Location = new System.Drawing.Point(13, 41);
            this.lbxAllFields.Name = "lbxAllFields";
            this.lbxAllFields.Size = new System.Drawing.Size(178, 251);
            this.lbxAllFields.TabIndex = 33;
            // 
            // msgBox2
            // 
            this.msgBox2.Location = new System.Drawing.Point(98, 563);
            this.msgBox2.Name = "msgBox2";
            this.msgBox2.ReadOnly = true;
            this.msgBox2.Size = new System.Drawing.Size(806, 20);
            this.msgBox2.TabIndex = 47;
            // 
            // tbInputRecords
            // 
            this.tbInputRecords.Location = new System.Drawing.Point(274, 455);
            this.tbInputRecords.Name = "tbInputRecords";
            this.tbInputRecords.ReadOnly = true;
            this.tbInputRecords.Size = new System.Drawing.Size(100, 20);
            this.tbInputRecords.TabIndex = 48;
            // 
            // tbOutputRecords
            // 
            this.tbOutputRecords.Location = new System.Drawing.Point(378, 455);
            this.tbOutputRecords.Name = "tbOutputRecords";
            this.tbOutputRecords.ReadOnly = true;
            this.tbOutputRecords.Size = new System.Drawing.Size(100, 20);
            this.tbOutputRecords.TabIndex = 49;
            // 
            // tbCurrRecord
            // 
            this.tbCurrRecord.Location = new System.Drawing.Point(169, 455);
            this.tbCurrRecord.Name = "tbCurrRecord";
            this.tbCurrRecord.ReadOnly = true;
            this.tbCurrRecord.Size = new System.Drawing.Size(100, 20);
            this.tbCurrRecord.TabIndex = 50;
            // 
            // loadCSV
            // 
            this.loadCSV.Location = new System.Drawing.Point(476, 19);
            this.loadCSV.Name = "loadCSV";
            this.loadCSV.Size = new System.Drawing.Size(75, 23);
            this.loadCSV.TabIndex = 51;
            this.loadCSV.Text = "Load CSV";
            this.loadCSV.UseVisualStyleBackColor = true;
            this.loadCSV.Click += new System.EventHandler(this.loadCSV_Click);
            // 
            // lblMessage2
            // 
            this.lblMessage2.AutoSize = true;
            this.lblMessage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage2.Location = new System.Drawing.Point(18, 567);
            this.lblMessage2.Name = "lblMessage2";
            this.lblMessage2.Size = new System.Drawing.Size(75, 16);
            this.lblMessage2.TabIndex = 54;
            this.lblMessage2.Text = "Messages:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 55;
            this.button1.Text = "Show Summary Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 601);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMessage2);
            this.Controls.Add(this.loadCSV);
            this.Controls.Add(this.tbCurrRecord);
            this.Controls.Add(this.tbOutputRecords);
            this.Controls.Add(this.tbInputRecords);
            this.Controls.Add(this.msgBox2);
            this.Controls.Add(this.gbFieldSelection);
            this.Controls.Add(this.gbTableSelection);
            this.Controls.Add(this.gbDatabaseConnection);
            this.Controls.Add(this.pbHPELogo);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "HPE MWS Text Analysis Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHPELogo)).EndInit();
            this.gbDatabaseConnection.ResumeLayout(false);
            this.gbDatabaseConnection.PerformLayout();
            this.gbTableSelection.ResumeLayout(false);
            this.gbTableSelection.PerformLayout();
            this.gbFieldSelection.ResumeLayout(false);
            this.gbFieldSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.OpenFileDialog ofdStopWords;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox msgBox;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pbHPELogo;
        private System.Windows.Forms.GroupBox gbDatabaseConnection;
        private System.Windows.Forms.TextBox tbDBPassword;
        private System.Windows.Forms.Label lbDBPassword;
        private System.Windows.Forms.TextBox tbDBUsername;
        private System.Windows.Forms.Label lbDBUsername;
        private System.Windows.Forms.Label lblConnState;
        private System.Windows.Forms.Button btnDBConnect;
        private System.Windows.Forms.TextBox tbDBCatalog;
        private System.Windows.Forms.Label lbDBCatalog;
        private System.Windows.Forms.TextBox tbDBSource;
        private System.Windows.Forms.Label lbDBSource;
        private System.Windows.Forms.GroupBox gbTableSelection;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblDetTable;
        private System.Windows.Forms.Label lblSumTable;
        private System.Windows.Forms.TextBox tbDetTable;
        private System.Windows.Forms.TextBox tbSumTable;
        private System.Windows.Forms.Label lblInputTable;
        private System.Windows.Forms.ComboBox cmbInputTable;
        private System.Windows.Forms.GroupBox gbFieldSelection;
        private System.Windows.Forms.Button btnTextFieldsMFUnselect;
        private System.Windows.Forms.Button btnTextFieldsSFUnselect;
        private System.Windows.Forms.Button btnTktSrcUnSelect;
        private System.Windows.Forms.Button btnTktNoUnSelect;
        private System.Windows.Forms.Label lbTktSrcAnalyze;
        private System.Windows.Forms.Button btnTextFieldsMFSelect;
        private System.Windows.Forms.Button btnTextFieldsSFSelect;
        private System.Windows.Forms.Button btnTktSrcSelect;
        private System.Windows.Forms.Label lbTktSrc;
        private System.Windows.Forms.Label lbTktNo;
        private System.Windows.Forms.Button btnTktNoSelect;
        private System.Windows.Forms.TextBox tbTktSrcField;
        private System.Windows.Forms.TextBox tbTktNoField;
        private System.Windows.Forms.Label lbAllFields;
        private System.Windows.Forms.ListBox lbxTextFields;
        private System.Windows.Forms.ListBox lbxAllFields;
        private System.Windows.Forms.Button btnStopWords;
        private System.Windows.Forms.Label lblStopWords;
        private System.Windows.Forms.TextBox tbStopWords;
        private System.Windows.Forms.TextBox msgBox2;
        private System.Windows.Forms.TextBox tbInputRecords;
        private System.Windows.Forms.TextBox tbOutputRecords;
        private System.Windows.Forms.TextBox tbOptSearchString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCurrRecord;
        private System.Windows.Forms.Button btnDropTables;
        private System.Windows.Forms.Button loadCSV;
        private System.Windows.Forms.Label lblMessage2;
        private System.Windows.Forms.Button button1;
    }
}

