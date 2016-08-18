namespace MusicianJokes
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
            this.setupLabel = new System.Windows.Forms.Label();
            this.punchLineLabel = new System.Windows.Forms.Label();
            this.buttonPunchLine = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // setupLabel
            // 
            this.setupLabel.AutoSize = true;
            this.setupLabel.Font = new System.Drawing.Font("Microsoft PhagsPa", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setupLabel.Location = new System.Drawing.Point(13, 13);
            this.setupLabel.Name = "setupLabel";
            this.setupLabel.Size = new System.Drawing.Size(70, 28);
            this.setupLabel.TabIndex = 0;
            this.setupLabel.Text = "label1";
            // 
            // punchLineLabel
            // 
            this.punchLineLabel.AutoSize = true;
            this.punchLineLabel.Font = new System.Drawing.Font("Microsoft PhagsPa", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punchLineLabel.Location = new System.Drawing.Point(13, 95);
            this.punchLineLabel.Name = "punchLineLabel";
            this.punchLineLabel.Size = new System.Drawing.Size(70, 28);
            this.punchLineLabel.TabIndex = 1;
            this.punchLineLabel.Text = "label2";
            // 
            // buttonPunchLine
            // 
            this.buttonPunchLine.Location = new System.Drawing.Point(13, 164);
            this.buttonPunchLine.Name = "buttonPunchLine";
            this.buttonPunchLine.Size = new System.Drawing.Size(75, 23);
            this.buttonPunchLine.TabIndex = 2;
            this.buttonPunchLine.Text = "Punch Line";
            this.buttonPunchLine.UseVisualStyleBackColor = true;
            this.buttonPunchLine.Click += new System.EventHandler(this.buttonPunchLine_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(532, 164);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 261);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPunchLine);
            this.Controls.Add(this.punchLineLabel);
            this.Controls.Add(this.setupLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label setupLabel;
        private System.Windows.Forms.Label punchLineLabel;
        private System.Windows.Forms.Button buttonPunchLine;
        private System.Windows.Forms.Button buttonNext;
    }
}

