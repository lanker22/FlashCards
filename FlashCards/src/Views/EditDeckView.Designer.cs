
using System;
using System.Windows.Forms;

namespace src.Views
{
    partial class EditDeckView
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
            this.textboxDeckName = new System.Windows.Forms.TextBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.textboxQuestion = new System.Windows.Forms.TextBox();
            this.textboxAnswer = new System.Windows.Forms.TextBox();
            this.btnAddCard = new System.Windows.Forms.Button();
            this.btnUpdateName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDeckName
            // 
            this.labelDeckName.AutoSize = true;
            this.labelDeckName.Location = new System.Drawing.Point(343, 46);
            this.labelDeckName.Name = "labelDeckName";
            this.labelDeckName.Size = new System.Drawing.Size(91, 15);
            this.labelDeckName.TabIndex = 0;
            this.labelDeckName.Text = "Edit Deck Name";
            // 
            // textboxDeckName
            // 
            this.textboxDeckName.Location = new System.Drawing.Point(287, 64);
            this.textboxDeckName.Name = "textboxDeckName";
            this.textboxDeckName.Size = new System.Drawing.Size(198, 23);
            this.textboxDeckName.TabIndex = 1;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(115, 150);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(55, 15);
            this.labelQuestion.TabIndex = 2;
            this.labelQuestion.Text = "Question";
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(413, 150);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(46, 15);
            this.labelAnswer.TabIndex = 3;
            this.labelAnswer.Text = "Answer";
            // 
            // textboxQuestion
            // 
            this.textboxQuestion.Location = new System.Drawing.Point(24, 179);
            this.textboxQuestion.Multiline = true;
            this.textboxQuestion.Name = "textboxQuestion";
            this.textboxQuestion.Size = new System.Drawing.Size(232, 112);
            this.textboxQuestion.TabIndex = 4;
            // 
            // textboxAnswer
            // 
            this.textboxAnswer.Location = new System.Drawing.Point(307, 179);
            this.textboxAnswer.Multiline = true;
            this.textboxAnswer.Name = "textboxAnswer";
            this.textboxAnswer.Size = new System.Drawing.Size(251, 112);
            this.textboxAnswer.TabIndex = 5;
            // 
            // btnAddCard
            // 
            this.btnAddCard.Location = new System.Drawing.Point(582, 178);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(75, 23);
            this.btnAddCard.TabIndex = 6;
            this.btnAddCard.Text = "Add Card";
            this.btnAddCard.UseVisualStyleBackColor = true;
            // 
            // btnUpdateName
            // 
            this.btnUpdateName.Location = new System.Drawing.Point(554, 64);
            this.btnUpdateName.Name = "btnUpdateName";
            this.btnUpdateName.Size = new System.Drawing.Size(103, 23);
            this.btnUpdateName.TabIndex = 7;
            this.btnUpdateName.Text = "Update";
            this.btnUpdateName.UseVisualStyleBackColor = true;
            // 
            // EditDeckView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 303);
            this.Controls.Add(this.btnUpdateName);
            this.Controls.Add(this.btnAddCard);
            this.Controls.Add(this.textboxAnswer);
            this.Controls.Add(this.textboxQuestion);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.textboxDeckName);
            this.Controls.Add(this.labelDeckName);
            this.Name = "EditDeckView";
            this.Text = "EditDeckView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeckName;
        private System.Windows.Forms.TextBox textboxDeckName;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.TextBox textboxQuestion;
        private System.Windows.Forms.TextBox textboxAnswer;
        private System.Windows.Forms.Button btnAddCard;
        private System.Windows.Forms.Button btnUpdateName;
    }
}