using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationPDF
{
    class ImageToPDF
    {
        public void imageToPDF()
        {
            const string filename = "ImageToPDF_Test2.pdf";
            const string imageLoc = "12540536_1099788833404737_5006626391975825542_n.jpg";

            PdfDocument document = new PdfDocument();

            // Create an empty page or load existing
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);
            gfx.DrawImage(XImage.FromFile(imageLoc), 0, 0);
            //DrawImage(gfx, imageLoc, 0,0);

            // Save and start View
            document.Save(filename);
            Process.Start(filename);
        }

        private void DrawImage(XGraphics gfx, string jpegSamplePath, int x, int y, int width, int height)
        {
            XImage image = XImage.FromFile(jpegSamplePath);
            gfx.DrawImage(image, x, y, width, height);
        }
    }
}
