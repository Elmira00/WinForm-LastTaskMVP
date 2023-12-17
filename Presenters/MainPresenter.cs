using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp16.Data;
using WindowsFormsApp16.Model;
using WindowsFormsApp16.Views;

namespace WindowsFormsApp16.Presenters
{
    //elementleri bir birine baglayir, business logic burda yazilir
    public class MainPresenter
    {
        //burda avtomatik aglimiza gelir ki form1'i saxlasin
        //amma bu duz deyil cunki bu(bir formu saxlamaq) agir bir prossesdir
        //form1'in icerisindeki her shey bize burda lazim olmur/olmaya biler
        //ve biz IMainView yaratmishdiq hansi ki onun icersindekiler
        //form1'den goturulen bize lazim olacaq sheyler idi
        //biz de ona gore burda form1 saxlamaqdansa, IMainView saxlayiriq 
        //ve artiq biz burda fomr1i ona gore saxlaya bileceyik ki base'i IMainView'dur

        private readonly IMainView _view;
        private readonly BenzinContext _db;
        //readonly->ancaq constructorun icinde initialize olunsun
        public MainPresenter(IMainView view)
        {
            _view = view;
            _db = new BenzinContext();
            _view.ExecuteButtonClick += ViewExecuteBtnClick;
            _view.SumRadioButtonChecked += ViewSumRBtnChecked;
            _view.LitrRadioButtonChecked += ViewLitrRBtnChecked;
            _view.BenzinCBSelectedIndexChanged += ViewBenzinCBSelectedIndexChanged;
            var benzin1 = new Benzin
            {
                Name="AI-92",
                Price=1
            };
            var benzin2 = new Benzin
            {
                Name="AI-95",
                Price=1.5
            };
            var benzin3 = new Benzin
            {
                Name="AI-98",
                Price=2
            };
            _db.Benzins.Add(benzin1);
            _db.Benzins.Add(benzin2);
            _db.Benzins.Add(benzin3);
            //_db.SaveChanges();
            var benzins = _db.Benzins.ToList();
            _view.Benzins = benzins;
        }

        private void ViewBenzinCBSelectedIndexChanged(object sender, EventArgs e)
        {
            _view.PriceText = _view.selectedBenzin.Price.ToString();
        }

        private void ViewLitrRBtnChecked(object sender, EventArgs e)
        {
           
           _view.SumText = (Convert.ToDouble(_view.PriceText) * Convert.ToDouble(_view.LitrText)).ToString();
             
        }

        private void ViewSumRBtnChecked(object sender, EventArgs e)
        {
         
            _view.LitrText = (Convert.ToDouble(_view.SumText) / Convert.ToDouble(_view.PriceText)).ToString();
        }

        private void ViewExecuteBtnClick(object sender, EventArgs e)
        {
            MessageBox.Show("The process continues");
        }
    }
}
