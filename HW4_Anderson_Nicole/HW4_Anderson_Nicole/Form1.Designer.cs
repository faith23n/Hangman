namespace HW4_Anderson_Nicole
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
            this.guessBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.newGameBox = new System.Windows.Forms.GroupBox();
            this.yesButton = new System.Windows.Forms.RadioButton();
            this.noButton = new System.Windows.Forms.RadioButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.newGameBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // guessBox
            // 
            this.guessBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessBox.Location = new System.Drawing.Point(30, 13);
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(60, 33);
            this.guessBox.TabIndex = 0;
            this.guessBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guessBox.TextChanged += new System.EventHandler(this.guessBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Guess a number between 1 and 100";
            // 
            // testButton
            // 
            this.testButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.testButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testButton.Location = new System.Drawing.Point(128, 13);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(110, 33);
            this.testButton.TabIndex = 2;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = false;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.errorMessage.Location = new System.Drawing.Point(30, 65);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 28);
            this.errorMessage.TabIndex = 3;
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(400, 4);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(0, 13);
            this.answerLabel.TabIndex = 4;
            // 
            // newGameBox
            // 
            this.newGameBox.Controls.Add(this.noButton);
            this.newGameBox.Controls.Add(this.yesButton);
            this.newGameBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameBox.Location = new System.Drawing.Point(30, 391);
            this.newGameBox.Name = "newGameBox";
            this.newGameBox.Size = new System.Drawing.Size(208, 71);
            this.newGameBox.TabIndex = 5;
            this.newGameBox.TabStop = false;
            this.newGameBox.Text = "New Game?";
            this.newGameBox.Visible = false;
            this.newGameBox.Enter += new System.EventHandler(this.newGameBox_Enter);
            // 
            // yesButton
            // 
            this.yesButton.AutoSize = true;
            this.yesButton.Location = new System.Drawing.Point(40, 29);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(51, 26);
            this.yesButton.TabIndex = 0;
            this.yesButton.TabStop = true;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.CheckedChanged += new System.EventHandler(this.yesButton_CheckedChanged);
            // 
            // noButton
            // 
            this.noButton.AutoSize = true;
            this.noButton.Location = new System.Drawing.Point(125, 29);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(49, 26);
            this.noButton.TabIndex = 1;
            this.noButton.TabStop = true;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.CheckedChanged += new System.EventHandler(this.noButton_CheckedChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.ErrorImage = global::HW4_Anderson_Nicole.Properties.Resources.yay;
            this.pictureBox.Location = new System.Drawing.Point(30, 97);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(519, 297);
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 464);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.newGameBox);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guessBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.newGameBox.ResumeLayout(false);
            this.newGameBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox guessBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.GroupBox newGameBox;
        private System.Windows.Forms.RadioButton noButton;
        private System.Windows.Forms.RadioButton yesButton;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

