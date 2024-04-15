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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.gridAllData.AllowDrop = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(232)))));
            this.gridAllData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridAllData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.gridAllData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridAllData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAllData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridAllData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAllData.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridAllData.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.gridAllData.Location = new System.Drawing.Point(12, 12);
            this.gridAllData.Name = "gridAllData";
            this.gridAllData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAllData.Size = new System.Drawing.Size(792, 414);
            this.gridAllData.TabIndex = 0;
            this.gridAllData.DragDrop += new System.Windows.Forms.DragEventHandler(this.ImportCsvDropGridData_DragDrop);
            this.gridAllData.DragEnter += new System.Windows.Forms.DragEventHandler(this.ImportCsvDropGridData_DragEnter);
            // 
            // importCsvBtn
            // 
            this.importCsvBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.importCsvBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.importCsvBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importCsvBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.importCsvBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.importCsvBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importCsvBtn.ForeColor = System.Drawing.Color.White;
            this.importCsvBtn.Location = new System.Drawing.Point(321, 9);
            this.importCsvBtn.Name = "importCsvBtn";
            this.importCsvBtn.Size = new System.Drawing.Size(105, 39);
            this.importCsvBtn.TabIndex = 1;
            this.importCsvBtn.Text = "Import CSV";
            this.importCsvBtn.UseVisualStyleBackColor = false;
            this.importCsvBtn.Click += new System.EventHandler(this.ImportCsvBtn_Click);
            // 
            // btnCleanGridData
            // 
            this.btnCleanGridData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCleanGridData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.btnCleanGridData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCleanGridData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.btnCleanGridData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.btnCleanGridData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanGridData.ForeColor = System.Drawing.Color.White;
            this.btnCleanGridData.Location = new System.Drawing.Point(432, 9);
            this.btnCleanGridData.Name = "btnCleanGridData";
            this.btnCleanGridData.Size = new System.Drawing.Size(105, 39);
            this.btnCleanGridData.TabIndex = 2;
            this.btnCleanGridData.Text = "Limpiar";
            this.btnCleanGridData.UseVisualStyleBackColor = false;
            this.btnCleanGridData.Click += new System.EventHandler(this.BtnCleanGridData_Click);
            // 
            // panelMainButtons
            // 
            this.panelMainButtons.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.panelMainButtons.Controls.Add(this.importCsvBtn);
            this.panelMainButtons.Controls.Add(this.btnCleanGridData);
            this.panelMainButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMainButtons.Location = new System.Drawing.Point(0, 432);
            this.panelMainButtons.Name = "panelMainButtons";
            this.panelMainButtons.Size = new System.Drawing.Size(816, 57);
            this.panelMainButtons.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.panelMainButtons);
            this.Controls.Add(this.gridAllData);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
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

