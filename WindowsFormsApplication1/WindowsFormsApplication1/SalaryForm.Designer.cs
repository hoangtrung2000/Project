namespace WindowsFormsApplication1
{
    partial class SalaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryForm));
            this.btnReceive = new System.Windows.Forms.Button();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.lblReceive = new System.Windows.Forms.Label();
            this.lblRaiseSalary = new System.Windows.Forms.Label();
            this.txtRaiseSalary = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblHead = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblAnnual = new System.Windows.Forms.Label();
            this.txtAnnual = new System.Windows.Forms.TextBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReceive
            // 
            this.btnReceive.BackColor = System.Drawing.SystemColors.Window;
            this.btnReceive.Location = new System.Drawing.Point(287, 268);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(75, 23);
            this.btnReceive.TabIndex = 48;
            this.btnReceive.Text = "Compute";
            this.btnReceive.UseVisualStyleBackColor = false;
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(284, 237);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(89, 20);
            this.txtReceive.TabIndex = 47;
            // 
            // lblReceive
            // 
            this.lblReceive.AutoSize = true;
            this.lblReceive.BackColor = System.Drawing.Color.Transparent;
            this.lblReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblReceive.Location = new System.Drawing.Point(186, 235);
            this.lblReceive.Name = "lblReceive";
            this.lblReceive.Size = new System.Drawing.Size(86, 24);
            this.lblReceive.TabIndex = 46;
            this.lblReceive.Text = "Receive";
            // 
            // lblRaiseSalary
            // 
            this.lblRaiseSalary.AutoSize = true;
            this.lblRaiseSalary.BackColor = System.Drawing.Color.Transparent;
            this.lblRaiseSalary.Location = new System.Drawing.Point(274, 135);
            this.lblRaiseSalary.Name = "lblRaiseSalary";
            this.lblRaiseSalary.Size = new System.Drawing.Size(66, 13);
            this.lblRaiseSalary.TabIndex = 45;
            this.lblRaiseSalary.Text = "Raise Salary";
            // 
            // txtRaiseSalary
            // 
            this.txtRaiseSalary.Location = new System.Drawing.Point(273, 153);
            this.txtRaiseSalary.Name = "txtRaiseSalary";
            this.txtRaiseSalary.Size = new System.Drawing.Size(89, 20);
            this.txtRaiseSalary.TabIndex = 44;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.Window;
            this.btnConvert.Location = new System.Drawing.Point(149, 151);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 43;
            this.btnConvert.Text = "Compute";
            this.btnConvert.UseVisualStyleBackColor = false;
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(13, 153);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(78, 20);
            this.txtBonus.TabIndex = 42;
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.BackColor = System.Drawing.Color.Transparent;
            this.lblBonus.Location = new System.Drawing.Point(16, 137);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(37, 13);
            this.lblBonus.TabIndex = 41;
            this.lblBonus.Text = "Bonus";
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.BackColor = System.Drawing.Color.Transparent;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHead.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHead.Location = new System.Drawing.Point(105, 18);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(221, 31);
            this.lblHead.TabIndex = 40;
            this.lblHead.Text = "Salary For Month";
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.SystemColors.Window;
            this.btnCompute.Location = new System.Drawing.Point(173, 82);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 39;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblYear.Location = new System.Drawing.Point(368, 87);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(43, 20);
            this.lblYear.TabIndex = 38;
            this.lblYear.Text = "/year";
            // 
            // lblAnnual
            // 
            this.lblAnnual.AutoSize = true;
            this.lblAnnual.BackColor = System.Drawing.Color.Transparent;
            this.lblAnnual.Location = new System.Drawing.Point(280, 69);
            this.lblAnnual.Name = "lblAnnual";
            this.lblAnnual.Size = new System.Drawing.Size(72, 13);
            this.lblAnnual.TabIndex = 37;
            this.lblAnnual.Text = "Annual Salary";
            // 
            // txtAnnual
            // 
            this.txtAnnual.Location = new System.Drawing.Point(273, 85);
            this.txtAnnual.Name = "txtAnnual";
            this.txtAnnual.Size = new System.Drawing.Size(89, 20);
            this.txtAnnual.TabIndex = 36;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.BackColor = System.Drawing.Color.Transparent;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMonth.Location = new System.Drawing.Point(97, 85);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(58, 20);
            this.lblMonth.TabIndex = 35;
            this.lblMonth.Text = "/month";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(13, 85);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(78, 20);
            this.txt.TabIndex = 34;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.Color.Transparent;
            this.lblSalary.Location = new System.Drawing.Point(16, 68);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(36, 13);
            this.lblSalary.TabIndex = 33;
            this.lblSalary.Text = "Salary";
            // 
            // SalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Group_247;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 303);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.lblReceive);
            this.Controls.Add(this.lblRaiseSalary);
            this.Controls.Add(this.txtRaiseSalary);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtBonus);
            this.Controls.Add(this.lblBonus);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblAnnual);
            this.Controls.Add(this.txtAnnual);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.lblSalary);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalaryForm";
            this.Text = "SalaryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Label lblReceive;
        private System.Windows.Forms.Label lblRaiseSalary;
        private System.Windows.Forms.TextBox txtRaiseSalary;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblAnnual;
        private System.Windows.Forms.TextBox txtAnnual;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label lblSalary;
    }
}