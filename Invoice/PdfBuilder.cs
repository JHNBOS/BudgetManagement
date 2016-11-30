using iTextSharp.text;
using iTextSharp.text.pdf;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Invoice
{
    public class PdfBuilder
    {
        private readonly factuur _post;
        private readonly string _file;
        public PdfBuilder(factuur post, string file)
        {
            _post = post;
            _file = file;
        }
        public FileContentResult GetPdf()
        {
            var html = GetHtml();
            Byte[] bytes;
            using (var ms = new MemoryStream())
            {
                using (var doc = new Document())
                {
                    using (var writer = PdfWriter.GetInstance(doc, ms))
                    {
                        doc.Open();
                        try
                        {
                            using (var msHtml = new MemoryStream(Encoding.UTF8.GetBytes(html)))
                            {
                                iTextSharp.tool.xml.XMLWorkerHelper.GetInstance()
                                    .ParseXHtml(writer, doc, msHtml, Encoding.UTF8);
                            }
                        }
                        finally
                        {
                            doc.Close();
                        }
                    }
                }
                bytes = ms.ToArray();
            }
            return new FileContentResult(bytes, "application/pdf");
        }
        private string GetHtml()
        {
            var html = File.ReadAllText(_file);
            return Razor.Parse(html, _post);
        }
    }
}