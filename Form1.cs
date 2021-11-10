using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace SnowmeetExperienceCounter
{
    public partial class Form1 : Form
    {
        public string[] productImgUrlArr = new string[] { "https://img.alicdn.com/bao/uploaded/i1/3040100879/O1CN016bSDc91IMciITcaVP_!!3040100879.jpg",
            "https://img.alicdn.com/bao/uploaded/i2/3040100879/TB2oOX6ac2DjeFjSspnXXb20XXa_!!3040100879.jpg",
            "https://img.alicdn.com/bao/uploaded/i1/3040100879/TB1jOjZSFXXXXXJXVXXXXXXXXXX_!!0-item_pic.jpg",
            "https://img.alicdn.com/bao/uploaded/i2/3040100879/O1CN01ZYjDby1IMcik8huBY_!!3040100879.jpg" };

        public Form1()
        {
            InitializeComponent();
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://img.alicdn.com/bao/uploaded/i1/3040100879/O1CN016bSDc91IMciITcaVP_!!3040100879.jpg");
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            Stream s = res.GetResponseStream();
            Image img = Image.FromStream(s);
            s.Close();
            res.Close();
            req.Abort();
            imageList.Images.Add(img);
            imageList.ImageSize = new Size(30, 40);
            listView1.LargeImageList = imageList;
            ListViewItem item = new ListViewItem("test");
            item.ImageIndex = 0;
            listView1.Items.Add(item);
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
