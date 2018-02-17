<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Epic_SpyChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 190px;
            height: 194px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial, Helvetica, sans-serif">
            <h1>
                <img alt="" class="auto-style1" src="epic-spies-logo.jpg" /></h1>
            <h1>Spy New Assignment Form</h1>
        </div>
        <p>
            Spy Code Name: <asp:TextBox ID="codeNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            New Assignment Name:
            <asp:TextBox ID="assignTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            End Date of Previous Assignment:<asp:Calendar ID="prevAssignCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            Start Date of New Assignment:<asp:Calendar ID="startAssgnCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            Project End Date of New Assignment:<asp:Calendar ID="projectCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="assignButton" runat="server" OnClick="AssignButton_Click" Text="Assign Spy" />
        </p>
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
