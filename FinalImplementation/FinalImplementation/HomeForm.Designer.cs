﻿namespace FinalImplementation
{
    partial class HomeForm
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.topMoviesLabel = new System.Windows.Forms.Label();
            this.topActorsLabel = new System.Windows.Forms.Label();
            this.topMoviesList = new System.Windows.Forms.ListBox();
            this.topActorsList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.topGenresList = new System.Windows.Forms.ListBox();
            this.topDecadesList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userListsButton = new System.Windows.Forms.Button();
            this.graphButton = new System.Windows.Forms.Button();
            this.labellll = new System.Windows.Forms.Label();
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.loadingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 36);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(495, 22);
            this.searchTextBox.TabIndex = 12;
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(513, 35);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // topMoviesLabel
            // 
            this.topMoviesLabel.AutoSize = true;
            this.topMoviesLabel.Location = new System.Drawing.Point(9, 64);
            this.topMoviesLabel.Name = "topMoviesLabel";
            this.topMoviesLabel.Size = new System.Drawing.Size(81, 17);
            this.topMoviesLabel.TabIndex = 2;
            this.topMoviesLabel.Text = "Top Movies";
            // 
            // topActorsLabel
            // 
            this.topActorsLabel.AutoSize = true;
            this.topActorsLabel.Location = new System.Drawing.Point(323, 64);
            this.topActorsLabel.Name = "topActorsLabel";
            this.topActorsLabel.Size = new System.Drawing.Size(77, 17);
            this.topActorsLabel.TabIndex = 3;
            this.topActorsLabel.Text = "Top Actors";
            // 
            // topMoviesList
            // 
            this.topMoviesList.FormattingEnabled = true;
            this.topMoviesList.ItemHeight = 16;
            this.topMoviesList.Location = new System.Drawing.Point(12, 84);
            this.topMoviesList.Name = "topMoviesList";
            this.topMoviesList.Size = new System.Drawing.Size(262, 436);
            this.topMoviesList.TabIndex = 6;
            this.topMoviesList.SelectedIndexChanged += new System.EventHandler(this.topMoviesList_SelectedIndexChanged);
            // 
            // topActorsList
            // 
            this.topActorsList.FormattingEnabled = true;
            this.topActorsList.ItemHeight = 16;
            this.topActorsList.Location = new System.Drawing.Point(326, 84);
            this.topActorsList.Name = "topActorsList";
            this.topActorsList.Size = new System.Drawing.Size(262, 436);
            this.topActorsList.TabIndex = 7;
            this.topActorsList.SelectedIndexChanged += new System.EventHandler(this.topActorsList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(659, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Genres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(659, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Decades";
            // 
            // topGenresList
            // 
            this.topGenresList.FormattingEnabled = true;
            this.topGenresList.ItemHeight = 16;
            this.topGenresList.Location = new System.Drawing.Point(662, 84);
            this.topGenresList.Name = "topGenresList";
            this.topGenresList.Size = new System.Drawing.Size(346, 196);
            this.topGenresList.TabIndex = 10;
            this.topGenresList.SelectedIndexChanged += new System.EventHandler(this.topGenresList_SelectedIndexChanged);
            // 
            // topDecadesList
            // 
            this.topDecadesList.FormattingEnabled = true;
            this.topDecadesList.ItemHeight = 16;
            this.topDecadesList.Location = new System.Drawing.Point(662, 324);
            this.topDecadesList.Name = "topDecadesList";
            this.topDecadesList.Size = new System.Drawing.Size(346, 196);
            this.topDecadesList.TabIndex = 11;
            this.topDecadesList.SelectedIndexChanged += new System.EventHandler(this.topDecadesList_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMovieToolStripMenuItem,
            this.toolStripMenuItem1,
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // userListsButton
            // 
            this.userListsButton.Location = new System.Drawing.Point(904, 35);
            this.userListsButton.Name = "userListsButton";
            this.userListsButton.Size = new System.Drawing.Size(103, 23);
            this.userListsButton.TabIndex = 13;
            this.userListsButton.Text = "Saved Lists";
            this.userListsButton.UseVisualStyleBackColor = true;
            this.userListsButton.Click += new System.EventHandler(this.userListsButton_Click);
            // 
            // graphButton
            // 
            this.graphButton.Location = new System.Drawing.Point(782, 35);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(116, 23);
            this.graphButton.TabIndex = 14;
            this.graphButton.Text = "Graph Search";
            this.graphButton.UseVisualStyleBackColor = true;
            this.graphButton.Click += new System.EventHandler(this.graphButton_Click);
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
            this.loadingPanel.TabIndex = 70;
            this.loadingPanel.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(662, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 71;
            this.button1.Text = "Adv Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loadingPanel);
            this.Controls.Add(this.graphButton);
            this.Controls.Add(this.userListsButton);
            this.Controls.Add(this.topDecadesList);
            this.Controls.Add(this.topGenresList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.topActorsList);
            this.Controls.Add(this.topMoviesList);
            this.Controls.Add(this.topActorsLabel);
            this.Controls.Add(this.topMoviesLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Finder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.loadingPanel.ResumeLayout(false);
            this.loadingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label topMoviesLabel;
        private System.Windows.Forms.Label topActorsLabel;
        private System.Windows.Forms.ListBox topMoviesList;
        private System.Windows.Forms.ListBox topActorsList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox topGenresList;
        private System.Windows.Forms.ListBox topDecadesList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addMovieToolStripMenuItem;
        private System.Windows.Forms.Button userListsButton;
        private System.Windows.Forms.Button graphButton;
        private System.Windows.Forms.Label labellll;
        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

