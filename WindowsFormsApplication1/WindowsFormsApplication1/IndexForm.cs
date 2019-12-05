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
    public partial class IndexForm : Form
    {
        private EmployeeManagement Business;
        public IndexForm()
        {
            InitializeComponent();
            this.Business = new EmployeeManagement();
            this.Load += IndexForm_Load;
            this.btnCreate.Click += btnCreate_Click;
            this.btnDelete.Click += btnDelete_Click;
            this.btnSalary.Click += btnSalary_Click;
            this.grdViewAllEmployees.DoubleClick += grdViewAllEmployees_DoubleClick;
        }

        void grdViewAllEmployees_DoubleClick(object sender, EventArgs e)
        {
       
        }

        void btnSalary_Click(object sender, EventArgs e)
        {
           
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
           if(this.grdViewAllEmployees.SelectedRows.Count ==1)
           {
               if (MessageBox.Show("Do you want delete this?", "Confirm", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
               {
                   var employee = (Employee)this.grdViewAllEmployees.SelectedRows[0].DataBoundItem;
                   this.Business.DeleteEmployee(employee.id);
                   MessageBox.Show("Delete employee successfully");
                   this.LoadAllEmployees();
               }
           }
        }

        void btnCreate_Click(object sender, EventArgs e)
        {
            var form = new CreateForm();
            form.ShowDialog();
            this.LoadAllEmployees();
        }

        void IndexForm_Load(object sender, EventArgs e)
        {
            this.LoadAllEmployees();
        }
        void LoadAllEmployees()
        {
            var employees = this.Business.GetEmployees();
            this.grdViewAllEmployees.DataSource = employees;
        }
    }
}
