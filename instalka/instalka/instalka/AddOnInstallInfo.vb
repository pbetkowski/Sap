'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On


Namespace AddOnInstaller
    
    Public Class AddOnInstallInfo
        
        Public StrAddOnInstallPath As String
        
        Public AddOnName As String
        
        Public PartnerName As String
        
        Public ExeFile As String
        
        Public DIFile As String
        
        Public UIFile As String
        
        Public B1WizardBaseFile As String
        
        Public ExtraFiles As System.String()
        
        Public ExtraDirectories As System.String()
        
        Public RestartNeeded As Boolean
        
        Public Sub New()
            MyBase.New
            'INITIALIZATION CODE	...
            AddOnName = "EP"
            PartnerName = "EP"
            RestartNeeded = False
            ExeFile = "PowerBusiness.exe"
            ExtraFiles = New String() {"PowerBusiness.b1s"}
            ExtraDirectories = New String() {""}
        End Sub
    End Class
End Namespace
