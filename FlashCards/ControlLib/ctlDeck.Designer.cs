namespace ControlLib
{
    partial class ctlDeck
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNumOfCards = new System.Windows.Forms.Label();
            this.labelDeckName = new System.Windows.Forms.Label();
            this.btnEditDeck = new System.Windows.Forms.Button();
            this.btnDeleteDeck = new System.Windows.Forms.Button();
            this.btnPlayDeck = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnPlayDeck);
            this.panel1.Controls.Add(this.labelNumOfCards);
            this.panel1.Controls.Add(this.labelDeckName);
            this.panel1.Controls.Add(this.btnEditDeck);
            this.panel1.Controls.Add(this.btnDeleteDeck);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 154);
            this.panel1.TabIndex = 0;
            // 
            // labelNumOfCards
            // 
            this.labelNumOfCards.AutoSize = true;
            this.labelNumOfCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumOfCards.Location = new System.Drawing.Point(83, 49);
            this.labelNumOfCards.Name = "labelNumOfCards";
            this.labelNumOfCards.Size = new System.Drawing.Size(51, 20);
            this.labelNumOfCards.TabIndex = 3;
            this.labelNumOfCards.Text = "label2";
            // 
            // labelDeckName
            // 
            this.labelDeckName.AutoSize = true;
            this.labelDeckName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeckName.Location = new System.Drawing.Point(83, 9);
            this.labelDeckName.Name = "labelDeckName";
            this.labelDeckName.Size = new System.Drawing.Size(51, 20);
            this.labelDeckName.TabIndex = 2;
            this.labelDeckName.Text = "label1";
            // 
            // btnEditDeck
            // 
            this.btnEditDeck.Location = new System.Drawing.Point(78, 104);
            this.btnEditDeck.Name = "btnEditDeck";
            this.btnEditDeck.Size = new System.Drawing.Size(64, 27);
            this.btnEditDeck.TabIndex = 1;
            this.btnEditDeck.Text = "EDIT";
            this.btnEditDeck.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDeck
            // 
            this.btnDeleteDeck.Location = new System.Drawing.Point(3, 104);
            this.btnDeleteDeck.Name = "btnDeleteDeck";
            this.btnDeleteDeck.Size = new System.Drawing.Size(57, 27);
            this.btnDeleteDeck.TabIndex = 0;
            this.btnDeleteDeck.Text = "DEL";
            this.btnDeleteDeck.UseVisualStyleBackColor = true;
            // 
            // btnPlayDeck
            // 
            this.btnPlayDeck.Location = new System.Drawing.Point(160, 104);
            this.btnPlayDeck.Name = "btnPlayDeck";
            this.btnPlayDeck.Size = new System.Drawing.Size(55, 27);
            this.btnPlayDeck.TabIndex = 4;
            this.btnPlayDeck.Text = "PLAY";
            this.btnPlayDeck.UseVisualStyleBackColor = true;
            // 
            // ctlDeck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ctlDeck";
            this.Size = new System.Drawing.Size(224, 160);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNumOfCards;
        private System.Windows.Forms.Label labelDeckName;
        private System.Windows.Forms.Button btnEditDeck;
        private System.Windows.Forms.Button btnDeleteDeck;
        private System.Windows.Forms.Button btnPlayDeck;
    }
}
