namespace Learca
{
    partial class AbstractForm_DeckSet
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
            this.tBFilter = new System.Windows.Forms.TextBox();
            this.dataGridView_Decks = new System.Windows.Forms.DataGridView();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeckName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCards = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStartingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMenu = new Learca.DoubleBufferedPanel();
            this.btnToCards = new System.Windows.Forms.Button();
            this.btnDeleteEmptyDecks = new System.Windows.Forms.Button();
            this.btnDeleteDeck = new System.Windows.Forms.Button();
            this.btnCreateDeck = new System.Windows.Forms.Button();
            this.btnOpenDeck = new System.Windows.Forms.Button();
            this.label_Loading = new System.Windows.Forms.Label();
            this.btnMoveInside = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Decks)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBFilter
            // 
            this.tBFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tBFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBFilter.Location = new System.Drawing.Point(185, 40);
            this.tBFilter.Margin = new System.Windows.Forms.Padding(4);
            this.tBFilter.Name = "tBFilter";
            this.tBFilter.Size = new System.Drawing.Size(1149, 26);
            this.tBFilter.TabIndex = 5;
            this.tBFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.ColumnStartingDate,
            this.ColumnDescription});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Decks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Decks.Location = new System.Drawing.Point(185, 73);
            this.dataGridView_Decks.Name = "dataGridView_Decks";
            this.dataGridView_Decks.ReadOnly = true;
            this.dataGridView_Decks.RowHeadersVisible = false;
            this.dataGridView_Decks.RowTemplate.Height = 50;
            this.dataGridView_Decks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Decks.Size = new System.Drawing.Size(1150, 636);
            this.dataGridView_Decks.TabIndex = 6;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.Frozen = true;
            this.ColumnNumber.HeaderText = "№";
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            this.ColumnNumber.Width = 49;
            // 
            // ColumnDeckName
            // 
            this.ColumnDeckName.Frozen = true;
            this.ColumnDeckName.HeaderText = "DECK NAME";
            this.ColumnDeckName.Name = "ColumnDeckName";
            this.ColumnDeckName.ReadOnly = true;
            this.ColumnDeckName.Width = 350;
            // 
            // ColumnCards
            // 
            this.ColumnCards.Frozen = true;
            this.ColumnCards.HeaderText = "CARDS";
            this.ColumnCards.Name = "ColumnCards";
            this.ColumnCards.ReadOnly = true;
            // 
            // ColumnStartingDate
            // 
            dataGridViewCellStyle2.NullValue = "System.Drawing.Bitmap";
            this.ColumnStartingDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnStartingDate.Frozen = true;
            this.ColumnStartingDate.HeaderText = "STARTING DATE";
            this.ColumnStartingDate.Name = "ColumnStartingDate";
            this.ColumnStartingDate.ReadOnly = true;
            this.ColumnStartingDate.Width = 200;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.Frozen = true;
            this.ColumnDescription.HeaderText = "DESCRIPTION";
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.ReadOnly = true;
            this.ColumnDescription.Width = 450;
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.btnMoveInside);
            this.panelMenu.Controls.Add(this.btnToCards);
            this.panelMenu.Controls.Add(this.btnDeleteEmptyDecks);
            this.panelMenu.Controls.Add(this.btnDeleteDeck);
            this.panelMenu.Controls.Add(this.btnCreateDeck);
            this.panelMenu.Controls.Add(this.btnOpenDeck);
            this.panelMenu.Location = new System.Drawing.Point(12, 64);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(166, 298);
            this.panelMenu.TabIndex = 1;
            // 
            // btnToCards
            // 
            this.btnToCards.BackColor = System.Drawing.Color.Transparent;
            this.btnToCards.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnToCards.FlatAppearance.BorderSize = 0;
            this.btnToCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToCards.ForeColor = System.Drawing.Color.White;
            this.btnToCards.Location = new System.Drawing.Point(3, 187);
            this.btnToCards.Name = "btnToCards";
            this.btnToCards.Size = new System.Drawing.Size(160, 40);
            this.btnToCards.TabIndex = 4;
            this.btnToCards.Text = "CARDS";
            this.btnToCards.UseVisualStyleBackColor = false;
            // 
            // btnDeleteEmptyDecks
            // 
            this.btnDeleteEmptyDecks.FlatAppearance.BorderSize = 0;
            this.btnDeleteEmptyDecks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEmptyDecks.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteEmptyDecks.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEmptyDecks.Location = new System.Drawing.Point(3, 141);
            this.btnDeleteEmptyDecks.Name = "btnDeleteEmptyDecks";
            this.btnDeleteEmptyDecks.Size = new System.Drawing.Size(160, 40);
            this.btnDeleteEmptyDecks.TabIndex = 3;
            this.btnDeleteEmptyDecks.Text = "DELETE EMPTY";
            this.btnDeleteEmptyDecks.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDeck
            // 
            this.btnDeleteDeck.FlatAppearance.BorderSize = 0;
            this.btnDeleteDeck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteDeck.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDeck.Location = new System.Drawing.Point(3, 95);
            this.btnDeleteDeck.Name = "btnDeleteDeck";
            this.btnDeleteDeck.Size = new System.Drawing.Size(160, 40);
            this.btnDeleteDeck.TabIndex = 2;
            this.btnDeleteDeck.Text = "DELETE";
            this.btnDeleteDeck.UseVisualStyleBackColor = true;
            // 
            // buttonCreateDeck
            // 
            this.btnCreateDeck.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateDeck.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCreateDeck.FlatAppearance.BorderSize = 0;
            this.btnCreateDeck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateDeck.ForeColor = System.Drawing.Color.White;
            this.btnCreateDeck.Location = new System.Drawing.Point(3, 3);
            this.btnCreateDeck.Name = "buttonCreateDeck";
            this.btnCreateDeck.Size = new System.Drawing.Size(160, 40);
            this.btnCreateDeck.TabIndex = 0;
            this.btnCreateDeck.Text = "CREATE";
            this.btnCreateDeck.UseVisualStyleBackColor = false;
            this.btnCreateDeck.Click += new System.EventHandler(this.BtnCreateDeck_Click);
            // 
            // btnOpenDeck
            // 
            this.btnOpenDeck.FlatAppearance.BorderSize = 0;
            this.btnOpenDeck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenDeck.ForeColor = System.Drawing.Color.White;
            this.btnOpenDeck.Location = new System.Drawing.Point(3, 49);
            this.btnOpenDeck.Name = "btnOpenDeck";
            this.btnOpenDeck.Size = new System.Drawing.Size(160, 40);
            this.btnOpenDeck.TabIndex = 1;
            this.btnOpenDeck.Text = "OPEN";
            this.btnOpenDeck.UseVisualStyleBackColor = true;
            this.btnOpenDeck.Click += new System.EventHandler(this.BtnOpenDeck_Click);
            // 
            // label_Loading
            // 
            this.label_Loading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Loading.AutoSize = true;
            this.label_Loading.BackColor = System.Drawing.Color.Transparent;
            this.label_Loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Loading.Location = new System.Drawing.Point(220, 125);
            this.label_Loading.Name = "label_Loading";
            this.label_Loading.Size = new System.Drawing.Size(92, 17);
            this.label_Loading.TabIndex = 10;
            this.label_Loading.Text = "LOADING...";
            // 
            // btnMoveInside
            // 
            this.btnMoveInside.FlatAppearance.BorderSize = 0;
            this.btnMoveInside.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveInside.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMoveInside.ForeColor = System.Drawing.Color.White;
            this.btnMoveInside.Location = new System.Drawing.Point(3, 233);
            this.btnMoveInside.Name = "btnMoveInside";
            this.btnMoveInside.Size = new System.Drawing.Size(160, 40);
            this.btnMoveInside.TabIndex = 5;
            this.btnMoveInside.Text = "MOVE INSIDE";
            this.btnMoveInside.UseVisualStyleBackColor = true;
            // 
            // Form_AbstractDeckSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1347, 721);
            this.Controls.Add(this.label_Loading);
            this.Controls.Add(this.dataGridView_Decks);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.tBFilter);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form_AbstractDeckSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LEARCA. Decks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Decks)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tBFilter;
        protected internal System.Windows.Forms.Button btnToCards;
        protected internal System.Windows.Forms.Button btnDeleteDeck;
        protected internal System.Windows.Forms.Button btnCreateDeck;
        protected internal System.Windows.Forms.Button btnOpenDeck;
        protected internal System.Windows.Forms.DataGridView dataGridView_Decks;
        protected internal System.Windows.Forms.Button btnDeleteEmptyDecks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeckName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCards;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStartingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private DoubleBufferedPanel panelMenu;
        private System.Windows.Forms.Label label_Loading;
        protected internal System.Windows.Forms.Button btnMoveInside;
    }
}