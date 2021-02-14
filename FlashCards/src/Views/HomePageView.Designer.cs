
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
            this.tlpAllDecks = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExportDecks = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewStats = new System.Windows.Forms.Button();
            this.deckControl2 = new src.Controls.DeckControl();
            this.deckControl3 = new src.Controls.DeckControl();
            this.deckControl1 = new src.Controls.DeckControl();
            this.tlpAllDecks.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpAllDecks
            // 
            this.tlpAllDecks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpAllDecks.AutoSize = true;
            this.tlpAllDecks.ColumnCount = 5;
            this.tlpAllDecks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAllDecks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAllDecks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAllDecks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAllDecks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAllDecks.Controls.Add(this.deckControl2, 1, 0);
            this.tlpAllDecks.Controls.Add(this.deckControl3, 2, 0);
            this.tlpAllDecks.Controls.Add(this.deckControl1, 0, 0);
            this.tlpAllDecks.Location = new System.Drawing.Point(3, 67);
            this.tlpAllDecks.Name = "tlpAllDecks";
            this.tlpAllDecks.RowCount = 1;
            this.tlpAllDecks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAllDecks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.tlpAllDecks.Size = new System.Drawing.Size(1988, 215);
            this.tlpAllDecks.TabIndex = 0;
            this.tlpAllDecks.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpAllDecks_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tlpAllDecks, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1994, 663);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(145, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Deck";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnExportDecks
            // 
            this.btnExportDecks.AutoSize = true;
            this.btnExportDecks.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExportDecks.Location = new System.Drawing.Point(0, 0);
            this.btnExportDecks.Name = "btnExportDecks";
            this.btnExportDecks.Size = new System.Drawing.Size(145, 58);
            this.btnExportDecks.TabIndex = 3;
            this.btnExportDecks.Text = "Export Decks";
            this.btnExportDecks.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnViewStats);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnExportDecks);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1988, 58);
            this.panel1.TabIndex = 3;
            // 
            // btnViewStats
            // 
            this.btnViewStats.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnViewStats.Location = new System.Drawing.Point(290, 0);
            this.btnViewStats.Name = "btnViewStats";
            this.btnViewStats.Size = new System.Drawing.Size(145, 58);
            this.btnViewStats.TabIndex = 4;
            this.btnViewStats.Text = "View Stats";
            this.btnViewStats.UseVisualStyleBackColor = true;
            // 
            // deckControl2
            // 
            this.deckControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deckControl2.Location = new System.Drawing.Point(401, 4);
            this.deckControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deckControl2.Name = "deckControl2";
            this.deckControl2.Size = new System.Drawing.Size(389, 207);
            this.deckControl2.TabIndex = 1;
            // 
            // deckControl3
            // 
            this.deckControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deckControl3.Location = new System.Drawing.Point(798, 4);
            this.deckControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deckControl3.Name = "deckControl3";
            this.deckControl3.Size = new System.Drawing.Size(389, 207);
            this.deckControl3.TabIndex = 2;
            // 
            // deckControl1
            // 
            this.deckControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deckControl1.Location = new System.Drawing.Point(4, 4);
            this.deckControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deckControl1.Name = "deckControl1";
            this.deckControl1.Size = new System.Drawing.Size(389, 207);
            this.deckControl1.TabIndex = 3;
            // 
            // HomePageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1996, 665);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "HomePageView";
            this.Text = "HomePageView";
            this.tlpAllDecks.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAllDecks;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controls.DeckControl deckControl2;
        private Controls.DeckControl deckControl3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewStats;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExportDecks;
        private Controls.DeckControl deckControl1;
    }
}