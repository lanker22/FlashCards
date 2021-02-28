
using System;
using System.Windows.Forms;

namespace src.Controls
{
    partial class DeckControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMainLayout = new System.Windows.Forms.Panel();
            this.labelNumOfCardsInDeck = new System.Windows.Forms.Label();
            this.labelDeckName = new System.Windows.Forms.Label();
            this.btnDeleteDeck = new System.Windows.Forms.Button();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.btnEditDeck = new System.Windows.Forms.Button();
            this.panelMainLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainLayout
            // 
            this.panelMainLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMainLayout.Controls.Add(this.labelNumOfCardsInDeck);
            this.panelMainLayout.Controls.Add(this.labelDeckName);
            this.panelMainLayout.Controls.Add(this.btnDeleteDeck);
            this.panelMainLayout.Controls.Add(this.btnPlayGame);
            this.panelMainLayout.Controls.Add(this.btnEditDeck);
            this.panelMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainLayout.Location = new System.Drawing.Point(0, 0);
            this.panelMainLayout.Name = "panelMainLayout";
            this.panelMainLayout.Size = new System.Drawing.Size(310, 171);
            this.panelMainLayout.TabIndex = 0;
            this.panelMainLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMainLayout_Paint);
            // 
            // labelNumOfCardsInDeck
            // 
            this.labelNumOfCardsInDeck.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNumOfCardsInDeck.Location = new System.Drawing.Point(0, 22);
            this.labelNumOfCardsInDeck.Name = "labelNumOfCardsInDeck";
            this.labelNumOfCardsInDeck.Size = new System.Drawing.Size(310, 19);
            this.labelNumOfCardsInDeck.TabIndex = 4;
            this.labelNumOfCardsInDeck.Text = "here";
            this.labelNumOfCardsInDeck.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDeckName
            // 
            this.labelDeckName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDeckName.Location = new System.Drawing.Point(0, 0);
            this.labelDeckName.Name = "labelDeckName";
            this.labelDeckName.Size = new System.Drawing.Size(310, 22);
            this.labelDeckName.TabIndex = 3;
            this.labelDeckName.Text = "here";
            this.labelDeckName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDeleteDeck
            // 
            this.btnDeleteDeck.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeleteDeck.Location = new System.Drawing.Point(0, 57);
            this.btnDeleteDeck.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteDeck.Name = "btnDeleteDeck";
            this.btnDeleteDeck.Size = new System.Drawing.Size(310, 37);
            this.btnDeleteDeck.TabIndex = 2;
            this.btnDeleteDeck.Text = "Delete";
            this.btnDeleteDeck.UseVisualStyleBackColor = true;
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPlayGame.Location = new System.Drawing.Point(0, 94);
            this.btnPlayGame.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(310, 38);
            this.btnPlayGame.TabIndex = 1;
            this.btnPlayGame.Text = "Play";
            this.btnPlayGame.UseVisualStyleBackColor = true;
            // 
            // btnEditDeck
            // 
            this.btnEditDeck.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEditDeck.Location = new System.Drawing.Point(0, 132);
            this.btnEditDeck.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditDeck.Name = "btnEditDeck";
            this.btnEditDeck.Size = new System.Drawing.Size(310, 39);
            this.btnEditDeck.TabIndex = 0;
            this.btnEditDeck.Text = "Edit";
            this.btnEditDeck.UseVisualStyleBackColor = true;
            // 
            // DeckControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelMainLayout);
            this.DoubleBuffered = true;
            this.Name = "DeckControl";
            this.Size = new System.Drawing.Size(310, 171);
            this.panelMainLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMainLayout;
        private Button btnDeleteDeck;
        private Button btnPlayGame;
        private Button btnEditDeck;
        private Label labelNumOfCardsInDeck;
        private Label labelDeckName;
    }
}
