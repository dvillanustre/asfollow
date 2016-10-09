﻿Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Imports Business

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class ASfollowService
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function ping() As String
        Return "pong"
    End Function

    <WebMethod()> _
    Public Function about() As String
        Return "ASfollow - De la siguiente manera - " & Now.ToString()
    End Function

    <WebMethod()> _
    Public Function shareInfo() As String
        EmailService.getInstance().shareInfo()

        Return Now.ToString()
    End Function

End Class