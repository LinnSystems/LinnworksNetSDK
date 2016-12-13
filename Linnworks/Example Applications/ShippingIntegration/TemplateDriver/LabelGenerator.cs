using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Web;
using TemplateDriver.Models;

namespace TemplateDriver
{
    public class LabelGenerator
    {
        public static int DPI = 400;

        public static Image GenerateLabel(List<ServiceConfigItem> serviceConfigItems,string SafePlace,string serviceCode,string orderReference, string newTrackingNumber, string AddressFormatted) {

            // lets create an image 4x6 inches. We will convert inched to pixels using DPI conversion defined in DPI field
            Bitmap newBitmap = new Bitmap(
                (int)GetPixels(4, GraphicsUnit.Inch,DPI),
                (int)GetPixels(6, GraphicsUnit.Inch, DPI)
            );

            newBitmap.SetResolution(DPI, DPI);  //set current resolution of the image
            var _graphics = Graphics.FromImage(newBitmap);  // and then create a graphic object from it where we can draw our label

            // some presets to ensure the label quality is as good and clear as it gets
            _graphics.Clear(Color.White);
            _graphics.PageUnit = GraphicsUnit.Inch;
            _graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _graphics.CompositingQuality = CompositingQuality.HighQuality;
            _graphics.CompositingMode = CompositingMode.SourceOver;
            _graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            _graphics.SmoothingMode = SmoothingMode.None;


            _graphics.DrawString(AddressFormatted, new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold), Brushes.Black, new PointF(0.2f, 0.2f));
            _graphics.DrawImage(images.insignia, new PointF(1.7f, 0.2f));

            string labeltag = "";
            if (serviceConfigItems.Find(s => s.ConfigItemId == "LABELTAG") != null) {
                labeltag = serviceConfigItems.Find(s => s.ConfigItemId == "LABELTAG").SelectedValue;
            }

            _graphics.DrawString(labeltag.ToUpper(), new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold), Brushes.Black, new PointF(2.8f, 1.3f));
            _graphics.DrawImage(images.somerandombarcode, new RectangleF(0.2f, 1.5f,3.6f,2f));
            _graphics.DrawImage(images._2dbarcode, new RectangleF(2.7f, 3.6f, 1f, 1f));

            if (SafePlace != "") {
                _graphics.DrawString("Safe Place", new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold), Brushes.Black, new PointF(0.2f, 3.4f));                
                _graphics.DrawRectangle(new Pen(Brushes.Black, 0.01f), 0.2f, 3.6f, 2.4f, 1f);
                _graphics.DrawString(SafePlace, new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular),Brushes.Black, new RectangleF(0.25f, 3.65f, 2.3f, 0.9f));
            }

            _graphics.DrawString(newTrackingNumber, new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold), Brushes.Black, new PointF(0.3f, 1.3f));

            _graphics.DrawString(@"NB! These barcodes will not scan 
                ofcourse, this is just a demo", new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold), Brushes.Black, new PointF(0.2f, 5f));


            using (MemoryStream stream = new MemoryStream())
            {
                newBitmap.Save(stream, ImageFormat.Png);
                return Image.FromStream(stream);
            }
                        
        }

        public static float GetPixels(float value, GraphicsUnit sourceUnit, int dpi)
        {
            switch (sourceUnit)
            {
                case GraphicsUnit.Point:
                    return value / 72f * (float)dpi;
                case GraphicsUnit.Inch:
                    return value * (float)dpi;
                case GraphicsUnit.Pixel:
                    return value;
                case GraphicsUnit.Millimeter:
                    return value * (float)dpi / 25.4f;
                default:
                    throw new ArgumentOutOfRangeException("sourceUnit", sourceUnit, "Source Unit not supported");
            }
        }

    }
}