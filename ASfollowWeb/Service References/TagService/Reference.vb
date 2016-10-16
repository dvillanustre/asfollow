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

Imports System
Imports System.Runtime.Serialization

Namespace TagService
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="tag", [Namespace]:="http://tempuri.org/"),  _
     System.SerializableAttribute()>  _
    Partial Public Class tag
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        Private tag_idField As Long
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private nameField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private colorField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property tag_id() As Long
            Get
                Return Me.tag_idField
            End Get
            Set
                If (Me.tag_idField.Equals(value) <> true) Then
                    Me.tag_idField = value
                    Me.RaisePropertyChanged("tag_id")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public Property name() As String
            Get
                Return Me.nameField
            End Get
            Set
                If (Object.ReferenceEquals(Me.nameField, value) <> true) Then
                    Me.nameField = value
                    Me.RaisePropertyChanged("name")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=2)>  _
        Public Property color() As String
            Get
                Return Me.colorField
            End Get
            Set
                If (Object.ReferenceEquals(Me.colorField, value) <> true) Then
                    Me.colorField = value
                    Me.RaisePropertyChanged("color")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.CollectionDataContractAttribute(Name:="ArrayOfTag", [Namespace]:="http://tempuri.org/", ItemName:="tag"),  _
     System.SerializableAttribute()>  _
    Public Class ArrayOfTag
        Inherits System.Collections.Generic.List(Of TagService.tag)
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="TagService.TagServiceSoap")>  _
    Public Interface TagServiceSoap
        
        'CODEGEN: Generating message contract since element name pingResult from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ping", ReplyAction:="*")>  _
        Function ping(ByVal request As TagService.pingRequest) As TagService.pingResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ping", ReplyAction:="*")>  _
        Function pingAsync(ByVal request As TagService.pingRequest) As System.Threading.Tasks.Task(Of TagService.pingResponse)
        
        'CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/addTagByName", ReplyAction:="*")>  _
        Function addTagByName(ByVal request As TagService.addTagByNameRequest) As TagService.addTagByNameResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/addTagByName", ReplyAction:="*")>  _
        Function addTagByNameAsync(ByVal request As TagService.addTagByNameRequest) As System.Threading.Tasks.Task(Of TagService.addTagByNameResponse)
        
        'CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/addTagByNameAndColor", ReplyAction:="*")>  _
        Function addTagByNameAndColor(ByVal request As TagService.addTagByNameAndColorRequest) As TagService.addTagByNameAndColorResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/addTagByNameAndColor", ReplyAction:="*")>  _
        Function addTagByNameAndColorAsync(ByVal request As TagService.addTagByNameAndColorRequest) As System.Threading.Tasks.Task(Of TagService.addTagByNameAndColorResponse)
        
        'CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/updateTag", ReplyAction:="*")>  _
        Function updateTag(ByVal request As TagService.updateTagRequest) As TagService.updateTagResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/updateTag", ReplyAction:="*")>  _
        Function updateTagAsync(ByVal request As TagService.updateTagRequest) As System.Threading.Tasks.Task(Of TagService.updateTagResponse)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/deleteTag", ReplyAction:="*")>  _
        Function deleteTag(ByVal tagId As Long) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/deleteTag", ReplyAction:="*")>  _
        Function deleteTagAsync(ByVal tagId As Long) As System.Threading.Tasks.Task(Of Boolean)
        
        'CODEGEN: Generating message contract since element name getTagsResult from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/getTags", ReplyAction:="*")>  _
        Function getTags(ByVal request As TagService.getTagsRequest) As TagService.getTagsResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/getTags", ReplyAction:="*")>  _
        Function getTagsAsync(ByVal request As TagService.getTagsRequest) As System.Threading.Tasks.Task(Of TagService.getTagsResponse)
        
        'CODEGEN: Generating message contract since element name getTagResult from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/getTag", ReplyAction:="*")>  _
        Function getTag(ByVal request As TagService.getTagRequest) As TagService.getTagResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/getTag", ReplyAction:="*")>  _
        Function getTagAsync(ByVal request As TagService.getTagRequest) As System.Threading.Tasks.Task(Of TagService.getTagResponse)
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class pingRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="ping", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As TagService.pingRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As TagService.pingRequestBody)
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
        Public Body As TagService.pingResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As TagService.pingResponseBody)
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
    Partial Public Class addTagByNameRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="addTagByName", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As TagService.addTagByNameRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As TagService.addTagByNameRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class addTagByNameRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public name As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal name As String)
            MyBase.New
            Me.name = name
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class addTagByNameResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="addTagByNameResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As TagService.addTagByNameResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As TagService.addTagByNameResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class addTagByNameResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public addTagByNameResult As TagService.tag
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal addTagByNameResult As TagService.tag)
            MyBase.New
            Me.addTagByNameResult = addTagByNameResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class addTagByNameAndColorRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="addTagByNameAndColor", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As TagService.addTagByNameAndColorRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As TagService.addTagByNameAndColorRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class addTagByNameAndColorRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public name As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public color As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal name As String, ByVal color As String)
            MyBase.New
            Me.name = name
            Me.color = color
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class addTagByNameAndColorResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="addTagByNameAndColorResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As TagService.addTagByNameAndColorResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As TagService.addTagByNameAndColorResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class addTagByNameAndColorResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public addTagByNameAndColorResult As TagService.tag
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal addTagByNameAndColorResult As TagService.tag)
            MyBase.New
            Me.addTagByNameAndColorResult = addTagByNameAndColorResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class updateTagRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="updateTag", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As TagService.updateTagRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As TagService.updateTagRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class updateTagRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public name As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public color As String
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=2)>  _
        Public tagId As Long
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal name As String, ByVal color As String, ByVal tagId As Long)
            MyBase.New
            Me.name = name
            Me.color = color
            Me.tagId = tagId
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class updateTagResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="updateTagResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As TagService.updateTagResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As TagService.updateTagResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class updateTagResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=0)>  _
        Public updateTagResult As Boolean
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal updateTagResult As Boolean)
            MyBase.New
            Me.updateTagResult = updateTagResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class getTagsRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="getTags", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As TagService.getTagsRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As TagService.getTagsRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute()>  _
    Partial Public Class getTagsRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class getTagsResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="getTagsResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As TagService.getTagsResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As TagService.getTagsResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class getTagsResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public getTagsResult As TagService.ArrayOfTag
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal getTagsResult As TagService.ArrayOfTag)
            MyBase.New
            Me.getTagsResult = getTagsResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class getTagRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="getTag", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As TagService.getTagRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As TagService.getTagRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class getTagRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=0)>  _
        Public tagId As Long
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal tagId As Long)
            MyBase.New
            Me.tagId = tagId
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class getTagResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="getTagResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As TagService.getTagResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As TagService.getTagResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class getTagResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public getTagResult As TagService.tag
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal getTagResult As TagService.tag)
            MyBase.New
            Me.getTagResult = getTagResult
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface TagServiceSoapChannel
        Inherits TagService.TagServiceSoap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class TagServiceSoapClient
        Inherits System.ServiceModel.ClientBase(Of TagService.TagServiceSoap)
        Implements TagService.TagServiceSoap
        
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
        Function TagService_TagServiceSoap_ping(ByVal request As TagService.pingRequest) As TagService.pingResponse Implements TagService.TagServiceSoap.ping
            Return MyBase.Channel.ping(request)
        End Function
        
        Public Function ping() As String
            Dim inValue As TagService.pingRequest = New TagService.pingRequest()
            inValue.Body = New TagService.pingRequestBody()
            Dim retVal As TagService.pingResponse = CType(Me,TagService.TagServiceSoap).ping(inValue)
            Return retVal.Body.pingResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function TagService_TagServiceSoap_pingAsync(ByVal request As TagService.pingRequest) As System.Threading.Tasks.Task(Of TagService.pingResponse) Implements TagService.TagServiceSoap.pingAsync
            Return MyBase.Channel.pingAsync(request)
        End Function
        
        Public Function pingAsync() As System.Threading.Tasks.Task(Of TagService.pingResponse)
            Dim inValue As TagService.pingRequest = New TagService.pingRequest()
            inValue.Body = New TagService.pingRequestBody()
            Return CType(Me,TagService.TagServiceSoap).pingAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function TagService_TagServiceSoap_addTagByName(ByVal request As TagService.addTagByNameRequest) As TagService.addTagByNameResponse Implements TagService.TagServiceSoap.addTagByName
            Return MyBase.Channel.addTagByName(request)
        End Function
        
        Public Function addTagByName(ByVal name As String) As TagService.tag
            Dim inValue As TagService.addTagByNameRequest = New TagService.addTagByNameRequest()
            inValue.Body = New TagService.addTagByNameRequestBody()
            inValue.Body.name = name
            Dim retVal As TagService.addTagByNameResponse = CType(Me,TagService.TagServiceSoap).addTagByName(inValue)
            Return retVal.Body.addTagByNameResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function TagService_TagServiceSoap_addTagByNameAsync(ByVal request As TagService.addTagByNameRequest) As System.Threading.Tasks.Task(Of TagService.addTagByNameResponse) Implements TagService.TagServiceSoap.addTagByNameAsync
            Return MyBase.Channel.addTagByNameAsync(request)
        End Function
        
        Public Function addTagByNameAsync(ByVal name As String) As System.Threading.Tasks.Task(Of TagService.addTagByNameResponse)
            Dim inValue As TagService.addTagByNameRequest = New TagService.addTagByNameRequest()
            inValue.Body = New TagService.addTagByNameRequestBody()
            inValue.Body.name = name
            Return CType(Me,TagService.TagServiceSoap).addTagByNameAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function TagService_TagServiceSoap_addTagByNameAndColor(ByVal request As TagService.addTagByNameAndColorRequest) As TagService.addTagByNameAndColorResponse Implements TagService.TagServiceSoap.addTagByNameAndColor
            Return MyBase.Channel.addTagByNameAndColor(request)
        End Function
        
        Public Function addTagByNameAndColor(ByVal name As String, ByVal color As String) As TagService.tag
            Dim inValue As TagService.addTagByNameAndColorRequest = New TagService.addTagByNameAndColorRequest()
            inValue.Body = New TagService.addTagByNameAndColorRequestBody()
            inValue.Body.name = name
            inValue.Body.color = color
            Dim retVal As TagService.addTagByNameAndColorResponse = CType(Me,TagService.TagServiceSoap).addTagByNameAndColor(inValue)
            Return retVal.Body.addTagByNameAndColorResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function TagService_TagServiceSoap_addTagByNameAndColorAsync(ByVal request As TagService.addTagByNameAndColorRequest) As System.Threading.Tasks.Task(Of TagService.addTagByNameAndColorResponse) Implements TagService.TagServiceSoap.addTagByNameAndColorAsync
            Return MyBase.Channel.addTagByNameAndColorAsync(request)
        End Function
        
        Public Function addTagByNameAndColorAsync(ByVal name As String, ByVal color As String) As System.Threading.Tasks.Task(Of TagService.addTagByNameAndColorResponse)
            Dim inValue As TagService.addTagByNameAndColorRequest = New TagService.addTagByNameAndColorRequest()
            inValue.Body = New TagService.addTagByNameAndColorRequestBody()
            inValue.Body.name = name
            inValue.Body.color = color
            Return CType(Me,TagService.TagServiceSoap).addTagByNameAndColorAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function TagService_TagServiceSoap_updateTag(ByVal request As TagService.updateTagRequest) As TagService.updateTagResponse Implements TagService.TagServiceSoap.updateTag
            Return MyBase.Channel.updateTag(request)
        End Function
        
        Public Function updateTag(ByVal name As String, ByVal color As String, ByVal tagId As Long) As Boolean
            Dim inValue As TagService.updateTagRequest = New TagService.updateTagRequest()
            inValue.Body = New TagService.updateTagRequestBody()
            inValue.Body.name = name
            inValue.Body.color = color
            inValue.Body.tagId = tagId
            Dim retVal As TagService.updateTagResponse = CType(Me,TagService.TagServiceSoap).updateTag(inValue)
            Return retVal.Body.updateTagResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function TagService_TagServiceSoap_updateTagAsync(ByVal request As TagService.updateTagRequest) As System.Threading.Tasks.Task(Of TagService.updateTagResponse) Implements TagService.TagServiceSoap.updateTagAsync
            Return MyBase.Channel.updateTagAsync(request)
        End Function
        
        Public Function updateTagAsync(ByVal name As String, ByVal color As String, ByVal tagId As Long) As System.Threading.Tasks.Task(Of TagService.updateTagResponse)
            Dim inValue As TagService.updateTagRequest = New TagService.updateTagRequest()
            inValue.Body = New TagService.updateTagRequestBody()
            inValue.Body.name = name
            inValue.Body.color = color
            inValue.Body.tagId = tagId
            Return CType(Me,TagService.TagServiceSoap).updateTagAsync(inValue)
        End Function
        
        Public Function deleteTag(ByVal tagId As Long) As Boolean Implements TagService.TagServiceSoap.deleteTag
            Return MyBase.Channel.deleteTag(tagId)
        End Function
        
        Public Function deleteTagAsync(ByVal tagId As Long) As System.Threading.Tasks.Task(Of Boolean) Implements TagService.TagServiceSoap.deleteTagAsync
            Return MyBase.Channel.deleteTagAsync(tagId)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function TagService_TagServiceSoap_getTags(ByVal request As TagService.getTagsRequest) As TagService.getTagsResponse Implements TagService.TagServiceSoap.getTags
            Return MyBase.Channel.getTags(request)
        End Function
        
        Public Function getTags() As TagService.ArrayOfTag
            Dim inValue As TagService.getTagsRequest = New TagService.getTagsRequest()
            inValue.Body = New TagService.getTagsRequestBody()
            Dim retVal As TagService.getTagsResponse = CType(Me,TagService.TagServiceSoap).getTags(inValue)
            Return retVal.Body.getTagsResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function TagService_TagServiceSoap_getTagsAsync(ByVal request As TagService.getTagsRequest) As System.Threading.Tasks.Task(Of TagService.getTagsResponse) Implements TagService.TagServiceSoap.getTagsAsync
            Return MyBase.Channel.getTagsAsync(request)
        End Function
        
        Public Function getTagsAsync() As System.Threading.Tasks.Task(Of TagService.getTagsResponse)
            Dim inValue As TagService.getTagsRequest = New TagService.getTagsRequest()
            inValue.Body = New TagService.getTagsRequestBody()
            Return CType(Me,TagService.TagServiceSoap).getTagsAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function TagService_TagServiceSoap_getTag(ByVal request As TagService.getTagRequest) As TagService.getTagResponse Implements TagService.TagServiceSoap.getTag
            Return MyBase.Channel.getTag(request)
        End Function
        
        Public Function getTag(ByVal tagId As Long) As TagService.tag
            Dim inValue As TagService.getTagRequest = New TagService.getTagRequest()
            inValue.Body = New TagService.getTagRequestBody()
            inValue.Body.tagId = tagId
            Dim retVal As TagService.getTagResponse = CType(Me,TagService.TagServiceSoap).getTag(inValue)
            Return retVal.Body.getTagResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function TagService_TagServiceSoap_getTagAsync(ByVal request As TagService.getTagRequest) As System.Threading.Tasks.Task(Of TagService.getTagResponse) Implements TagService.TagServiceSoap.getTagAsync
            Return MyBase.Channel.getTagAsync(request)
        End Function
        
        Public Function getTagAsync(ByVal tagId As Long) As System.Threading.Tasks.Task(Of TagService.getTagResponse)
            Dim inValue As TagService.getTagRequest = New TagService.getTagRequest()
            inValue.Body = New TagService.getTagRequestBody()
            inValue.Body.tagId = tagId
            Return CType(Me,TagService.TagServiceSoap).getTagAsync(inValue)
        End Function
    End Class
End Namespace
