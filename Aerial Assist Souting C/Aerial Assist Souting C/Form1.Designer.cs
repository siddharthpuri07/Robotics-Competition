namespace Aerial_Assist_Souting_C
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.HighGoalBox = new System.Windows.Forms.ComboBox();
            this.HighGoalLabel = new System.Windows.Forms.Label();
            this.LowGoalBox = new System.Windows.Forms.ComboBox();
            this.LowGoalLabel = new System.Windows.Forms.Label();
            this.MiddleBarBox = new System.Windows.Forms.ComboBox();
            this.MiddleBarLabel = new System.Windows.Forms.Label();
            this.PickUpBallBox = new System.Windows.Forms.ComboBox();
            this.PickUpBallLabel = new System.Windows.Forms.Label();
            this.CatchBallBox = new System.Windows.Forms.ComboBox();
            this.CatchBallLabel = new System.Windows.Forms.Label();
            this.PassBallBox = new System.Windows.Forms.ComboBox();
            this.PassBallLabel = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.AutoHighGoalBox = new System.Windows.Forms.ComboBox();
            this.AutoHighGoalLabel = new System.Windows.Forms.Label();
            this.AutoLowGoalBox = new System.Windows.Forms.ComboBox();
            this.AutoLowGoalLabel = new System.Windows.Forms.Label();
            this.AutoForwardBox = new System.Windows.Forms.ComboBox();
            this.TeamNameBox = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.TeamNumberBox = new System.Windows.Forms.TextBox();
            this.TeamNumberLabel = new System.Windows.Forms.Label();
            this.TeamDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.ratingGroup = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ratingHideBtn = new System.Windows.Forms.Button();
            this.tb5 = new System.Windows.Forms.Label();
            this.tb4 = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.Label();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.tb1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AutoForwardLabel = new System.Windows.Forms.Label();
            this.AutonomousDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.ratingBtn = new System.Windows.Forms.Button();
            this.preMatch = new System.Windows.Forms.RadioButton();
            this.InMatch = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView = new System.Windows.Forms.ListView();
            this.saveList = new System.Windows.Forms.Button();
            this.detfaultSizeBtn = new System.Windows.Forms.Button();
            this.loadimgBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ds = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GroupBox1.SuspendLayout();
            this.TeamDetailsGroupBox.SuspendLayout();
            this.ratingGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.AutonomousDetailsGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HighGoalBox
            // 
            this.HighGoalBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HighGoalBox.BackColor = System.Drawing.Color.White;
            this.HighGoalBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HighGoalBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HighGoalBox.ForeColor = System.Drawing.Color.Black;
            this.HighGoalBox.FormattingEnabled = true;
            this.HighGoalBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.HighGoalBox.Location = new System.Drawing.Point(143, 175);
            this.HighGoalBox.Name = "HighGoalBox";
            this.HighGoalBox.Size = new System.Drawing.Size(268, 24);
            this.HighGoalBox.TabIndex = 13;
            this.HighGoalBox.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            this.HighGoalBox.VisibleChanged += new System.EventHandler(this.comboBox_VisibleChanged);
            // 
            // HighGoalLabel
            // 
            this.HighGoalLabel.Location = new System.Drawing.Point(19, 175);
            this.HighGoalLabel.Name = "HighGoalLabel";
            this.HighGoalLabel.Size = new System.Drawing.Size(117, 22);
            this.HighGoalLabel.TabIndex = 12;
            this.HighGoalLabel.Text = "High Goal";
            this.HighGoalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LowGoalBox
            // 
            this.LowGoalBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LowGoalBox.BackColor = System.Drawing.Color.White;
            this.LowGoalBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LowGoalBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LowGoalBox.ForeColor = System.Drawing.Color.Black;
            this.LowGoalBox.FormattingEnabled = true;
            this.LowGoalBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.LowGoalBox.Location = new System.Drawing.Point(143, 146);
            this.LowGoalBox.Name = "LowGoalBox";
            this.LowGoalBox.Size = new System.Drawing.Size(268, 24);
            this.LowGoalBox.TabIndex = 11;
            this.LowGoalBox.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            this.LowGoalBox.VisibleChanged += new System.EventHandler(this.comboBox_VisibleChanged);
            // 
            // LowGoalLabel
            // 
            this.LowGoalLabel.Location = new System.Drawing.Point(19, 146);
            this.LowGoalLabel.Name = "LowGoalLabel";
            this.LowGoalLabel.Size = new System.Drawing.Size(117, 22);
            this.LowGoalLabel.TabIndex = 10;
            this.LowGoalLabel.Text = "Low Goal";
            this.LowGoalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MiddleBarBox
            // 
            this.MiddleBarBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MiddleBarBox.BackColor = System.Drawing.Color.White;
            this.MiddleBarBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MiddleBarBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiddleBarBox.ForeColor = System.Drawing.Color.Black;
            this.MiddleBarBox.FormattingEnabled = true;
            this.MiddleBarBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.MiddleBarBox.Location = new System.Drawing.Point(143, 117);
            this.MiddleBarBox.Name = "MiddleBarBox";
            this.MiddleBarBox.Size = new System.Drawing.Size(268, 24);
            this.MiddleBarBox.TabIndex = 9;
            this.MiddleBarBox.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            this.MiddleBarBox.VisibleChanged += new System.EventHandler(this.comboBox_VisibleChanged);
            // 
            // MiddleBarLabel
            // 
            this.MiddleBarLabel.Location = new System.Drawing.Point(19, 117);
            this.MiddleBarLabel.Name = "MiddleBarLabel";
            this.MiddleBarLabel.Size = new System.Drawing.Size(117, 22);
            this.MiddleBarLabel.TabIndex = 8;
            this.MiddleBarLabel.Text = "Middle Bar";
            this.MiddleBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PickUpBallBox
            // 
            this.PickUpBallBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PickUpBallBox.BackColor = System.Drawing.Color.White;
            this.PickUpBallBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PickUpBallBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PickUpBallBox.ForeColor = System.Drawing.Color.Black;
            this.PickUpBallBox.FormattingEnabled = true;
            this.PickUpBallBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.PickUpBallBox.Location = new System.Drawing.Point(143, 90);
            this.PickUpBallBox.Name = "PickUpBallBox";
            this.PickUpBallBox.Size = new System.Drawing.Size(268, 24);
            this.PickUpBallBox.TabIndex = 7;
            this.PickUpBallBox.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            this.PickUpBallBox.VisibleChanged += new System.EventHandler(this.comboBox_VisibleChanged);
            // 
            // PickUpBallLabel
            // 
            this.PickUpBallLabel.Location = new System.Drawing.Point(19, 90);
            this.PickUpBallLabel.Name = "PickUpBallLabel";
            this.PickUpBallLabel.Size = new System.Drawing.Size(117, 22);
            this.PickUpBallLabel.TabIndex = 6;
            this.PickUpBallLabel.Text = "Pick Up Ball";
            this.PickUpBallLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CatchBallBox
            // 
            this.CatchBallBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CatchBallBox.BackColor = System.Drawing.Color.White;
            this.CatchBallBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CatchBallBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatchBallBox.ForeColor = System.Drawing.Color.Black;
            this.CatchBallBox.FormattingEnabled = true;
            this.CatchBallBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.CatchBallBox.Location = new System.Drawing.Point(143, 63);
            this.CatchBallBox.Name = "CatchBallBox";
            this.CatchBallBox.Size = new System.Drawing.Size(268, 24);
            this.CatchBallBox.TabIndex = 5;
            this.CatchBallBox.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            this.CatchBallBox.VisibleChanged += new System.EventHandler(this.comboBox_VisibleChanged);
            // 
            // CatchBallLabel
            // 
            this.CatchBallLabel.Location = new System.Drawing.Point(19, 63);
            this.CatchBallLabel.Name = "CatchBallLabel";
            this.CatchBallLabel.Size = new System.Drawing.Size(117, 22);
            this.CatchBallLabel.TabIndex = 4;
            this.CatchBallLabel.Text = "Catch Ball";
            this.CatchBallLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PassBallBox
            // 
            this.PassBallBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PassBallBox.BackColor = System.Drawing.Color.White;
            this.PassBallBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PassBallBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassBallBox.ForeColor = System.Drawing.Color.Black;
            this.PassBallBox.FormattingEnabled = true;
            this.PassBallBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.PassBallBox.Location = new System.Drawing.Point(143, 34);
            this.PassBallBox.Name = "PassBallBox";
            this.PassBallBox.Size = new System.Drawing.Size(268, 24);
            this.PassBallBox.TabIndex = 3;
            this.PassBallBox.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            this.PassBallBox.VisibleChanged += new System.EventHandler(this.comboBox_VisibleChanged);
            // 
            // PassBallLabel
            // 
            this.PassBallLabel.Location = new System.Drawing.Point(19, 34);
            this.PassBallLabel.Name = "PassBallLabel";
            this.PassBallLabel.Size = new System.Drawing.Size(117, 22);
            this.PassBallLabel.TabIndex = 2;
            this.PassBallLabel.Text = "Pass Ball";
            this.PassBallLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GroupBox1.Controls.Add(this.HighGoalBox);
            this.GroupBox1.Controls.Add(this.HighGoalLabel);
            this.GroupBox1.Controls.Add(this.LowGoalBox);
            this.GroupBox1.Controls.Add(this.LowGoalLabel);
            this.GroupBox1.Controls.Add(this.MiddleBarBox);
            this.GroupBox1.Controls.Add(this.MiddleBarLabel);
            this.GroupBox1.Controls.Add(this.PickUpBallBox);
            this.GroupBox1.Controls.Add(this.PickUpBallLabel);
            this.GroupBox1.Controls.Add(this.CatchBallBox);
            this.GroupBox1.Controls.Add(this.CatchBallLabel);
            this.GroupBox1.Controls.Add(this.PassBallBox);
            this.GroupBox1.Controls.Add(this.PassBallLabel);
            this.GroupBox1.Location = new System.Drawing.Point(23, 353);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(431, 209);
            this.GroupBox1.TabIndex = 5;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Autonomous Details";
            // 
            // AutoHighGoalBox
            // 
            this.AutoHighGoalBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoHighGoalBox.BackColor = System.Drawing.Color.White;
            this.AutoHighGoalBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AutoHighGoalBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoHighGoalBox.ForeColor = System.Drawing.Color.Black;
            this.AutoHighGoalBox.FormattingEnabled = true;
            this.AutoHighGoalBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.AutoHighGoalBox.Location = new System.Drawing.Point(143, 93);
            this.AutoHighGoalBox.Name = "AutoHighGoalBox";
            this.AutoHighGoalBox.Size = new System.Drawing.Size(268, 24);
            this.AutoHighGoalBox.TabIndex = 7;
            this.AutoHighGoalBox.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            this.AutoHighGoalBox.VisibleChanged += new System.EventHandler(this.comboBox_VisibleChanged);
            // 
            // AutoHighGoalLabel
            // 
            this.AutoHighGoalLabel.Location = new System.Drawing.Point(19, 93);
            this.AutoHighGoalLabel.Name = "AutoHighGoalLabel";
            this.AutoHighGoalLabel.Size = new System.Drawing.Size(117, 22);
            this.AutoHighGoalLabel.TabIndex = 6;
            this.AutoHighGoalLabel.Text = "High Goal";
            this.AutoHighGoalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AutoLowGoalBox
            // 
            this.AutoLowGoalBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoLowGoalBox.BackColor = System.Drawing.Color.White;
            this.AutoLowGoalBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AutoLowGoalBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoLowGoalBox.ForeColor = System.Drawing.Color.Black;
            this.AutoLowGoalBox.FormattingEnabled = true;
            this.AutoLowGoalBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.AutoLowGoalBox.Location = new System.Drawing.Point(143, 63);
            this.AutoLowGoalBox.Name = "AutoLowGoalBox";
            this.AutoLowGoalBox.Size = new System.Drawing.Size(268, 24);
            this.AutoLowGoalBox.TabIndex = 4;
            this.AutoLowGoalBox.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            this.AutoLowGoalBox.VisibleChanged += new System.EventHandler(this.comboBox_VisibleChanged);
            // 
            // AutoLowGoalLabel
            // 
            this.AutoLowGoalLabel.Location = new System.Drawing.Point(19, 64);
            this.AutoLowGoalLabel.Name = "AutoLowGoalLabel";
            this.AutoLowGoalLabel.Size = new System.Drawing.Size(117, 22);
            this.AutoLowGoalLabel.TabIndex = 0;
            this.AutoLowGoalLabel.Text = "Low Goal";
            this.AutoLowGoalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AutoForwardBox
            // 
            this.AutoForwardBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoForwardBox.BackColor = System.Drawing.Color.White;
            this.AutoForwardBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AutoForwardBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoForwardBox.ForeColor = System.Drawing.Color.Black;
            this.AutoForwardBox.FormattingEnabled = true;
            this.AutoForwardBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.AutoForwardBox.Location = new System.Drawing.Point(143, 34);
            this.AutoForwardBox.Name = "AutoForwardBox";
            this.AutoForwardBox.Size = new System.Drawing.Size(268, 24);
            this.AutoForwardBox.TabIndex = 3;
            this.AutoForwardBox.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            this.AutoForwardBox.VisibleChanged += new System.EventHandler(this.comboBox_VisibleChanged);
            // 
            // TeamNameBox
            // 
            this.TeamNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeamNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamNameBox.Location = new System.Drawing.Point(143, 57);
            this.TeamNameBox.Name = "TeamNameBox";
            this.TeamNameBox.Size = new System.Drawing.Size(267, 22);
            this.TeamNameBox.TabIndex = 2;
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.Location = new System.Drawing.Point(19, 56);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(117, 22);
            this.TeamNameLabel.TabIndex = 0;
            this.TeamNameLabel.Text = "Name";
            this.TeamNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TeamNumberBox
            // 
            this.TeamNumberBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeamNumberBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamNumberBox.Location = new System.Drawing.Point(143, 30);
            this.TeamNumberBox.Name = "TeamNumberBox";
            this.TeamNumberBox.Size = new System.Drawing.Size(267, 22);
            this.TeamNumberBox.TabIndex = 1;
            this.TeamNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeamNumberBox_KeyPress);
            // 
            // TeamNumberLabel
            // 
            this.TeamNumberLabel.Location = new System.Drawing.Point(19, 30);
            this.TeamNumberLabel.Name = "TeamNumberLabel";
            this.TeamNumberLabel.Size = new System.Drawing.Size(117, 22);
            this.TeamNumberLabel.TabIndex = 0;
            this.TeamNumberLabel.Text = "Number";
            this.TeamNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TeamDetailsGroupBox
            // 
            this.TeamDetailsGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TeamDetailsGroupBox.Controls.Add(this.TeamNameBox);
            this.TeamDetailsGroupBox.Controls.Add(this.TeamNameLabel);
            this.TeamDetailsGroupBox.Controls.Add(this.TeamNumberBox);
            this.TeamDetailsGroupBox.Controls.Add(this.TeamNumberLabel);
            this.TeamDetailsGroupBox.Location = new System.Drawing.Point(23, 87);
            this.TeamDetailsGroupBox.Name = "TeamDetailsGroupBox";
            this.TeamDetailsGroupBox.Size = new System.Drawing.Size(431, 97);
            this.TeamDetailsGroupBox.TabIndex = 3;
            this.TeamDetailsGroupBox.TabStop = false;
            this.TeamDetailsGroupBox.Text = "Team Details";
            // 
            // ratingGroup
            // 
            this.ratingGroup.Controls.Add(this.pictureBox4);
            this.ratingGroup.Controls.Add(this.ratingHideBtn);
            this.ratingGroup.Controls.Add(this.tb5);
            this.ratingGroup.Controls.Add(this.tb4);
            this.ratingGroup.Controls.Add(this.tb3);
            this.ratingGroup.Controls.Add(this.tb2);
            this.ratingGroup.Controls.Add(this.trackBar5);
            this.ratingGroup.Controls.Add(this.trackBar4);
            this.ratingGroup.Controls.Add(this.trackBar3);
            this.ratingGroup.Controls.Add(this.trackBar2);
            this.ratingGroup.Controls.Add(this.tb1);
            this.ratingGroup.Controls.Add(this.trackBar1);
            this.ratingGroup.Controls.Add(this.label5);
            this.ratingGroup.Controls.Add(this.label4);
            this.ratingGroup.Controls.Add(this.label3);
            this.ratingGroup.Controls.Add(this.label2);
            this.ratingGroup.Controls.Add(this.label1);
            this.ratingGroup.Location = new System.Drawing.Point(17, 13);
            this.ratingGroup.Margin = new System.Windows.Forms.Padding(4);
            this.ratingGroup.Name = "ratingGroup";
            this.ratingGroup.Padding = new System.Windows.Forms.Padding(4);
            this.ratingGroup.Size = new System.Drawing.Size(437, 516);
            this.ratingGroup.TabIndex = 3;
            this.ratingGroup.TabStop = false;
            this.ratingGroup.Text = "Performance Rating";
            this.ratingGroup.Enter += new System.EventHandler(this.RatingGroup_Enter);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(158, 400);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(123, 72);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 51;
            this.pictureBox4.TabStop = false;
            // 
            // ratingHideBtn
            // 
            this.ratingHideBtn.Location = new System.Drawing.Point(106, 349);
            this.ratingHideBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ratingHideBtn.Name = "ratingHideBtn";
            this.ratingHideBtn.Size = new System.Drawing.Size(228, 26);
            this.ratingHideBtn.TabIndex = 50;
            this.ratingHideBtn.Text = "Done";
            this.ratingHideBtn.UseVisualStyleBackColor = true;
            this.ratingHideBtn.Click += new System.EventHandler(this.ratingHideBtn_Click);
            // 
            // tb5
            // 
            this.tb5.AutoSize = true;
            this.tb5.Location = new System.Drawing.Point(360, 297);
            this.tb5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(36, 17);
            this.tb5.TabIndex = 49;
            this.tb5.Text = "       ";
            // 
            // tb4
            // 
            this.tb4.AutoSize = true;
            this.tb4.Location = new System.Drawing.Point(360, 240);
            this.tb4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(36, 17);
            this.tb4.TabIndex = 48;
            this.tb4.Text = "       ";
            // 
            // tb3
            // 
            this.tb3.AutoSize = true;
            this.tb3.Location = new System.Drawing.Point(360, 184);
            this.tb3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(36, 17);
            this.tb3.TabIndex = 47;
            this.tb3.Text = "       ";
            // 
            // tb2
            // 
            this.tb2.AutoSize = true;
            this.tb2.Location = new System.Drawing.Point(360, 125);
            this.tb2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(36, 17);
            this.tb2.TabIndex = 46;
            this.tb2.Text = "       ";
            // 
            // trackBar5
            // 
            this.trackBar5.Location = new System.Drawing.Point(195, 296);
            this.trackBar5.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(157, 56);
            this.trackBar5.TabIndex = 45;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll_1);
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(195, 240);
            this.trackBar4.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(157, 56);
            this.trackBar4.TabIndex = 44;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll_1);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(195, 179);
            this.trackBar3.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(157, 56);
            this.trackBar3.TabIndex = 43;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll_1);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(195, 120);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(157, 56);
            this.trackBar2.TabIndex = 42;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll_1);
            // 
            // tb1
            // 
            this.tb1.AutoSize = true;
            this.tb1.Location = new System.Drawing.Point(360, 64);
            this.tb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(36, 17);
            this.tb1.TabIndex = 41;
            this.tb1.Text = "       ";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(195, 63);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(157, 56);
            this.trackBar1.TabIndex = 40;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 296);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Overall Attack";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "High Goal Accuracy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Maneuverability";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Overall Defence";
            // 
            // AutoForwardLabel
            // 
            this.AutoForwardLabel.Location = new System.Drawing.Point(19, 34);
            this.AutoForwardLabel.Name = "AutoForwardLabel";
            this.AutoForwardLabel.Size = new System.Drawing.Size(117, 22);
            this.AutoForwardLabel.TabIndex = 0;
            this.AutoForwardLabel.Text = "Drive Forward";
            this.AutoForwardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AutonomousDetailsGroupBox
            // 
            this.AutonomousDetailsGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AutonomousDetailsGroupBox.Controls.Add(this.AutoHighGoalBox);
            this.AutonomousDetailsGroupBox.Controls.Add(this.AutoHighGoalLabel);
            this.AutonomousDetailsGroupBox.Controls.Add(this.AutoLowGoalBox);
            this.AutonomousDetailsGroupBox.Controls.Add(this.AutoLowGoalLabel);
            this.AutonomousDetailsGroupBox.Controls.Add(this.AutoForwardBox);
            this.AutonomousDetailsGroupBox.Controls.Add(this.AutoForwardLabel);
            this.AutonomousDetailsGroupBox.Location = new System.Drawing.Point(23, 211);
            this.AutonomousDetailsGroupBox.Name = "AutonomousDetailsGroupBox";
            this.AutonomousDetailsGroupBox.Size = new System.Drawing.Size(431, 134);
            this.AutonomousDetailsGroupBox.TabIndex = 4;
            this.AutonomousDetailsGroupBox.TabStop = false;
            this.AutonomousDetailsGroupBox.Text = "Autonomous Details";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(166, 544);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(132, 26);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save To CVS";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(322, 544);
            this.loadBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(132, 26);
            this.loadBtn.TabIndex = 7;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // ratingBtn
            // 
            this.ratingBtn.Location = new System.Drawing.Point(132, 502);
            this.ratingBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ratingBtn.Name = "ratingBtn";
            this.ratingBtn.Size = new System.Drawing.Size(228, 26);
            this.ratingBtn.TabIndex = 15;
            this.ratingBtn.Text = "Performance Rating";
            this.ratingBtn.UseVisualStyleBackColor = true;
            this.ratingBtn.Click += new System.EventHandler(this.ratingBtn_Click);
            // 
            // preMatch
            // 
            this.preMatch.AutoSize = true;
            this.preMatch.Location = new System.Drawing.Point(72, 125);
            this.preMatch.Margin = new System.Windows.Forms.Padding(4);
            this.preMatch.Name = "preMatch";
            this.preMatch.Size = new System.Drawing.Size(94, 21);
            this.preMatch.TabIndex = 16;
            this.preMatch.TabStop = true;
            this.preMatch.Text = "Pre-Match";
            this.preMatch.UseVisualStyleBackColor = true;
            // 
            // InMatch
            // 
            this.InMatch.AutoSize = true;
            this.InMatch.Location = new System.Drawing.Point(224, 125);
            this.InMatch.Margin = new System.Windows.Forms.Padding(4);
            this.InMatch.Name = "InMatch";
            this.InMatch.Size = new System.Drawing.Size(83, 21);
            this.InMatch.TabIndex = 17;
            this.InMatch.TabStop = true;
            this.InMatch.Text = "In-Match";
            this.InMatch.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView);
            this.groupBox2.Location = new System.Drawing.Point(461, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(255, 270);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CSV File path";
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(8, 22);
            this.listView.Margin = new System.Windows.Forms.Padding(4);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(237, 233);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            this.listView.ItemActivate += new System.EventHandler(this.listView_ItemActivate_1);
            // 
            // saveList
            // 
            this.saveList.Location = new System.Drawing.Point(17, 544);
            this.saveList.Margin = new System.Windows.Forms.Padding(4);
            this.saveList.Name = "saveList";
            this.saveList.Size = new System.Drawing.Size(132, 26);
            this.saveList.TabIndex = 20;
            this.saveList.Text = "Show ListView";
            this.saveList.UseVisualStyleBackColor = true;
            this.saveList.Click += new System.EventHandler(this.saveList_Click);
            // 
            // detfaultSizeBtn
            // 
            this.detfaultSizeBtn.Location = new System.Drawing.Point(487, 439);
            this.detfaultSizeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.detfaultSizeBtn.Name = "detfaultSizeBtn";
            this.detfaultSizeBtn.Size = new System.Drawing.Size(132, 26);
            this.detfaultSizeBtn.TabIndex = 21;
            this.detfaultSizeBtn.Text = "Hide ListView ";
            this.detfaultSizeBtn.UseVisualStyleBackColor = true;
            this.detfaultSizeBtn.Click += new System.EventHandler(this.detfaultSizeBtn_Click);
            // 
            // loadimgBtn
            // 
            this.loadimgBtn.Location = new System.Drawing.Point(505, 395);
            this.loadimgBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loadimgBtn.Name = "loadimgBtn";
            this.loadimgBtn.Size = new System.Drawing.Size(100, 26);
            this.loadimgBtn.TabIndex = 26;
            this.loadimgBtn.Text = "Load Image";
            this.loadimgBtn.UseVisualStyleBackColor = true;
            this.loadimgBtn.Click += new System.EventHandler(this.loadimgBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(492, 299);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(127, 89);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ds);
            this.groupBox3.Location = new System.Drawing.Point(723, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 270);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Description";
            // 
            // ds
            // 
            this.ds.Location = new System.Drawing.Point(6, 22);
            this.ds.Multiline = true;
            this.ds.Name = "ds";
            this.ds.Size = new System.Drawing.Size(205, 233);
            this.ds.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(723, 304);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 764);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.loadimgBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ratingGroup);
            this.Controls.Add(this.detfaultSizeBtn);
            this.Controls.Add(this.saveList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.InMatch);
            this.Controls.Add(this.preMatch);
            this.Controls.Add(this.ratingBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.TeamDetailsGroupBox);
            this.Controls.Add(this.AutonomousDetailsGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "FRC";
            this.GroupBox1.ResumeLayout(false);
            this.TeamDetailsGroupBox.ResumeLayout(false);
            this.TeamDetailsGroupBox.PerformLayout();
            this.ratingGroup.ResumeLayout(false);
            this.ratingGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.AutonomousDetailsGroupBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox HighGoalBox;
        internal System.Windows.Forms.Label HighGoalLabel;
        internal System.Windows.Forms.ComboBox LowGoalBox;
        internal System.Windows.Forms.Label LowGoalLabel;
        internal System.Windows.Forms.ComboBox MiddleBarBox;
        internal System.Windows.Forms.Label MiddleBarLabel;
        internal System.Windows.Forms.ComboBox PickUpBallBox;
        internal System.Windows.Forms.Label PickUpBallLabel;
        internal System.Windows.Forms.ComboBox CatchBallBox;
        internal System.Windows.Forms.Label CatchBallLabel;
        internal System.Windows.Forms.ComboBox PassBallBox;
        internal System.Windows.Forms.Label PassBallLabel;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ComboBox AutoHighGoalBox;
        internal System.Windows.Forms.Label AutoHighGoalLabel;
        internal System.Windows.Forms.ComboBox AutoLowGoalBox;
        internal System.Windows.Forms.Label AutoLowGoalLabel;
        internal System.Windows.Forms.ComboBox AutoForwardBox;
        internal System.Windows.Forms.TextBox TeamNameBox;
        internal System.Windows.Forms.Label TeamNameLabel;
        internal System.Windows.Forms.TextBox TeamNumberBox;
        internal System.Windows.Forms.Label TeamNumberLabel;
        internal System.Windows.Forms.GroupBox TeamDetailsGroupBox;
        internal System.Windows.Forms.Label AutoForwardLabel;
        internal System.Windows.Forms.GroupBox AutonomousDetailsGroupBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button ratingBtn;
        private System.Windows.Forms.RadioButton preMatch;
        private System.Windows.Forms.RadioButton InMatch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button saveList;
        private System.Windows.Forms.Button detfaultSizeBtn;
        private System.Windows.Forms.GroupBox ratingGroup;
        private System.Windows.Forms.Label tb5;
        private System.Windows.Forms.Label tb4;
        private System.Windows.Forms.Label tb3;
        private System.Windows.Forms.Label tb2;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label tb1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ratingHideBtn;
        private System.Windows.Forms.Button loadimgBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox ds;
        private System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.GroupBox groupBox3;
    }
}

