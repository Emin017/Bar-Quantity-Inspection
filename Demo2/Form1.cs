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
        HObject ho_image, ho_Rectangle;
        HTuple hv_Number = new HTuple();
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

                    HOperatorSet.GetImageSize(ho_image, out hv_width, out hv_Height);
                    HOperatorSet.SetPart(hWindowControl1.HalconWindow, 0, 0, hv_Height - 1, hv_width - 1);
                    HOperatorSet.DispObj(ho_image, hWindowControl1.HalconWindow);
                }
            }
            catch
            {
                MessageBox.Show("Program Error!");
            }
        }

        private void ROI_Button_Click(object sender, EventArgs e)
        {    
            HTuple hv_Row1 = new HTuple();
            HTuple hv_Column1 = new HTuple(), hv_Row2 = new HTuple();
            HTuple hv_Column2 = new HTuple();
            HOperatorSet.SetDraw(hWindowControl1.HalconWindow, "margin");
            HOperatorSet.SetColor(hWindowControl1.HalconWindow, "red");
            HOperatorSet.DrawRectangle1(hWindowControl1.HalconWindow, out hv_Row1, out hv_Column1, out hv_Row2, 
            out hv_Column2);
            HOperatorSet.GenRectangle1(out ho_Rectangle, hv_Row1, hv_Column1, hv_Row2, hv_Column2);
            HOperatorSet.DispObj(ho_Rectangle, hWindowControl1.HalconWindow);

        }

        private void count_button_Click(object sender, EventArgs e)
        {
            HObject ho_GrayImage, ho_ImageReduced, ho_ImageScaleMax;
            HObject ho_Region1, ho_ConnectedRegions, ho_SelectedRegions, ho_RegionErosion;
            HTuple hv_UsedThreshold = new HTuple();
            HOperatorSet.Rgb1ToGray(ho_image, out ho_GrayImage);
            HOperatorSet.ReduceDomain(ho_GrayImage, ho_Rectangle, out ho_ImageReduced);
            HOperatorSet.ScaleImageMax(ho_ImageReduced, out ho_ImageScaleMax);
            HOperatorSet.BinaryThreshold(ho_ImageScaleMax, out ho_Region1, "max_separability", 
                                        "light", out hv_UsedThreshold);
            HOperatorSet.ErosionCircle(ho_Region1, out ho_RegionErosion, 20);
            HObject ExpTmpOutVar_0;
            HOperatorSet.ErosionCircle(ho_RegionErosion, out ExpTmpOutVar_0, 20);
            ho_Region1 = ExpTmpOutVar_0;

            HOperatorSet.Connection(ho_Region1, out ho_ConnectedRegions);
            HOperatorSet.SelectShape(ho_ConnectedRegions, out ho_SelectedRegions, "area", 
                                    "and", 500, 5000);
            HOperatorSet.CountObj(ho_SelectedRegions, out hv_Number);

            textBox1.Text = hv_Number.ToString();
            HOperatorSet.ClearWindow(hWindowControl1.HalconWindow);
            HOperatorSet.SetDraw(hWindowControl1.HalconWindow, "fill");
            HOperatorSet.DispObj(ho_image, hWindowControl1.HalconWindow);
            HOperatorSet.DispObj(ho_SelectedRegions, hWindowControl1.HalconWindow);

        }
    }
}
