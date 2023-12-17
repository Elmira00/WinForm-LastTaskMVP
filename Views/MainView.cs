using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp16.Model;
using WindowsFormsApp16.Views;

namespace WindowsFormsApp16
{
    public partial class MainView : Form,IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        public EventHandler<EventArgs> ExecuteButtonClick { get; set ; }
        public EventHandler<EventArgs> LitrRadioButtonChecked { get; set; }
        public EventHandler<EventArgs> SumRadioButtonChecked { get; set ; }
        public EventHandler<EventArgs> BenzinCBSelectedIndexChanged { get; set; }

        //BINDINGS
        public List<Benzin> Benzins {
     
            set {
                benzinComboBox.DataSource = null;
                benzinComboBox.Items.AddRange(value.ToArray());
            } }
        public string PriceText { get=>priceTxtb.Text ; set =>priceTxtb.Text=value; }
        public string LitrText { get => litrTxtb.Text; set => litrTxtb.Text = value; }
        public string SumText { get => sumTxtb.Text; set => sumTxtb.Text=value; }
        public string CalculateText { get => sumLbl.Text; set => sumLbl.Text=value; }
        public Benzin selectedBenzin { get=>benzinComboBox.SelectedItem as Benzin;  }

        private void executeBtn_Click(object sender, EventArgs e)
        {
            ExecuteButtonClick.Invoke(sender, e);
        }

        private void litrRbtn_CheckedChanged(object sender, EventArgs e)
        {
            LitrRadioButtonChecked.Invoke(sender, e);
        }

        private void sumRbtn_CheckedChanged(object sender, EventArgs e)
        {
            SumRadioButtonChecked.Invoke(sender, e);
        }

        private void benzinComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BenzinCBSelectedIndexChanged.Invoke(sender, e);
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
