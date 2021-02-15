
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
            this.tlpMainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tlpButtonContainer = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditDeck = new System.Windows.Forms.Button();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.btnDeleteDeck = new System.Windows.Forms.Button();
            this.tlpLabelsContainer = new System.Windows.Forms.TableLayoutPanel();
            this.labelNumOfCardsInDeck = new System.Windows.Forms.Label();
            this.labelDeckName = new System.Windows.Forms.Label();
            this.tlpMainLayout.SuspendLayout();
            this.tlpButtonContainer.SuspendLayout();
            this.tlpLabelsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMainLayout
            // 
            this.tlpMainLayout.ColumnCount = 1;
            this.tlpMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMainLayout.Controls.Add(this.tlpButtonContainer, 0, 1);
            this.tlpMainLayout.Controls.Add(this.tlpLabelsContainer, 0, 0);
            this.tlpMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpMainLayout.Name = "tlpMainLayout";
            this.tlpMainLayout.RowCount = 2;
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainLayout.Size = new System.Drawing.Size(819, 400);
            this.tlpMainLayout.TabIndex = 0;
            // 
            // tlpButtonContainer
            // 
            this.tlpButtonContainer.ColumnCount = 3;
            this.tlpButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtonContainer.Controls.Add(this.btnEditDeck, 2, 0);
            this.tlpButtonContainer.Controls.Add(this.btnPlayGame, 1, 0);
            this.tlpButtonContainer.Controls.Add(this.btnDeleteDeck, 0, 0);
            this.tlpButtonContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtonContainer.Location = new System.Drawing.Point(3, 203);
            this.tlpButtonContainer.Name = "tlpButtonContainer";
            this.tlpButtonContainer.RowCount = 1;
            this.tlpButtonContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtonContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tlpButtonContainer.Size = new System.Drawing.Size(813, 194);
            this.tlpButtonContainer.TabIndex = 0;
            // 
            // btnEditDeck
            // 
            this.btnEditDeck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditDeck.Location = new System.Drawing.Point(545, 3);
            this.btnEditDeck.Name = "btnEditDeck";
            this.btnEditDeck.Size = new System.Drawing.Size(265, 188);
            this.btnEditDeck.TabIndex = 2;
            this.btnEditDeck.Text = "EDIT";
            this.btnEditDeck.UseVisualStyleBackColor = true;
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlayGame.Location = new System.Drawing.Point(274, 3);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(265, 188);
            this.btnPlayGame.TabIndex = 1;
            this.btnPlayGame.Text = "PLAY";
            this.btnPlayGame.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDeck
            // 
            this.btnDeleteDeck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteDeck.Location = new System.Drawing.Point(3, 3);
            this.btnDeleteDeck.Name = "btnDeleteDeck";
            this.btnDeleteDeck.Size = new System.Drawing.Size(265, 188);
            this.btnDeleteDeck.TabIndex = 0;
            this.btnDeleteDeck.Text = "DEL";
            this.btnDeleteDeck.UseVisualStyleBackColor = true;
            this.btnDeleteDeck.Click += btnDeleteDeck_Click;
            // 
            // tlpLabelsContainer
            // 
            this.tlpLabelsContainer.ColumnCount = 1;
            this.tlpLabelsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLabelsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLabelsContainer.Controls.Add(this.labelNumOfCardsInDeck, 0, 0);
            this.tlpLabelsContainer.Controls.Add(this.labelDeckName, 0, 0);
            this.tlpLabelsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLabelsContainer.Location = new System.Drawing.Point(3, 3);
            this.tlpLabelsContainer.Name = "tlpLabelsContainer";
            this.tlpLabelsContainer.RowCount = 2;
            this.tlpLabelsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLabelsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLabelsContainer.Size = new System.Drawing.Size(813, 194);
            this.tlpLabelsContainer.TabIndex = 1;
            // 
            // labelNumOfCardsInDeck
            // 
            this.labelNumOfCardsInDeck.AutoSize = true;
            this.labelNumOfCardsInDeck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNumOfCardsInDeck.Location = new System.Drawing.Point(3, 97);
            this.labelNumOfCardsInDeck.Name = "labelNumOfCardsInDeck";
            this.labelNumOfCardsInDeck.Size = new System.Drawing.Size(807, 97);
            this.labelNumOfCardsInDeck.TabIndex = 1;
            this.labelNumOfCardsInDeck.Text = "label1";
            this.labelNumOfCardsInDeck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDeckName
            // 
            this.labelDeckName.AutoSize = true;
            this.labelDeckName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDeckName.Location = new System.Drawing.Point(3, 0);
            this.labelDeckName.Name = "labelDeckName";
            this.labelDeckName.Size = new System.Drawing.Size(807, 97);
            this.labelDeckName.TabIndex = 0;
            this.labelDeckName.Text = "label1";
            this.labelDeckName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeckControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMainLayout);
            this.DoubleBuffered = true;
            this.Name = "DeckControl";
            this.Size = new System.Drawing.Size(819, 400);
            this.Load += new System.EventHandler(this.DeckControl_Load);
            this.tlpMainLayout.ResumeLayout(false);
            this.tlpButtonContainer.ResumeLayout(false);
            this.tlpLabelsContainer.ResumeLayout(false);
            this.tlpLabelsContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpMainLayout;
        private TableLayoutPanel tlpButtonContainer;
        private Button btnEditDeck;
        private Button btnPlayGame;
        private Button btnDeleteDeck;
        private TableLayoutPanel tlpLabelsContainer;
        private Label labelNumOfCardsInDeck;
        private Label labelDeckName;
    }
}
