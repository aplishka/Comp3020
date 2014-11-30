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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.plotReview = new System.Windows.Forms.TextBox();
            this.actorsReview = new System.Windows.Forms.TextBox();
            this.PublishReviewButton = new System.Windows.Forms.Button();
            this.starRating = new RatingControls.StarRatingControl();
            this.errorText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Write a review";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plot Review";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Actors Review";
            // 
            // plotReview
            // 
            this.plotReview.Location = new System.Drawing.Point(26, 124);
            this.plotReview.Multiline = true;
            this.plotReview.Name = "plotReview";
            this.plotReview.Size = new System.Drawing.Size(676, 93);
            this.plotReview.TabIndex = 3;
            // 
            // actorsReview
            // 
            this.actorsReview.Location = new System.Drawing.Point(26, 240);
            this.actorsReview.Multiline = true;
            this.actorsReview.Name = "actorsReview";
            this.actorsReview.Size = new System.Drawing.Size(676, 118);
            this.actorsReview.TabIndex = 4;
            // 
            // PublishReviewButton
            // 
            this.PublishReviewButton.Location = new System.Drawing.Point(575, 364);
            this.PublishReviewButton.Name = "PublishReviewButton";
            this.PublishReviewButton.Size = new System.Drawing.Size(127, 23);
            this.PublishReviewButton.TabIndex = 5;
            this.PublishReviewButton.Text = "Publish Review";
            this.PublishReviewButton.UseVisualStyleBackColor = true;
            this.PublishReviewButton.Click += new System.EventHandler(this.PublishReviewButton_Click);
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
            this.starRating.Size = new System.Drawing.Size(676, 57);
            this.starRating.StarCount = 10;
            this.starRating.StarSpacing = 8;
            this.starRating.TabIndex = 6;
            this.starRating.Text = "starRatingControl1";
            this.starRating.TopMargin = 2;
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Location = new System.Drawing.Point(26, 370);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(0, 17);
            this.errorText.TabIndex = 7;
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 399);
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
    }
}