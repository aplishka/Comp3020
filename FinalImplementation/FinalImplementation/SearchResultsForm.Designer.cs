namespace FinalImplementation
{
    partial class SearchResultsForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchResultList = new System.Windows.Forms.ListBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.genreSelector = new System.Windows.Forms.ComboBox();
            this.plotBox = new System.Windows.Forms.RichTextBox();
            this.actor1 = new System.Windows.Forms.TextBox();
            this.actor2 = new System.Windows.Forms.TextBox();
            this.actor3 = new System.Windows.Forms.TextBox();
            this.actor4 = new System.Windows.Forms.TextBox();
            this.advancedSearchButton = new System.Windows.Forms.Button();
            this.plus1 = new System.Windows.Forms.Button();
            this.plus2 = new System.Windows.Forms.Button();
            this.plus3 = new System.Windows.Forms.Button();
            this.minus2 = new System.Windows.Forms.Button();
            this.minus3 = new System.Windows.Forms.Button();
            this.minus4 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.minus1 = new System.Windows.Forms.Button();
            this.starRatingTo = new RatingControls.StarRatingControl();
            this.starRatingFrom = new RatingControls.StarRatingControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(513, 30);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 31);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(495, 22);
            this.searchTextBox.TabIndex = 14;
            this.searchTextBox.Text = "Enter search query...";
            // 
            // searchResultList
            // 
            this.searchResultList.FormattingEnabled = true;
            this.searchResultList.ItemHeight = 16;
            this.searchResultList.Location = new System.Drawing.Point(12, 75);
            this.searchResultList.Name = "searchResultList";
            this.searchResultList.Size = new System.Drawing.Size(623, 436);
            this.searchResultList.TabIndex = 16;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(613, 75);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 436);
            this.vScrollBar1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(740, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Advanced Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(649, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(649, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Rating:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(649, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Genre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(649, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Plot:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(650, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Actors:";
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(708, 75);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(273, 22);
            this.fromDate.TabIndex = 24;
            this.fromDate.Value = new System.DateTime(2014, 11, 29, 17, 31, 14, 0);
            // 
            // toDate
            // 
            this.toDate.Location = new System.Drawing.Point(708, 103);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(273, 22);
            this.toDate.TabIndex = 25;
            this.toDate.Value = new System.DateTime(2014, 11, 29, 17, 31, 14, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(834, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "to";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(688, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "to";
            // 
            // genreSelector
            // 
            this.genreSelector.FormattingEnabled = true;
            this.genreSelector.Location = new System.Drawing.Point(708, 185);
            this.genreSelector.Name = "genreSelector";
            this.genreSelector.Size = new System.Drawing.Size(273, 24);
            this.genreSelector.TabIndex = 30;
            // 
            // plotBox
            // 
            this.plotBox.Location = new System.Drawing.Point(708, 241);
            this.plotBox.Name = "plotBox";
            this.plotBox.Size = new System.Drawing.Size(273, 117);
            this.plotBox.TabIndex = 31;
            this.plotBox.Text = "";
            // 
            // actor1
            // 
            this.actor1.Location = new System.Drawing.Point(708, 367);
            this.actor1.Name = "actor1";
            this.actor1.Size = new System.Drawing.Size(183, 22);
            this.actor1.TabIndex = 32;
            // 
            // actor2
            // 
            this.actor2.Location = new System.Drawing.Point(708, 395);
            this.actor2.Name = "actor2";
            this.actor2.Size = new System.Drawing.Size(183, 22);
            this.actor2.TabIndex = 33;
            this.actor2.Visible = false;
            // 
            // actor3
            // 
            this.actor3.Location = new System.Drawing.Point(708, 423);
            this.actor3.Name = "actor3";
            this.actor3.Size = new System.Drawing.Size(183, 22);
            this.actor3.TabIndex = 34;
            this.actor3.Visible = false;
            // 
            // actor4
            // 
            this.actor4.Location = new System.Drawing.Point(708, 451);
            this.actor4.Name = "actor4";
            this.actor4.Size = new System.Drawing.Size(183, 22);
            this.actor4.TabIndex = 35;
            this.actor4.Visible = false;
            // 
            // advancedSearchButton
            // 
            this.advancedSearchButton.Location = new System.Drawing.Point(708, 486);
            this.advancedSearchButton.Name = "advancedSearchButton";
            this.advancedSearchButton.Size = new System.Drawing.Size(273, 23);
            this.advancedSearchButton.TabIndex = 36;
            this.advancedSearchButton.Text = "Search";
            this.advancedSearchButton.UseVisualStyleBackColor = true;
            this.advancedSearchButton.Click += new System.EventHandler(this.advancedSearchButton_Click);
            // 
            // plus1
            // 
            this.plus1.Location = new System.Drawing.Point(897, 366);
            this.plus1.Name = "plus1";
            this.plus1.Size = new System.Drawing.Size(33, 23);
            this.plus1.TabIndex = 37;
            this.plus1.Text = "+";
            this.plus1.UseVisualStyleBackColor = true;
            this.plus1.Click += new System.EventHandler(this.plus1_Click);
            // 
            // plus2
            // 
            this.plus2.Location = new System.Drawing.Point(897, 395);
            this.plus2.Name = "plus2";
            this.plus2.Size = new System.Drawing.Size(33, 23);
            this.plus2.TabIndex = 38;
            this.plus2.Text = "+";
            this.plus2.UseVisualStyleBackColor = true;
            this.plus2.Visible = false;
            this.plus2.Click += new System.EventHandler(this.plus2_Click);
            // 
            // plus3
            // 
            this.plus3.Location = new System.Drawing.Point(897, 423);
            this.plus3.Name = "plus3";
            this.plus3.Size = new System.Drawing.Size(33, 23);
            this.plus3.TabIndex = 39;
            this.plus3.Text = "+";
            this.plus3.UseVisualStyleBackColor = true;
            this.plus3.Visible = false;
            this.plus3.Click += new System.EventHandler(this.plus3_Click);
            // 
            // minus2
            // 
            this.minus2.Location = new System.Drawing.Point(936, 395);
            this.minus2.Name = "minus2";
            this.minus2.Size = new System.Drawing.Size(33, 23);
            this.minus2.TabIndex = 41;
            this.minus2.Text = "-";
            this.minus2.UseVisualStyleBackColor = true;
            this.minus2.Visible = false;
            this.minus2.Click += new System.EventHandler(this.minus2_Click);
            // 
            // minus3
            // 
            this.minus3.Location = new System.Drawing.Point(936, 423);
            this.minus3.Name = "minus3";
            this.minus3.Size = new System.Drawing.Size(33, 23);
            this.minus3.TabIndex = 42;
            this.minus3.Text = "-";
            this.minus3.UseVisualStyleBackColor = true;
            this.minus3.Visible = false;
            this.minus3.Click += new System.EventHandler(this.minus3_Click);
            // 
            // minus4
            // 
            this.minus4.Location = new System.Drawing.Point(936, 450);
            this.minus4.Name = "minus4";
            this.minus4.Size = new System.Drawing.Size(33, 23);
            this.minus4.TabIndex = 43;
            this.minus4.Text = "-";
            this.minus4.UseVisualStyleBackColor = true;
            this.minus4.Visible = false;
            this.minus4.Click += new System.EventHandler(this.minus4_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // minus1
            // 
            this.minus1.Location = new System.Drawing.Point(936, 366);
            this.minus1.Name = "minus1";
            this.minus1.Size = new System.Drawing.Size(33, 23);
            this.minus1.TabIndex = 44;
            this.minus1.Text = "-";
            this.minus1.UseVisualStyleBackColor = true;
            this.minus1.Click += new System.EventHandler(this.minus1_Click);
            // 
            // starRatingTo
            // 
            this.starRatingTo.BottomMargin = 2;
            this.starRatingTo.HoverColor = System.Drawing.Color.Gold;
            this.starRatingTo.LeftMargin = 1;
            this.starRatingTo.Location = new System.Drawing.Point(857, 141);
            this.starRatingTo.Name = "starRatingTo";
            this.starRatingTo.OutlineColor = System.Drawing.Color.DarkGray;
            this.starRatingTo.OutlineThickness = 1;
            this.starRatingTo.RightMargin = 1;
            this.starRatingTo.SelectedColor = System.Drawing.Color.Yellow;
            this.starRatingTo.Size = new System.Drawing.Size(129, 20);
            this.starRatingTo.StarCount = 10;
            this.starRatingTo.StarSpacing = 1;
            this.starRatingTo.TabIndex = 27;
            this.starRatingTo.Text = "starRatingControl2";
            this.starRatingTo.TopMargin = 2;
            // 
            // starRatingFrom
            // 
            this.starRatingFrom.BottomMargin = 2;
            this.starRatingFrom.HoverColor = System.Drawing.Color.Gold;
            this.starRatingFrom.LeftMargin = 1;
            this.starRatingFrom.Location = new System.Drawing.Point(708, 141);
            this.starRatingFrom.Name = "starRatingFrom";
            this.starRatingFrom.OutlineColor = System.Drawing.Color.DarkGray;
            this.starRatingFrom.OutlineThickness = 1;
            this.starRatingFrom.RightMargin = 1;
            this.starRatingFrom.SelectedColor = System.Drawing.Color.Yellow;
            this.starRatingFrom.Size = new System.Drawing.Size(129, 20);
            this.starRatingFrom.StarCount = 10;
            this.starRatingFrom.StarSpacing = 1;
            this.starRatingFrom.TabIndex = 26;
            this.starRatingFrom.Text = "starRatingControl1";
            this.starRatingFrom.TopMargin = 2;
            // 
            // SearchResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 521);
            this.Controls.Add(this.minus1);
            this.Controls.Add(this.minus4);
            this.Controls.Add(this.minus3);
            this.Controls.Add(this.minus2);
            this.Controls.Add(this.plus3);
            this.Controls.Add(this.plus2);
            this.Controls.Add(this.plus1);
            this.Controls.Add(this.advancedSearchButton);
            this.Controls.Add(this.actor4);
            this.Controls.Add(this.actor3);
            this.Controls.Add(this.actor2);
            this.Controls.Add(this.actor1);
            this.Controls.Add(this.plotBox);
            this.Controls.Add(this.genreSelector);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.starRatingTo);
            this.Controls.Add(this.starRatingFrom);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.searchResultList);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label7);
            this.Name = "SearchResultsForm";
            this.Text = "SearchResultsForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ListBox searchResultList;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.DateTimePicker toDate;
        private RatingControls.StarRatingControl starRatingFrom;
        private RatingControls.StarRatingControl starRatingTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox genreSelector;
        private System.Windows.Forms.RichTextBox plotBox;
        private System.Windows.Forms.TextBox actor1;
        private System.Windows.Forms.TextBox actor2;
        private System.Windows.Forms.TextBox actor3;
        private System.Windows.Forms.TextBox actor4;
        private System.Windows.Forms.Button advancedSearchButton;
        private System.Windows.Forms.Button plus1;
        private System.Windows.Forms.Button plus2;
        private System.Windows.Forms.Button plus3;
        private System.Windows.Forms.Button minus2;
        private System.Windows.Forms.Button minus3;
        private System.Windows.Forms.Button minus4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button minus1;
    }
}