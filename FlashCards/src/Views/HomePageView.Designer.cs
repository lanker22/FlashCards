
namespace src.Views
{
    partial class HomePageView
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
            this.tlpMainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.btnViewStats = new System.Windows.Forms.Button();
            this.btnAddDeck = new System.Windows.Forms.Button();
            this.btnExportDecks = new System.Windows.Forms.Button();
            this.tlpListOfDecks = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMainLayoutPanel.SuspendLayout();
            this.panelToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMainLayoutPanel
            // 
            this.tlpMainLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMainLayoutPanel.ColumnCount = 1;
            this.tlpMainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMainLayoutPanel.Controls.Add(this.panelToolbar, 0, 0);
            this.tlpMainLayoutPanel.Controls.Add(this.tlpListOfDecks, 0, 1);
            this.tlpMainLayoutPanel.Location = new System.Drawing.Point(0, -1);
            this.tlpMainLayoutPanel.Name = "tlpMainLayoutPanel";
            this.tlpMainLayoutPanel.RowCount = 3;
            this.tlpMainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpMainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMainLayoutPanel.Size = new System.Drawing.Size(1368, 629);
            this.tlpMainLayoutPanel.TabIndex = 1;
            // 
            // panelToolbar
            // 
            this.panelToolbar.Controls.Add(this.btnViewStats);
            this.panelToolbar.Controls.Add(this.btnAddDeck);
            this.panelToolbar.Controls.Add(this.btnExportDecks);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelToolbar.Location = new System.Drawing.Point(3, 3);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(1362, 54);
            this.panelToolbar.TabIndex = 3;
            // 
            // btnViewStats
            // 
            this.btnViewStats.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnViewStats.Location = new System.Drawing.Point(290, 0);
            this.btnViewStats.Name = "btnViewStats";
            this.btnViewStats.Size = new System.Drawing.Size(145, 54);
            this.btnViewStats.TabIndex = 4;
            this.btnViewStats.Text = "View Stats";
            this.btnViewStats.UseVisualStyleBackColor = true;
            // 
            // btnAddDeck
            // 
            this.btnAddDeck.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddDeck.Location = new System.Drawing.Point(145, 0);
            this.btnAddDeck.Name = "btnAddDeck";
            this.btnAddDeck.Size = new System.Drawing.Size(145, 54);
            this.btnAddDeck.TabIndex = 2;
            this.btnAddDeck.Text = "Add Deck";
            this.btnAddDeck.UseVisualStyleBackColor = true;
            // 
            // btnExportDecks
            // 
            this.btnExportDecks.AutoSize = true;
            this.btnExportDecks.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExportDecks.Location = new System.Drawing.Point(0, 0);
            this.btnExportDecks.Name = "btnExportDecks";
            this.btnExportDecks.Size = new System.Drawing.Size(145, 54);
            this.btnExportDecks.TabIndex = 3;
            this.btnExportDecks.Text = "Export Decks";
            this.btnExportDecks.UseVisualStyleBackColor = true;
            // 
            // tlpListOfDecks
            // 
            this.tlpListOfDecks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpListOfDecks.ColumnCount = 10;
            this.tlpListOfDecks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpListOfDecks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpListOfDecks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpListOfDecks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpListOfDecks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpListOfDecks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpListOfDecks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpListOfDecks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpListOfDecks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpListOfDecks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpListOfDecks.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlpListOfDecks.Location = new System.Drawing.Point(3, 63);
            this.tlpListOfDecks.Name = "tlpListOfDecks";
            this.tlpListOfDecks.RowCount = 1;
            this.tlpListOfDecks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpListOfDecks.Size = new System.Drawing.Size(1362, 135);
            this.tlpListOfDecks.TabIndex = 4;
            // 
            // HomePageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1370, 631);
            this.Controls.Add(this.tlpMainLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "HomePageView";
            this.Text = "HomePageView";
            this.tlpMainLayoutPanel.ResumeLayout(false);
            this.panelToolbar.ResumeLayout(false);
            this.panelToolbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpMainLayoutPanel;
        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.Button btnViewStats;
        private System.Windows.Forms.Button btnAddDeck;
        private System.Windows.Forms.Button btnExportDecks;
        private System.Windows.Forms.TableLayoutPanel tlpListOfDecks;
        private Controls.DeckControl deckControl1;
    }
}