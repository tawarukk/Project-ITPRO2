
# แอปพลิเคชันเล่นวิดีโอจาก YouTube ด้วย Windows Forms

ไฟล์นี้เป็นส่วนหนึ่งของโปรแกรม Windows Forms ที่ใช้ C# เพื่อเล่นวิดีโอจาก YouTube โดยมีปุ่มสำหรับใส่ลิงก์วิดีโอและแสดงผลวิดีโอผ่าน WebBrowser

## รายละเอียดโค้ด

```csharp
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
            // ฟังก์ชันเมื่อปุ่มถูกคลิก
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
            // ฟังก์ชันสำหรับแยกตัวเลขของวิดีโอ ID จาก URL ของ YouTube
            if (youtubeLink.Contains("="))
            {
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
```

# Youtube Player Application

## Events and Functionality

### button1_Click
เมื่อคลิก Button1 จะทำการดึง Video ID จาก URL ที่ระบุ และแสดง Video จาก YouTube ในรูปแบบ iframe บน Web Browser โดยใช้ Video ID ที่ดึงมาจาก URL ที่ผู้ใช้กรอกเข้ามา
