using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public void Fi11 (Table_Motobike Motobike)
        {
            labelIDData.Text = Motobike.ID.ToString();
            labelModelData.Text = Motobike.Model;
            labelBrandData.Text = Motobike.Brand;
            labelPriceData.Text = Motobike.Price.ToString();
            labelHorsepowerData.Text = Motobike.Horsepower.ToString();
            labelMileageData.Text = Motobike.Mileage.ToString();
            pictureBox1.Image = Image.FromFile($@"Pictures\{Motobike.Picture}");
        }
    }
}
