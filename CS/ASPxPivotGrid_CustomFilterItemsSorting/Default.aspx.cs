using System;
using System.Collections;
using System.Web.UI;
using DevExpress.Web.ASPxPivotGrid;
using DevExpress.XtraPivotGrid.Data;

namespace ASPxPivotGrid_CustomFilterItemsSorting {
    public partial class _Default : Page {
        protected void ASPxPivotGrid1_CustomFilterPopupItems(object sender,
                                PivotCustomFilterPopupItemsEventArgs e) {
            if (DropDownList1.Items[1].Selected)
                ArrayList.Adapter((IList)e.Items).Sort(new FilterItemsComparer());
        }
    }
    public class FilterItemsComparer : IComparer {
        int IComparer.Compare(object x, object y) {
            if (!(x is PivotGridFilterItem) || !(y is PivotGridFilterItem)) return 0;
            PivotGridFilterItem item1 = (PivotGridFilterItem)x;
            PivotGridFilterItem item2 = (PivotGridFilterItem)y;
            if (item1.ToString().Length == item2.ToString().Length) return 0;
            if (item1.ToString().Length > item2.ToString().Length) return 1;
            return -1;
        }
    }
}
