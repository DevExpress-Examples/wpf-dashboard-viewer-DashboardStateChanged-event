Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWpf
Imports System
Imports System.Linq
Imports System.Windows

Namespace WPF_DashboardStateChanged_Event

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub DashboardControl_DashboardStateChanged(ByVal sender As Object, ByVal e As DashboardStateChangedWpfEventArgs)
            Dim newState = e.DashboardState
            Dim message = String.Empty
            For Each itemState As DashboardItemState In newState.Items
                Dim item = dashboardControl1.Dashboard.Items(itemState.ItemName)
                message += item.Name
                If itemState.DrillDownValues.Count <> 0 Then
                    message += Microsoft.VisualBasic.Constants.vbLf & "Filter Drill-Down:" & " " & String.Join(",", itemState.DrillDownValues)
                End If

                If itemState.MasterFilterValues.Count <> 0 Then
                    message += Microsoft.VisualBasic.Constants.vbLf & "Master Filter:" & " " & String.Join(" | ", itemState.MasterFilterValues.[Select](Function(v) String.Join(",", v)))
                End If

                If itemState.RangeFilterState.Selection.Minimum IsNot Nothing OrElse itemState.RangeFilterState.Selection.Maximum IsNot Nothing Then
                    message += Microsoft.VisualBasic.Constants.vbLf & "Range Filter:" & " " & (CDate(itemState.RangeFilterState.Selection.Minimum)).ToString("y") & "-" & (CDate(itemState.RangeFilterState.Selection.Maximum)).ToString("y")
                End If

                message += Environment.NewLine
                message += Microsoft.VisualBasic.Constants.vbLf
            Next

            TextEdit.Text = message
        End Sub
    End Class
End Namespace
