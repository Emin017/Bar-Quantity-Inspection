﻿using System;
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
            set_display_font(hWindowControl1.HalconWindow, 30, "mono", "true", "false");
            HOperatorSet.SetTposition(hWindowControl1.HalconWindow, 10, 10);
            HOperatorSet.WriteString(hWindowControl1.HalconWindow, "初始数量: "+hv_Number);
        }

        private void add_num_Click(object sender, EventArgs e)
        {
            hv_Number += 1;
            textBox1.Text = hv_Number.ToString();
        }

        private void reduce_num_Click(object sender, EventArgs e)
        {
            hv_Number -= 1;
            if (hv_Number < 0) hv_Number=0;
            textBox1.Text = hv_Number.ToString();
        }

        public void set_display_font (HTuple hv_WindowHandle, HTuple hv_Size, HTuple hv_Font, 
            HTuple hv_Bold, HTuple hv_Slant)
        {
          // Local iconic variables 

          // Local control variables 

            HTuple hv_OS = new HTuple(), hv_Fonts = new HTuple();
            HTuple hv_Style = new HTuple(), hv_Exception = new HTuple();
            HTuple hv_AvailableFonts = new HTuple(), hv_Fdx = new HTuple();
            HTuple hv_Indices = new HTuple();
            HTuple   hv_Font_COPY_INP_TMP = new HTuple(hv_Font);
            HTuple   hv_Size_COPY_INP_TMP = new HTuple(hv_Size);

          // Initialize local and output iconic variables 
          try
          {
            //This procedure sets the text font of the current window with
            //the specified attributes.
            //
            //Input parameters:
            //WindowHandle: The graphics window for which the font will be set
            //Size: The font size. If Size=-1, the default of 16 is used.
            //Bold: If set to 'true', a bold font is used
            //Slant: If set to 'true', a slanted font is used
            //
            hv_OS.Dispose();
            HOperatorSet.GetSystem("operating_system", out hv_OS);
            if ((int)((new HTuple(hv_Size_COPY_INP_TMP.TupleEqual(new HTuple()))).TupleOr(
                new HTuple(hv_Size_COPY_INP_TMP.TupleEqual(-1)))) != 0)
            {
              hv_Size_COPY_INP_TMP.Dispose();
              hv_Size_COPY_INP_TMP = 16;
            }
            if ((int)(new HTuple(((hv_OS.TupleSubstr(0,2))).TupleEqual("Win"))) != 0)
            {
              //Restore previous behaviour
              using (HDevDisposeHelper dh = new HDevDisposeHelper())
              {
              {
              HTuple 
                ExpTmpLocalVar_Size = ((1.13677*hv_Size_COPY_INP_TMP)).TupleInt()
                  ;
              hv_Size_COPY_INP_TMP.Dispose();
              hv_Size_COPY_INP_TMP = ExpTmpLocalVar_Size;
              }
              }
            }
            else
            {
              using (HDevDisposeHelper dh = new HDevDisposeHelper())
              {
              {
              HTuple 
                ExpTmpLocalVar_Size = hv_Size_COPY_INP_TMP.TupleInt()
                  ;
              hv_Size_COPY_INP_TMP.Dispose();
              hv_Size_COPY_INP_TMP = ExpTmpLocalVar_Size;
              }
              }
            }
            if ((int)(new HTuple(hv_Font_COPY_INP_TMP.TupleEqual("Courier"))) != 0)
            {
              hv_Fonts.Dispose();
              hv_Fonts = new HTuple();
              hv_Fonts[0] = "Courier";
              hv_Fonts[1] = "Courier 10 Pitch";
              hv_Fonts[2] = "Courier New";
              hv_Fonts[3] = "CourierNew";
              hv_Fonts[4] = "Liberation Mono";
            }
            else if ((int)(new HTuple(hv_Font_COPY_INP_TMP.TupleEqual("mono"))) != 0)
            {
              hv_Fonts.Dispose();
              hv_Fonts = new HTuple();
              hv_Fonts[0] = "Consolas";
              hv_Fonts[1] = "Menlo";
              hv_Fonts[2] = "Courier";
              hv_Fonts[3] = "Courier 10 Pitch";
              hv_Fonts[4] = "FreeMono";
              hv_Fonts[5] = "Liberation Mono";
            }
            else if ((int)(new HTuple(hv_Font_COPY_INP_TMP.TupleEqual("sans"))) != 0)
            {
              hv_Fonts.Dispose();
              hv_Fonts = new HTuple();
              hv_Fonts[0] = "Luxi Sans";
              hv_Fonts[1] = "DejaVu Sans";
              hv_Fonts[2] = "FreeSans";
              hv_Fonts[3] = "Arial";
              hv_Fonts[4] = "Liberation Sans";
            }
            else if ((int)(new HTuple(hv_Font_COPY_INP_TMP.TupleEqual("serif"))) != 0)
            {
              hv_Fonts.Dispose();
              hv_Fonts = new HTuple();
              hv_Fonts[0] = "Times New Roman";
              hv_Fonts[1] = "Luxi Serif";
              hv_Fonts[2] = "DejaVu Serif";
              hv_Fonts[3] = "FreeSerif";
              hv_Fonts[4] = "Utopia";
              hv_Fonts[5] = "Liberation Serif";
            }
            else
            {
              hv_Fonts.Dispose();
              hv_Fonts = new HTuple(hv_Font_COPY_INP_TMP);
            }
            hv_Style.Dispose();
            hv_Style = "";
            if ((int)(new HTuple(hv_Bold.TupleEqual("true"))) != 0)
            {
              using (HDevDisposeHelper dh = new HDevDisposeHelper())
              {
              {
              HTuple 
                ExpTmpLocalVar_Style = hv_Style+"Bold";
              hv_Style.Dispose();
              hv_Style = ExpTmpLocalVar_Style;
              }
              }
            }
            else if ((int)(new HTuple(hv_Bold.TupleNotEqual("false"))) != 0)
            {
              hv_Exception.Dispose();
              hv_Exception = "Wrong value of control parameter Bold";
              throw new HalconException(hv_Exception);
            }
            if ((int)(new HTuple(hv_Slant.TupleEqual("true"))) != 0)
            {
              using (HDevDisposeHelper dh = new HDevDisposeHelper())
              {
              {
              HTuple 
                ExpTmpLocalVar_Style = hv_Style+"Italic";
              hv_Style.Dispose();
              hv_Style = ExpTmpLocalVar_Style;
              }
              }
            }
            else if ((int)(new HTuple(hv_Slant.TupleNotEqual("false"))) != 0)
            {
              hv_Exception.Dispose();
              hv_Exception = "Wrong value of control parameter Slant";
              throw new HalconException(hv_Exception);
            }
            if ((int)(new HTuple(hv_Style.TupleEqual(""))) != 0)
            {
              hv_Style.Dispose();
              hv_Style = "Normal";
            }
            hv_AvailableFonts.Dispose();
            HOperatorSet.QueryFont(hv_WindowHandle, out hv_AvailableFonts);
            hv_Font_COPY_INP_TMP.Dispose();
            hv_Font_COPY_INP_TMP = "";
            for (hv_Fdx=0; (int)hv_Fdx<=(int)((new HTuple(hv_Fonts.TupleLength()))-1); hv_Fdx = (int)hv_Fdx + 1)
            {
              hv_Indices.Dispose();
              using (HDevDisposeHelper dh = new HDevDisposeHelper())
              {
              hv_Indices = hv_AvailableFonts.TupleFind(
                  hv_Fonts.TupleSelect(hv_Fdx));
              }
              if ((int)(new HTuple((new HTuple(hv_Indices.TupleLength())).TupleGreater(
                  0))) != 0)
              {
                if ((int)(new HTuple(((hv_Indices.TupleSelect(0))).TupleGreaterEqual(0))) != 0)
                {
                  hv_Font_COPY_INP_TMP.Dispose();
                  using (HDevDisposeHelper dh = new HDevDisposeHelper())
                  {
                  hv_Font_COPY_INP_TMP = hv_Fonts.TupleSelect(
                      hv_Fdx);
                  }
                  break;
                }
              }
            }
            if ((int)(new HTuple(hv_Font_COPY_INP_TMP.TupleEqual(""))) != 0)
            {
              throw new HalconException("Wrong value of control parameter Font");
            }
            using (HDevDisposeHelper dh = new HDevDisposeHelper())
            {
                {
                HTuple 
                    ExpTmpLocalVar_Font = (((hv_Font_COPY_INP_TMP+"-")+hv_Style)+"-")+hv_Size_COPY_INP_TMP;
                hv_Font_COPY_INP_TMP.Dispose();
                hv_Font_COPY_INP_TMP = ExpTmpLocalVar_Font;
                }
            }
            HOperatorSet.SetFont(hv_WindowHandle, hv_Font_COPY_INP_TMP);

            hv_Font_COPY_INP_TMP.Dispose();
            hv_Size_COPY_INP_TMP.Dispose();
            hv_OS.Dispose();
            hv_Fonts.Dispose();
            hv_Style.Dispose();
            hv_Exception.Dispose();
            hv_AvailableFonts.Dispose();
            hv_Fdx.Dispose();
            hv_Indices.Dispose();

            return;
            }
            catch (HalconException HDevExpDefaultException)
            {

                hv_Font_COPY_INP_TMP.Dispose();
                hv_Size_COPY_INP_TMP.Dispose();
                hv_OS.Dispose();
                hv_Fonts.Dispose();
                hv_Style.Dispose();
                hv_Exception.Dispose();
                hv_AvailableFonts.Dispose();
                hv_Fdx.Dispose();
                hv_Indices.Dispose();

                throw HDevExpDefaultException;
            }
        }
    }
}
