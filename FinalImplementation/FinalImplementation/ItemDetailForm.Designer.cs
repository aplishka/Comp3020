﻿namespace FinalImplementation
{
    partial class ItemDetailForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleLabel = new System.Windows.Forms.Label();
            this.reviewButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.directorLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.certificationLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.actorLabel = new System.Windows.Forms.Label();
            this.reviewBox = new System.Windows.Forms.ListBox();
            this.genreBox = new System.Windows.Forms.ListBox();
            this.actorBox = new System.Windows.Forms.ListBox();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.directorBox = new System.Windows.Forms.TextBox();
            this.certificationBox = new System.Windows.Forms.TextBox();
            this.movieLabel = new System.Windows.Forms.Label();
            this.movieBox = new System.Windows.Forms.ListBox();
            this.addToListButton = new System.Windows.Forms.Button();
            this.ratingBar = new System.Windows.Forms.ProgressBar();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.ratingValueLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loadingPanel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMovieToolStripMenuItem,
            this.toolStripMenuItem2,
            this.homeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editMovieToolStripMenuItem
            // 
            this.editMovieToolStripMenuItem.Name = "editMovieToolStripMenuItem";
            this.editMovieToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.editMovieToolStripMenuItem.Text = "Edit Movie";
            this.editMovieToolStripMenuItem.Click += new System.EventHandler(this.editMovieToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(172, 6);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.homeToolStripMenuItem.Text = "Back";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(172, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(82, 35);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(70, 25);
            this.titleLabel.TabIndex = 15;
            this.titleLabel.Text = "label1";
            // 
            // reviewButton
            // 
            this.reviewButton.Location = new System.Drawing.Point(588, 46);
            this.reviewButton.Name = "reviewButton";
            this.reviewButton.Size = new System.Drawing.Size(420, 23);
            this.reviewButton.TabIndex = 20;
            this.reviewButton.Text = "Write a Review";
            this.reviewButton.UseVisualStyleBackColor = true;
            this.reviewButton.Click += new System.EventHandler(this.reviewButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(13, 35);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(44, 23);
            this.backButton.TabIndex = 50;
            this.backButton.Text = "<--";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorLabel.Location = new System.Drawing.Point(14, 172);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(71, 17);
            this.directorLabel.TabIndex = 52;
            this.directorLabel.Text = "Director:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(15, 129);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(48, 17);
            this.timeLabel.TabIndex = 53;
            this.timeLabel.Text = "Time:";
            // 
            // certificationLabel
            // 
            this.certificationLabel.AutoSize = true;
            this.certificationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.certificationLabel.Location = new System.Drawing.Point(14, 217);
            this.certificationLabel.Name = "certificationLabel";
            this.certificationLabel.Size = new System.Drawing.Size(100, 17);
            this.certificationLabel.TabIndex = 54;
            this.certificationLabel.Text = "Certification:";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(15, 263);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(66, 17);
            this.genreLabel.TabIndex = 55;
            this.genreLabel.Text = "Genres:";
            // 
            // actorLabel
            // 
            this.actorLabel.AutoSize = true;
            this.actorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actorLabel.Location = new System.Drawing.Point(319, 263);
            this.actorLabel.Name = "actorLabel";
            this.actorLabel.Size = new System.Drawing.Size(59, 17);
            this.actorLabel.TabIndex = 56;
            this.actorLabel.Text = "Actors:";
            // 
            // reviewBox
            // 
            this.reviewBox.FormattingEnabled = true;
            this.reviewBox.ItemHeight = 16;
            this.reviewBox.Location = new System.Drawing.Point(588, 75);
            this.reviewBox.Name = "reviewBox";
            this.reviewBox.Size = new System.Drawing.Size(420, 452);
            this.reviewBox.TabIndex = 57;
            this.reviewBox.SelectedIndexChanged += new System.EventHandler(this.reviewBox_SelectedIndexChanged);
            // 
            // genreBox
            // 
            this.genreBox.FormattingEnabled = true;
            this.genreBox.ItemHeight = 16;
            this.genreBox.Location = new System.Drawing.Point(18, 283);
            this.genreBox.Name = "genreBox";
            this.genreBox.ScrollAlwaysVisible = true;
            this.genreBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.genreBox.Size = new System.Drawing.Size(250, 244);
            this.genreBox.TabIndex = 58;
            // 
            // actorBox
            // 
            this.actorBox.FormattingEnabled = true;
            this.actorBox.ItemHeight = 16;
            this.actorBox.Location = new System.Drawing.Point(322, 283);
            this.actorBox.Name = "actorBox";
            this.actorBox.ScrollAlwaysVisible = true;
            this.actorBox.Size = new System.Drawing.Size(250, 244);
            this.actorBox.TabIndex = 59;
            this.actorBox.SelectedIndexChanged += new System.EventHandler(this.actorBox_SelectedIndexChanged);
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(120, 126);
            this.timeBox.Name = "timeBox";
            this.timeBox.ReadOnly = true;
            this.timeBox.Size = new System.Drawing.Size(321, 22);
            this.timeBox.TabIndex = 60;
            // 
            // directorBox
            // 
            this.directorBox.Location = new System.Drawing.Point(120, 169);
            this.directorBox.Name = "directorBox";
            this.directorBox.ReadOnly = true;
            this.directorBox.Size = new System.Drawing.Size(321, 22);
            this.directorBox.TabIndex = 61;
            // 
            // certificationBox
            // 
            this.certificationBox.Location = new System.Drawing.Point(120, 214);
            this.certificationBox.Name = "certificationBox";
            this.certificationBox.ReadOnly = true;
            this.certificationBox.Size = new System.Drawing.Size(321, 22);
            this.certificationBox.TabIndex = 62;
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Location = new System.Drawing.Point(15, 85);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(56, 17);
            this.movieLabel.TabIndex = 63;
            this.movieLabel.Text = "Movies:";
            // 
            // movieBox
            // 
            this.movieBox.FormattingEnabled = true;
            this.movieBox.ItemHeight = 16;
            this.movieBox.Location = new System.Drawing.Point(77, 85);
            this.movieBox.Name = "movieBox";
            this.movieBox.Size = new System.Drawing.Size(931, 436);
            this.movieBox.TabIndex = 64;
            this.movieBox.SelectedIndexChanged += new System.EventHandler(this.movieBox_SelectedIndexChanged);
            // 
            // addToListButton
            // 
            this.addToListButton.Location = new System.Drawing.Point(462, 87);
            this.addToListButton.Name = "addToListButton";
            this.addToListButton.Size = new System.Drawing.Size(110, 23);
            this.addToListButton.TabIndex = 65;
            this.addToListButton.Text = "Save to a list...";
            this.addToListButton.UseVisualStyleBackColor = true;
            this.addToListButton.Click += new System.EventHandler(this.addToListButton_Click);
            // 
            // ratingBar
            // 
            this.ratingBar.Location = new System.Drawing.Point(166, 86);
            this.ratingBar.Maximum = 10;
            this.ratingBar.Name = "ratingBar";
            this.ratingBar.Size = new System.Drawing.Size(275, 23);
            this.ratingBar.TabIndex = 66;
            this.ratingBar.Value = 7;
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLabel.Location = new System.Drawing.Point(15, 90);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(60, 17);
            this.ratingLabel.TabIndex = 67;
            this.ratingLabel.Text = "Rating:";
            // 
            // ratingValueLabel
            // 
            this.ratingValueLabel.AutoSize = true;
            this.ratingValueLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ratingValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingValueLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ratingValueLabel.Location = new System.Drawing.Point(119, 90);
            this.ratingValueLabel.Name = "ratingValueLabel";
            this.ratingValueLabel.Size = new System.Drawing.Size(40, 17);
            this.ratingValueLabel.TabIndex = 68;
            this.ratingValueLabel.Text = "7/10";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.loadingPanel);
            this.panel1.Location = new System.Drawing.Point(343, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 83);
            this.panel1.TabIndex = 69;
            this.panel1.Visible = false;
            // 
            // loadingPanel
            // 
            this.loadingPanel.AutoSize = true;
            this.loadingPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingPanel.Location = new System.Drawing.Point(102, 25);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(128, 29);
            this.loadingPanel.TabIndex = 0;
            this.loadingPanel.Text = "Loading...";
            // 
            // ItemDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ratingValueLabel);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.ratingBar);
            this.Controls.Add(this.addToListButton);
            this.Controls.Add(this.certificationBox);
            this.Controls.Add(this.directorBox);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.actorBox);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.reviewBox);
            this.Controls.Add(this.actorLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.certificationLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.directorLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.reviewButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.movieBox);
            this.Controls.Add(this.movieLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Movie Viewer";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button reviewButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ToolStripMenuItem editMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label certificationLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label actorLabel;
        private System.Windows.Forms.ListBox reviewBox;
        private System.Windows.Forms.ListBox genreBox;
        private System.Windows.Forms.ListBox actorBox;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.TextBox directorBox;
        private System.Windows.Forms.TextBox certificationBox;
        private System.Windows.Forms.Label movieLabel;
        private System.Windows.Forms.ListBox movieBox;
        private System.Windows.Forms.Button addToListButton;
        private System.Windows.Forms.ProgressBar ratingBar;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label ratingValueLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loadingPanel;
    }
}