Imports Microsoft.VisualBasic
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPivotGrid.Data
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid.ViewInfo
Imports System.Drawing

Namespace DXSample
	Public Class MyPivotGridControl
		Inherits PivotGridControl
		Public Sub New()
			MyBase.New()
		End Sub

		Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean
			Dim key As Keys = keyData And ((Not Keys.Modifiers))
			If key = Keys.Tab Then
				Return False
			End If
			Return MyBase.ProcessDialogKey(keyData)
		End Function

		Protected Overrides Function CreateData() As PivotGridViewInfoData
			Return New MyPivotGridViewInfoData(Me)
		End Function
	End Class

	Public Class MyPivotGridViewInfo
		Inherits PivotGridViewInfo
		Public Sub New(ByVal data As PivotGridViewInfoData)
			MyBase.New(data)
		End Sub

		Private Sub ProcessTabKey(ByVal shift As Boolean)
			Dim newFocusedCell As Point = FocusedCell
			If shift Then
				If newFocusedCell.X = 0 AndAlso newFocusedCell.Y > 0 Then
					newFocusedCell.X = CellsArea.ColumnCount - 1
					newFocusedCell.Y -= 1
				ElseIf newFocusedCell.X > 0 Then
					newFocusedCell.X -= 1
				End If
			Else
				If newFocusedCell.X = CellsArea.ColumnCount - 1 AndAlso newFocusedCell.Y < CellsArea.RowCount - 1 Then
					newFocusedCell.X = 0
					newFocusedCell.Y += 1
				ElseIf newFocusedCell.X < CellsArea.ColumnCount - 1 Then
					newFocusedCell.X += 1
				End If
			End If
			StartSelection(False)
			FocusedCell = newFocusedCell
		End Sub

		Public Overrides Overloads Sub KeyDown(ByVal e As KeyEventArgs)
			MyBase.KeyDown(e)
			If e.KeyCode = Keys.Tab Then
				ProcessTabKey(e.Shift)
			End If
		End Sub
	End Class

	Public Class MyPivotGridViewInfoData
		Inherits PivotGridViewInfoData
		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal control As IViewInfoControl)
			MyBase.New(control)
		End Sub

		Protected Overrides Function CreateViewInfo() As PivotGridViewInfoBase
			Return New MyPivotGridViewInfo(Me)
		End Function
	End Class
End Namespace