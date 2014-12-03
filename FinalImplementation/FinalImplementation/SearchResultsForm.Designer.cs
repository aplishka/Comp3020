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
            this.addMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchResultList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.genreSelector = new System.Windows.Forms.ComboBox();
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
            this.fromSlider = new System.Windows.Forms.TrackBar();
            this.toSlider = new System.Windows.Forms.TrackBar();
            this.fromDateBox = new System.Windows.Forms.TextBox();
            this.toDateBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.starRatingTo = new RatingControls.StarRatingControl();
            this.starRatingFrom = new RatingControls.StarRatingControl();
            this.labellll = new System.Windows.Forms.Label();
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toSlider)).BeginInit();
            this.loadingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMovieToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addMovieToolStripMenuItem
            // 
            this.addMovieToolStripMenuItem.Name = "addMovieToolStripMenuItem";
            this.addMovieToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.addMovieToolStripMenuItem.Text = "Add Movie";
            this.addMovieToolStripMenuItem.Click += new System.EventHandler(this.addMovieToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(559, 35);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(63, 36);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(490, 22);
            this.searchTextBox.TabIndex = 14;
            this.searchTextBox.Text = "Enter search query...";
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            // 
            // searchResultList
            // 
            this.searchResultList.FormattingEnabled = true;
            this.searchResultList.ItemHeight = 16;
            this.searchResultList.Location = new System.Drawing.Point(12, 75);
            this.searchResultList.Name = "searchResultList";
            this.searchResultList.ScrollAlwaysVisible = true;
            this.searchResultList.Size = new System.Drawing.Size(622, 452);
            this.searchResultList.TabIndex = 16;
            this.searchResultList.SelectedIndexChanged += new System.EventHandler(this.searchResultList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(763, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Advanced Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(661, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(659, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Rating:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(660, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Genre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(659, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Actors:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(842, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "to";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(843, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "to";
            // 
            // genreSelector
            // 
            this.genreSelector.FormattingEnabled = true;
            this.genreSelector.Location = new System.Drawing.Point(717, 133);
            this.genreSelector.Name = "genreSelector";
            this.genreSelector.Size = new System.Drawing.Size(273, 24);
            this.genreSelector.TabIndex = 30;
            // 
            // actor1
            // 
            this.actor1.Location = new System.Drawing.Point(717, 357);
            this.actor1.Name = "actor1";
            this.actor1.Size = new System.Drawing.Size(183, 22);
            this.actor1.TabIndex = 32;
            // 
            // actor2
            // 
            this.actor2.Location = new System.Drawing.Point(717, 391);
            this.actor2.Name = "actor2";
            this.actor2.Size = new System.Drawing.Size(183, 22);
            this.actor2.TabIndex = 33;
            this.actor2.Visible = false;
            // 
            // actor3
            // 
            this.actor3.Location = new System.Drawing.Point(717, 425);
            this.actor3.Name = "actor3";
            this.actor3.Size = new System.Drawing.Size(183, 22);
            this.actor3.TabIndex = 34;
            this.actor3.Visible = false;
            // 
            // actor4
            // 
            this.actor4.Location = new System.Drawing.Point(717, 458);
            this.actor4.Name = "actor4";
            this.actor4.Size = new System.Drawing.Size(183, 22);
            this.actor4.TabIndex = 35;
            this.actor4.Visible = false;
            // 
            // advancedSearchButton
            // 
            this.advancedSearchButton.Location = new System.Drawing.Point(717, 501);
            this.advancedSearchButton.Name = "advancedSearchButton";
            this.advancedSearchButton.Size = new System.Drawing.Size(263, 23);
            this.advancedSearchButton.TabIndex = 36;
            this.advancedSearchButton.Text = "Advanced Search";
            this.advancedSearchButton.UseVisualStyleBackColor = true;
            this.advancedSearchButton.Click += new System.EventHandler(this.advancedSearchButton_Click);
            // 
            // plus1
            // 
            this.plus1.Location = new System.Drawing.Point(906, 356);
            this.plus1.Name = "plus1";
            this.plus1.Size = new System.Drawing.Size(33, 23);
            this.plus1.TabIndex = 37;
            this.plus1.Text = "+";
            this.plus1.UseVisualStyleBackColor = true;
            this.plus1.Click += new System.EventHandler(this.plus1_Click);
            // 
            // plus2
            // 
            this.plus2.Location = new System.Drawing.Point(906, 391);
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
            this.plus3.Location = new System.Drawing.Point(906, 425);
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
            this.minus2.Location = new System.Drawing.Point(945, 391);
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
            this.minus3.Location = new System.Drawing.Point(945, 425);
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
            this.minus4.Location = new System.Drawing.Point(945, 457);
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
            this.minus1.Location = new System.Drawing.Point(945, 356);
            this.minus1.Name = "minus1";
            this.minus1.Size = new System.Drawing.Size(33, 23);
            this.minus1.TabIndex = 44;
            this.minus1.Text = "-";
            this.minus1.UseVisualStyleBackColor = true;
            this.minus1.Click += new System.EventHandler(this.minus1_Click);
            // 
            // fromSlider
            // 
            this.fromSlider.LargeChange = 10;
            this.fromSlider.Location = new System.Drawing.Point(717, 197);
            this.fromSlider.Maximum = 2014;
            this.fromSlider.Minimum = 1900;
            this.fromSlider.Name = "fromSlider";
            this.fromSlider.Size = new System.Drawing.Size(273, 56);
            this.fromSlider.SmallChange = 5;
            this.fromSlider.TabIndex = 45;
            this.fromSlider.Value = 1900;
            this.fromSlider.Scroll += new System.EventHandler(this.fromSlider_Scroll);
            // 
            // toSlider
            // 
            this.toSlider.LargeChange = 10;
            this.toSlider.Location = new System.Drawing.Point(717, 283);
            this.toSlider.Maximum = 2014;
            this.toSlider.Minimum = 1900;
            this.toSlider.Name = "toSlider";
            this.toSlider.Size = new System.Drawing.Size(273, 56);
            this.toSlider.SmallChange = 5;
            this.toSlider.TabIndex = 46;
            this.toSlider.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.toSlider.Value = 2014;
            this.toSlider.Scroll += new System.EventHandler(this.toSlider_Scroll);
            // 
            // fromDateBox
            // 
            this.fromDateBox.Location = new System.Drawing.Point(728, 249);
            this.fromDateBox.Name = "fromDateBox";
            this.fromDateBox.ReadOnly = true;
            this.fromDateBox.Size = new System.Drawing.Size(100, 22);
            this.fromDateBox.TabIndex = 47;
            this.fromDateBox.Text = "1900";
            this.fromDateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toDateBox
            // 
            this.toDateBox.Location = new System.Drawing.Point(880, 249);
            this.toDateBox.Name = "toDateBox";
            this.toDateBox.ReadOnly = true;
            this.toDateBox.Size = new System.Drawing.Size(100, 22);
            this.toDateBox.TabIndex = 48;
            this.toDateBox.Text = "2014";
            this.toDateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(13, 35);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(44, 23);
            this.backButton.TabIndex = 49;
            this.backButton.Text = "<--";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // starRatingTo
            // 
            this.starRatingTo.BottomMargin = 2;
            this.starRatingTo.HoverColor = System.Drawing.Color.Gold;
            this.starRatingTo.LeftMargin = 1;
            this.starRatingTo.Location = new System.Drawing.Point(861, 78);
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
            this.starRatingFrom.Location = new System.Drawing.Point(717, 78);
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
            // labellll
            // 
            this.labellll.AutoSize = true;
            this.labellll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellll.Location = new System.Drawing.Point(102, 25);
            this.labellll.Name = "labellll";
            this.labellll.Size = new System.Drawing.Size(128, 29);
            this.labellll.TabIndex = 0;
            this.labellll.Text = "Loading...";
            // 
            // loadingPanel
            // 
            this.loadingPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.loadingPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loadingPanel.Controls.Add(this.labellll);
            this.loadingPanel.Location = new System.Drawing.Point(347, 227);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(327, 83);
            this.loadingPanel.TabIndex = 71;
            this.loadingPanel.Visible = false;
            // 
            // SearchResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 536);
            this.Controls.Add(this.loadingPanel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.toDateBox);
            this.Controls.Add(this.fromDateBox);
            this.Controls.Add(this.toSlider);
            this.Controls.Add(this.fromSlider);
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
            this.Controls.Add(this.genreSelector);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.starRatingTo);
            this.Controls.Add(this.starRatingFrom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchResultList);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SearchResultsForm";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toSlider)).EndInit();
            this.loadingPanel.ResumeLayout(false);
            this.loadingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ListBox searchResultList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private RatingControls.StarRatingControl starRatingFrom;
        private RatingControls.StarRatingControl starRatingTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox genreSelector;
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
        private System.Windows.Forms.TrackBar fromSlider;
        private System.Windows.Forms.TrackBar toSlider;
        private System.Windows.Forms.TextBox fromDateBox;
        private System.Windows.Forms.TextBox toDateBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ToolStripMenuItem addMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label labellll;
        private System.Windows.Forms.Panel loadingPanel;
    }
}