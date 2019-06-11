<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Multiple Queues.aspx.cs" Inherits="ITRW316.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <style>
        h1
        {
            color:blue;
            font-family:'Leoscar Serif';
            font-size:xx-large;
        }

        h2 {
            color:blue;
            font-family:'Leoscar Serif';
            font-size:x-large;
            font:bold;
        }
        label
        {
            color:green;
            font-family:Kristen ITC;
            font-size:x-large;
        }
        button
        {
            border:2px solid powderblue;
            color:darkcyan;
            font-family:Chiller;
            font-size:medium;
            font:bold;
        }
        body
        {
            background-color:black;
        }
        div
        {
            
        }
    </style>
    <form id="form1" runat="server">
        <div class ="Slider">
            <section class="Slider">
                <h1>Multiple Queues</h1>
                <h2>Slider values must be in increasing order!</h2>
                </div>
                <label>Choose quantum for queue 1:
                    <input id= "Slider1" name="Slider1" runat="server" type ="range" min ="0" max="10" step="1" value ="0"
                        oninput="showAmount(this.value)"
                        onchange="showAmount(this.value)"/>
                    <span id ="amount">0</span>
                </label>
                </section>
                    </div>
            <script>
                    function showAmount(newAmount) {
                        document.getElementById('amount').innerHTML = newAmount;
                }

                function showAmount1(newAmount) {
                    document.getElementById('amount1').innerHTML = newAmount;
                }

                function showAmount2(newAmount) {
                    document.getElementById('amount2').innerHTML = newAmount;
                }
            </script>
        <div class ="Slider">
            <section class="Slider">
                <label>Choose quantum for queue 2:
                    <input id= "Slider2" name="Slider2" runat="server" type ="range" min ="0" max="10" step="1" value ="0"
                        oninput="showAmount1(this.value)"
                        onchange="showAmount1(this.value)"/>
                    <span id ="amount1">0</span>
                </label>
                </section>
                    </div>

                <div class ="Slider">
            <section class="Slider">
                <label>Choose quantum for queue 3:
                    <input id= "Slider3" name="Slider3" runat="server" type ="range" min ="0" max="10" step="1" value ="0"
                        oninput="showAmount2(this.value)"
                        onchange="showAmount2(this.value)"/>
                    <span id ="amount2">0</span>
                <br />
                <br />
                <asp:Button Font-Names="Leoscar Serif" Font-Size="X-Large" BackColor="SkyBlue" Font-Bold="true" Font-Italic="true" ForeColor="Blue" ID="Button1" runat="server" OnClick="Button1_Click1" Text="Execute Multiple Queues" Height="38px" />
                <br />
                <br />
                <asp:ListBox Font-Names="Stencil" Font-Size="Medium" BackColor="WhiteSmoke" Font-Bold ="true" ForeColor="Black" ID="ListBox1" runat="server" Height="219px" Width="227px"></asp:ListBox>
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Queue 1: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <asp:Label ID="Label2" runat="server" Text="Queue 2: "></asp:Label>
                <br />
                <asp:Label ID="Label3" runat="server" Text="Queue 3: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                </label>
                </section>
                    </div>

    </form>
</body>
</html>
