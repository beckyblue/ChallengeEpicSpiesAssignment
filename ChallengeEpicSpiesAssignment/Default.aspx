﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 199px;
            height: 212px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img alt="spy" class="auto-style1" src="epic-spies-logo.jpg" /><br />
            <h2>Spy New Assignment Form</h2>
            Spy Code Name:&nbsp;
            <asp:TextBox ID="codeNameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            New Assignment Name:&nbsp; <asp:TextBox ID="newAssignmentTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            End Date of Previous Assignment:<asp:Calendar ID="previousCalendar" runat="server"></asp:Calendar>
            <br />
            <br />
            Start Date of New Assignment:<asp:Calendar ID="newCalendar" runat="server"></asp:Calendar>
            <br />
            <br />
            Projected End Date of New Assignment:<asp:Calendar ID="endCalendar" runat="server"></asp:Calendar>
            <br />
            <asp:Button ID="AssignButton" runat="server" OnClick="AssignButton_Click" Text="Assign Spy" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
