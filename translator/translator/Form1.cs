using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using Newtonsoft.Json;
using System.Net;
using System.IO;



namespace translator
{
    public partial class Form1 : Form
    {
         string url="https://translate.yandex.net/api/v1.5/tr.json/translate?key=yourKey&text=";
         UriTypeConverter myWord;
        
       
        public Form1()
        {
            InitializeComponent();
            myWord= new UriTypeConverter() ;
           
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
       
        string changedUrl = "";

            changedUrl=url;
            var word = textBox1.Text;
             
            changedUrl+= myWord.ConvertFrom(word);

            changedUrl+="&lang=en";
            


          string json = new WebClient().DownloadString(changedUrl);
          Translate obj = JsonConvert.DeserializeObject<Translate>(json);
         
            
                textBox2.Text = obj.text[0];

                


                
                
            
            changedUrl=url;
       
        
        
        
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }






    }
}
