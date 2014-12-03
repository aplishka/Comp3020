namespace FinalImplementation
{
    partial class ReviewForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.plotReview = new System.Windows.Forms.TextBox();
            this.actorsReview = new System.Windows.Forms.TextBox();
            this.PublishReviewButton = new System.Windows.Forms.Button();
            this.errorText = new System.Windows.Forms.Label();
            this.ratingBar = new System.Windows.Forms.ProgressBar();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.starRating = new RatingControls.StarRatingControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Write a review";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plot Review";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Actors Review";
            // 
            // plotReview
            // 
            this.plotReview.Location = new System.Drawing.Point(26, 124);
            this.plotReview.Multiline = true;
            this.plotReview.Name = "plotReview";
            this.plotReview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.plotReview.Size = new System.Drawing.Size(676, 93);
            this.plotReview.TabIndex = 3;
            // 
            // actorsReview
            // 
            this.actorsReview.Location = new System.Drawing.Point(26, 240);
            this.actorsReview.Multiline = true;
            this.actorsReview.Name = "actorsReview";
            this.actorsReview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.actorsReview.Size = new System.Drawing.Size(676, 118);
            this.actorsReview.TabIndex = 4;
            // 
            // PublishReviewButton
            // 
            this.PublishReviewButton.Location = new System.Drawing.Point(575, 364);
            this.PublishReviewButton.Name = "PublishReviewButton";
            this.PublishReviewButton.Size = new System.Drawing.Size(127, 23);
            this.PublishReviewButton.TabIndex = 0;
            this.PublishReviewButton.Text = "Publish Review";
            this.PublishReviewButton.UseVisualStyleBackColor = true;
            this.PublishReviewButton.Click += new System.EventHandler(this.PublishReviewButton_Click);
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.ForeColor = System.Drawing.Color.Red;
            this.errorText.Location = new System.Drawing.Point(26, 370);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(0, 17);
            this.errorText.TabIndex = 7;
            // 
            // ratingBar
            // 
            this.ratingBar.Location = new System.Drawing.Point(26, 55);
            this.ratingBar.Maximum = 10;
            this.ratingBar.Name = "ratingBar";
            this.ratingBar.Size = new System.Drawing.Size(673, 36);
            this.ratingBar.TabIndex = 5;
            this.ratingBar.Value = 7;
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLabel.Location = new System.Drawing.Point(619, 9);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ratingLabel.Size = new System.Drawing.Size(75, 32);
            this.ratingLabel.TabIndex = 9;
            this.ratingLabel.Text = "7/10";
            this.ratingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // starRating
            // 
            this.starRating.BottomMargin = 2;
            this.starRating.HoverColor = System.Drawing.Color.Gold;
            this.starRating.LeftMargin = 2;
            this.starRating.Location = new System.Drawing.Point(26, 44);
            this.starRating.Name = "starRating";
            this.starRating.OutlineColor = System.Drawing.Color.DarkGray;
            this.starRating.OutlineThickness = 1;
            this.starRating.RightMargin = 2;
            this.starRating.SelectedColor = System.Drawing.Color.Yellow;
            this.starRating.Size = new System.Drawing.Size(668, 57);
            this.starRating.StarCount = 10;
            this.starRating.StarSpacing = 8;
            this.starRating.TabIndex = 6;
            this.starRating.Text = "starRatingControl";
            this.starRating.TopMargin = 2;
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 399);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.ratingBar);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.starRating);
            this.Controls.Add(this.PublishReviewButton);
            this.Controls.Add(this.actorsReview);
            this.Controls.Add(this.plotReview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Write a Review";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox plotReview;
        private System.Windows.Forms.TextBox actorsReview;
        private System.Windows.Forms.Button PublishReviewButton;
        private RatingControls.StarRatingControl starRating;
        private System.Windows.Forms.Label errorText;
        private System.Windows.Forms.ProgressBar ratingBar;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}