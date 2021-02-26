
using System;
using System.Windows.Forms;

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
            this.textQuestionOrAnswer = new System.Windows.Forms.TextBox();
            this.labelQuestionOrAnswer = new System.Windows.Forms.Label();
            this.labelProgress = new System.Windows.Forms.Label();
            this.labelGameFinished = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnNextItem = new System.Windows.Forms.Button();
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
            // textQuestionOrAnswer
            // 
            this.textQuestionOrAnswer.Location = new System.Drawing.Point(76, 116);
            this.textQuestionOrAnswer.Multiline = true;
            this.textQuestionOrAnswer.Name = "textQuestionOrAnswer";
            this.textQuestionOrAnswer.ReadOnly = true;
            this.textQuestionOrAnswer.Size = new System.Drawing.Size(383, 168);
            this.textQuestionOrAnswer.TabIndex = 1;
            // 
            // labelQuestionOrAnswer
            // 
            this.labelQuestionOrAnswer.AutoSize = true;
            this.labelQuestionOrAnswer.Location = new System.Drawing.Point(249, 98);
            this.labelQuestionOrAnswer.Name = "labelQuestionOrAnswer";
            this.labelQuestionOrAnswer.Size = new System.Drawing.Size(0, 15);
            this.labelQuestionOrAnswer.TabIndex = 2;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(249, 73);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(0, 15);
            this.labelProgress.TabIndex = 3;
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
            // 
            // btnNextItem
            // 
            this.btnNextItem.Location = new System.Drawing.Point(201, 87);
            this.btnNextItem.Name = "btnNextItem";
            this.btnNextItem.Size = new System.Drawing.Size(139, 23);
            this.btnNextItem.TabIndex = 6;
            this.btnNextItem.UseVisualStyleBackColor = true;
            // 
            // FlashCardGameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 355);
            this.Controls.Add(this.btnNextItem);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.labelGameFinished);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.labelQuestionOrAnswer);
            this.Controls.Add(this.textQuestionOrAnswer);
            this.Controls.Add(this.labelDeckName);
            this.Name = "FlashCardGameView";
            this.Text = "FlashCardGameView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BtnPlayAgain_Click(object sender, EventArgs e)
        {
            PlayAgainButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BtnNextItem_Click(object sender, EventArgs e)
        {
            NextItemButtonClicked?.Invoke(sender, EventArgs.Empty);
        }

        #endregion

        private System.Windows.Forms.Label labelDeckName;
        private System.Windows.Forms.TextBox textQuestionOrAnswer;
        private System.Windows.Forms.Label labelQuestionOrAnswer;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Label labelGameFinished;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnNextItem;
    }
}