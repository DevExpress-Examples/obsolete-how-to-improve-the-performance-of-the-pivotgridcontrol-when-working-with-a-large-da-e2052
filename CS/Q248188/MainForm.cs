using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using DevExpress.Data.PivotGrid;
using System.Collections.Generic;

namespace Q248188 {
    public partial class MainForm :XtraForm {
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.SalesPerson' table. You can move, or remove it, as needed.
            this.salesPersonTableAdapter.Fill(this.nwindDataSet.SalesPerson);
            optimizedPivot.DataSource = GetData(CreateQuery(optimizedPivot));
            optimizedPivot.ForceInitialize();
            optimizedPivot.RetrieveFields();
            optimizedPivot.FieldAreaChanged += OnOptimizedPivotFieldAreaChanged;
        }

        private void OnOptimizedPivotFieldAreaChanged(object sender, PivotFieldEventArgs e) {
            refreshButton.Visible = true;
        }

        private void OnRefreshButtonClick(object sender, EventArgs e) {
            optimizedPivot.DataSource = GetData(CreateQuery(optimizedPivot));
            ((Control)sender).Visible = false;
        }

        private DataTable GetData(string sql) {
            DataTable result = new DataTable();
            salesPersonTableAdapter.Adapter.SelectCommand = 
                new OleDbCommand(sql, salesPersonTableAdapter.Connection);
            salesPersonTableAdapter.Adapter.Fill(result);
            return result;
        }

        private string CreateQuery(PivotGridControl pivot) {
            QueryBuilder builder = new QueryBuilder();
            if (pivot.Fields.Count == 0) 
                return "select Country, ProductName, CategoryName, UnitPrice, Quantity, Discount, [Extended Price], [Sales Person] from SalesPerson where false";
            else {
                GetColumns(pivot.GetFieldsByArea(PivotArea.ColumnArea), builder, false);
                GetColumns(pivot.GetFieldsByArea(PivotArea.RowArea), builder, false);
                GetColumns(pivot.GetFieldsByArea(PivotArea.DataArea), builder, true);
            }
            string result = string.Format("select {0} from SalesPerson", builder.GetColumns());
            if (builder.Groups.Count > 0) result = string.Format("{0} group by {1}", result, builder.GetGroups());
            return result;
        }

        private void GetColumns(List<PivotGridField> fields, QueryBuilder builder, bool aggregate) {
            if (aggregate)
                foreach (PivotGridField field in fields)
                    builder.Columns.Add(Aggregate(string.Format("[{0}]", field.FieldName), field.SummaryType));
            else
                foreach (PivotGridField field in fields) {
                    builder.Columns.Add(string.Format("[{0}]", field.FieldName));
                    builder.Groups.Add(string.Format("[{0}]", field.FieldName));
                }
        }

        private string Aggregate(string column, PivotSummaryType summaryType) {
            switch (summaryType) {
                case PivotSummaryType.Average:
                    return string.Format("avg({0}) as {0}", column);
                    break;
                case PivotSummaryType.Count:
                    return string.Format("count({0}) as {0}", column);
                    break;
                case PivotSummaryType.Max:
                    return string.Format("max({0}) as {0}", column);
                    break;
                case PivotSummaryType.Min:
                    return string.Format("min({0}) as {0}", column);
                    break;
                case PivotSummaryType.Sum:
                    return string.Format("sum({0}) as {0}", column);
                    break;
                default:
                    throw new NotImplementedException();
                    break;
            }
        }

        private class QueryBuilder {
            private List<string> fColumns = new List<string>();
            public List<string> Columns { get { return fColumns; } }

            private List<string> fGroups = new List<string>();
            public List<string> Groups { get { return fGroups; } }

            public string GetColumns() { return string.Join(",", Columns.ToArray()); }

            public string GetGroups() { return string.Join(",", Groups.ToArray()); }
        }
    }
}
