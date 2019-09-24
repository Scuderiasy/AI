using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.CvEnum;

using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;
using xc = Microsoft.Office.Interop.Excel;

namespace AI_Image_Recognition
{
    public partial class Form1 : Form
    {
        private Capture Pic_Capture;
        private Image<Bgr, Byte> ImageFrame;
        private Image<Bgr, Byte> ImageFram2;
        Rectangle area;
        Rectangle area2;

        int countour_cnt, countour_choose = -1;
        int[,] point = new int[151, 4];
        int img_roi_section_x, img_roi_section_y, img_begin_x, img_begin_y, sum_contour_area;
        double pattern_threshold_1 = 0.15, pattern_threshold_2 = 0.8;
        string[] pattern_recognition = new string[10];
        string dectected_pattern, read_pattern;
        string[] bb;

        xc.Application excelApp;
        xc.Workbook excelWorkbook;
        xc.Worksheet excelWorkSheet;
        xc.Sheets excelSheets;
        xc.Range excelCell;

        xc.Application excel_DB;
        xc.Workbook excel_DB_excelWorkbook;
        xc.Worksheet excel_DB_excelWorkSheet;
        xc.Sheets excel_DB_excelSheets;
        xc.Range excel_DB_excelCell;

        List<TextBox> TextBoxs = new List<TextBox>();
        List<PictureBox> pictureBoxes = new List<PictureBox>();


        public Form1()
        {
            InitializeComponent();

            Control[] matches;
            for (int i = 1; i <= 9; i++)
            {
                matches = this.Controls.Find("textBox" + i.ToString(), true);
                if (matches.Length > 0 && matches[0] is TextBox)
                {
                    TextBoxs.Add((TextBox)matches[0]);
                }
            }

            Control[] matches2;
            for (int i = 4; i <= 12; i++)
            {
                matches2 = this.Controls.Find("pictureBox" + i.ToString(), true);
                if (matches2.Length > 0 && matches2[0] is PictureBox)
                {
                    pictureBoxes.Add((PictureBox)matches2[0]);
                }
            }

            excelApp = new xc.Application();
            excelApp.Visible = true;
            excelWorkbook = excelApp.Workbooks.Add();
            excelSheets = excelWorkbook.Worksheets;
            excelWorkSheet = excelSheets.get_Item("Sheet1");
            excelCell = excelWorkSheet.UsedRange;

            string path = Directory.GetCurrentDirectory();

            excel_DB = new xc.Application();
            excel_DB.Visible = true;
            excel_DB_excelWorkbook = excel_DB.Workbooks.Open(path + "/pattern recognition");
            excel_DB_excelSheets = excel_DB_excelWorkbook.Worksheets;
            excel_DB_excelWorkSheet = excel_DB_excelSheets.get_Item("Sheet1");
            excel_DB_excelCell = excel_DB_excelWorkSheet.UsedRange;

            for (int x = 0; x <= 9; x++)
            {
                for (int r = 1; r <= 9; r++)
                {
                    read_pattern += excel_DB_excelWorkSheet.Cells[x + 1, r].Value;
                }
                pattern_recognition[x] = read_pattern;
                // listBox1.Items.Add(read_pattern);
                read_pattern = "";
            }
        }

        private void picture_dragdrop(object sender, DragEventArgs e)
        {

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                string list_address = file;
                string fileName = Path.GetFileNameWithoutExtension(file);

                Pic_Capture = new Capture(list_address);
                ImageFrame = Pic_Capture.QueryFrame();
                ImageFram2 = new Image<Bgr, Byte>(ImageFrame.Width, ImageFrame.Height);  ///////////// สร้างตัวแปรรูปภาพในระบบสี binary
                CvInvoke.cvCopy(ImageFrame, ImageFram2, System.IntPtr.Zero);
                pictureBox1.BackgroundImage = ImageFrame.ToBitmap(pictureBox1.Width, pictureBox1.Height);

            }

        }

        private void picture_dragenter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void prev_button_Click(object sender, EventArgs e)
        {

            countour_choose--;
            if (countour_choose < 0)
            {
                countour_choose = 0;
            }

            bb = listBox1.Items[countour_choose].ToString().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

            textBox11.Text = bb[0] + "," + bb[1] + "," + bb[2] + "," + bb[3];

            Application.Idle += find_roi;
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            countour_choose++;
            if (countour_choose > countour_cnt - 1)
            {
                countour_choose = countour_cnt - 1;
            }

            bb = listBox1.Items[countour_choose].ToString().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

            textBox11.Text = bb[0] + "," + bb[1] + "," + bb[2] + "," + bb[3];

            Application.Idle += find_roi;
        }

        private void img_processing(object sender, EventArgs e)
        {
            Image<Gray, Byte> GrayImage = ImageFrame.Convert<Gray, Byte>();

            Image<Gray, Byte> cannyEdges = GrayImage.Canny(new Gray(180), new Gray(120));

            Image<Gray, Byte> Contour = new Image<Gray, byte>(GrayImage.Width, GrayImage.Height);  ///////////// สร้างตัวแปรรูปภาพสำหรับหา contour

            CvInvoke.cvCopy(cannyEdges, Contour, System.IntPtr.Zero);

            IntPtr storage = CvInvoke.cvCreateMemStorage(0);

            IntPtr contour = new IntPtr();

            CvInvoke.cvFindContours(Contour, storage, ref contour, System.Runtime.InteropServices.Marshal.SizeOf(typeof(MCvContour)), Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_EXTERNAL, Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_NONE, new Point(0, 0));   //////  หา contour

            Seq<Point> seq = new Seq<Point>(contour, null);    /////////////  เก็บข้อมูลของ  contour  ที่ค้นหา

            countour_cnt = 0;
            listBox1.Items.Clear();

            for (; seq != null && seq.Ptr.ToInt32() != 0; seq = seq.HNext)
            {

                Rectangle bndRec = CvInvoke.cvBoundingRect(seq, 1);  ////  คำนวณความกว้าง สูงชอง contour

                double Contour_area_cal = CvInvoke.cvContourArea(seq, MCvSlice.WholeSeq, 1) * -1;   ////  คำนวณพื้นที่ชอง contour

                if (Contour_area_cal >= 50)
                {
                    countour_cnt++;

                    CvInvoke.cvRectangle(ImageFrame, new Point(bndRec.X, bndRec.Y), new Point(bndRec.X + bndRec.Width, bndRec.Y + bndRec.Height), new MCvScalar(0, 0, 255), 2, LINE_TYPE.CV_AA, 0);   //////////   วาดสี่เหลี่ยม ล้อมรอบ contour โดยใช้ตำแหน่งที่หาจากข้างบน
                    listBox1.Items.Add(bndRec.X + "," + bndRec.Y + "," + bndRec.Width + "," + bndRec.Height);

                    img_roi_section_x = bndRec.Width / 3;
                    img_roi_section_y = bndRec.Height / 3;
                    img_begin_x = bndRec.X;
                    img_begin_y = bndRec.Y;

                    ImageFram2.ROI = Rectangle.Empty;
                    area = new Rectangle(bndRec.X, bndRec.Y, bndRec.Width, bndRec.Height);  // set the roi
                    ImageFram2.ROI = area;
                    pictureBox3.Image = ImageFram2.ToBitmap(pictureBox3.Width, pictureBox3.Height);


                    for (int i = 0; i <= 2; i++)
                    {
                        for (int j = 0; j <= 2; j++)
                        {

                            area2 = new Rectangle(img_begin_x + (i * img_roi_section_x), img_begin_y + (j * img_roi_section_y), img_roi_section_x, img_roi_section_y);  // set the roi
                            ImageFram2.ROI = area2;
                            pictureBoxes[(i + (3 * j))].Image = ImageFram2.ToBitmap(pictureBoxes[(i + (3 * j))].Width, pictureBoxes[(i + (3 * j))].Height);

                            Image<Gray, Byte> GrayImage_1 = ImageFram2.Convert<Gray, Byte>().Not().ThresholdBinary(new Gray(50), new Gray(255));

                            sum_contour_area = 0;
                            dectected_pattern = "";

                            for (int Y = 0; Y < GrayImage_1.Height; Y++)
                            {
                                for (int X = 0; X < GrayImage_1.Width; X++)
                                {
                                    int check_pixel = GrayImage_1.Data[Y, X, 0];

                                    if (check_pixel >= 250)
                                    {
                                        sum_contour_area++;
                                    }

                                }
                            }

                            TextBoxs[i + (3 * j)].Text = sum_contour_area.ToString();

                        }
                    }

                    pattern_threshold_1 = double.Parse(threshold_textBox_1.Text);
                    pattern_threshold_2 = double.Parse(threshold_textBox_2.Text);

                    for (int y = 1; y <= 9; y++)
                    {
                        double k = (double.Parse(TextBoxs[y - 1].Text)) / (img_roi_section_x * img_roi_section_y);

                        if (k <= pattern_threshold_1)
                        {
                            dectected_pattern += "1";
                        }
                        else if (k <= pattern_threshold_2)
                        {
                            dectected_pattern += "2";
                        }
                        else
                        {
                            dectected_pattern += "3";
                        }

                    }

                    for (int z = 0; z <= 9; z++)
                    {
                        if (dectected_pattern.Equals(pattern_recognition[z]))
                        {
                            MCvFont f = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_SIMPLEX, 1.3, 1.0);
                            ImageFrame.Draw(z.ToString(), ref f, new Point(bndRec.X + (bndRec.Width / 2), bndRec.Y - (bndRec.Height / 4)), new Bgr(255, 0, 0));
                            ImageFrame.Draw(z.ToString(), ref f, new Point(bndRec.X + (bndRec.Width / 2), bndRec.Y - (bndRec.Height / 4) + 1), new Bgr(255, 0, 0));
                            ImageFrame.Draw(z.ToString(), ref f, new Point(bndRec.X + (bndRec.Width / 2), bndRec.Y - (bndRec.Height / 4) - 1), new Bgr(255, 0, 0));
                            ImageFrame.Draw(z.ToString(), ref f, new Point(bndRec.X + (bndRec.Width / 2) + 1, bndRec.Y - (bndRec.Height / 4)), new Bgr(255, 0, 0));
                            ImageFrame.Draw(z.ToString(), ref f, new Point(bndRec.X + (bndRec.Width / 2) - 1, bndRec.Y - (bndRec.Height / 4)), new Bgr(255, 0, 0));
                            break;
                        }

                    }

                }
                else
                {

                }

            }


            pictureBox1.Image = ImageFrame.ToBitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox2.Image = cannyEdges.ToBitmap(pictureBox2.Width, pictureBox2.Height);

            CvInvoke.cvReleaseMemStorage(ref storage);   ///////////// clear RAM memory  

            countour_choose = -1;

            CvInvoke.cvCopy(GrayImage, ImageFram2, System.IntPtr.Zero);

        }


        private void find_roi(object sender, EventArgs e)
        {
            img_roi_section_x = (Convert.ToInt32(bb[2]) / 3);
            img_roi_section_y = (Convert.ToInt32(bb[3]) / 3);
            img_begin_x = Convert.ToInt32(bb[0]);
            img_begin_y = Convert.ToInt32(bb[1]);

            ImageFram2.ROI = Rectangle.Empty;
            area = new Rectangle(Convert.ToInt32(bb[0]), Convert.ToInt32(bb[1]), Convert.ToInt32(bb[2]), Convert.ToInt32(bb[3]));  // set the roi
            ImageFram2.ROI = area;
            pictureBox3.Image = ImageFram2.ToBitmap(pictureBox3.Width, pictureBox3.Height);


            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {

                    area2 = new Rectangle(img_begin_x + (i * img_roi_section_x), img_begin_y + (j * img_roi_section_y), img_roi_section_x, img_roi_section_y);  // set the roi
                    ImageFram2.ROI = area2;

                    pictureBoxes[(i + (3 * j))].Image = ImageFram2.ToBitmap(pictureBoxes[(i + (3 * j))].Width, pictureBoxes[(i + (3 * j))].Height);

                    Image<Gray, Byte> GrayImage = ImageFram2.Convert<Gray, Byte>().Not().ThresholdBinary(new Gray(50), new Gray(255));

                    sum_contour_area = 0;
                    dectected_pattern = "";

                    for (int Y = 0; Y < GrayImage.Height; Y++)
                    {
                        for (int X = 0; X < GrayImage.Width; X++)
                        {
                            int check_pixel = GrayImage.Data[Y, X, 0];

                            if (check_pixel >= 250)
                            {
                                sum_contour_area++;
                            }

                        }
                    }

                    TextBoxs[i + (3 * j)].Text = sum_contour_area.ToString();

                }
            }

            excelWorkSheet.Cells[countour_choose + 2, 1] = "Obj " + countour_choose;

            pattern_threshold_1 = double.Parse(threshold_textBox_1.Text);
            pattern_threshold_2 = double.Parse(threshold_textBox_2.Text);

            for (int y = 1; y <= 9; y++)
            {

                double k = (double.Parse(TextBoxs[y - 1].Text)) / (img_roi_section_x * img_roi_section_y);

                if (checkBox1.Checked == false)
                {
                    if (k <= pattern_threshold_1)
                    {
                        excelWorkSheet.Cells[countour_choose + 2, y + 1] = 1;
                        dectected_pattern += "1";
                    }
                    else if (k <= pattern_threshold_2)
                    {
                        excelWorkSheet.Cells[countour_choose + 2, y + 1] = 2;
                        dectected_pattern += "2";
                    }
                    else 
                    {
                        excelWorkSheet.Cells[countour_choose + 2, y + 1] = 3;
                        dectected_pattern += "3";
                    }
                }
                else
                {
                    excelWorkSheet.Cells[countour_choose + 2, y + 1] = k;
                }

            }

            for (int z = 0; z <= 9; z++)
            {
                if (dectected_pattern.Equals(pattern_recognition[z]))
                {
                    result_textBox.Text = z.ToString();
                    break;
                }
                else
                {
                    result_textBox.Text = "error";
                }

            }

            Application.Idle -= find_roi;
        }


        private void close_button_Click(object sender, EventArgs e)
        {
            try
            {
                excelApp.Quit();
                excel_DB.Quit();

                Marshal.ReleaseComObject(excelApp);
                Marshal.ReleaseComObject(excel_DB);
                excelApp = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();

                this.Close();
            }
            catch (Exception)
            {
                this.Close();
            }
        }
        
    }
}
