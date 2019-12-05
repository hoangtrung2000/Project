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
    public partial class CreateForm : Form
    {
        private EmployeeManagement Business;
        public CreateForm()
        {
            InitializeComponent();
            this.Business = new EmployeeManagement();
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;

        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var code = this.txtCode.Text;
            var name = this.txtName.Text;
            var birthday = this.dtp.Value;
            var address = this.txtAddress.Text;
            var location = this.cmbLocation.Text;
            int salary = Int32.Parse(this.txtSalary.Text);
            this.Business.AddEmployee(code, name, birthday, address, location, salary);
            MessageBox.Show("Create employee successfull");
            this.Close();


        }
    }
}
