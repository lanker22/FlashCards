
using System;

namespace src.Views
{
    partial class AddDeckView
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
            this.inputDeckName = new System.Windows.Forms.TextBox();
            this.btnAddDeck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDeckName
            // 
            this.labelDeckName.AutoSize = true;
            this.labelDeckName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDeckName.Location = new System.Drawing.Point(262, 69);
            this.labelDeckName.Name = "labelDeckName";
            this.labelDeckName.Size = new System.Drawing.Size(137, 21);
            this.labelDeckName.TabIndex = 0;
            this.labelDeckName.Text = "New Deck Name";
            // 
            // inputDeckName
            // 
            this.inputDeckName.Location = new System.Drawing.Point(145, 102);
            this.inputDeckName.Name = "inputDeckName";
            this.inputDeckName.Size = new System.Drawing.Size(377, 23);
            this.inputDeckName.TabIndex = 1;
            // 
            // btnAddDeck
            // 
            this.btnAddDeck.Location = new System.Drawing.Point(288, 150);
            this.btnAddDeck.Name = "btnAddDeck";
            this.btnAddDeck.Size = new System.Drawing.Size(75, 23);
            this.btnAddDeck.TabIndex = 4;
            this.btnAddDeck.Text = "Add Deck";
            this.btnAddDeck.UseVisualStyleBackColor = true;
            this.btnAddDeck.Click += BtnAddDeck_Click;
            // 
            // AddDeckView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 185);
            this.Controls.Add(this.btnAddDeck);
            this.Controls.Add(this.inputDeckName);
            this.Controls.Add(this.labelDeckName);
            this.Name = "AddDeckView";
            this.Text = "AddDeckView";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormClosed += AddDeckView_FormClosed;

        }

        private void AddDeckView_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            AddDeckViewClosedEvent?.Invoke(this, EventArgs.Empty);
        }

        private void BtnAddDeck_Click(object sender, System.EventArgs e)
        {
            DeckAddedClicked?.Invoke(this, EventArgs.Empty);
        }

        #endregion

        private System.Windows.Forms.Label labelDeckName;
        private System.Windows.Forms.TextBox inputDeckName;
        private System.Windows.Forms.Button btnAddDeck;
    }
}