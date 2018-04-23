# How to introduce the capability to move focus within the PivotGridControl via the Tab key


<p>By default, the PivotGridCotnrol doesn't provide this functionality, because it isn't intended to be used for editing values. However, if your application's design requires this feature, you can manually implement it within a PivotGridControl descendant by overriding the PivotGridViewInfo.KeyDown method. It's also necessary to override the PivotGridControl.ProcessDialogKey method, because by default the Tab key is used to move focus to another control.</p>

<br/>


