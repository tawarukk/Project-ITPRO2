using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubePlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string videoId = ExtractVideoId(txtVideoLink.Text);
            if (!string.IsNullOrEmpty(videoId))
            {
                string html = "<html><head>";
                html += "<meta http-equiv='X-UA-Compatible' content='IE=Edge'/>";
                html += $"<iframe id='video' src='https://www.youtube.com/embed/{videoId}' width='600' height='300' frameborder='0' allowfullscreen></iframe>";
                html += "</head></html>";
                this.webBrowser1.DocumentText = html;
            }
            else
            {
                MessageBox.Show("Invalid YouTube link.");
            }
        }

        private string ExtractVideoId(string youtubeLink)
        {
            // ตรวจสอบว่าลิงค์มี "=" หรือไม่
            if (youtubeLink.Contains("="))
            {
                // ใช้ Split("=") เพื่อแบ่งข้อความและเลือกอินเด็กซ์ที่ต้องการ
                string[] parts = youtubeLink.Split('=');
                if (parts.Length > 1)
                {
                    return parts[1];
                }
            }
            return null;
        }

    }
}
