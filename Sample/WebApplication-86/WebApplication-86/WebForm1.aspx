<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication_86.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="center-content">
            <h1 style="color: #e8bd4b"><asp:Label ID="Label1" runat="server" Text="คำนวณค่าดัชนีมวลกาย" Font-Bold="True"></asp:Label>
            :<br /></h1>
            <div class="content">
                <p>
                    <asp:Label ID="Label6" runat="server" Text="ค่า BMI คือค่าดัชนีที่ใช้ชี้วัดความสมดุลของน้ำหนักตัว (กิโลกรัม) และส่วนสูง (เซนติเมตร) ซึ่งสามารถระบุได้ว่า ตอนนี้รูปร่างของคนคนนั้นอยู่ในระดับใด ตั้งแต่อ้วนมากไปจนถึงผอมเกินไป"></asp:Label>
                </p>
                <p>
                    <asp:Label ID="Label7" runat="server" Text="Body Mass Index (BMI) มีสูตรการคำนวณ = น้ำหนักตัว[Kg] / (ส่วนสูง[m] ยกกำลังสอง) สูตรคำนวณเหมาะสำหรับใช้ประเมินผู้ที่มีอายุตั้งแต่ 20 ปีขึ้นไป ประโยชน์ของการวัดค่า BMI เพื่อดูอัตราเสี่ยงต่อการเกิดโรคต่าง ๆ ตรวจสอบภาวะไขมันและความอ้วน ดังนั้นการทำให้ร่างกายอยู่ในเกณฑ์ปกติจึงมีความสำคัญอย่างยิ่งกับผู้ที่ต้องการรักษาสุขภาพในระยะยาว"></asp:Label>
                </p>
            </div>
            <p>
                <asp:Label ID="Label3" runat="server" Text="น้ำหนัก (Kg.)"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="TextBox" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Text="ส่วนสูง (cm.)"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="TextBox"></asp:TextBox>
            </p>
            <p>
            <asp:Button ID="Button1" runat="server" Text="คำนวณ BMI" class="button" OnClick="Button1_Click" />
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="ค่า BMI ของคุณคือ :"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="TextBox"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="ผลทดสอบ : "></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" CssClass="TextBox"></asp:TextBox>
        </p>
        

        <h2 style="color: #e8bd4b">BMI Classification Table</h2>
            <a style="color: #e8bd4b; width: 300px; height: 300px; align-content:center;">
                <asp:Image ID="Image1" runat="server" ImageUrl="https://i.pinimg.com/originals/95/3f/6e/953f6e72014ac744e54815991075b5e3.png" Visible="False" />
            </a>
    <table>
        <thead>
            <tr>
                <th>BMI Range</th>
                <th>Classification</th>
                <th>&#10004;</th>
                <th>Risk of Health Issues</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>Less than 18.5</td>
                <td style="background-color:yellowgreen">Underweight</td>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="X"></asp:Label>
                </td>
                <td>Malnutrition, Osteoporosis, Anemia</td>
            </tr>
            <tr>
                <td>18.5 - 24.9</td>
                <td style="background-color:yellow">Normal weight</td>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="X"></asp:Label>
                </td>
                <td>Normal</td>
            </tr>
            <tr>
                <td>25.0 - 29.9</td>
                <td style="background-color:orangered">Overweight</td>
                <td>
                    <asp:Label ID="Label10" runat="server" Text="X"></asp:Label>
                </td>
                <td>High blood pressure, Diabetes, Heart disease</td>
            </tr>
            <tr>
                <td>30.0 - 34.9</td>
                <td style="background-color:crimson" >Obesity (Class 1)</td>
                <td>
                    <asp:Label ID="Label11" runat="server" Text="X"></asp:Label>
                </td>
                <td>High risk of health problems</td>
            </tr>
            <tr>
                <td>35.0 - 39.9</td>
                <td style="background-color:brown">Obesity (Class 2)</td>
                <td>
                    <asp:Label ID="Label12" runat="server" Text="X"></asp:Label>
                </td>
                <td>Very high risk of health problems</td>
            </tr>
            <tr>
                <td>40.0 and above</td>
                <td style="background-color:maroon">Obesity (Class 3)</td>
                <td>
                    <asp:Label ID="Label13" runat="server" Text="X"></asp:Label>
                </td>
                <td>Extremely high risk of health problems</td>
            </tr>
        </tbody>
    </table>
            </div>
    </form>

</body>
</html>

<style>
    body {
        font-family: Arial, sans-serif;
        background-color: #f2f2f2;
        margin: 0;
        padding: 0;
    }

    .center-content {
        text-align: center;
        margin: 0 auto;
        max-width: 800px;
        background-color: #fff;
        padding: 20px;
        border-radius: 10px;
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        margin-top: 50px;
    }

    .button {
        text-align: center;
        width: 100%;
        padding: 10px;
        background-color: #e8bd4b;
        border-radius: 5px;
        color: #fff;
        font-weight: bold;
        cursor: pointer;
    }

    .TextBox {
        width: 100%;
        padding: 12px;
        box-sizing: border-box;
        background-color: #f2f2f2;
        border-radius: 5px;
        margin-top: 10px;
    }

    .content {
        max-width: 600px;
        margin: 0 auto;
    }

    table {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
            font-family: Arial, sans-serif;
            background-color: #f2f2f2;
            margin: 0;
            padding: 0;
        }

        th, td {
            border: 1px solid #ddd;
            padding: 8px;
            text-align: center;
        }

        th {
            background-color: #e8bd4b;
            color: #fff;
        }

    col{
        color: #e8bd4b;
    }


</style>

