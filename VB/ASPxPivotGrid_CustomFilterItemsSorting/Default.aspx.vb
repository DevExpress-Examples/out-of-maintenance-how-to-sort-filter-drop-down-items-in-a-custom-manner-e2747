Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Web.UI
Imports DevExpress.Web.ASPxPivotGrid
Imports DevExpress.XtraPivotGrid.Data

Namespace ASPxPivotGrid_CustomFilterItemsSorting
	Partial Public Class _Default
		Inherits Page
		Protected Sub ASPxPivotGrid1_CustomFilterPopupItems(ByVal sender As Object, _
				ByVal e As PivotCustomFilterPopupItemsEventArgs)
			If DropDownList1.Items(1).Selected Then
				ArrayList.Adapter(CType(e.Items, IList)).Sort(New FilterItemsComparer())
			End If
		End Sub
	End Class
	Public Class FilterItemsComparer
		Implements IComparer
		Private Function IComparer_Compare(ByVal x As Object, ByVal y As Object) As Integer _
																Implements IComparer.Compare
			If Not(TypeOf x Is PivotGridFilterItem) OrElse Not(TypeOf y Is PivotGridFilterItem) Then
				Return 0
			End If
			Dim item1 As PivotGridFilterItem = CType(x, PivotGridFilterItem)
			Dim item2 As PivotGridFilterItem = CType(y, PivotGridFilterItem)
			If item1.ToString().Length = item2.ToString().Length Then
				Return 0
			End If
			If item1.ToString().Length > item2.ToString().Length Then
				Return 1
			End If
			Return -1
		End Function
	End Class
End Namespace
