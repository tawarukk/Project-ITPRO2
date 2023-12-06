# การดึงข้อมูล JSON และแสดงผลบน GridView ด้วย ASP.NET

ไฟล์นี้เป็นส่วนหนึ่งของโครงการเว็บ ASP.NET ที่ใช้ C# เพื่อดึงข้อมูล JSON จาก API ที่เกี่ยวข้องกับสถิติการเสียชีวิตจาก COVID-19 และแสดงผลข้อมูลผ่าน GridView ที่ชื่อว่า GridView1 บนหน้าเว็บ

## รายละเอียดโค้ด

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Data;
using System.Net;

namespace WebApplication_86
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        DataTable dt;

        // Function สำหรับดึงข้อมูล JSON จาก URL
        void GetJSONFromUrl()
        {
            using (WebClient wc = new WebClient())
            {
                try
                {
                    // ดึงข้อมูล JSON จาก URL
                    var json = wc.DownloadString("https://covid19.ddc.moph.go.th/api/Deaths/round-1to2-line-list");

                    // แปลง JSON เป็น DataTable
                    dt = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

                    // Bind DataTable กับ GridView
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
                catch (WebException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            // โค้ดที่ทำงานเมื่อหน้าเว็บโหลด
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // เมื่อ Button1 ถูกคลิก จะเรียกใช้ฟังก์ชัน GetJSONFromUrl() เพื่อดึงและแสดงข้อมูล JSON
            GetJSONFromUrl();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // เมื่อมีการเปลี่ยนหน้าของ GridView จะเรียกใช้ GetJSONFromUrl() เพื่อดึงข้อมูลใหม่
            GridView1.PageIndex = e.NewPageIndex;
            GetJSONFromUrl();
        }
    }
}
```

ในตัวอย่างโค้ดนี้เป็นการใช้งาน C# ในส่วนของ ASP.NET ซึ่งได้ทำการดึงข้อมูล JSON จาก URL ของ API ที่เกี่ยวข้องกับข้อมูลการเสียชีวิตจาก COVID-19 มาแสดงผลผ่าน GridView ในหน้าเว็บของเรา

การใช้งานและประยุกต์ใช้งานตัวต่างๆ ของ C# ได้แก่การใช้งาน WebClient ในการดึงข้อมูล JSON จาก URL และการแปลง JSON ให้อยู่ในรูปของ DataTable ด้วย JsonConvert จากนั้นนำ DataTable ไปผูกข้อมูลกับ GridView เพื่อแสดงผลที่หน้าเว็บ

ฟังก์ชัน GetJSONFromUrl() เป็นที่ตั้งใจสำหรับดึงข้อมูล JSON จาก URL ที่กำหนด และแสดงผลผ่าน GridView1 ซึ่งสามารถเรียกใช้ได้จาก Button1_Click เมื่อปุ่มถูกคลิก และ GridView1_PageIndexChanging เพื่อเปลี่ยนหน้าของ GridView


#### การใช้งาน WebClient: ใช้ในการโหลดข้อมูล JSON จาก URL ของ API โดยใช้คลาส WebClient เพื่อดึงข้อมูล JSON มาเก็บไว้ในตัวแปร json

#### การแปลง JSON เป็น DataTable: โดยใช้คลาส JsonConvert ภายใต้ namespace Newtonsoft.Json เพื่อแปลงข้อมูล JSON ที่ได้มาให้อยู่ในรูปของ #DataTable และเก็บไว้ในตัวแปร dt

#### การผูกข้อมูลใน DataTable กับ GridView: จากนั้นนำ DataTable ที่ได้มาจากขั้นตอนก่อนหน้า ผูกกับ GridView1 ซึ่งเป็นตารางเพื่อแสดงผลข้อมูล JSON ที่ได้รับจาก API และเรียกใช้ DataBind() เพื่อแสดงข้อมูลใหม่ล่าสุด

### Events และ Functionality:

Page_Load: เป็นตัวที่ทำงานเมื่อเว็บโหลด เพื่อให้หน้าเว็บทำงานได้ตามที่ต้องการ
Button1_Click: เมื่อปุ่มถูกคลิก จะเรียกใช้ GetJSONFromUrl() เพื่อดึงข้อมูล JSON และแสดงผลบน GridView
GridView1_PageIndexChanging: เมื่อมีการเปลี่ยนหน้าของ GridView จะเรียกใช้ GetJSONFromUrl() เพื่อเรียกข้อมูลใหม่สำหรับหน้าใหม่ของ GridView
โดยรวมแล้ว โค้ดนี้เป็นตัวอย่างที่แสดงการใช้งานฟังก์ชันพื้นฐานของ ASP.NET ในการดึงข้อมูลจากภายนอกและแสดงผลบนหน้าเว็บแอปพลิเคชันในรูปแบบของตารางข้อมูลแบบ GridView