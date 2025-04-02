Imports System
Imports System.Drawing
Imports DevExpress.Web.ASPxPivotGrid
Imports DevExpress.XtraPivotGrid

Namespace CustomizeCellsAppearanceViaEvents

    Public Partial Class _Default
        Inherits Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Protected Sub CustomCellStyle(ByVal sender As Object, ByVal e As PivotCustomCellStyleEventArgs)
            If e.ColumnValueType <> PivotGridValueType.Value OrElse e.RowValueType <> PivotGridValueType.Value Then Return
            If Convert.ToInt32(e.Value) > 50 AndAlso Equals(e.DataField.FieldName, "Quantity") Then
                e.CellStyle.BackColor = Color.Orange
                e.CellStyle.Font.Bold = True
            End If
        End Sub
    End Class
End Namespace
