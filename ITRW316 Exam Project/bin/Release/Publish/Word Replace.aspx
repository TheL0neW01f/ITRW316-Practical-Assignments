<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Word Replace.aspx.cs" Inherits="ITRW316.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <style>
        body
        {
            background-color:black;
        }
        h1
        {
            font-family:Monotype Corsiva;
            font-size:xx-large;
            color:blue;
        }
        h2
        {
            font-family:Monotype Corsiva;
            font-size:x-large;
            color:forestgreen;
        }
    </style>
    <form id="form1" runat="server">
        <div>
            <h1>Find a word in the section below which you wish to replace:</h1>
            <asp:Label ForeColor="White" Font-Size="X-Large" Font-Names="Stencil" ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <h2>Enter the word you wish to replace:</h2>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <h2>Enter the word you wish to replace it with:</h2>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button Font-Size="X-Large" Font-Names="Monotype Corsiva" BackColor="SlateGray" ForeColor="#0000ff" ID="Button1" runat="server" OnClick="Button1_Click" Text="Replace" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button Font-Size="X-Large" Font-Names="Monotype Corsiva" BackColor="SlateGray" ForeColor="#0000ff" ID="Button2" runat="server" Text="Processes" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
