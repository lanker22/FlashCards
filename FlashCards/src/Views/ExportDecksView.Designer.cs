
using System;

namespace src.Views
{
    partial class ExportDecksView
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
            this.textboxFileLocation = new System.Windows.Forms.TextBox();
            this.btnBrowseFilesystem = new System.Windows.Forms.Button();
            this.textboxFileName = new System.Windows.Forms.TextBox();
            this.btnCreateExcelFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textboxFileLocation
            // 
            this.textboxFileLocation.Location = new System.Drawing.Point(12, 32);
            this.textboxFileLocation.Name = "textboxFileLocation";
            this.textboxFileLocation.ReadOnly = true;
            this.textboxFileLocation.Size = new System.Drawing.Size(368, 23);
            this.textboxFileLocation.TabIndex = 0;
            // 
            // btnBrowseFilesystem
            // 
            this.btnBrowseFilesystem.Location = new System.Drawing.Point(410, 32);
            this.btnBrowseFilesystem.Name = "btnBrowseFilesystem";
            this.btnBrowseFilesystem.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFilesystem.TabIndex = 1;
            this.btnBrowseFilesystem.Text = "Browse";
            this.btnBrowseFilesystem.UseVisualStyleBackColor = true;
            // 
            // textboxFileName
            // 
            this.textboxFileName.Location = new System.Drawing.Point(12, 91);
            this.textboxFileName.Name = "textboxFileName";
            this.textboxFileName.PlaceholderText = "Choose a filename";
            this.textboxFileName.Size = new System.Drawing.Size(368, 23);
            this.textboxFileName.TabIndex = 2;
            // 
            // btnCreateExcelFile
            // 
            this.btnCreateExcelFile.Location = new System.Drawing.Point(522, 32);
            this.btnCreateExcelFile.Name = "btnCreateExcelFile";
            this.btnCreateExcelFile.Size = new System.Drawing.Size(75, 23);
            this.btnCreateExcelFile.TabIndex = 3;
            this.btnCreateExcelFile.Text = "Create";
            this.btnCreateExcelFile.UseVisualStyleBackColor = true;
            // 
            // ExportDecksView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 175);
            this.Controls.Add(this.btnCreateExcelFile);
            this.Controls.Add(this.textboxFileName);
            this.Controls.Add(this.btnBrowseFilesystem);
            this.Controls.Add(this.textboxFileLocation);
            this.Name = "ExportDecksView";
            this.Text = "ExportDecksView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxFileLocation;
        private System.Windows.Forms.Button btnBrowseFilesystem;
        private System.Windows.Forms.TextBox textboxFileName;
        private System.Windows.Forms.Button btnCreateExcelFile;
    }
}