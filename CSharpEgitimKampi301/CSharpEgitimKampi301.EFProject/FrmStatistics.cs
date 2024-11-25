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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            #region Location Count
            lblLocation.Text=db.TBL_LOCATION.Count().ToString();
            #endregion

            #region Capacity Sum
            lblSumCapacity.Text = db.TBL_LOCATION.Sum(x => x.Capacity).ToString();
            #endregion

            #region Guide Count 
            lblRehber.Text=db.TBL_GUIDE.Count().ToString();
            #endregion

            #region Average Capacity
            lblOrtalamaKapasite.Text = db.TBL_LOCATION.Average(x => x.Capacity).ToString();
            #endregion

            #region Average Tour Price
            lblOrtalamaTurFiyatı.Text = (Math.Round((double)db.TBL_LOCATION.Average(x => x.Price), 2)).ToString("F2") + " ₺";
            #endregion

            #region Last Country
            int locationId = db.TBL_LOCATION.Max(x => x.LocationId);
            lblSonUlke.Text = db.TBL_LOCATION.Where(x => x.LocationId == locationId).Select(y=>y.County).FirstOrDefault();
            #endregion

            #region Kapadokya Tour Capacity
            lblKapadokyaKapasite.Text = db.TBL_LOCATION.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();
            #endregion

            #region Turkey Average Tour Capacity
            lblTurkiyeOrtalamaKapasite.Text=db.TBL_LOCATION.Where(x=>x.County=="Turkey").Average(y=>y.Capacity).ToString();
            #endregion

            #region Guide Name for Roma Tour
            var romeGuideId = db.TBL_LOCATION.Where(x => x.City == "Roma").Select(y => y.GuideId).FirstOrDefault();
            lblRomaRehberAdi.Text = db.TBL_GUIDE.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault();
            #endregion

            #region Max Capacity Tour
            var maxCapactiy = db.TBL_LOCATION.Max(x => x.Capacity);
            lblEnYuksekKapasiteliTur.Text = db.TBL_LOCATION.Where(x => x.Capacity == maxCapactiy).Select(y => y.City).FirstOrDefault().ToString();
            #endregion

            #region Max Price Tour
            var maxPrice = db.TBL_LOCATION.Max(x => x.Price);
            lblEnPahalitur.Text = db.TBL_LOCATION.Where(x => x.Price == maxPrice).Select(y => y.City).FirstOrDefault().ToString();
            #endregion

            #region Ayşegül Çınar's Tour Count
            int guideId = int.Parse(db.TBL_GUIDE.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y=>y.GuideId).FirstOrDefault().ToString());
            lblAysegulCinarTurSayisi.Text=db.TBL_LOCATION.Where(x=>x.GuideId==guideId).Count().ToString();
            #endregion

        }
    }
}
