<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/134061931/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2052)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainForm.cs](./CS/Q248188/MainForm.cs) (VB: [MainForm.vb](./VB/Q248188/MainForm.vb))
* [Program.cs](./CS/Q248188/Program.cs) (VB: [Program.vb](./VB/Q248188/Program.vb))
<!-- default file list end -->
# OBSOLETE: How to improve the performance of the PivotGridControl when working with a large data source
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e2052)**
<!-- run online end -->


<p>The best solution to display calculations based on the huge amount of data within the PivotgridControl or ASPxPivotGrid is to create the <a href="http://en.wikipedia.org/wiki/OLAP_cube"><u>OLAP Cube</u></a> and perform all calculations on the SQL server side.<br /><br />If you cannot use OLAP data source, I suggest you use PivotGrid in the server mode. In version 14.2 we have introduced the <a href="https://www.devexpress.com/Support/Center/p/S133758">server mode support in PivotGrid</a>, thus the approach described in this example is not actual any more. We have added the Obsolete prefix to emphasize this statement. To enable Server Mode, use the following components depending on the target platform:<br />-  ASP.Net - <a href="https://documentation.devexpress.com/#AspNet/clsDevExpressDataLinqEntityServerModeDataSourcetopic">EntityServerModeDataSource</a> and <a href="https://documentation.devexpress.com/#AspNet/clsDevExpressDataLinqLinqServerModeDataSourcetopic">LinqServerModeDataSource</a>;<br />-  Windows Forms - <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressDataLinqEntityServerModeSourcetopic">EntityServerModeSource</a> and <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressDataLinqLinqServerModeSourcetopic">LinqServerModeSource</a>;<br />-  WPF - <a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfCoreServerModeEntityServerModeDataSourcetopic">EntityServerModeDataSource</a> and <a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfCoreServerModeLinqServerModeDataSourcetopic">LinqServerModeDataSource</a>.<br /><br /></p>
<p>In previous versions it's possible to slightly improve the performance when the PivotgridControl or ASPxPivotGrid is bound to the DataSet. The main idea is to group data when retrieving them from the database. This way, calculations performed on the client side will be reduced, and the pivot grid will load and sort data faster. In this instance, it's necessary to update the data source each time the user moves fields between areas. Otherwise, the pivot grid will display incorrect values.</p>
<p>This example demonstrates how to implement this in a simple case.<br /><br /></p>
<p><strong>See Also:</strong><br /> <u>Analysis Services</u><br /> <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument3253"><u>Binding to an OLAP Server </u></a><br /> <a href="https://www.devexpress.com/Support/Center/p/K18104">How to improve the PivotGrid performance</a><u><br /> </u><a href="https://www.devexpress.com/Support/Center/p/Q423110">Any way to improve performance for PivotGrid when using EntityFramework CodeFirst?</a></p>

<br/>


