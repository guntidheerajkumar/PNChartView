# PNChartView

This is a Obj-C binding project based on https://github.com/kevinzhow/PNChart


### PieChart

```
var pieChart = new PNPieChart(new CGRect(80, 50, 200, 200),
							  new NSObject[] {
	PNPieChartDataItem.DataItemWithValue(10f, UIColor.Red, "Build"), PNPieChartDataItem.DataItemWithValue(20f, UIColor.Green,"Apple WWDC"),
	PNPieChartDataItem.DataItemWithValue(40f, UIColor.Yellow, "Google I/O")
								});
pieChart.DescriptionTextFont = UIFont.SystemFontOfSize(12f);
pieChart.DescriptionTextColor = UIColor.Black;
pieChart.StrokeChart();
this.View.AddSubview(pieChart);
```

![](https://github.com/guntidheerajkumar/PNChartView/blob/master/PieChart.png)

### CircleChart

```
var circleChart = new PNCircleChart(new CGRect(80, pieChart.Frame.Y + pieChart.Frame.Height + 50, 100, 100),
									NSNumber.FromFloat(100f), NSNumber.FromFloat(45f), true, false, UIColor.LightGray);
circleChart.StrokeColor = UIColor.Green;
circleChart.BackgroundColor = UIColor.Clear;
circleChart.StrokeChart();
this.View.AddSubview(circleChart);
```
      
![](https://github.com/guntidheerajkumar/PNChartView/blob/master/CircleChart.png)

### BarChart

```
var barChart = new PNBarChart();
barChart.Frame = new CGRect(10, 100, this.View.Frame.Width - 20, 200);
barChart.XLabels = new NSObject[] { new NSString("Jan"), new NSString("Feb"), new NSString("Mar"),
	new NSString("Apr"), new NSString("May") };
barChart.YValues = new NSObject[] { NSNumber.FromFloat(1f), NSNumber.FromFloat(10f),
	NSNumber.FromFloat(2f), NSNumber.FromFloat(6f), NSNumber.FromFloat(3f) };

barChart.ShowChartBorder = true;
barChart.LabelMarginTop = 100f;
barChart.StrokeChart();
this.View.AddSubview(barChart);
```

![](https://github.com/guntidheerajkumar/PNChartView/blob/master/BarChart.png)

