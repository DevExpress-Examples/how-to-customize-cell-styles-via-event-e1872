using System;
using System.Drawing;
using DevExpress.Web.ASPxPivotGrid;
using DevExpress.XtraPivotGrid;

namespace CustomizeCellsAppearanceViaEvents {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
        }
        protected void CustomCellStyle(object sender,
            PivotCustomCellStyleEventArgs e) {
            if (e.ColumnValueType != PivotGridValueType.Value ||
                e.RowValueType != PivotGridValueType.Value) return;
            if (Convert.ToInt32(e.Value) > 50 && 
              e.DataField == fieldQuantity) {
                e.CellStyle.BackColor = Color.Orange;
                e.CellStyle.Font.Bold = true;
            }
        }
    }
}
