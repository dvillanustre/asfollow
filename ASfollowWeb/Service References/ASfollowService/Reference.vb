﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.17929
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace ASfollowService
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ASfollowService.ASfollowServiceSoap")>  _
    Public Interface ASfollowServiceSoap
        
        'CODEGEN: Generating message contract since element name pingResult from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ping", ReplyAction:="*")>  _
        Function ping(ByVal request As ASfollowService.pingRequest) As ASfollowService.pingResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ping", ReplyAction:="*")>  _
        Function pingAsync(ByVal request As ASfollowService.pingRequest) As System.Threading.Tasks.Task(Of ASfollowService.pingResponse)
        
        'CODEGEN: Generating message contract since element name aboutResult from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/about", ReplyAction:="*")>  _
        Function about(ByVal request As ASfollowService.aboutRequest) As ASfollowService.aboutResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/about", ReplyAction:="*")>  _
        Function aboutAsync(ByVal request As ASfollowService.aboutRequest) As System.Threading.Tasks.Task(Of ASfollowService.aboutResponse)
        
        'CODEGEN: Generating message contract since element name shareInfoMonthlyResult from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/shareInfoMonthly", ReplyAction:="*")>  _
        Function shareInfoMonthly(ByVal request As ASfollowService.shareInfoMonthlyRequest) As ASfollowService.shareInfoMonthlyResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/shareInfoMonthly", ReplyAction:="*")>  _
        Function shareInfoMonthlyAsync(ByVal request As ASfollowService.shareInfoMonthlyRequest) As System.Threading.Tasks.Task(Of ASfollowService.shareInfoMonthlyResponse)
        
        'CODEGEN: Generating message contract since element name shareInfoUrgentResult from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/shareInfoUrgent", ReplyAction:="*")>  _
        Function shareInfoUrgent(ByVal request As ASfollowService.shareInfoUrgentRequest) As ASfollowService.shareInfoUrgentResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/shareInfoUrgent", ReplyAction:="*")>  _
        Function shareInfoUrgentAsync(ByVal request As ASfollowService.shareInfoUrgentRequest) As System.Threading.Tasks.Task(Of ASfollowService.shareInfoUrgentResponse)
        
        'CODEGEN: Generating message contract since element name exportXmlResult from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/exportXml", ReplyAction:="*")>  _
        Function exportXml(ByVal request As ASfollowService.exportXmlRequest) As ASfollowService.exportXmlResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/exportXml", ReplyAction:="*")>  _
        Function exportXmlAsync(ByVal request As ASfollowService.exportXmlRequest) As System.Threading.Tasks.Task(Of ASfollowService.exportXmlResponse)
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class pingRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="ping", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ASfollowService.pingRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ASfollowService.pingRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute()>  _
    Partial Public Class pingRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class pingResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="pingResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ASfollowService.pingResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ASfollowService.pingResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class pingResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public pingResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal pingResult As String)
            MyBase.New
            Me.pingResult = pingResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class aboutRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="about", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ASfollowService.aboutRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ASfollowService.aboutRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute()>  _
    Partial Public Class aboutRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class aboutResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="aboutResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ASfollowService.aboutResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ASfollowService.aboutResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class aboutResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public aboutResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal aboutResult As String)
            MyBase.New
            Me.aboutResult = aboutResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class shareInfoMonthlyRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="shareInfoMonthly", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ASfollowService.shareInfoMonthlyRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ASfollowService.shareInfoMonthlyRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute()>  _
    Partial Public Class shareInfoMonthlyRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class shareInfoMonthlyResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="shareInfoMonthlyResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ASfollowService.shareInfoMonthlyResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ASfollowService.shareInfoMonthlyResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class shareInfoMonthlyResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public shareInfoMonthlyResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal shareInfoMonthlyResult As String)
            MyBase.New
            Me.shareInfoMonthlyResult = shareInfoMonthlyResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class shareInfoUrgentRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="shareInfoUrgent", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ASfollowService.shareInfoUrgentRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ASfollowService.shareInfoUrgentRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute()>  _
    Partial Public Class shareInfoUrgentRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class shareInfoUrgentResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="shareInfoUrgentResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ASfollowService.shareInfoUrgentResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ASfollowService.shareInfoUrgentResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class shareInfoUrgentResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public shareInfoUrgentResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal shareInfoUrgentResult As String)
            MyBase.New
            Me.shareInfoUrgentResult = shareInfoUrgentResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class exportXmlRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="exportXml", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ASfollowService.exportXmlRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ASfollowService.exportXmlRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute()>  _
    Partial Public Class exportXmlRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class exportXmlResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="exportXmlResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ASfollowService.exportXmlResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ASfollowService.exportXmlResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class exportXmlResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public exportXmlResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal exportXmlResult As String)
            MyBase.New
            Me.exportXmlResult = exportXmlResult
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface ASfollowServiceSoapChannel
        Inherits ASfollowService.ASfollowServiceSoap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class ASfollowServiceSoapClient
        Inherits System.ServiceModel.ClientBase(Of ASfollowService.ASfollowServiceSoap)
        Implements ASfollowService.ASfollowServiceSoap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ASfollowService_ASfollowServiceSoap_ping(ByVal request As ASfollowService.pingRequest) As ASfollowService.pingResponse Implements ASfollowService.ASfollowServiceSoap.ping
            Return MyBase.Channel.ping(request)
        End Function
        
        Public Function ping() As String
            Dim inValue As ASfollowService.pingRequest = New ASfollowService.pingRequest()
            inValue.Body = New ASfollowService.pingRequestBody()
            Dim retVal As ASfollowService.pingResponse = CType(Me,ASfollowService.ASfollowServiceSoap).ping(inValue)
            Return retVal.Body.pingResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ASfollowService_ASfollowServiceSoap_pingAsync(ByVal request As ASfollowService.pingRequest) As System.Threading.Tasks.Task(Of ASfollowService.pingResponse) Implements ASfollowService.ASfollowServiceSoap.pingAsync
            Return MyBase.Channel.pingAsync(request)
        End Function
        
        Public Function pingAsync() As System.Threading.Tasks.Task(Of ASfollowService.pingResponse)
            Dim inValue As ASfollowService.pingRequest = New ASfollowService.pingRequest()
            inValue.Body = New ASfollowService.pingRequestBody()
            Return CType(Me,ASfollowService.ASfollowServiceSoap).pingAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ASfollowService_ASfollowServiceSoap_about(ByVal request As ASfollowService.aboutRequest) As ASfollowService.aboutResponse Implements ASfollowService.ASfollowServiceSoap.about
            Return MyBase.Channel.about(request)
        End Function
        
        Public Function about() As String
            Dim inValue As ASfollowService.aboutRequest = New ASfollowService.aboutRequest()
            inValue.Body = New ASfollowService.aboutRequestBody()
            Dim retVal As ASfollowService.aboutResponse = CType(Me,ASfollowService.ASfollowServiceSoap).about(inValue)
            Return retVal.Body.aboutResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ASfollowService_ASfollowServiceSoap_aboutAsync(ByVal request As ASfollowService.aboutRequest) As System.Threading.Tasks.Task(Of ASfollowService.aboutResponse) Implements ASfollowService.ASfollowServiceSoap.aboutAsync
            Return MyBase.Channel.aboutAsync(request)
        End Function
        
        Public Function aboutAsync() As System.Threading.Tasks.Task(Of ASfollowService.aboutResponse)
            Dim inValue As ASfollowService.aboutRequest = New ASfollowService.aboutRequest()
            inValue.Body = New ASfollowService.aboutRequestBody()
            Return CType(Me,ASfollowService.ASfollowServiceSoap).aboutAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ASfollowService_ASfollowServiceSoap_shareInfoMonthly(ByVal request As ASfollowService.shareInfoMonthlyRequest) As ASfollowService.shareInfoMonthlyResponse Implements ASfollowService.ASfollowServiceSoap.shareInfoMonthly
            Return MyBase.Channel.shareInfoMonthly(request)
        End Function
        
        Public Function shareInfoMonthly() As String
            Dim inValue As ASfollowService.shareInfoMonthlyRequest = New ASfollowService.shareInfoMonthlyRequest()
            inValue.Body = New ASfollowService.shareInfoMonthlyRequestBody()
            Dim retVal As ASfollowService.shareInfoMonthlyResponse = CType(Me,ASfollowService.ASfollowServiceSoap).shareInfoMonthly(inValue)
            Return retVal.Body.shareInfoMonthlyResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ASfollowService_ASfollowServiceSoap_shareInfoMonthlyAsync(ByVal request As ASfollowService.shareInfoMonthlyRequest) As System.Threading.Tasks.Task(Of ASfollowService.shareInfoMonthlyResponse) Implements ASfollowService.ASfollowServiceSoap.shareInfoMonthlyAsync
            Return MyBase.Channel.shareInfoMonthlyAsync(request)
        End Function
        
        Public Function shareInfoMonthlyAsync() As System.Threading.Tasks.Task(Of ASfollowService.shareInfoMonthlyResponse)
            Dim inValue As ASfollowService.shareInfoMonthlyRequest = New ASfollowService.shareInfoMonthlyRequest()
            inValue.Body = New ASfollowService.shareInfoMonthlyRequestBody()
            Return CType(Me,ASfollowService.ASfollowServiceSoap).shareInfoMonthlyAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ASfollowService_ASfollowServiceSoap_shareInfoUrgent(ByVal request As ASfollowService.shareInfoUrgentRequest) As ASfollowService.shareInfoUrgentResponse Implements ASfollowService.ASfollowServiceSoap.shareInfoUrgent
            Return MyBase.Channel.shareInfoUrgent(request)
        End Function
        
        Public Function shareInfoUrgent() As String
            Dim inValue As ASfollowService.shareInfoUrgentRequest = New ASfollowService.shareInfoUrgentRequest()
            inValue.Body = New ASfollowService.shareInfoUrgentRequestBody()
            Dim retVal As ASfollowService.shareInfoUrgentResponse = CType(Me,ASfollowService.ASfollowServiceSoap).shareInfoUrgent(inValue)
            Return retVal.Body.shareInfoUrgentResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ASfollowService_ASfollowServiceSoap_shareInfoUrgentAsync(ByVal request As ASfollowService.shareInfoUrgentRequest) As System.Threading.Tasks.Task(Of ASfollowService.shareInfoUrgentResponse) Implements ASfollowService.ASfollowServiceSoap.shareInfoUrgentAsync
            Return MyBase.Channel.shareInfoUrgentAsync(request)
        End Function
        
        Public Function shareInfoUrgentAsync() As System.Threading.Tasks.Task(Of ASfollowService.shareInfoUrgentResponse)
            Dim inValue As ASfollowService.shareInfoUrgentRequest = New ASfollowService.shareInfoUrgentRequest()
            inValue.Body = New ASfollowService.shareInfoUrgentRequestBody()
            Return CType(Me,ASfollowService.ASfollowServiceSoap).shareInfoUrgentAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ASfollowService_ASfollowServiceSoap_exportXml(ByVal request As ASfollowService.exportXmlRequest) As ASfollowService.exportXmlResponse Implements ASfollowService.ASfollowServiceSoap.exportXml
            Return MyBase.Channel.exportXml(request)
        End Function
        
        Public Function exportXml() As String
            Dim inValue As ASfollowService.exportXmlRequest = New ASfollowService.exportXmlRequest()
            inValue.Body = New ASfollowService.exportXmlRequestBody()
            Dim retVal As ASfollowService.exportXmlResponse = CType(Me,ASfollowService.ASfollowServiceSoap).exportXml(inValue)
            Return retVal.Body.exportXmlResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ASfollowService_ASfollowServiceSoap_exportXmlAsync(ByVal request As ASfollowService.exportXmlRequest) As System.Threading.Tasks.Task(Of ASfollowService.exportXmlResponse) Implements ASfollowService.ASfollowServiceSoap.exportXmlAsync
            Return MyBase.Channel.exportXmlAsync(request)
        End Function
        
        Public Function exportXmlAsync() As System.Threading.Tasks.Task(Of ASfollowService.exportXmlResponse)
            Dim inValue As ASfollowService.exportXmlRequest = New ASfollowService.exportXmlRequest()
            inValue.Body = New ASfollowService.exportXmlRequestBody()
            Return CType(Me,ASfollowService.ASfollowServiceSoap).exportXmlAsync(inValue)
        End Function
    End Class
End Namespace
