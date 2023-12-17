using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp16.Model;

namespace WindowsFormsApp16.Views
{
    //burda view'da olan butun elementlerin backSide'ini yaziriq
    public interface IMainView
    {
        EventHandler<EventArgs> ExecuteButtonClick { get; set; }
        EventHandler<EventArgs> LitrRadioButtonChecked { get; set; }
        EventHandler<EventArgs> SumRadioButtonChecked { get; set; }
        EventHandler<EventArgs> BenzinCBSelectedIndexChanged { get; set; }

        Benzin selectedBenzin { get;  }
        List<Benzin> Benzins {  set; }
        string PriceText { get; set; }
        string LitrText { get; set; }
        string SumText { get; set; }
        string CalculateText { get; set; }

    }
}
