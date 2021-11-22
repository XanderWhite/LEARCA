namespace Learca
{
    partial class Form_SettingsToLearn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddDecksAuto = new System.Windows.Forms.Button();
            this.dataGridView_Decks = new System.Windows.Forms.DataGridView();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeckName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCards = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStartingPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeckType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelStartingPoint_Decks = new System.Windows.Forms.Label();
            this.dateTimePicker_DeckStartPoint = new System.Windows.Forms.DateTimePicker();
            this.btnAddChosenDecksAuto = new System.Windows.Forms.Button();
            this.groupBox_AskBothSides = new System.Windows.Forms.GroupBox();
            this.checkBox_LearnOnlyOneSide = new System.Windows.Forms.CheckBox();
            this.groupBox_StartSide = new System.Windows.Forms.GroupBox();
            this.radioButton_MixSides = new System.Windows.Forms.RadioButton();
            this.radioButton_RightSide = new System.Windows.Forms.RadioButton();
            this.radioButton_LeftSide = new System.Windows.Forms.RadioButton();
            this.groupBox_Percent = new System.Windows.Forms.GroupBox();
            this.label_RightPercent = new System.Windows.Forms.Label();
            this.trackBar_Percent = new System.Windows.Forms.TrackBar();
            this.label_LeftPercent = new System.Windows.Forms.Label();
            this.labelRightSide = new System.Windows.Forms.Label();
            this.labelLeftSide = new System.Windows.Forms.Label();
            this.checkBox_LearnQACards = new System.Windows.Forms.CheckBox();
            this.checkBox_LearnInformationCards = new System.Windows.Forms.CheckBox();
            this.checkBox_LearnBothSides = new System.Windows.Forms.CheckBox();
            this.btnLearnCards = new System.Windows.Forms.Button();
            this.checkBox_TypeAnswers = new System.Windows.Forms.CheckBox();
            this.label_Loading = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAddChosenDeck = new System.Windows.Forms.Button();
            this.btnAddDecks = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dateTimePicker_ChosenDeckStartPoint = new System.Windows.Forms.DateTimePicker();
            this.labelStartingPoint_RepeatingDecks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Decks)).BeginInit();
            this.groupBox_AskBothSides.SuspendLayout();
            this.groupBox_StartSide.SuspendLayout();
            this.groupBox_Percent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Percent)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddDecksAuto
            // 
            this.btnAddDecksAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDecksAuto.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDecksAuto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddDecksAuto.FlatAppearance.BorderSize = 0;
            this.btnAddDecksAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDecksAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddDecksAuto.ForeColor = System.Drawing.Color.White;
            this.btnAddDecksAuto.Location = new System.Drawing.Point(259, 67);
            this.btnAddDecksAuto.Name = "btnAddDecksAuto";
            this.btnAddDecksAuto.Size = new System.Drawing.Size(160, 40);
            this.btnAddDecksAuto.TabIndex = 0;
            this.btnAddDecksAuto.Text = "ADD LIST";
            this.btnAddDecksAuto.UseVisualStyleBackColor = false;
            // 
            // dataGridView_Decks
            // 
            this.dataGridView_Decks.AllowUserToAddRows = false;
            this.dataGridView_Decks.AllowUserToDeleteRows = false;
            this.dataGridView_Decks.AllowUserToResizeColumns = false;
            this.dataGridView_Decks.AllowUserToResizeRows = false;
            this.dataGridView_Decks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Decks.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Decks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Decks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Decks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Decks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnDeckName,
            this.ColumnCards,
            this.ColumnStartingPoint,
            this.ColumnDescription,
            this.ColumnDeckType});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Decks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Decks.Location = new System.Drawing.Point(184, 144);
            this.dataGridView_Decks.Name = "dataGridView_Decks";
            this.dataGridView_Decks.ReadOnly = true;
            this.dataGridView_Decks.RowHeadersVisible = false;
            this.dataGridView_Decks.RowHeadersWidth = 51;
            this.dataGridView_Decks.RowTemplate.Height = 50;
            this.dataGridView_Decks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Decks.Size = new System.Drawing.Size(1151, 242);
            this.dataGridView_Decks.TabIndex = 22;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.Frozen = true;
            this.ColumnNumber.HeaderText = "№";
            this.ColumnNumber.MinimumWidth = 6;
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            this.ColumnNumber.Width = 49;
            // 
            // ColumnDeckName
            // 
            this.ColumnDeckName.Frozen = true;
            this.ColumnDeckName.HeaderText = "DECK NAME";
            this.ColumnDeckName.MinimumWidth = 6;
            this.ColumnDeckName.Name = "ColumnDeckName";
            this.ColumnDeckName.ReadOnly = true;
            this.ColumnDeckName.Width = 300;
            // 
            // ColumnCards
            // 
            this.ColumnCards.Frozen = true;
            this.ColumnCards.HeaderText = "CARDS";
            this.ColumnCards.MinimumWidth = 6;
            this.ColumnCards.Name = "ColumnCards";
            this.ColumnCards.ReadOnly = true;
            this.ColumnCards.Width = 125;
            // 
            // ColumnStartingPoint
            // 
            dataGridViewCellStyle2.NullValue = "System.Drawing.Bitmap";
            this.ColumnStartingPoint.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnStartingPoint.Frozen = true;
            this.ColumnStartingPoint.HeaderText = "START POINT";
            this.ColumnStartingPoint.MinimumWidth = 6;
            this.ColumnStartingPoint.Name = "ColumnStartingPoint";
            this.ColumnStartingPoint.ReadOnly = true;
            this.ColumnStartingPoint.Width = 200;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.Frozen = true;
            this.ColumnDescription.HeaderText = "DESCRIPTION";
            this.ColumnDescription.MinimumWidth = 6;
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.ReadOnly = true;
            this.ColumnDescription.Width = 300;
            // 
            // ColumnDeckType
            // 
            this.ColumnDeckType.Frozen = true;
            this.ColumnDeckType.HeaderText = "DECK TYPE";
            this.ColumnDeckType.MinimumWidth = 6;
            this.ColumnDeckType.Name = "ColumnDeckType";
            this.ColumnDeckType.ReadOnly = true;
            this.ColumnDeckType.Width = 200;
            // 
            // labelStartingPoint_Decks
            // 
            this.labelStartingPoint_Decks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStartingPoint_Decks.AutoSize = true;
            this.labelStartingPoint_Decks.BackColor = System.Drawing.Color.Transparent;
            this.labelStartingPoint_Decks.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStartingPoint_Decks.ForeColor = System.Drawing.Color.White;
            this.labelStartingPoint_Decks.Location = new System.Drawing.Point(442, 61);
            this.labelStartingPoint_Decks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartingPoint_Decks.Name = "labelStartingPoint_Decks";
            this.labelStartingPoint_Decks.Size = new System.Drawing.Size(204, 17);
            this.labelStartingPoint_Decks.TabIndex = 47;
            this.labelStartingPoint_Decks.Text = "START POINT FOR DECKS";
            // 
            // dateTimePicker_DeckStartPoint
            // 
            this.dateTimePicker_DeckStartPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_DeckStartPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_DeckStartPoint.Location = new System.Drawing.Point(429, 85);
            this.dateTimePicker_DeckStartPoint.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_DeckStartPoint.Name = "dateTimePicker_DeckStartPoint";
            this.dateTimePicker_DeckStartPoint.Size = new System.Drawing.Size(228, 26);
            this.dateTimePicker_DeckStartPoint.TabIndex = 1;
            // 
            // btnAddChosenDecksAuto
            // 
            this.btnAddChosenDecksAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddChosenDecksAuto.BackColor = System.Drawing.Color.Transparent;
            this.btnAddChosenDecksAuto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddChosenDecksAuto.FlatAppearance.BorderSize = 0;
            this.btnAddChosenDecksAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddChosenDecksAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddChosenDecksAuto.ForeColor = System.Drawing.Color.White;
            this.btnAddChosenDecksAuto.Location = new System.Drawing.Point(749, 67);
            this.btnAddChosenDecksAuto.Name = "btnAddChosenDecksAuto";
            this.btnAddChosenDecksAuto.Size = new System.Drawing.Size(160, 40);
            this.btnAddChosenDecksAuto.TabIndex = 3;
            this.btnAddChosenDecksAuto.Text = "ADD LIST";
            this.btnAddChosenDecksAuto.UseVisualStyleBackColor = false;
            // 
            // groupBox_AskBothSides
            // 
            this.groupBox_AskBothSides.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_AskBothSides.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_AskBothSides.Controls.Add(this.checkBox_LearnOnlyOneSide);
            this.groupBox_AskBothSides.Controls.Add(this.groupBox_StartSide);
            this.groupBox_AskBothSides.Controls.Add(this.groupBox_Percent);
            this.groupBox_AskBothSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_AskBothSides.ForeColor = System.Drawing.Color.White;
            this.groupBox_AskBothSides.Location = new System.Drawing.Point(552, 414);
            this.groupBox_AskBothSides.Name = "groupBox_AskBothSides";
            this.groupBox_AskBothSides.Size = new System.Drawing.Size(701, 276);
            this.groupBox_AskBothSides.TabIndex = 14;
            this.groupBox_AskBothSides.TabStop = false;
            this.groupBox_AskBothSides.Text = "ASK BOTH SIDES OPTIONS";
            // 
            // checkBox_LearnOnlyOneSide
            // 
            this.checkBox_LearnOnlyOneSide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_LearnOnlyOneSide.AutoSize = true;
            this.checkBox_LearnOnlyOneSide.Location = new System.Drawing.Point(20, 42);
            this.checkBox_LearnOnlyOneSide.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_LearnOnlyOneSide.Name = "checkBox_LearnOnlyOneSide";
            this.checkBox_LearnOnlyOneSide.Size = new System.Drawing.Size(206, 21);
            this.checkBox_LearnOnlyOneSide.TabIndex = 15;
            this.checkBox_LearnOnlyOneSide.Text = "LEARN ONLY ONE SIDE";
            this.checkBox_LearnOnlyOneSide.UseVisualStyleBackColor = true;
            // 
            // groupBox_StartSide
            // 
            this.groupBox_StartSide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_StartSide.Controls.Add(this.radioButton_MixSides);
            this.groupBox_StartSide.Controls.Add(this.radioButton_RightSide);
            this.groupBox_StartSide.Controls.Add(this.radioButton_LeftSide);
            this.groupBox_StartSide.ForeColor = System.Drawing.Color.White;
            this.groupBox_StartSide.Location = new System.Drawing.Point(20, 93);
            this.groupBox_StartSide.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_StartSide.Name = "groupBox_StartSide";
            this.groupBox_StartSide.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_StartSide.Size = new System.Drawing.Size(294, 161);
            this.groupBox_StartSide.TabIndex = 16;
            this.groupBox_StartSide.TabStop = false;
            this.groupBox_StartSide.Text = "START SIDE";
            // 
            // radioButton_MixSides
            // 
            this.radioButton_MixSides.AutoSize = true;
            this.radioButton_MixSides.Location = new System.Drawing.Point(165, 67);
            this.radioButton_MixSides.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_MixSides.Name = "radioButton_MixSides";
            this.radioButton_MixSides.Size = new System.Drawing.Size(105, 21);
            this.radioButton_MixSides.TabIndex = 19;
            this.radioButton_MixSides.TabStop = true;
            this.radioButton_MixSides.Text = "MIX SIDES";
            this.radioButton_MixSides.UseVisualStyleBackColor = true;
            // 
            // radioButton_RightSide
            // 
            this.radioButton_RightSide.AutoSize = true;
            this.radioButton_RightSide.Location = new System.Drawing.Point(26, 93);
            this.radioButton_RightSide.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_RightSide.Name = "radioButton_RightSide";
            this.radioButton_RightSide.Size = new System.Drawing.Size(117, 21);
            this.radioButton_RightSide.TabIndex = 18;
            this.radioButton_RightSide.TabStop = true;
            this.radioButton_RightSide.Text = "RIGHT SIDE";
            this.radioButton_RightSide.UseVisualStyleBackColor = true;
            // 
            // radioButton_LeftSide
            // 
            this.radioButton_LeftSide.AutoSize = true;
            this.radioButton_LeftSide.Checked = true;
            this.radioButton_LeftSide.Location = new System.Drawing.Point(26, 42);
            this.radioButton_LeftSide.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_LeftSide.Name = "radioButton_LeftSide";
            this.radioButton_LeftSide.Size = new System.Drawing.Size(107, 21);
            this.radioButton_LeftSide.TabIndex = 17;
            this.radioButton_LeftSide.TabStop = true;
            this.radioButton_LeftSide.Text = "LEFT SIDE";
            this.radioButton_LeftSide.UseVisualStyleBackColor = true;
            // 
            // groupBox_Percent
            // 
            this.groupBox_Percent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Percent.Controls.Add(this.label_RightPercent);
            this.groupBox_Percent.Controls.Add(this.trackBar_Percent);
            this.groupBox_Percent.Controls.Add(this.label_LeftPercent);
            this.groupBox_Percent.Controls.Add(this.labelRightSide);
            this.groupBox_Percent.Controls.Add(this.labelLeftSide);
            this.groupBox_Percent.ForeColor = System.Drawing.Color.White;
            this.groupBox_Percent.Location = new System.Drawing.Point(322, 93);
            this.groupBox_Percent.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_Percent.Name = "groupBox_Percent";
            this.groupBox_Percent.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_Percent.Size = new System.Drawing.Size(360, 161);
            this.groupBox_Percent.TabIndex = 20;
            this.groupBox_Percent.TabStop = false;
            this.groupBox_Percent.Text = "BEGIN WITH";
            // 
            // label_RightPercent
            // 
            this.label_RightPercent.AutoSize = true;
            this.label_RightPercent.Location = new System.Drawing.Point(287, 81);
            this.label_RightPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_RightPercent.Name = "label_RightPercent";
            this.label_RightPercent.Size = new System.Drawing.Size(39, 17);
            this.label_RightPercent.TabIndex = 16;
            this.label_RightPercent.Text = "50%";
            // 
            // trackBar_Percent
            // 
            this.trackBar_Percent.BackColor = System.Drawing.Color.DarkGray;
            this.trackBar_Percent.Location = new System.Drawing.Point(102, 52);
            this.trackBar_Percent.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar_Percent.Name = "trackBar_Percent";
            this.trackBar_Percent.Size = new System.Drawing.Size(146, 56);
            this.trackBar_Percent.TabIndex = 21;
            this.trackBar_Percent.Value = 5;
            // 
            // label_LeftPercent
            // 
            this.label_LeftPercent.AutoSize = true;
            this.label_LeftPercent.Location = new System.Drawing.Point(33, 81);
            this.label_LeftPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_LeftPercent.Name = "label_LeftPercent";
            this.label_LeftPercent.Size = new System.Drawing.Size(39, 17);
            this.label_LeftPercent.TabIndex = 8;
            this.label_LeftPercent.Text = "50%";
            // 
            // labelRightSide
            // 
            this.labelRightSide.AutoSize = true;
            this.labelRightSide.Location = new System.Drawing.Point(256, 56);
            this.labelRightSide.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRightSide.Name = "labelRightSide";
            this.labelRightSide.Size = new System.Drawing.Size(96, 17);
            this.labelRightSide.TabIndex = 7;
            this.labelRightSide.Text = "RIGHT SIDE";
            // 
            // labelLeftSide
            // 
            this.labelLeftSide.AutoSize = true;
            this.labelLeftSide.Location = new System.Drawing.Point(8, 54);
            this.labelLeftSide.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLeftSide.Name = "labelLeftSide";
            this.labelLeftSide.Size = new System.Drawing.Size(86, 17);
            this.labelLeftSide.TabIndex = 6;
            this.labelLeftSide.Text = "LEFT SIDE";
            // 
            // checkBox_LearnQACards
            // 
            this.checkBox_LearnQACards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_LearnQACards.AutoSize = true;
            this.checkBox_LearnQACards.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_LearnQACards.Checked = true;
            this.checkBox_LearnQACards.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_LearnQACards.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_LearnQACards.ForeColor = System.Drawing.Color.White;
            this.checkBox_LearnQACards.Location = new System.Drawing.Point(82, 501);
            this.checkBox_LearnQACards.Name = "checkBox_LearnQACards";
            this.checkBox_LearnQACards.Size = new System.Drawing.Size(307, 21);
            this.checkBox_LearnQACards.TabIndex = 11;
            this.checkBox_LearnQACards.Text = "LEARN CARDS \"QUESTION-ANSWER\"";
            this.checkBox_LearnQACards.UseVisualStyleBackColor = false;
            // 
            // checkBox_LearnInformationCards
            // 
            this.checkBox_LearnInformationCards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_LearnInformationCards.AutoSize = true;
            this.checkBox_LearnInformationCards.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_LearnInformationCards.Checked = true;
            this.checkBox_LearnInformationCards.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_LearnInformationCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_LearnInformationCards.ForeColor = System.Drawing.Color.White;
            this.checkBox_LearnInformationCards.Location = new System.Drawing.Point(82, 459);
            this.checkBox_LearnInformationCards.Name = "checkBox_LearnInformationCards";
            this.checkBox_LearnInformationCards.Size = new System.Drawing.Size(250, 21);
            this.checkBox_LearnInformationCards.TabIndex = 10;
            this.checkBox_LearnInformationCards.Text = "SHOW INFORMATION CARDS ";
            this.checkBox_LearnInformationCards.UseVisualStyleBackColor = false;
            // 
            // checkBox_LearnBothSides
            // 
            this.checkBox_LearnBothSides.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_LearnBothSides.AutoSize = true;
            this.checkBox_LearnBothSides.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_LearnBothSides.Checked = true;
            this.checkBox_LearnBothSides.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_LearnBothSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_LearnBothSides.ForeColor = System.Drawing.Color.White;
            this.checkBox_LearnBothSides.Location = new System.Drawing.Point(82, 543);
            this.checkBox_LearnBothSides.Name = "checkBox_LearnBothSides";
            this.checkBox_LearnBothSides.Size = new System.Drawing.Size(283, 21);
            this.checkBox_LearnBothSides.TabIndex = 12;
            this.checkBox_LearnBothSides.Text = "LEARN CARDS \"ASK BOTH SIDES\"";
            this.checkBox_LearnBothSides.UseVisualStyleBackColor = false;
            // 
            // btnLearnCards
            // 
            this.btnLearnCards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLearnCards.BackColor = System.Drawing.Color.Transparent;
            this.btnLearnCards.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLearnCards.FlatAppearance.BorderSize = 0;
            this.btnLearnCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLearnCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLearnCards.ForeColor = System.Drawing.Color.White;
            this.btnLearnCards.Location = new System.Drawing.Point(15, 67);
            this.btnLearnCards.Name = "btnLearnCards";
            this.btnLearnCards.Size = new System.Drawing.Size(160, 40);
            this.btnLearnCards.TabIndex = 4;
            this.btnLearnCards.Text = "LEARN";
            this.btnLearnCards.UseVisualStyleBackColor = false;
            // 
            // checkBox_TypeAnswers
            // 
            this.checkBox_TypeAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_TypeAnswers.AutoSize = true;
            this.checkBox_TypeAnswers.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_TypeAnswers.Checked = true;
            this.checkBox_TypeAnswers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_TypeAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_TypeAnswers.ForeColor = System.Drawing.Color.White;
            this.checkBox_TypeAnswers.Location = new System.Drawing.Point(82, 607);
            this.checkBox_TypeAnswers.Name = "checkBox_TypeAnswers";
            this.checkBox_TypeAnswers.Size = new System.Drawing.Size(151, 21);
            this.checkBox_TypeAnswers.TabIndex = 13;
            this.checkBox_TypeAnswers.Text = "TYPE ANSWERS";
            this.checkBox_TypeAnswers.UseVisualStyleBackColor = false;
            // 
            // label_Loading
            // 
            this.label_Loading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Loading.AutoSize = true;
            this.label_Loading.BackColor = System.Drawing.Color.Transparent;
            this.label_Loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Loading.Location = new System.Drawing.Point(217, 193);
            this.label_Loading.Name = "label_Loading";
            this.label_Loading.Size = new System.Drawing.Size(92, 17);
            this.label_Loading.TabIndex = 51;
            this.label_Loading.Text = "LOADING...";
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.btnAddChosenDeck);
            this.panelMenu.Controls.Add(this.btnAddDecks);
            this.panelMenu.Controls.Add(this.btnOpen);
            this.panelMenu.Controls.Add(this.btnDelete);
            this.panelMenu.Location = new System.Drawing.Point(12, 144);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(166, 242);
            this.panelMenu.TabIndex = 5;
            // 
            // btnAddChosenDeck
            // 
            this.btnAddChosenDeck.FlatAppearance.BorderSize = 0;
            this.btnAddChosenDeck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddChosenDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddChosenDeck.ForeColor = System.Drawing.Color.White;
            this.btnAddChosenDeck.Location = new System.Drawing.Point(3, 49);
            this.btnAddChosenDeck.Name = "btnAddChosenDeck";
            this.btnAddChosenDeck.Size = new System.Drawing.Size(160, 62);
            this.btnAddChosenDeck.TabIndex = 7;
            this.btnAddChosenDeck.Text = "ADD CHOSEN DECKS";
            this.btnAddChosenDeck.UseVisualStyleBackColor = true;
            // 
            // btnAddDecks
            // 
            this.btnAddDecks.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDecks.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddDecks.FlatAppearance.BorderSize = 0;
            this.btnAddDecks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDecks.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddDecks.ForeColor = System.Drawing.Color.White;
            this.btnAddDecks.Location = new System.Drawing.Point(3, 3);
            this.btnAddDecks.Name = "btnAddDecks";
            this.btnAddDecks.Size = new System.Drawing.Size(160, 40);
            this.btnAddDecks.TabIndex = 6;
            this.btnAddDecks.Text = "ADD DECKS";
            this.btnAddDecks.UseVisualStyleBackColor = false;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnOpen.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(3, 117);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(160, 40);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(3, 163);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 40);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_ChosenDeckStartPoint
            // 
            this.dateTimePicker_ChosenDeckStartPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_ChosenDeckStartPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_ChosenDeckStartPoint.Location = new System.Drawing.Point(943, 85);
            this.dateTimePicker_ChosenDeckStartPoint.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_ChosenDeckStartPoint.Name = "dateTimePicker_ChosenDeckStartPoint";
            this.dateTimePicker_ChosenDeckStartPoint.Size = new System.Drawing.Size(228, 26);
            this.dateTimePicker_ChosenDeckStartPoint.TabIndex = 2;
            // 
            // labelStartingPoint_RepeatingDecks
            // 
            this.labelStartingPoint_RepeatingDecks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStartingPoint_RepeatingDecks.AutoSize = true;
            this.labelStartingPoint_RepeatingDecks.BackColor = System.Drawing.Color.Transparent;
            this.labelStartingPoint_RepeatingDecks.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStartingPoint_RepeatingDecks.ForeColor = System.Drawing.Color.White;
            this.labelStartingPoint_RepeatingDecks.Location = new System.Drawing.Point(916, 61);
            this.labelStartingPoint_RepeatingDecks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartingPoint_RepeatingDecks.Name = "labelStartingPoint_RepeatingDecks";
            this.labelStartingPoint_RepeatingDecks.Size = new System.Drawing.Size(273, 17);
            this.labelStartingPoint_RepeatingDecks.TabIndex = 50;
            this.labelStartingPoint_RepeatingDecks.Text = "START POINT FOR CHOSEN DECKS";
            // 
            // Form_SettingsToLearn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1347, 721);
            this.Controls.Add(this.label_Loading);
            this.Controls.Add(this.checkBox_TypeAnswers);
            this.Controls.Add(this.btnLearnCards);
            this.Controls.Add(this.groupBox_AskBothSides);
            this.Controls.Add(this.checkBox_LearnQACards);
            this.Controls.Add(this.checkBox_LearnInformationCards);
            this.Controls.Add(this.btnAddDecksAuto);
            this.Controls.Add(this.checkBox_LearnBothSides);
            this.Controls.Add(this.btnAddChosenDecksAuto);
            this.Controls.Add(this.labelStartingPoint_RepeatingDecks);
            this.Controls.Add(this.dateTimePicker_ChosenDeckStartPoint);
            this.Controls.Add(this.labelStartingPoint_Decks);
            this.Controls.Add(this.dateTimePicker_DeckStartPoint);
            this.Controls.Add(this.dataGridView_Decks);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form_SettingsToLearn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LEARCA. Learn. Settings";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Decks)).EndInit();
            this.groupBox_AskBothSides.ResumeLayout(false);
            this.groupBox_AskBothSides.PerformLayout();
            this.groupBox_StartSide.ResumeLayout(false);
            this.groupBox_StartSide.PerformLayout();
            this.groupBox_Percent.ResumeLayout(false);
            this.groupBox_Percent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Percent)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddDecks;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddDecksAuto;
        protected internal System.Windows.Forms.DataGridView dataGridView_Decks;
        private System.Windows.Forms.Label labelStartingPoint_Decks;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DeckStartPoint;
        private System.Windows.Forms.Button btnAddChosenDecksAuto;
        private System.Windows.Forms.RadioButton radioButton_MixSides;
        private System.Windows.Forms.RadioButton radioButton_RightSide;
        private System.Windows.Forms.RadioButton radioButton_LeftSide;
        private System.Windows.Forms.Label label_RightPercent;
        private System.Windows.Forms.TrackBar trackBar_Percent;
        private System.Windows.Forms.Label label_LeftPercent;
        private System.Windows.Forms.Label labelRightSide;
        private System.Windows.Forms.Label labelLeftSide;
        private System.Windows.Forms.CheckBox checkBox_LearnQACards;
        private System.Windows.Forms.CheckBox checkBox_LearnInformationCards;
        private System.Windows.Forms.CheckBox checkBox_LearnBothSides;
        private System.Windows.Forms.Button btnAddChosenDeck;
        private System.Windows.Forms.Button btnLearnCards;
        private System.Windows.Forms.CheckBox checkBox_LearnOnlyOneSide;
        private System.Windows.Forms.CheckBox checkBox_TypeAnswers;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.GroupBox groupBox_AskBothSides;
        private System.Windows.Forms.GroupBox groupBox_StartSide;
        private System.Windows.Forms.GroupBox groupBox_Percent;
        private System.Windows.Forms.Label label_Loading;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ChosenDeckStartPoint;
        private System.Windows.Forms.Label labelStartingPoint_RepeatingDecks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeckName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCards;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStartingPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeckType;
    }
}