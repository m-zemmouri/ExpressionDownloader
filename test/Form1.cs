using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Directory.Delete("C:\\test",true);
        
            string adr ="http://www.google.com/intl/fr_ALL/images/logo.gif";
            adr = "http://stackoverflow.com/robots.txt";
            adr = "http://www.binothaimeen.com/sound/snd/b0001/B0001-1A.rm";
            System.Net.WebRequest req = System.Net.HttpWebRequest.Create(adr);
            req.Method = "HEAD";
            System.Net.WebResponse resp = req.GetResponse();
            int ContentLength;
            if (int.TryParse(resp.Headers.Get("Content-Length"), out ContentLength))
            {
                MessageBox.Show(ContentLength.ToString());
              //Do something useful with ContentLength here 
            }
            InitializeComponent();
            int id = 0;
            int id2 = id++;



            
            MessageBox.Show(id.ToString()+"," + id2.ToString());


            a a = new a();
            lista.Add(a);
            b b = new b();
            listb.Add(b);
            b.a = a;
            a.z = 5;
            MessageBox.Show(b.a.z.ToString());
            b.a = null;
            MessageBox.Show(a.ToString());
        }


        private void      AddTab()
  {
           
             System.Windows.Forms.TabPage tabPage1;
            System.Windows.Forms.WebBrowser webBrowser1;
            System.Windows.Forms.TextBox textBox1;
    
        tabPage1 = new System.Windows.Forms.TabPage();
        textBox1 = new System.Windows.Forms.TextBox();
            webBrowser1 = new System.Windows.Forms.WebBrowser();
           
            
       tabPage1.SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(webBrowser1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new System.Drawing.Point(4, 22);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(434, 190);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
                // 
            // textBox1
            // 
            textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            textBox1.Location = new System.Drawing.Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(428, 20);
            textBox1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            webBrowser1.Location = new System.Drawing.Point(3, 23);
            webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            webBrowser1.Name = "webBrowser1";
            webBrowser1.Size = new System.Drawing.Size(428, 164);
            webBrowser1.TabIndex = 1;
              tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();

            this.tabControl1.TabPages.Add(tabPage1);
            this.tabControl1.SelectedTab = tabPage1;
        
  }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            AddTab();
            //this.anneeTableAdapter.Fill(this.aRBdbDataSet.Annee);
            string str = ",,,,";

            MessageBox.Show(test(  str));
        }
        string test( Object o)
        {
            return o.GetType().ToString();
        }

        private void anneeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
   private void button1_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// 
        /// </summary>
        class a
        {
            public int z;
            public a()
            {
                z = 0;
            }
        }



        class b
        {
            int z;
            public a a;
            public b()
            {
                z = 0;
            }
        }


        List<a> lista = new List<a>();
        List<b> listb = new List<b>();

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage3)
                AddTab();
        }

        private void button2_Click(object sender, EventArgs e)
        {
 AddTab();
        }

    }


    

}
