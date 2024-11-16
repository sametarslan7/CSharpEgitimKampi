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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.TBL_GUIDE.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TBL_GUIDE guide= new TBL_GUIDE();
            guide.GuideName=txtName.Text;
            guide.GuideSurname=txtSurname.Text;
            db.TBL_GUIDE.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Adding succesfull");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id =int.Parse(txtId.Text);
            var remove_value = db.TBL_GUIDE.Find(id);
            db.TBL_GUIDE.Remove(remove_value);
            db.SaveChanges();
            MessageBox.Show("Deleting succesfull");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtId.Text);
            var update_value = db.TBL_GUIDE.Find(id);
            update_value.GuideName=txtName.Text;
            update_value.GuideSurname= txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("updating succesfull","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = db.TBL_GUIDE.Where(x => x.GuideId == id).ToList();
            dataGridView1.DataSource = values;
        }
    }
} 
