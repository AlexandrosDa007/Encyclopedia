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
            string lemmaBodyToHTML = Encoding.UTF8.GetString(lemmaBody, 0, lemmaBody.Length);

			// set up the title display style
			string titleStyle = " style=\"display: block; " +
				"font-size: 3em;" +
				"margin-top: 0.67em; " +
				"margin-bottom: 0.67em; " +
				"margin-left: 0; " +
				"margin-right: 0; " +
				"font-weight: bold;\"";
			// concatenate both HTML lemma title and body
			string wholeHTMLLemma = "<h1" + titleStyle + ">" + lemmaTitle.Replace("_", " ") + "</h1>" + lemmaBodyToHTML;

			IronPdf.HtmlToPdf Renderer = new IronPdf.HtmlToPdf();
            Renderer.RenderHtmlAsPdf(wholeHTMLLemma).SaveAs(path);

        }
    }
}
