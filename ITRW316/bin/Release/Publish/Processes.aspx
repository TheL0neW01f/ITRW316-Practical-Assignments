<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Processes.aspx.cs" Inherits="ITRW316.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <style>
        h1{
            color:blue;
            font-family:'Leoscar Serif';
            font-size:xx-large;
        }
        body
        {
            background-color:black;
            text-align:center;
        }
        br
        {
            font-family:'Leoscar Serif';
            font-size:large;
            color:forestgreen;
        }
        h2{
            color:forestgreen;
            font-family:'Leoscar Serif';
            font-size:medium;
        }
    </style>
    <script>
    function AddRecord() {
        var adoConn = new ActiveXObject("ADODB.Connection");
        var adoCom = new ActiveXObject("ADODB.Command");

        adoConn.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='\\Process.mdb'");
        //adoCom.Open("Select * From tblName", adoConn, 1, 3);

        adoCom.ActiveConnection = adoConn;
        adoCom.CommandText = "Insert Into processes(name) Values('P1')";
        adoCom.Execute();

        adoConn.Close();

        //adoRS.Fields("Name").value = "P1";
       // adoRS.Update();
       // adoRS.Close();
        //adoConn.Close();
        }
        </script>
    <form id="form1" runat="server">
        <div>
            <section>
                <h1>Processes</h1>

            <h2>Enter arrival time for process 1:</h2>
            <asp:TextBox ID="txtArr1" runat="server"></asp:TextBox>
            <h2>Enter running time for process 1:</h2>
            <asp:TextBox ID="txtRun1" runat="server" TabIndex="1"></asp:TextBox>
            <h2>Enter arrival time for process 2:</h2>
            <asp:TextBox ID="txtArr2" runat="server" TabIndex="2"></asp:TextBox>
            <h2>Enter running time for process 2:</h2>
            <asp:TextBox ID="txtRun2" runat="server" TabIndex="3"></asp:TextBox>
            <h2>Enter arrival time for process 3:</h2>
            <asp:TextBox ID="txtArr3" runat="server" TabIndex="4"></asp:TextBox>
            <h2>Enter running time for process 3:</h2>
            <asp:TextBox ID="txtRun3" runat="server" TabIndex="5"></asp:TextBox>
            <h2>Enter arrival time for process 4:</h2>
            <asp:TextBox ID="txtArr4" runat="server" TabIndex="6"></asp:TextBox>
            <h2>Enter running time for process 4:</h2>
            <asp:TextBox ID="txtRun4" runat="server" TabIndex="7"></asp:TextBox>
            <br />
            <br />
            <asp:Button BackColor="SkyBlue" Font-Size="Large" BorderStyle="Solid" BorderColor="PowderBlue" ForeColor="Black" ID="Button1" runat="server" OnClick="Button1_Click" TabIndex="8" Text="Next Page"/>
                <!--<button onclick="AddRecord()">Click</button>-->
                 </section>
        </div>
    </form>
</body>
</html>
