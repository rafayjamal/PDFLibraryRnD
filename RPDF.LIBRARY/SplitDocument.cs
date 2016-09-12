using System;
using PdfSharp.Pdf;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Pdf.IO;
using System.IO;

namespace RPDF.LIBRARY
{
    public class SplitDocument
    {
        public void SplitPdf(string fileName)
        {
            PdfDocument inputDocument = PdfReader.Open(fileName, PdfDocumentOpenMode.Import);
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
            for (int idx = 0; idx < inputDocument.PageCount; idx++)
            {
                // Create new document
                PdfDocument outputDocument = new PdfDocument();
                outputDocument.Version = inputDocument.Version;
                outputDocument.Info.Title = String.Format("Page {0} of {1}", idx + 1, inputDocument.Info.Title);
                outputDocument.Info.Creator = inputDocument.Info.Creator;

                // Add the page and save it
                outputDocument.AddPage(inputDocument.Pages[idx]);
                outputDocument.Save(String.Format("{0} - Page {1}.pdf", fileNameWithoutExtension, idx + 1));
            }
        }
    }
}
