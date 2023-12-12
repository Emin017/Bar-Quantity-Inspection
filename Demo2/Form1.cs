using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;

namespace Demo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        HObject ho_image, ho_GrayImage, ho_ImageScaleMax, ho_Region1;
        HObject ho_RegionErosion;
        private void open_button_Click(object sender, EventArgs e)
        {
            try
            {
                HTuple hv_width = new HTuple(), hv_Height = new HTuple();
                HTuple hv_UsedThreshold = new HTuple();

                string image_Path;
                OpenFileDialog opnDlg = new OpenFileDialog();
                opnDlg.Filter = "All image files |*.bmp;*.jpg;*.gif;*.png";
                if (opnDlg.ShowDialog() == DialogResult.OK)
                {
                    image_Path = opnDlg.FileName;
                    HOperatorSet.ReadImage(out ho_image, image_Path);
                    HOperatorSet.Rgb1ToGray(ho_image, out ho_GrayImage);
                    HOperatorSet.ScaleImageMax(ho_GrayImage, out ho_ImageScaleMax);

                    HOperatorSet.BinaryThreshold(ho_ImageScaleMax, out ho_Region1, "max_separability", 
          "light", out hv_UsedThreshold);
                    HOperatorSet.ErosionCircle(ho_Region1, out ho_RegionErosion, 20);
                    HObject ExpTmpOutVar_0;
                    HOperatorSet.ErosionCircle(ho_RegionErosion, out ExpTmpOutVar_0, 20);
                    ho_Region1 = ExpTmpOutVar_0;

                    HOperatorSet.GetImageSize(ho_image, out hv_width, out hv_Height);
                    HOperatorSet.SetPart(hWindowControl1.HalconWindow, 0, 0, hv_Height - 1, hv_width - 1);
                    HOperatorSet.DispObj(ho_Region1, hWindowControl1.HalconWindow);
                }
            }
            catch
            {
                MessageBox.Show("Program Error!");
            }
        }
    }
}
