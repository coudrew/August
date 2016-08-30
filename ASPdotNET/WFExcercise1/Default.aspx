<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>WebForms Excercise 1</h1>
        <br />
        <h4>Simple Controls</h4>
        <br />
        <asp:Label ID="lblEnterName" Text="Please Enter your name" runat="server"></asp:Label>
        <asp:TextBox ID="txtEnterName" runat="server"></asp:TextBox>
        <asp:Button ID="btnEnterName" Text="Enter" runat="server" OnClick="btnEnterName_Click" />
        <br />
        <asp:Label ID="outEnterName" runat="server"></asp:Label>
        <br /><br />
        <asp:Label ID="lblCheckBox" Text="Please check or uncheck the box" runat="server"></asp:Label>
        <br /> <asp:CheckBox ID="cbCheckBox" runat="server" />
        <br /> <asp:Button ID="btnCheckBox" Text="Click here to check checkbox" runat="server" OnClick="btnCheckBox_Click" />
        <br /> <asp:Label ID="outCheckBox" runat="server"></asp:Label>
        <br /><br />
        <asp:Label ID="lblRadio" Text="Please click a radio button. Or don't, whatever." runat="server"></asp:Label>
        <br /> <asp:RadioButtonList ID="RadioButtonList1" runat="server" >
            <asp:ListItem>Oh my god</asp:ListItem>
            <asp:ListItem>So easy</asp:ListItem>
            <asp:ListItem>This can&#39;t be someone&#39;s job</asp:ListItem>
        </asp:RadioButtonList>
        <br /><asp:Button ID="btnRadio" Text="check radio buttons" runat="server" OnClick="btnRadio_Click" />
        <br /><asp:Label ID="outRadio" runat="server"></asp:Label>
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" PostBackUrl="http://www.codewars.com">LinkButton</asp:LinkButton>
        <br /><asp:ImageMap ID="ImageMap1" runat="server" ImageUrl="303.jpg" Width="350px" OnClick="ImageMap1_Click" HotSpotMode="PostBack">
            <asp:CircleHotSpot PostBackValue="Tempo" Radius="12" X="52" Y="62" HotSpotMode="PostBack" />
            <asp:CircleHotSpot HotSpotMode="PostBack" PostBackValue="Track/Pattern" Radius="12" X="105" Y="62" />
        </asp:ImageMap>
        <br /><asp:Label ID="lblImgMap" runat="server"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox>
        <br /><asp:Label ID="lblMLTxtBox" runat="server" Text="Enter some text and hit the button"></asp:Label>
        <br /><asp:Button ID="btnMLTxtBox" runat="server" Text="the button" OnClick="btnMLTxtBox_Click" />
        <br /><asp:Label ID="outMLTxtBox" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblEMValid" Text="Enter your email, we'll validate it by only checking if it has '@', cause microsoft" runat="server"></asp:Label>
        <br /><asp:TextBox ID="TextBox2" runat="server" TextMode="Email"></asp:TextBox>
        <br />
        <asp:Label ID="lblCalendar" runat="server" Text="Here's a calendar. I know, right?"></asp:Label>
        <br /><asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <br /><asp:Label ID="outCalendar" runat="server"></asp:Label>
        <br />
        <h4>List Controls</h4>
        <br />
        <asp:Label ID="lblDropDown" runat="server" Text="Select your favourite language"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" >
            <asp:ListItem>C#</asp:ListItem>
            <asp:ListItem>Objective-C</asp:ListItem>
            <asp:ListItem>Java</asp:ListItem>
            <asp:ListItem>JavaScript</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="btnDropDown" Text="Confirm Language" runat="server" OnClick="btnDropDown_Click" />
        <br /><asp:Label ID="outDropDown" runat="server"></asp:Label>
        <br /><asp:Label ID="lblCheckList" Text="Choose some things" runat="server"></asp:Label>
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>chocolate</asp:ListItem>
            <asp:ListItem>vanilla</asp:ListItem>
            <asp:ListItem>neapolitan</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <br /><asp:Label ID="outCheckList" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnCheckList" Text="Click here for a thing about the things" runat="server" OnClick="btnCheckList_Click" />
        <br /><br />
        <asp:Label ID="lblBulletList" Text="Here's a bullet list, with actual bullets as bullets, unless I can't find any good bullet pics, then it's whatever it is as bullets" runat="server"></asp:Label>
        <br /><asp:BulletedList ID="BulletedList1" BulletStyle="CustomImage" BulletImageUrl="303small.jpg" runat="server">
            <asp:ListItem>item 1</asp:ListItem>
            <asp:ListItem>item 2</asp:ListItem>
            <asp:ListItem>item 3</asp:ListItem>
        </asp:BulletedList>
    </div>

    </form>
</body>
</html>
