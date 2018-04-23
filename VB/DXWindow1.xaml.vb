Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Linq
Imports System.Runtime.InteropServices
Imports System.Security
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.PropertyGrid
Imports DevExpress.Xpf.Reports.UserDesigner
Imports DevExpress.XtraReports.UI


Namespace CustomCommands
    ''' <summary>
    ''' Interaction logic for DXWindow1.xaml
    ''' </summary>
    Partial Public Class DXWindow1
        Inherits DXWindow

        Public Sub New()
            InitializeComponent()
            reportDesigner.OpenDocument(New XtraReport())
        End Sub
    End Class


End Namespace
