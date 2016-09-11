using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationPDF
{
    class ProtectDocument
    {
        public void protectDocument()
        {

            // Get a fresh copy of the sample PDF file
            const string filenameSource = @"Confidentiality and IP Assignment-of-Rights Agreement (Non-Employee Staf.pdf";

            // Open an existing document. Providing an unrequired password is ignored.
            PdfDocument document = PdfReader.Open(filenameSource, "some text");
            
            PdfSecuritySettings securitySettings = document.SecuritySettings;
            
            // Setting one of the passwords automatically sets the security level to 
            // PdfDocumentSecurityLevel.Encrypted128Bit.
            securitySettings.UserPassword = "user";
            securitySettings.OwnerPassword = "owner";
            
            // Don't use 40 bit encryption unless needed for compatibility
            //securitySettings.DocumentSecurityLevel = PdfDocumentSecurityLevel.Encrypted40Bit;
            
            // Restrict some rights.
            securitySettings.PermitAccessibilityExtractContent = false;
            securitySettings.PermitAnnotations = false;
            securitySettings.PermitAssembleDocument = false;
            securitySettings.PermitExtractContent = false;
            securitySettings.PermitFormsFill = true;
            securitySettings.PermitFullQualityPrint = false;
            securitySettings.PermitModifyDocument = true;
            securitySettings.PermitPrint = false;
            
            // Save the document...
            document.Save(filenameSource);
        }
    }
}
