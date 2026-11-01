using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.FolderforModel
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
                    public void Fill(Table_Motorbike motorbike)
        {
            labelIDData.Text = motorbike.ID.ToString();
            labelModelData.Text = motorbike.Model;
            labelBrandData.Text = motorbike.Brand;
            labelPriceData.Text = motorbike.Price.ToString();
            labelHorsepowerData.Text = motorbike.Horsepower.ToString();
            labelMileageData.Text = motorbike.Mileage.ToString();

            string imagePath = System.IO.Path.Combine(Application.StartupPath, "Pictures", motorbike.Picture);

            if (System.IO.File.Exists(imagePath))
            {
                pictureBoxMotorbike.Image = Image.FromFile(imagePath);
            }
            else
            {
                pictureBoxMotorbike.Image = null;
            }
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
