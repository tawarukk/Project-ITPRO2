<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication_86.WebForm2" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
    
<head runat="server">
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <title>Knowledgebase / การใช้ภาษาไทยกับ TIS-620</title>  
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <h1> ข้อมูลผู้เสียชีวิตระลอก 1 ถึงระลอก 2 (ตั้งแต่ 12/01/2020 – 31/03/2021)</h1>
        <asp:Button ID="Button1" runat="server" Text="แสดงข้อมูล" OnClick="Button1_Click" />
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnPageIndexChanging="GridView1_PageIndexChanging">
            <Columns>
                <asp:BoundField DataField="province" HeaderText="จังหวัด" />
                <asp:BoundField DataField="age" HeaderText="อายุ" />
                <asp:BoundField DataField="occupation" HeaderText="อาชีพ" />
                <asp:BoundField DataField="death_cluster" HeaderText="สถานที่" />
                <asp:BoundField DataField="update_date" DataFormatString="{0:dd MMM yyyy}" HeaderText="วันที่" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
        <asp:Label ID="lbJSON" runat="server"></asp:Label>
    </form>
</body>
</html>
