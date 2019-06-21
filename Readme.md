<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/ASPxPivotGrid_CustomFilterItemsSorting/Default.aspx) (VB: [Default.aspx](./VB/ASPxPivotGrid_CustomFilterItemsSorting/Default.aspx))
* [Default.aspx.cs](./CS/ASPxPivotGrid_CustomFilterItemsSorting/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/ASPxPivotGrid_CustomFilterItemsSorting/Default.aspx.vb))
<!-- default file list end -->
# How to sort filter drop-down items in a custom manner
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e2747/)**
<!-- run online end -->


<p>The following example demonstrates how to sort filter drop-down items in a custom manner.<br />
In this example, the CustomFilterPopupItems event is handled to manage a list of filter items. This event is raised when an end-user invokes the filter drop-down. The event parameter provides access to the filter items list, which is then sorted by the length of the items' captions (if the corresponding option is selected).</p>

<br/>


