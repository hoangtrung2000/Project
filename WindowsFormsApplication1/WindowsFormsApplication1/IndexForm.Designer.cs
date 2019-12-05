namespace WindowsFormsApplication1
{
    partial class IndexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexForm));
            this.grdViewAllEmployees = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalary = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewAllEmployees)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdViewAllEmployees
            // 
            this.grdViewAllEmployees.AllowUserToAddRows = false;
            this.grdViewAllEmployees.AllowUserToDeleteRows = false;
            this.grdViewAllEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewAllEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdViewAllEmployees.Location = new System.Drawing.Point(0, 24);
            this.grdViewAllEmployees.Name = "grdViewAllEmployees";
            this.grdViewAllEmployees.ReadOnly = true;
            this.grdViewAllEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdViewAllEmployees.Size = new System.Drawing.Size(284, 237);
            this.grdViewAllEmployees.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreate,
            this.btnDelete,
            this.btnSalary});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnCreate
            // 
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(53, 20);
            this.btnCreate.Text = "Create";
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(52, 20);
            this.btnDelete.Text = "Delete";
            // 
            // btnSalary
            // 
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(50, 20);
            this.btnSalary.Text = "Salary";
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.grdViewAllEmployees);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IndexForm";
            this.Text = "IndexForm";
            ((System.ComponentModel.ISupportInitialize)(this.grdViewAllEmployees)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdViewAllEmployees;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnCreate;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
        private System.Windows.Forms.ToolStripMenuItem btnSalary;
    }
}