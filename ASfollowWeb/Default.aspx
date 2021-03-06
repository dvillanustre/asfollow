﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="ASfollowWeb._Default" %>
<%@ Import Namespace="ASfollowWeb" %>

<!DOCTYPE html>

<script runat="server">
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASfollow - De la siguiente manera</title>
    <link rel="stylesheet" type="text/css" href="/data/css/ASfollowWeb.css" />
    <link rel="stylesheet" type="text/css" href="/data/css/General.css" />
    <link href="/data/photos/favicon.ico" rel="shortcut icon" type="image/x-icon" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="boxResumeAmount">TOTAL: $<%=AllServices.getInstance().getTotalAmount().ToString()%></div>
    <asp:Button runat="server" ID="btnRefreshSteps" CssClass="generalAction refreshPic" OnClick="refreshSteps_Click" Text="" ToolTip="Reset tareas realizadas"/>
    <asp:Button runat="server" ID="btnShareInfo" CssClass="generalAction sharePic" OnClick="shareInfo_Click" Text="" ToolTip="Enviar acciones repetitivas"/>
    <asp:Button runat="server" ID="btnShareUrgentInfo" CssClass="generalAction shareUrgentPic" OnClick="shareUrgentInfo_Click" Text="" ToolTip="Enviar acciones urgentes"/>
    <asp:Button runat="server" ID="addNewUnit" CssClass="generalAction addUnitPic" OnClick="addNewUnit_Click" Text="" ToolTip="Agregar Unidad"/>
    <asp:Button runat="server" ID="exportToXml" CssClass="generalAction exportXmlPic" OnClick="exportToXml_Click" Text="" ToolTip="Exportar a XML"/>

    <div class="centralContent">
        
        <asp:Button runat="server" ID="btnGoToActions" style="display:none;" OnClick="btnGoToActions_Click" CommandArgument="" />
        <asp:Button runat="server" ID="deleteUnit" style="display:none;" OnClick="deleteUnit_Click" Text="" />
        <asp:HiddenField runat="server" ID="unitIdHidden" value="" />

        <%For Each unit As Entity.unit In AllServices.getInstance().getUnits()%>
            <div class="boxResume">
                <table class="tableResume" onclick="document.getElementById('unitIdHidden').value='<%=unit.unit_id.ToString()%>';document.getElementById('<%= btnGoToActions.ClientID%>').click()">
                    <tr class="boxResume-rowInit">
                        <td><b><%=unit.name.ToUpper()%></b></td>
                    </tr>
                    <tr>
                        <td><img class="boxResume-picUrl" src="<%=AllServices.getInstance().getPicUrlByUnitType(unit.type_id) %>" /></td>
                    </tr>
                    <tr class="boxResume-rowEnd">
                        <td>$<%=AllServices.getInstance().getTotalAmountByUnitId(unit.unit_id)%></td>
                    </tr>
                </table>
                <a href="#" onclick="document.getElementById('unitIdHidden').value='<%=unit.unit_id.ToString()%>';document.getElementById('<%= deleteUnit.ClientID%>').click();">Borrar</a>
            </div>
        <%Next%>
    </div>
    </form>
</body>
</html>
