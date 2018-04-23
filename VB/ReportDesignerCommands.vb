Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Data
Imports System.Windows.Markup
Imports DevExpress.Mvvm
Imports DevExpress.Xpf.Reports.UserDesigner
Imports DevExpress.Xpf.Reports.UserDesigner.Native

Namespace CustomCommands
    Public NotInheritable Class ReportDesignerCommands

        Private Sub New()
        End Sub

        Public Shared ReadOnly Property ToggleReportDrawGridCommand() As DelegateCommand(Of ReportDesigner)
            Get
                Return New DelegateCommand(Of ReportDesigner)(AddressOf ShowGrid)
            End Get
        End Property
        Private Shared Sub ShowGrid(ByVal designer As ReportDesigner)
            Tracker.Set(designer.ActiveDocument.XRObject, Function(x) x.DrawGrid, (Not designer.ActiveDocument.XRObject.DrawGrid))
        End Sub
    End Class
    Public Class CustomCommandConverter
        Inherits MarkupExtension
        Implements IValueConverter

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function

        #Region "IValueConverter Members"

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            If TypeOf value Is Boolean AndAlso DirectCast(value, Boolean) Then
                Return "Hide Grid Lines"
            End If
            Return "Show Grid Lines"
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function

        #End Region
    End Class
End Namespace
