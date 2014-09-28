using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInfoWithUserDefineTypeApp
{
    public partial class EmployeeInfoFormUI : Form
    {
        public EmployeeInfoFormUI()
        {
            InitializeComponent();
        }

   Employee anEmployee=new Employee();
        private void saveButton_Click(object sender, EventArgs e)
        {

            anEmployee.id = idTextBox.Text;
            anEmployee.name = nameTextBox.Text;
            anEmployee.salary = Convert.ToDouble(salaryTextBox.Text);
                MessageBox.Show(@"Information Saved Successfully");

                idTextBox.Text = "";
                nameTextBox.Text = "";
                salaryTextBox.Text = "";
          

        }

        private void retriveButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = anEmployee.id;
            nameTextBox.Text = anEmployee.name;
            salaryTextBox.Text = anEmployee.salary.ToString();
            MessageBox.Show(@"Information Retrive Successfully");

        }

      

    }
}
