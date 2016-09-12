using PdfSharp.Drawing;
using PdfSharp.Pdf;
using RPDF.LIBRARY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            const string fileName = @"Confidentiality and IP Assignment-of-Rights Agreement (Non-Employee Staf.pdf";

            ////1. You’ll need a PDF document:
            //PdfDocument document = new PdfDocument();
            ////2. And you need a page:
            //PdfPage page = document.AddPage();
            ////3. Drawing is done with an XGraphics objec
            //XGraphics gfx = XGraphics.FromPdfPage(page);
            ////4. Then you'll create a font:
            //XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
            ////5. And you use that font to draw a string:
            //gfx.DrawString("Hello, World!", font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);
            ////6. When drawing is done, write the file:
            //string filename = "HelloWorld.pdf";
            ////7. A PC application might show the file:
            //document.Save(filename);

            SplitDocument splitDocument = new SplitDocument();
            splitDocument.SplitPdf(fileName);

            // CombineDocuments combineDocuments = new CombineDocuments();
            //combineDocuments.combineDocuments2();

            //ImageToPDF imageToPDF = new ImageToPDF();
            //imageToPDF.imageToPDF();
        }
    }
}
