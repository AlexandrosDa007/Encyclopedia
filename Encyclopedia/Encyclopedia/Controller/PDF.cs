using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encyclopedia.Model;
using IronPdf;

namespace Encyclopedia.Controller
{
    class PDF
    {
        public static void exportToPDF(string lemmaTitle,string path)
        {
            
            //Get lemma body
            byte[] lemmaBody = DBConnect.GetLemmaBodyByTitle(lemmaTitle);
            //Convert byte array to string
            string lemmaBodyToHTML = System.Text.Encoding.UTF8.GetString(lemmaBody, 0, lemmaBody.Length);

            IronPdf.HtmlToPdf Renderer = new IronPdf.HtmlToPdf();
            Renderer.RenderHtmlAsPdf(lemmaBodyToHTML).SaveAs(path);

        }
    }
}
