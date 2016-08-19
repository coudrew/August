namespace CSharpAssessment
{
    partial class Form1
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
            this.mediaGroupBox = new System.Windows.Forms.GroupBox();
            this.videoButton = new System.Windows.Forms.RadioButton();
            this.audioButton = new System.Windows.Forms.RadioButton();
            this.periodicalButton = new System.Windows.Forms.RadioButton();
            this.bookButton = new System.Windows.Forms.RadioButton();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.titleSearchInput = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.searchResultGroupBox = new System.Windows.Forms.GroupBox();
            this.priceResult = new System.Windows.Forms.Label();
            this.isbnResult = new System.Windows.Forms.Label();
            this.authorResult = new System.Windows.Forms.Label();
            this.titleResult = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.mediaGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.searchResultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mediaGroupBox
            // 
            this.mediaGroupBox.Controls.Add(this.videoButton);
            this.mediaGroupBox.Controls.Add(this.audioButton);
            this.mediaGroupBox.Controls.Add(this.periodicalButton);
            this.mediaGroupBox.Controls.Add(this.bookButton);
            this.mediaGroupBox.Location = new System.Drawing.Point(13, 13);
            this.mediaGroupBox.Name = "mediaGroupBox";
            this.mediaGroupBox.Size = new System.Drawing.Size(270, 161);
            this.mediaGroupBox.TabIndex = 0;
            this.mediaGroupBox.TabStop = false;
            this.mediaGroupBox.Text = "Media Type";
            // 
            // videoButton
            // 
            this.videoButton.AutoSize = true;
            this.videoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoButton.Location = new System.Drawing.Point(7, 110);
            this.videoButton.Name = "videoButton";
            this.videoButton.Size = new System.Drawing.Size(68, 24);
            this.videoButton.TabIndex = 3;
            this.videoButton.TabStop = true;
            this.videoButton.Text = "Video";
            this.videoButton.UseVisualStyleBackColor = true;
            this.videoButton.CheckedChanged += new System.EventHandler(this.videoButton_CheckedChanged);
            // 
            // audioButton
            // 
            this.audioButton.AutoSize = true;
            this.audioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audioButton.Location = new System.Drawing.Point(7, 80);
            this.audioButton.Name = "audioButton";
            this.audioButton.Size = new System.Drawing.Size(68, 24);
            this.audioButton.TabIndex = 2;
            this.audioButton.TabStop = true;
            this.audioButton.Text = "Audio";
            this.audioButton.UseVisualStyleBackColor = true;
            this.audioButton.CheckedChanged += new System.EventHandler(this.audioButton_CheckedChanged);
            // 
            // periodicalButton
            // 
            this.periodicalButton.AutoSize = true;
            this.periodicalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodicalButton.Location = new System.Drawing.Point(7, 50);
            this.periodicalButton.Name = "periodicalButton";
            this.periodicalButton.Size = new System.Drawing.Size(139, 24);
            this.periodicalButton.TabIndex = 1;
            this.periodicalButton.TabStop = true;
            this.periodicalButton.Text = "Periodical/Serial";
            this.periodicalButton.UseVisualStyleBackColor = true;
            this.periodicalButton.CheckedChanged += new System.EventHandler(this.periodicalButton_CheckedChanged);
            // 
            // bookButton
            // 
            this.bookButton.AutoSize = true;
            this.bookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookButton.Location = new System.Drawing.Point(7, 20);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(64, 24);
            this.bookButton.TabIndex = 0;
            this.bookButton.TabStop = true;
            this.bookButton.Text = "Book";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.CheckedChanged += new System.EventHandler(this.bookButton_CheckedChanged);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.titleSearchInput);
            this.searchGroupBox.Controls.Add(this.titleLabel);
            this.searchGroupBox.Location = new System.Drawing.Point(13, 181);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(270, 120);
            this.searchGroupBox.TabIndex = 1;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(113, 63);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(151, 51);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search Catalogue";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // titleSearchInput
            // 
            this.titleSearchInput.Location = new System.Drawing.Point(113, 20);
            this.titleSearchInput.Name = "titleSearchInput";
            this.titleSearchInput.Size = new System.Drawing.Size(151, 20);
            this.titleSearchInput.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(7, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(38, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // searchResultGroupBox
            // 
            this.searchResultGroupBox.Controls.Add(this.priceResult);
            this.searchResultGroupBox.Controls.Add(this.isbnResult);
            this.searchResultGroupBox.Controls.Add(this.authorResult);
            this.searchResultGroupBox.Controls.Add(this.titleResult);
            this.searchResultGroupBox.Location = new System.Drawing.Point(290, 13);
            this.searchResultGroupBox.Name = "searchResultGroupBox";
            this.searchResultGroupBox.Size = new System.Drawing.Size(566, 345);
            this.searchResultGroupBox.TabIndex = 2;
            this.searchResultGroupBox.TabStop = false;
            this.searchResultGroupBox.Text = "Search Result";
            // 
            // priceResult
            // 
            this.priceResult.AutoSize = true;
            this.priceResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceResult.Location = new System.Drawing.Point(7, 197);
            this.priceResult.Name = "priceResult";
            this.priceResult.Size = new System.Drawing.Size(0, 20);
            this.priceResult.TabIndex = 3;
            // 
            // isbnResult
            // 
            this.isbnResult.AutoSize = true;
            this.isbnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnResult.Location = new System.Drawing.Point(7, 141);
            this.isbnResult.Name = "isbnResult";
            this.isbnResult.Size = new System.Drawing.Size(0, 20);
            this.isbnResult.TabIndex = 2;
            // 
            // authorResult
            // 
            this.authorResult.AutoSize = true;
            this.authorResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorResult.Location = new System.Drawing.Point(7, 84);
            this.authorResult.Name = "authorResult";
            this.authorResult.Size = new System.Drawing.Size(0, 20);
            this.authorResult.TabIndex = 1;
            // 
            // titleResult
            // 
            this.titleResult.AutoSize = true;
            this.titleResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleResult.Location = new System.Drawing.Point(7, 30);
            this.titleResult.Name = "titleResult";
            this.titleResult.Size = new System.Drawing.Size(0, 20);
            this.titleResult.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(13, 315);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(133, 43);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add to Catalogue";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(152, 315);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(133, 43);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove from Catalogue";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 439);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchResultGroupBox);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.mediaGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mediaGroupBox.ResumeLayout(false);
            this.mediaGroupBox.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.searchResultGroupBox.ResumeLayout(false);
            this.searchResultGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mediaGroupBox;
        private System.Windows.Forms.RadioButton videoButton;
        private System.Windows.Forms.RadioButton audioButton;
        private System.Windows.Forms.RadioButton periodicalButton;
        private System.Windows.Forms.RadioButton bookButton;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox titleSearchInput;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox searchResultGroupBox;
        private System.Windows.Forms.Label priceResult;
        private System.Windows.Forms.Label isbnResult;
        private System.Windows.Forms.Label authorResult;
        private System.Windows.Forms.Label titleResult;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
    }
}

