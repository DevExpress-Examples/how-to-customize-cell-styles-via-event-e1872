Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Web.ASPxPivotGrid
Imports DevExpress.XtraPivotGrid

Namespace CustomizeCellsAppearanceViaEvents
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, _
			ByVal e As EventArgs)
		End Sub
		Protected Sub CustomCellStyle(ByVal sender As Object, _
			ByVal e As PivotCustomCellStyleEventArgs)
			If e.ColumnValueType <> PivotGridValueType.Value OrElse _
				e.RowValueType <> PivotGridValueType.Value Then
					Return
			End If
			If Convert.ToInt32(e.Value) > 50 AndAlso _
				e.DataField.FieldName = "Quantity" Then
					e.CellStyle.BackColor = Color.Orange
					e.CellStyle.Font.Bold = True
			End If
		End Sub
	End Class
End Namespace
