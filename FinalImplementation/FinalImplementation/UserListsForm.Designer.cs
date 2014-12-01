namespace FinalImplementation
{
    partial class UserListsForm
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
            this.buyListBox = new System.Windows.Forms.ListBox();
            this.mustWatchListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listTypeComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.newListTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Must-Watch Lists";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buy Lists";
            // 
            // buyListBox
            // 
            this.buyListBox.FormattingEnabled = true;
            this.buyListBox.ItemHeight = 16;
            this.buyListBox.Location = new System.Drawing.Point(365, 32);
            this.buyListBox.Name = "buyListBox";
            this.buyListBox.Size = new System.Drawing.Size(308, 276);
            this.buyListBox.TabIndex = 4;
            this.buyListBox.SelectedIndexChanged += new System.EventHandler(this.buyListBox_SelectedIndexChanged);
            // 
            // mustWatchListBox
            // 
            this.mustWatchListBox.FormattingEnabled = true;
            this.mustWatchListBox.ItemHeight = 16;
            this.mustWatchListBox.Location = new System.Drawing.Point(16, 33);
            this.mustWatchListBox.Name = "mustWatchListBox";
            this.mustWatchListBox.Size = new System.Drawing.Size(331, 276);
            this.mustWatchListBox.TabIndex = 5;
            this.mustWatchListBox.SelectedIndexChanged += new System.EventHandler(this.mustWatchListBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(715, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "List Type:";
            // 
            // listTypeComboBox
            // 
            this.listTypeComboBox.FormattingEnabled = true;
            this.listTypeComboBox.Location = new System.Drawing.Point(718, 68);
            this.listTypeComboBox.Name = "listTypeComboBox";
            this.listTypeComboBox.Size = new System.Drawing.Size(170, 24);
            this.listTypeComboBox.TabIndex = 11;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(823, 183);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(65, 23);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Create";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(715, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "New List Name: ";
            // 
            // newListTextBox
            // 
            this.newListTextBox.Location = new System.Drawing.Point(718, 142);
            this.newListTextBox.Name = "newListTextBox";
            this.newListTextBox.Size = new System.Drawing.Size(170, 22);
            this.newListTextBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(714, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Create new list";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 322);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newListTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.listTypeComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mustWatchListBox);
            this.Controls.Add(this.buyListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserListsForm";
            this.Text = "Users watch lists";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox buyListBox;
        private System.Windows.Forms.ListBox mustWatchListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox listTypeComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newListTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}