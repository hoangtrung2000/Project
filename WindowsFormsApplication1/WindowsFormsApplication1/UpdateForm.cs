using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class UpdateForm : Form
    {
        private int EmployeeId;
        private EmployeeManagement Business;
        public UpdateForm(int id)
        {
            InitializeComponent();
            this.Business = new EmployeeManagement();
            this.EmployeeId = id;
            this.btnCancel.Click += btnCancel_Click;
            this.btnSave.Click += btnSave_Click;
            this.Load += UpdateForm_Load;
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            
        }
        
        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void UpdateForm_Load(object sender, EventArgs e)
        {
            var employee = this.Business.GetEmployee(this.EmployeeId);
            this.txtCode.Text = employee.Code;
            this.txtName.Text = employee.Name;
            this.txtAddress.Text = employee.Address;
            this.cmbLocation.Text = employee.Location;
            this.txtSalary.Text = employee.Salary.ToString();
            
        }
    }
}
