namespace CSharpAssessment
{
    partial class Form2
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
            this.addRemoveLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.authorInput = new System.Windows.Forms.TextBox();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.isbnInput = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.addRemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addRemoveLabel
            // 
            this.addRemoveLabel.AutoSize = true;
            this.addRemoveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRemoveLabel.Location = new System.Drawing.Point(143, 13);
            this.addRemoveLabel.Name = "addRemoveLabel";
            this.addRemoveLabel.Size = new System.Drawing.Size(51, 20);
            this.addRemoveLabel.TabIndex = 0;
            this.addRemoveLabel.Text = "label1";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(13, 62);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(38, 20);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(13, 105);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(38, 20);
            this.authorLabel.TabIndex = 2;
            this.authorLabel.Text = "Title";
            // 
            // titleInput
            // 
            this.titleInput.Location = new System.Drawing.Point(147, 62);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(228, 20);
            this.titleInput.TabIndex = 3;
            // 
            // authorInput
            // 
            this.authorInput.Location = new System.Drawing.Point(147, 108);
            this.authorInput.Name = "authorInput";
            this.authorInput.Size = new System.Drawing.Size(228, 20);
            this.authorInput.TabIndex = 4;
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(147, 200);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(228, 20);
            this.priceInput.TabIndex = 8;
            // 
            // isbnInput
            // 
            this.isbnInput.Location = new System.Drawing.Point(147, 154);
            this.isbnInput.Name = "isbnInput";
            this.isbnInput.Size = new System.Drawing.Size(228, 20);
            this.isbnInput.TabIndex = 7;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(13, 197);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(44, 20);
            this.priceLabel.TabIndex = 6;
            this.priceLabel.Text = "Price";
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnLabel.Location = new System.Drawing.Point(13, 154);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(38, 20);
            this.isbnLabel.TabIndex = 5;
            this.isbnLabel.Text = "Title";
            // 
            // addRemoveButton
            // 
            this.addRemoveButton.Location = new System.Drawing.Point(147, 284);
            this.addRemoveButton.Name = "addRemoveButton";
            this.addRemoveButton.Size = new System.Drawing.Size(132, 53);
            this.addRemoveButton.TabIndex = 9;
            this.addRemoveButton.Text = "button1";
            this.addRemoveButton.UseVisualStyleBackColor = true;
            this.addRemoveButton.Click += new System.EventHandler(this.addRemoveButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 387);
            this.Controls.Add(this.addRemoveButton);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.isbnInput);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.isbnLabel);
            this.Controls.Add(this.authorInput);
            this.Controls.Add(this.titleInput);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.addRemoveLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addRemoveLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.TextBox authorInput;
        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.TextBox isbnInput;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.Button addRemoveButton;
    }
}