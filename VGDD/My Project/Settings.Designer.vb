﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.2.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Public NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("320")>  _
        Public Property DefaultWidth() As Short
            Get
                Return CType(Me("DefaultWidth"),Short)
            End Get
            Set
                Me("DefaultWidth") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("240")>  _
        Public Property DefaultHeight() As Short
            Get
                Return CType(Me("DefaultHeight"),Short)
            End Get
            Set
                Me("DefaultHeight") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property MyTop() As Integer
            Get
                Return CType(Me("MyTop"),Integer)
            End Get
            Set
                Me("MyTop") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property MyLeft() As Integer
            Get
                Return CType(Me("MyLeft"),Integer)
            End Get
            Set
                Me("MyLeft") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("797")>  _
        Public Property MyWidth() As Integer
            Get
                Return CType(Me("MyWidth"),Integer)
            End Get
            Set
                Me("MyWidth") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("614")>  _
        Public Property MyHeight() As Integer
            Get
                Return CType(Me("MyHeight"),Integer)
            End Get
            Set
                Me("MyHeight") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property Recent() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("Recent"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("Recent") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("16")>  _
        Public Property DefaultColourDepth() As Short
            Get
                Return CType(Me("DefaultColourDepth"),Short)
            End Get
            Set
                Me("DefaultColourDepth") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property UseIndexedColours() As Boolean
            Get
                Return CType(Me("UseIndexedColours"),Boolean)
            End Get
            Set
                Me("UseIndexedColours") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property UseMultiByteChars() As Boolean
            Get
                Return CType(Me("UseMultiByteChars"),Boolean)
            End Get
            Set
                Me("UseMultiByteChars") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property UseGRC() As Boolean
            Get
                Return CType(Me("UseGRC"),Boolean)
            End Get
            Set
                Me("UseGRC") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("java.exe -jar")>  _
        Public Property JavaCommand() As String
            Get
                Return CType(Me("JavaCommand"),String)
            End Get
            Set
                Me("JavaCommand") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("C32")>  _
        Public Property DefaultCompiler() As String
            Get
                Return CType(Me("DefaultCompiler"),String)
            End Get
            Set
                Me("DefaultCompiler") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SettingsUpgraded() As Boolean
            Get
                Return CType(Me("SettingsUpgraded"),Boolean)
            End Get
            Set
                Me("SettingsUpgraded") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("xxx")>  _
        Public Property MalPath() As String
            Get
                Return CType(Me("MalPath"),String)
            End Get
            Set
                Me("MalPath") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property MplabXWizardDevBoard() As String
            Get
                Return CType(Me("MplabXWizardDevBoard"),String)
            End Get
            Set
                Me("MplabXWizardDevBoard") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property MplabXWizardExpBoard() As String
            Get
                Return CType(Me("MplabXWizardExpBoard"),String)
            End Get
            Set
                Me("MplabXWizardExpBoard") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property BmpChooserTop() As Integer
            Get
                Return CType(Me("BmpChooserTop"),Integer)
            End Get
            Set
                Me("BmpChooserTop") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property BmpChooserLeft() As Integer
            Get
                Return CType(Me("BmpChooserLeft"),Integer)
            End Get
            Set
                Me("BmpChooserLeft") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property BmpChooserHeight() As Integer
            Get
                Return CType(Me("BmpChooserHeight"),Integer)
            End Get
            Set
                Me("BmpChooserHeight") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property BmpChooserWidth() As Integer
            Get
                Return CType(Me("BmpChooserWidth"),Integer)
            End Get
            Set
                Me("BmpChooserWidth") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property MplabXWizardDispBoard() As String
            Get
                Return CType(Me("MplabXWizardDispBoard"),String)
            End Get
            Set
                Me("MplabXWizardDispBoard") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("90")>  _
        Public Property MplabXWizardDispOrientation() As Integer
            Get
                Return CType(Me("MplabXWizardDispOrientation"),Integer)
            End Get
            Set
                Me("MplabXWizardDispOrientation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("100, 100")>  _
        Public Property MagnifyWindowLocation() As Global.System.Drawing.Point
            Get
                Return CType(Me("MagnifyWindowLocation"),Global.System.Drawing.Point)
            End Get
            Set
                Me("MagnifyWindowLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("200, 200")>  _
        Public Property MagnifyWindowSize() As Global.System.Drawing.Size
            Get
                Return CType(Me("MagnifyWindowSize"),Global.System.Drawing.Size)
            End Get
            Set
                Me("MagnifyWindowSize") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("3")>  _
        Public Property MagnifyWindowZoomFactor() As Integer
            Get
                Return CType(Me("MagnifyWindowZoomFactor"),Integer)
            End Get
            Set
                Me("MagnifyWindowZoomFactor") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property DemoExtractFolder() As String
            Get
                Return CType(Me("DemoExtractFolder"),String)
            End Get
            Set
                Me("DemoExtractFolder") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Maximized")>  _
        Public Property MyWindowState() As Global.System.Windows.Forms.FormWindowState
            Get
                Return CType(Me("MyWindowState"),Global.System.Windows.Forms.FormWindowState)
            End Get
            Set
                Me("MyWindowState") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property CopyBitmapsInVgddProjectFolder() As Boolean
            Get
                Return CType(Me("CopyBitmapsInVgddProjectFolder"),Boolean)
            End Get
            Set
                Me("CopyBitmapsInVgddProjectFolder") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property ProjectUseBmpPrefix() As Boolean
            Get
                Return CType(Me("ProjectUseBmpPrefix"),Boolean)
            End Get
            Set
                Me("ProjectUseBmpPrefix") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Alphabetical")>  _
        Public Property MyPropertySort() As Global.System.Windows.Forms.PropertySort
            Get
                Return CType(Me("MyPropertySort"),Global.System.Windows.Forms.PropertySort)
            End Get
            Set
                Me("MyPropertySort") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property MyUserTemplatesFolder() As String
            Get
                Return CType(Me("MyUserTemplatesFolder"),String)
            End Get
            Set
                Me("MyUserTemplatesFolder") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property MyMakeBackups() As Boolean
            Get
                Return CType(Me("MyMakeBackups"),Boolean)
            End Get
            Set
                Me("MyMakeBackups") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property MyStoreLayout() As Boolean
            Get
                Return CType(Me("MyStoreLayout"),Boolean)
            End Get
            Set
                Me("MyStoreLayout") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property MultiLanguageTranslations() As Integer
            Get
                Return CType(Me("MultiLanguageTranslations"),Integer)
            End Get
            Set
                Me("MultiLanguageTranslations") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property ConfiguredFrameworks() As Global.VGDDCommon.VGDDFrameworkCollection
            Get
                Return CType(Me("ConfiguredFrameworks"),Global.VGDDCommon.VGDDFrameworkCollection)
            End Get
            Set
                Me("ConfiguredFrameworks") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property MplabXIpcIpAddress() As String
            Get
                Return CType(Me("MplabXIpcIpAddress"),String)
            End Get
            Set
                Me("MplabXIpcIpAddress") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("4242")>  _
        Public Property MplabXIpcPort() As Integer
            Get
                Return CType(Me("MplabXIpcPort"),Integer)
            End Get
            Set
                Me("MplabXIpcPort") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property MplabXUseIpc() As Boolean
            Get
                Return CType(Me("MplabXUseIpc"),Boolean)
            End Get
            Set
                Me("MplabXUseIpc") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("<Scheme Name=""Default"" Font=""GentiumBasicRegular11"" BackgroundType=""GFX_BACKGROUN"& _ 
            "D_COLOR"" FillStyle=""GFX_FILL_STYLE_COLOR"" CommonBkLeft=""0"" CommonBkTop=""0"" Backg"& _ 
            "roundImageName="""" AlphaValue=""0"" EmbossSize=""3"">"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <Color0>192,255,255</Color0>"& _ 
            ""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <Color1>128,128,255</Color1>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <Colordisabled>208,224,240</Colordisabled>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)& _ 
            "  <Commonbkcolor>255,255,255</Commonbkcolor>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <Embossdkcolor>0,0,255</Embossdk"& _ 
            "color>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <Embossltcolor>192,192,255</Embossltcolor>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <Textcolor0>24,24,24</Te"& _ 
            "xtcolor0>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <Textcolor1>248,252,248</Textcolor1>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <Textcolordisabled>128,128,"& _ 
            "128</Textcolordisabled>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <gradientStartColor>211,211,211</gradientStartColor>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <gradientEndColor>169,169,169</gradientEndColor>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"</Scheme>")>  _
        Public Property DefaultSchemeXML() As String
            Get
                Return CType(Me("DefaultSchemeXML"),String)
            End Get
            Set
                Me("DefaultSchemeXML") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("grc.jar")>  _
        Public Property FallbackGRCPath() As String
            Get
                Return CType(Me("FallbackGRCPath"),String)
            End Get
            Set
                Me("FallbackGRCPath") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.My.MySettings
            Get
                Return Global.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
