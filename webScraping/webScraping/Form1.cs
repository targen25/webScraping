using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webScraping
{
    public partial class fmWebScraping : Form
    {
        static DataTable table;
        static int inputYahoo = 0;
        static int inputBind = 0;

        public fmWebScraping()
        {
            InitializeComponent();
            IniTable();
        }

        private void IniTable()
        {
            table = new DataTable();
            table.Columns.Add("Search Engines Yahoo", typeof(string));
            table.Columns.Add("Search Engines Bind", typeof(string));
            table.Columns.Add("Winner", typeof(string));
            dgvResult.DataSource = table;
        }
        private void buSearch_Click(object sender, EventArgs e)
        {
            var input = "\""+ txSearch.Text+"\"";
            //GetHtmlYahoo(input);
            //GetHtmlBing(input);
            GetHtml(input);
            table.Rows.Add(inputYahoo, inputBind, "");
        }
        static async void GetHtmlYahoo(string input)
        {

            var url = "https://search.yahoo.com/search?p=" + input;

            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);
            var htmlDocument = new HtmlAgilityPack.HtmlDocument();

            
            string string1 = html;
            string toFind1 = "Next</a><span>";
            int start = string1.IndexOf(toFind1) + toFind1.Length;
            int end = start + 40;
            string string2 = string1.Substring(start, end - start);

            string onlyNumber = Regex.Replace(string2, "[a-zA-Z</>,\n. ]", "");
            inputYahoo = Convert.ToInt32(onlyNumber);

            table.Rows[0][0] = inputYahoo;
            
        }
        static async void GetHtmlBing(string input)
        {

            var url = "https://www.bing.com/search?q="+ input ;

            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);
            
            string string1 = html;
            string toFind1 = "class=\"sb_count\"";
            int start = string1.IndexOf(toFind1) + toFind1.Length;
            int end = start + 40;
            string string2 = string1.Substring(start, end - start);

            string onlyNumber = Regex.Replace(string2, "[a-zA-Z</>,\n. ]", "");
            inputBind = Convert.ToInt32(onlyNumber);

            table.Rows[0][1] = inputBind;


        }

        static async void GetHtml(string input)
        {

            //----Search on Yahoo
            string urlYahoo = "https://search.yahoo.com/search?p=" + input;

            HttpClient httpClient = new HttpClient();
            string htmlYahoo = await httpClient.GetStringAsync(urlYahoo);

            string toFindYahoo = "Next</a><span>";
            int startYahoo = htmlYahoo.IndexOf(toFindYahoo) + toFindYahoo.Length;
            int endYahoo = startYahoo + 40;
            string resultYahoo = htmlYahoo.Substring(startYahoo, endYahoo - startYahoo);

            string onlyNumberYahoo = Regex.Replace(resultYahoo, "[a-zA-Z</>,\n. ]", "");
            inputYahoo = Convert.ToInt32(onlyNumberYahoo);

            table.Rows[0][0] = inputYahoo;
            
            //----Search on Bind
            string urlBind = "https://www.bing.com/search?q=" + input;
            httpClient = new HttpClient();
            string htmlBind = await httpClient.GetStringAsync(urlBind);

            string toFindBind = "class=\"sb_count\"";
            int startBind = htmlBind.IndexOf(toFindBind) + toFindBind.Length;
            int endBind = startBind + 40;
            string resultBind = htmlBind.Substring(startBind, endBind - startBind);

            string onlyNumberBind = Regex.Replace(resultBind, "[a-zA-Z</>,\n. ]", "");
            inputBind = Convert.ToInt32(onlyNumberBind);

            table.Rows[0][1] = inputBind;
            //---Compare the result of the two search engines
            if (inputYahoo> inputBind)
            {
                table.Rows[0][2] = "Yahoo";
            }
            else
            {
                table.Rows[0][2] = "Bind";
            }

            
        }
    }
}
