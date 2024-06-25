using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV;
using System.Management;
using Emgu.CV.Util;
using System;
using nietras.SeparatedValues;
using System.Data;
using Emgu.CV.OCR;


namespace GetSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Openfile = new OpenFileDialog();
                if (Openfile.ShowDialog() == DialogResult.OK)
                {
                    Image<Bgr, Byte> My_Image = new Image<Bgr, byte>(Openfile.FileName);
                    picBox.Image = My_Image.ToBitmap();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }
        private void DetectText(Image<Bgr, Byte> image)
        {
            var grayImage = image.Convert<Gray, Byte>();
            //CvInvoke.CvtColor(image, grayImage, ColorConversion.Bgr2Gray);
            var sobelImage = grayImage.Sobel(1, 0, 3);

            var thresholdImage = sobelImage.ThresholdBinaryInv(new Gray(0), new Gray(255));


            // Perform morphological operations
            var element = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(10, 2), new Point(-1, -1));
            CvInvoke.MorphologyEx(thresholdImage, thresholdImage, MorphOp.Close, element, new Point(-1, -1), 1, BorderType.Reflect, new MCvScalar());

            // Find contours
            using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
            {
                CvInvoke.FindContours(thresholdImage, contours, null, RetrType.External, ChainApproxMethod.ChainApproxSimple);
                for (int i = 0; i < contours.Size; i++)
                {
                    Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);
                    // Filter for text size and area here
                    image.Draw(rect, new Bgr(Color.Red), 2);
                }
            }

            // Display the result
            picBox.Image = image.ToBitmap();
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;

            MessageBox.Show(coordinates.ToString());
        }
    }
}

