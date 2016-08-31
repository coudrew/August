<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <link rel="stylesheet" href="c8r.css" />
    <title>calculator</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-xs-4 col-xs-offset-2" id="calculator">
                <div class="col-xs-10 col-xs-offset-1" id="displayScreen">
                    <asp:Label ID="lblDisplayScreen" runat="server" Text="00000000000000000000" Font-Size="XX-Large"></asp:Label>
                </div>
                <div class="btnPad">
                    <div class="row">
                        <div class="col-xs-12 col-xs-offset-1 btnRow">
                            <asp:Button ID="btnClear" Text="C" runat="server" CssClass="btnFunc" />
                            <asp:Button ID="btnSigned" Text="+/-" runat="server" CssClass="btnFunc" />
                            <asp:Button ID="btnPercMod" Text="%" runat="server" CssClass="btnOperator" />
                            <asp:Button ID="btnDiv" Text="/" runat="server" CssClass="btnOperator" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xs-12 col-xs-offset-1 btnRow">
                            <asp:Button ID="btn7" Text="7" runat="server" CssClass="btnNumber" />
                            <asp:Button ID="btn8" Text="8" runat="server" CssClass="btnNumber" />
                            <asp:Button ID="btn9" Text="9" runat="server" CssClass="btnNumber" />
                            <asp:Button ID="btnMult" Text="*" runat="server" CssClass="btnOperator" />
                        </div>
                    </div>
                     <div class="row">
                        <div class="col-xs-12 col-xs-offset-1 btnRow">
                            <asp:Button ID="btn4" Text="4" runat="server" CssClass="btnNumber" />
                            <asp:Button ID="btn5" Text="5" runat="server" CssClass="btnNumber" />
                            <asp:Button ID="btn6" Text="6" runat="server" CssClass="btnNumber" />
                            <asp:Button ID="btnSum" Text="+" runat="server" CssClass="btnOperator" />

                        </div>
                    </div>
                     <div class="row">
                        <div class="col-xs-12 col-xs-offset-1 btnRow">
                            <asp:Button ID="btn1" Text="1" runat="server" CssClass="btnNumber" />
                            <asp:Button ID="btn2" Text="2" runat="server" CssClass="btnNumber" />
                            <asp:Button ID="btn3" Text="3" runat="server" CssClass="btnNumber" />
                            <asp:Button ID="btnMinus" Text="-" runat="server" CssClass="btnOperator" />

                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xs-12 col-xs-offset-1 btnRow">
                            <asp:Button ID="btn0" Text="0" runat="server" CssClass="btnNumber" OnClientClick="btn0Click" />
                            <asp:Button ID="btnDot" Text="." runat="server" CssClass="btnNumber" />
                            <asp:Button ID="btnEquals" Text="=" runat="server" CssClass="btnOperator" />

                        </div>
                    </div>
                 </div>

            </div>
            <div class="col-xs-4 col-xs-offset-1" id="sequenceDisplay">


            </div>
                    
        </div>
        
    
    </div>
    </form>
</body>
</html>
