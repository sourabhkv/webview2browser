using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vfc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Reload();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("http://google.com");
        }

        private void webView21_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            textBox1.Text = webView21.Source.ToString();
        }
    }
}
