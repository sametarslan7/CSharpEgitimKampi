using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        EgitimKampiEFTravelDbEntities db=new EgitimKampiEFTravelDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.TBL_CUSTOMER.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TBL_CUSTOMER customer=new TBL_CUSTOMER();
            customer.CustomerName = txtName.Text;
            customer.CustomerSurname= txtSurname.Text;
            customer.CustomerBalance=decimal.Parse(txtBalance.Text);
            db.TBL_CUSTOMER.Add(customer);
            db.SaveChanges();
            MessageBox.Show("Customer adding is succesfull.");
            txtName.Text = "";
            txtSurname.Text = "";
            txtBalance.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtId.Text);
            var remove = db.TBL_CUSTOMER.Find(id);
            db.TBL_CUSTOMER.Remove(remove);
            db.SaveChanges();
            MessageBox.Show("customer deleting is succesfull.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updatevalue = db.TBL_CUSTOMER.Find(id);
            updatevalue.CustomerName= txtName.Text;
            updatevalue.CustomerSurname= txtSurname.Text;
            updatevalue.CustomerBalance=decimal.Parse(txtBalance.Text);
            db.SaveChanges();
            MessageBox.Show("customer updating is succesfull.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtName.Text = "";
            txtSurname.Text = "";
            txtBalance.Text = "";
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtId.Text);
            var values = db.TBL_CUSTOMER.Where(x => x.CustomerId == id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
