Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Data.PivotGrid
Imports System.Collections.Generic

Namespace Q248188
	Partial Public Class MainForm
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.SalesPerson' table. You can move, or remove it, as needed.
			Me.salesPersonTableAdapter.Fill(Me.nwindDataSet.SalesPerson)
			optimizedPivot.DataSource = GetData(CreateQuery(optimizedPivot))
			optimizedPivot.ForceInitialize()
			optimizedPivot.RetrieveFields()
			AddHandler optimizedPivot.FieldAreaChanged, AddressOf OnOptimizedPivotFieldAreaChanged
		End Sub

		Private Sub OnOptimizedPivotFieldAreaChanged(ByVal sender As Object, ByVal e As PivotFieldEventArgs)
			refreshButton.Visible = True
		End Sub

		Private Sub OnRefreshButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles refreshButton.Click
			optimizedPivot.DataSource = GetData(CreateQuery(optimizedPivot))
			CType(sender, Control).Visible = False
		End Sub

		Private Function GetData(ByVal sql As String) As DataTable
			Dim result As New DataTable()
			salesPersonTableAdapter.Adapter.SelectCommand = New OleDbCommand(sql, salesPersonTableAdapter.Connection)
			salesPersonTableAdapter.Adapter.Fill(result)
			Return result
		End Function

		Private Function CreateQuery(ByVal pivot As PivotGridControl) As String
			Dim builder As New QueryBuilder()
			If pivot.Fields.Count = 0 Then
				Return "select Country, ProductName, CategoryName, UnitPrice, Quantity, Discount, [Extended Price], [Sales Person] from SalesPerson where false"
			Else
				GetColumns(pivot.GetFieldsByArea(PivotArea.ColumnArea), builder, False)
				GetColumns(pivot.GetFieldsByArea(PivotArea.RowArea), builder, False)
				GetColumns(pivot.GetFieldsByArea(PivotArea.DataArea), builder, True)
			End If
			Dim result As String = String.Format("select {0} from SalesPerson", builder.GetColumns())
			If builder.Groups.Count > 0 Then
				result = String.Format("{0} group by {1}", result, builder.GetGroups())
			End If
			Return result
		End Function

		Private Sub GetColumns(ByVal fields As List(Of PivotGridField), ByVal builder As QueryBuilder, ByVal aggregate As Boolean)
			If aggregate Then
				For Each field As PivotGridField In fields
					builder.Columns.Add(Me.Aggregate(String.Format("[{0}]", field.FieldName), field.SummaryType))
				Next field
			Else
				For Each field As PivotGridField In fields
					builder.Columns.Add(String.Format("[{0}]", field.FieldName))
					builder.Groups.Add(String.Format("[{0}]", field.FieldName))
				Next field
			End If
		End Sub

		Private Function Aggregate(ByVal column As String, ByVal summaryType As PivotSummaryType) As String
			Select Case summaryType
				Case PivotSummaryType.Average
					Return String.Format("avg({0}) as {0}", column)
				Case PivotSummaryType.Count
					Return String.Format("count({0}) as {0}", column)
				Case PivotSummaryType.Max
					Return String.Format("max({0}) as {0}", column)
				Case PivotSummaryType.Min
					Return String.Format("min({0}) as {0}", column)
				Case PivotSummaryType.Sum
					Return String.Format("sum({0}) as {0}", column)
				Case Else
					Throw New NotImplementedException()
			End Select
		End Function

		Private Class QueryBuilder
			Private fColumns As New List(Of String)()
			Public ReadOnly Property Columns() As List(Of String)
				Get
					Return fColumns
				End Get
			End Property

			Private fGroups As New List(Of String)()
			Public ReadOnly Property Groups() As List(Of String)
				Get
					Return fGroups
				End Get
			End Property

			Public Function GetColumns() As String
				Return String.Join(",", Columns.ToArray())
			End Function

			Public Function GetGroups() As String
				Return String.Join(",", Groups.ToArray())
			End Function
		End Class
	End Class
End Namespace
