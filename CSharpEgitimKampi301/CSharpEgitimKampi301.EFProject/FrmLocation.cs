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
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();    
        }
        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.TBL_LOCATION.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TBL_LOCATION locat = new TBL_LOCATION();
            locat.Capacity = byte.Parse(numericUpDown1.Value.ToString());
            locat.City=txtCity.Text;
            locat.County = txtCountry.Text;
            locat.Price=decimal.Parse(txtPrice.Text);
            locat.DayNight=txtDayNight.Text;
            locat.GuideId =int.Parse(comboBox1.SelectedValue.ToString());

            db.TBL_LOCATION.Add(locat);
            db.SaveChanges();

            MessageBox.Show("Successful adding ...");
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.TBL_GUIDE.Select(x=> new
            {
                FullName=x.GuideName + " " + x.GuideSurname,
                x.GuideId
            }).ToList();
            comboBox1.DisplayMember = "FullName";
            comboBox1.ValueMember = "GuideId";
            comboBox1.DataSource = values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var delete_location = db.TBL_LOCATION.Find(id);
            db.TBL_LOCATION.Remove(delete_location);
            db.SaveChanges();
            MessageBox.Show("Successfull deleting");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var update_location=db.TBL_LOCATION.Find(id);
            update_location.DayNight=txtDayNight.Text;
            update_location.Capacity = byte.Parse(numericUpDown1.Value.ToString());
            update_location.Price = decimal.Parse(txtPrice.Text);
            update_location.City = txtCity.Text;
            update_location.County = txtCountry.Text;
            update_location.GuideId = int.Parse(comboBox1.SelectedValue.ToString());

            db.SaveChanges();
            MessageBox.Show("Successfull Updating");

        }
    }
}
