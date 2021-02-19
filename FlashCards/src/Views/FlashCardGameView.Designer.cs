
namespace src.Views
{
    partial class FlashCardGameView
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
            this.labelDeckName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelQuestionOrAnswer = new System.Windows.Forms.Label();
            this.labelCardNumber = new System.Windows.Forms.Label();
            this.labelGameFinished = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDeckName
            // 
            this.labelDeckName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDeckName.AutoSize = true;
            this.labelDeckName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDeckName.Location = new System.Drawing.Point(213, 18);
            this.labelDeckName.Name = "labelDeckName";
            this.labelDeckName.Size = new System.Drawing.Size(0, 30);
            this.labelDeckName.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 23);
            this.textBox1.TabIndex = 1;
            // 
            // labelQuestionOrAnswer
            // 
            this.labelQuestionOrAnswer.AutoSize = true;
            this.labelQuestionOrAnswer.Location = new System.Drawing.Point(249, 98);
            this.labelQuestionOrAnswer.Name = "labelQuestionOrAnswer";
            this.labelQuestionOrAnswer.Size = new System.Drawing.Size(0, 15);
            this.labelQuestionOrAnswer.TabIndex = 2;
            // 
            // labelCardNumber
            // 
            this.labelCardNumber.AutoSize = true;
            this.labelCardNumber.Location = new System.Drawing.Point(249, 73);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(0, 15);
            this.labelCardNumber.TabIndex = 3;
            // 
            // labelGameFinished
            // 
            this.labelGameFinished.AutoSize = true;
            this.labelGameFinished.ForeColor = System.Drawing.Color.Red;
            this.labelGameFinished.Location = new System.Drawing.Point(224, 287);
            this.labelGameFinished.Name = "labelGameFinished";
            this.labelGameFinished.Size = new System.Drawing.Size(93, 15);
            this.labelGameFinished.TabIndex = 4;
            this.labelGameFinished.Text = "GAME FINISHED";
            this.labelGameFinished.Visible = false;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(213, 320);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(114, 23);
            this.btnPlayAgain.TabIndex = 5;
            this.btnPlayAgain.Text = "Play Again?";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Click += BtnPlayAgain_Click;
            // 
            // FlashCardGameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 355);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.labelGameFinished);
            this.Controls.Add(this.labelCardNumber);
            this.Controls.Add(this.labelQuestionOrAnswer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelDeckName);
            this.Name = "FlashCardGameView";
            this.Text = "FlashCardGameView";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Click += FlashCardGameView_Click;

        }

        #endregion

        private System.Windows.Forms.Label labelDeckName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelQuestionOrAnswer;
        private System.Windows.Forms.Label labelCardNumber;
        private System.Windows.Forms.Label labelGameFinished;
        public System.Windows.Forms.Button btnPlayAgain;
    }
}