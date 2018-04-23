Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Private style As AppearanceObject

		Public Sub InitStyle()
			style = New AppearanceObject()
			style.BackColor = Color.Red
			style.BackColor2 = Color.Orange
			style.ForeColor = Color.White
			style.Font = New Font(style.Font, FontStyle.Bold)
		End Sub

		Public Sub New()
			InitializeComponent()
			Dim TempXViewsPrinting As DevExpress.XtraGrid.Design.XViewsPrinting = New DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1)
			InitStyle()
		End Sub

		Private Sub gridView1_RowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles gridView1.RowCellStyle
			Dim view As GridView = TryCast(sender, GridView)
			If Convert.ToBoolean(view.GetRowCellValue(e.RowHandle, view.Columns("Discontinued"))) Then
				e.Appearance.Assign(style)
			End If
		End Sub
	End Class
End Namespace