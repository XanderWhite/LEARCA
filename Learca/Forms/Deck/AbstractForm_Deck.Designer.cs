namespace Learca
{
    partial class AbstractForm_Deck
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelStartingPoint = new System.Windows.Forms.Label();
            this.labelDeckName = new System.Windows.Forms.Label();
            this.tBDescription = new System.Windows.Forms.TextBox();
            this.tBDeckName = new System.Windows.Forms.TextBox();
            this.dateTimePicker_StartPoint = new System.Windows.Forms.DateTimePicker();
            this.labelDescription = new System.Windows.Forms.Label();
            this.dataGridView_Cards = new System.Windows.Forms.DataGridView();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLeftSideValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_LeftSideImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnRighSideValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_RightSideImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel_Home = new Learca.DoubleBufferedPanel();
            this.btnMoveInside = new System.Windows.Forms.Button();
            this.btnMoveOut = new System.Windows.Forms.Button();
            this.btnDeleteCard = new System.Windows.Forms.Button();
            this.btnDeleteDeck = new System.Windows.Forms.Button();
            this.btnCreateCard = new System.Windows.Forms.Button();
            this.btnEditCard = new System.Windows.Forms.Button();
            this.label_Loading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cards)).BeginInit();
            this.panel_Home.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStartingPoint
            // 
            this.labelStartingPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStartingPoint.AutoSize = true;
            this.labelStartingPoint.BackColor = System.Drawing.Color.Transparent;
            this.labelStartingPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStartingPoint.ForeColor = System.Drawing.Color.White;
            this.labelStartingPoint.Location = new System.Drawing.Point(1223, 46);
            this.labelStartingPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartingPoint.Name = "labelStartingPoint";
            this.labelStartingPoint.Size = new System.Drawing.Size(111, 17);
            this.labelStartingPoint.TabIndex = 29;
            this.labelStartingPoint.Text = "START POINT";
            // 
            // labelDeckName
            // 
            this.labelDeckName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDeckName.AutoSize = true;
            this.labelDeckName.BackColor = System.Drawing.Color.Transparent;
            this.labelDeckName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeckName.ForeColor = System.Drawing.Color.White;
            this.labelDeckName.Location = new System.Drawing.Point(1044, 46);
            this.labelDeckName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeckName.Name = "labelDeckName";
            this.labelDeckName.Size = new System.Drawing.Size(97, 17);
            this.labelDeckName.TabIndex = 28;
            this.labelDeckName.Text = "DECK NAME";
            // 
            // tBDescription
            // 
            this.tBDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tBDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBDescription.Location = new System.Drawing.Point(185, 118);
            this.tBDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tBDescription.Multiline = true;
            this.tBDescription.Name = "tBDescription";
            this.tBDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBDescription.Size = new System.Drawing.Size(1149, 54);
            this.tBDescription.TabIndex = 8;
            // 
            // tBDeckName
            // 
            this.tBDeckName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tBDeckName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBDeckName.Location = new System.Drawing.Point(185, 67);
            this.tBDeckName.Margin = new System.Windows.Forms.Padding(4);
            this.tBDeckName.Name = "tBDeckName";
            this.tBDeckName.Size = new System.Drawing.Size(956, 26);
            this.tBDeckName.TabIndex = 6;
            this.tBDeckName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePicker_StartPoint
            // 
            this.dateTimePicker_StartPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_StartPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_StartPoint.Location = new System.Drawing.Point(1149, 67);
            this.dateTimePicker_StartPoint.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_StartPoint.Name = "dateTimePicker_StartPoint";
            this.dateTimePicker_StartPoint.Size = new System.Drawing.Size(185, 26);
            this.dateTimePicker_StartPoint.TabIndex = 7;
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.ForeColor = System.Drawing.Color.White;
            this.labelDescription.Location = new System.Drawing.Point(1223, 97);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(111, 17);
            this.labelDescription.TabIndex = 34;
            this.labelDescription.Text = "DESCRIPTION";
            // 
            // dataGridView_Cards
            // 
            this.dataGridView_Cards.AllowUserToAddRows = false;
            this.dataGridView_Cards.AllowUserToDeleteRows = false;
            this.dataGridView_Cards.AllowUserToResizeColumns = false;
            this.dataGridView_Cards.AllowUserToResizeRows = false;
            this.dataGridView_Cards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Cards.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Cards.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Cards.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Cards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnLeftSideValues,
            this.Column_LeftSideImage,
            this.ColumnRighSideValues,
            this.Column_RightSideImage});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Cards.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Cards.Location = new System.Drawing.Point(185, 179);
            this.dataGridView_Cards.Name = "dataGridView_Cards";
            this.dataGridView_Cards.ReadOnly = true;
            this.dataGridView_Cards.RowHeadersVisible = false;
            this.dataGridView_Cards.RowHeadersWidth = 51;
            this.dataGridView_Cards.RowTemplate.Height = 50;
            this.dataGridView_Cards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Cards.Size = new System.Drawing.Size(1149, 530);
            this.dataGridView_Cards.TabIndex = 9;
            this.dataGridView_Cards.SelectionChanged += new System.EventHandler(this.DataGridView_Cards_SelectionChanged);
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
            // ColumnLeftSideValues
            // 
            this.ColumnLeftSideValues.Frozen = true;
            this.ColumnLeftSideValues.HeaderText = "Left Side Values";
            this.ColumnLeftSideValues.MinimumWidth = 6;
            this.ColumnLeftSideValues.Name = "ColumnLeftSideValues";
            this.ColumnLeftSideValues.ReadOnly = true;
            this.ColumnLeftSideValues.Width = 400;
            // 
            // Column_LeftSideImage
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "System.Drawing.Bitmap";
            this.Column_LeftSideImage.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column_LeftSideImage.Frozen = true;
            this.Column_LeftSideImage.HeaderText = "Left Side Image";
            this.Column_LeftSideImage.MinimumWidth = 6;
            this.Column_LeftSideImage.Name = "Column_LeftSideImage";
            this.Column_LeftSideImage.ReadOnly = true;
            this.Column_LeftSideImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_LeftSideImage.Width = 150;
            // 
            // ColumnRighSideValues
            // 
            this.ColumnRighSideValues.Frozen = true;
            this.ColumnRighSideValues.HeaderText = "Right Side Values";
            this.ColumnRighSideValues.MinimumWidth = 6;
            this.ColumnRighSideValues.Name = "ColumnRighSideValues";
            this.ColumnRighSideValues.ReadOnly = true;
            this.ColumnRighSideValues.Width = 400;
            // 
            // Column_RightSideImage
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "System.Drawing.Bitmap";
            this.Column_RightSideImage.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column_RightSideImage.Frozen = true;
            this.Column_RightSideImage.HeaderText = "Right Side Image";
            this.Column_RightSideImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column_RightSideImage.MinimumWidth = 6;
            this.Column_RightSideImage.Name = "Column_RightSideImage";
            this.Column_RightSideImage.ReadOnly = true;
            this.Column_RightSideImage.Width = 150;
            // 
            // panel_Home
            // 
            this.panel_Home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Home.BackColor = System.Drawing.Color.Transparent;
            this.panel_Home.Controls.Add(this.btnMoveInside);
            this.panel_Home.Controls.Add(this.btnMoveOut);
            this.panel_Home.Controls.Add(this.btnDeleteCard);
            this.panel_Home.Controls.Add(this.btnDeleteDeck);
            this.panel_Home.Controls.Add(this.btnCreateCard);
            this.panel_Home.Controls.Add(this.btnEditCard);
            this.panel_Home.Location = new System.Drawing.Point(12, 64);
            this.panel_Home.Name = "panel_Home";
            this.panel_Home.Size = new System.Drawing.Size(166, 339);
            this.panel_Home.TabIndex = 1;
            // 
            // btnMoveInside
            // 
            this.btnMoveInside.FlatAppearance.BorderSize = 0;
            this.btnMoveInside.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveInside.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMoveInside.ForeColor = System.Drawing.Color.White;
            this.btnMoveInside.Location = new System.Drawing.Point(3, 141);
            this.btnMoveInside.Name = "btnMoveInside";
            this.btnMoveInside.Size = new System.Drawing.Size(160, 40);
            this.btnMoveInside.TabIndex = 4;
            this.btnMoveInside.Text = "MOVE INSIDE";
            this.btnMoveInside.UseVisualStyleBackColor = true;
            // 
            // btnMoveOut
            // 
            this.btnMoveOut.BackColor = System.Drawing.Color.Transparent;
            this.btnMoveOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMoveOut.FlatAppearance.BorderSize = 0;
            this.btnMoveOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMoveOut.ForeColor = System.Drawing.Color.White;
            this.btnMoveOut.Location = new System.Drawing.Point(3, 187);
            this.btnMoveOut.Name = "btnMoveOut";
            this.btnMoveOut.Size = new System.Drawing.Size(160, 40);
            this.btnMoveOut.TabIndex = 2;
            this.btnMoveOut.Text = "MOVE OUT";
            this.btnMoveOut.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCard
            // 
            this.btnDeleteCard.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteCard.FlatAppearance.BorderSize = 0;
            this.btnDeleteCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteCard.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCard.Location = new System.Drawing.Point(3, 95);
            this.btnDeleteCard.Name = "btnDeleteCard";
            this.btnDeleteCard.Size = new System.Drawing.Size(160, 40);
            this.btnDeleteCard.TabIndex = 3;
            this.btnDeleteCard.Text = "DELETE CARD";
            this.btnDeleteCard.UseVisualStyleBackColor = false;
            // 
            // btnDeleteDeck
            // 
            this.btnDeleteDeck.FlatAppearance.BorderSize = 0;
            this.btnDeleteDeck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteDeck.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDeck.Location = new System.Drawing.Point(3, 233);
            this.btnDeleteDeck.Name = "btnDeleteDeck";
            this.btnDeleteDeck.Size = new System.Drawing.Size(160, 40);
            this.btnDeleteDeck.TabIndex = 5;
            this.btnDeleteDeck.Text = "DELETE DECK";
            this.btnDeleteDeck.UseVisualStyleBackColor = true;
            this.btnDeleteDeck.Click += new System.EventHandler(this.BtnDeleteDeck_Click);
            // 
            // btnCreateCard
            // 
            this.btnCreateCard.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateCard.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCreateCard.FlatAppearance.BorderSize = 0;
            this.btnCreateCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateCard.ForeColor = System.Drawing.Color.White;
            this.btnCreateCard.Location = new System.Drawing.Point(3, 3);
            this.btnCreateCard.Name = "btnCreateCard";
            this.btnCreateCard.Size = new System.Drawing.Size(160, 40);
            this.btnCreateCard.TabIndex = 0;
            this.btnCreateCard.Text = "CREATE CARD";
            this.btnCreateCard.UseVisualStyleBackColor = false;
            // 
            // btnEditCard
            // 
            this.btnEditCard.FlatAppearance.BorderSize = 0;
            this.btnEditCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditCard.ForeColor = System.Drawing.Color.White;
            this.btnEditCard.Location = new System.Drawing.Point(3, 49);
            this.btnEditCard.Name = "btnEditCard";
            this.btnEditCard.Size = new System.Drawing.Size(160, 40);
            this.btnEditCard.TabIndex = 1;
            this.btnEditCard.Text = "EDIT";
            this.btnEditCard.UseVisualStyleBackColor = true;
            this.btnEditCard.Click += new System.EventHandler(this.BtnEditCard_Click);
            // 
            // label_Loading
            // 
            this.label_Loading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Loading.AutoSize = true;
            this.label_Loading.BackColor = System.Drawing.Color.Transparent;
            this.label_Loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Loading.Location = new System.Drawing.Point(207, 217);
            this.label_Loading.Name = "label_Loading";
            this.label_Loading.Size = new System.Drawing.Size(92, 17);
            this.label_Loading.TabIndex = 35;
            this.label_Loading.Text = "LOADING...";
            // 
            // AbstractForm_Deck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1347, 721);
            this.Controls.Add(this.label_Loading);
            this.Controls.Add(this.dataGridView_Cards);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.panel_Home);
            this.Controls.Add(this.labelStartingPoint);
            this.Controls.Add(this.labelDeckName);
            this.Controls.Add(this.tBDescription);
            this.Controls.Add(this.tBDeckName);
            this.Controls.Add(this.dateTimePicker_StartPoint);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AbstractForm_Deck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LEARCA. Deck";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cards)).EndInit();
            this.panel_Home.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelStartingPoint;
        private System.Windows.Forms.Label labelDeckName;
        private System.Windows.Forms.TextBox tBDescription;
        private System.Windows.Forms.TextBox tBDeckName;
        private System.Windows.Forms.DateTimePicker dateTimePicker_StartPoint;
        private System.Windows.Forms.Label labelDescription;
        protected internal System.Windows.Forms.Button btnDeleteCard;
        protected internal System.Windows.Forms.Button btnDeleteDeck;
        protected internal System.Windows.Forms.Button btnCreateCard;
        protected internal System.Windows.Forms.Button btnEditCard;
        protected internal System.Windows.Forms.Button btnMoveOut;
        protected internal System.Windows.Forms.DataGridView dataGridView_Cards;
        protected internal System.Windows.Forms.Button btnMoveInside;
        internal DoubleBufferedPanel panel_Home;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLeftSideValues;
        private System.Windows.Forms.DataGridViewImageColumn Column_LeftSideImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRighSideValues;
        private System.Windows.Forms.DataGridViewImageColumn Column_RightSideImage;
        private System.Windows.Forms.Label label_Loading;
    }
}