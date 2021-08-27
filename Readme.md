<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1555)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MyPivotGridControl.cs](./CS/Q200703/MyPivotGridControl.cs) (VB: [MyPivotGridControl.vb](./VB/Q200703/MyPivotGridControl.vb))
<!-- default file list end -->
# How to introduce the capability to move focus within the PivotGridControl via the Tab key


<p>By default, the PivotGridCotnrol doesn't provide this functionality, because it isn't intended to be used for editing values. However, if your application's design requires this feature, you can manually implement it within a PivotGridControl descendant by overriding the PivotGridViewInfo.KeyDown method. It's also necessary to override the PivotGridControl.ProcessDialogKey method, because by default the Tab key is used to move focus to another control.</p>

<br/>


