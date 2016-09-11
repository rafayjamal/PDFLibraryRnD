using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationPDF
{
    class SplitDocument
    {
        public void splitDocument()
        {

            // Get a fresh copy of the sample PDF file
            const string filename = @"Confidentiality and IP Assignment-of-Rights Agreement (Non-Employee Staf.pdf";

            // Open the file
            PdfDocument inputDocument = PdfReader.Open(filename, PdfDocumentOpenMode.Import);
            string name = Path.GetFileNameWithoutExtension(filename);
            for (int idx = 0; idx < inputDocument.PageCount; idx++)
            {
                // Create new document
                PdfDocument outputDocument = new PdfDocument();
                outputDocument.Version = inputDocument.Version;
                outputDocument.Info.Title =
                  String.Format("Page {0} of {1}", idx + 1, inputDocument.Info.Title);
                outputDocument.Info.Creator = inputDocument.Info.Creator;
             
                // Add the page and save it
                outputDocument.AddPage(inputDocument.Pages[idx]);
                outputDocument.Save(String.Format("{0} - Page {1}_tempfile.pdf", name, idx + 1));
            }
        }

    }
}
