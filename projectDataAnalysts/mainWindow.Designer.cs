using System.Windows.Forms;

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
            this.btnCleanGridData = new System.Windows.Forms.Button();
            this.panelMainButtons = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllData)).BeginInit();
            this.panelMainButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridAllData
            // 
            this.gridAllData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAllData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAllData.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridAllData.Location = new System.Drawing.Point(12, 12);
            this.gridAllData.Name = "gridAllData";
            this.gridAllData.Size = new System.Drawing.Size(776, 375);
            this.gridAllData.TabIndex = 0;
            this.gridAllData.AllowDrop = true;
            this.gridAllData.DragEnter += new DragEventHandler(this.ImportCsvDropGridData_DragEnter);
            this.gridAllData.DragDrop += new DragEventHandler(this.ImportCsvDropGridData_DragDrop);
            // 
            // importCsvBtn
            // 
            this.importCsvBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.importCsvBtn.Location = new System.Drawing.Point(301, 3);
            this.importCsvBtn.Name = "importCsvBtn";
            this.importCsvBtn.Size = new System.Drawing.Size(105, 39);
            this.importCsvBtn.TabIndex = 1;
            this.importCsvBtn.Text = "Import CSV";
            this.importCsvBtn.UseVisualStyleBackColor = true;
            this.importCsvBtn.Click += new System.EventHandler(this.ImportCsvBtn_Click);
            // 
            // btnCleanGridData
            // 
            this.btnCleanGridData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCleanGridData.Location = new System.Drawing.Point(412, 3);
            this.btnCleanGridData.Name = "btnCleanGridData";
            this.btnCleanGridData.Size = new System.Drawing.Size(105, 39);
            this.btnCleanGridData.TabIndex = 2;
            this.btnCleanGridData.Text = "Limpiar";
            this.btnCleanGridData.UseVisualStyleBackColor = true;
            this.btnCleanGridData.Click += new System.EventHandler(this.BtnCleanGridData_Click);
            // 
            // panelMainButtons
            // 
            this.panelMainButtons.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.panelMainButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMainButtons.Controls.Add(this.importCsvBtn);
            this.panelMainButtons.Controls.Add(this.btnCleanGridData);
            this.panelMainButtons.Location = new System.Drawing.Point(12, 393);
            this.panelMainButtons.Name = "panelMainButtons";
            this.panelMainButtons.Size = new System.Drawing.Size(776, 45);
            this.panelMainButtons.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMainButtons);
            this.Controls.Add(this.gridAllData);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainWindow";
            this.Text = "projectDataAnalyst";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAllData)).EndInit();
            this.panelMainButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAllData;
        private System.Windows.Forms.Button importCsvBtn;
        private System.Windows.Forms.Button btnCleanGridData;
        private System.Windows.Forms.Panel panelMainButtons;
    }
}

