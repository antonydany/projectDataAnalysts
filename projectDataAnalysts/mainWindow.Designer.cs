namespace projectDataAnalysts
{
    partial class MainWindow
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
            this.gridAllData = new System.Windows.Forms.DataGridView();
            this.importCsvBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllData)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAllData
            // 
            this.gridAllData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAllData.Location = new System.Drawing.Point(33, 72);
            this.gridAllData.Name = "gridAllData";
            this.gridAllData.Size = new System.Drawing.Size(722, 315);
            this.gridAllData.TabIndex = 0;
            // 
            // button import csv
            // 
            this.importCsvBtn.Location = new System.Drawing.Point(680, 393);
            this.importCsvBtn.Name = "importCsv";
            this.importCsvBtn.Size = new System.Drawing.Size(75, 23);
            this.importCsvBtn.TabIndex = 1;
            this.importCsvBtn.Text = "Import CSV";
            this.importCsvBtn.UseVisualStyleBackColor = true;
            this.importCsvBtn.Click += new System.EventHandler(this.ImportCsvBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.importCsvBtn);
            this.Controls.Add(this.gridAllData);
            this.Name = "MainWindow";
            this.Text = "projectDataAnalyst";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAllData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAllData;
        private System.Windows.Forms.Button importCsvBtn;
    }
}

