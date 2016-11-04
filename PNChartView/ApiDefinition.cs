using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace PNChart
{
	// @interface PNBar : UIView
	[BaseType(typeof(UIView))]
	interface PNBar
	{
		// -(void)rollBack;
		[Export("rollBack")]
		void RollBack();

		// @property (nonatomic) float grade;
		[Export("grade")]
		float Grade { get; set; }

		// @property (nonatomic) float maxDivisor;
		[Export("maxDivisor")]
		float MaxDivisor { get; set; }

		// @property (nonatomic) CAShapeLayer * chartLine;
		[Export("chartLine", ArgumentSemantic.Assign)]
		CAShapeLayer ChartLine { get; set; }

		// @property (nonatomic) UIColor * barColor;
		[Export("barColor", ArgumentSemantic.Assign)]
		UIColor BarColor { get; set; }

		// @property (nonatomic) UIColor * barColorGradientStart;
		[Export("barColorGradientStart", ArgumentSemantic.Assign)]
		UIColor BarColorGradientStart { get; set; }

		// @property (nonatomic) CGFloat barRadius;
		[Export("barRadius")]
		nfloat BarRadius { get; set; }

		// @property (nonatomic) CAShapeLayer * gradientMask;
		[Export("gradientMask", ArgumentSemantic.Assign)]
		CAShapeLayer GradientMask { get; set; }

		// @property (nonatomic) CAShapeLayer * gradeLayer;
		[Export("gradeLayer", ArgumentSemantic.Assign)]
		CAShapeLayer GradeLayer { get; set; }

		// @property (nonatomic) CATextLayer * textLayer;
		[Export("textLayer", ArgumentSemantic.Assign)]
		CATextLayer TextLayer { get; set; }

		// @property (nonatomic) UIColor * labelTextColor;
		[Export("labelTextColor", ArgumentSemantic.Assign)]
		UIColor LabelTextColor { get; set; }

		// @property (assign, nonatomic) BOOL isNegative;
		[Export("isNegative")]
		bool IsNegative { get; set; }

		// @property (assign, nonatomic) BOOL isShowNumber;
		[Export("isShowNumber")]
		bool IsShowNumber { get; set; }

		// @property (nonatomic) BOOL displayAnimated;
		[Export("displayAnimated")]
		bool DisplayAnimated { get; set; }
	}

	// @interface PNGenericChart : UIView
	[BaseType(typeof(UIView))]
	interface PNGenericChart
	{
		// @property (assign, nonatomic) BOOL hasLegend;
		[Export("hasLegend")]
		bool HasLegend { get; set; }

		//// @property (assign, nonatomic) PNLegendPosition legendPosition;
		//[Export("legendPosition", ArgumentSemantic.Assign)]
		//PNLegendPosition LegendPosition { get; set; }

		//// @property (assign, nonatomic) PNLegendItemStyle legendStyle;
		//[Export("legendStyle", ArgumentSemantic.Assign)]
		//PNLegendItemStyle LegendStyle { get; set; }

		// @property (assign, nonatomic) UIFont * legendFont;
		[Export("legendFont", ArgumentSemantic.Assign)]
		UIFont LegendFont { get; set; }

		// @property (assign, nonatomic) UIColor * legendFontColor;
		[Export("legendFontColor", ArgumentSemantic.Assign)]
		UIColor LegendFontColor { get; set; }

		// @property (assign, nonatomic) NSUInteger labelRowsInSerialMode;
		[Export("labelRowsInSerialMode")]
		nuint LabelRowsInSerialMode { get; set; }

		// @property (nonatomic) BOOL displayAnimated;
		[Export("displayAnimated")]
		bool DisplayAnimated { get; set; }

		// -(UIView *)getLegendWithMaxWidth:(CGFloat)mWidth;
		[Export("getLegendWithMaxWidth:")]
		UIView GetLegendWithMaxWidth(nfloat mWidth);

		// -(void)setupDefaultValues;
		[Export("setupDefaultValues")]
		void SetupDefaultValues();
	}

	// @protocol PNChartDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface PNChartDelegate
	{
		// @optional -(void)userClickedOnLinePoint:(CGPoint)point lineIndex:(NSInteger)lineIndex;
		[Export("userClickedOnLinePoint:lineIndex:")]
		void UserClickedOnLinePoint(CGPoint point, nint lineIndex);

		// @optional -(void)userClickedOnLineKeyPoint:(CGPoint)point lineIndex:(NSInteger)lineIndex pointIndex:(NSInteger)pointIndex;
		[Export("userClickedOnLineKeyPoint:lineIndex:pointIndex:")]
		void UserClickedOnLineKeyPoint(CGPoint point, nint lineIndex, nint pointIndex);

		// @optional -(void)userClickedOnBarAtIndex:(NSInteger)barIndex;
		[Export("userClickedOnBarAtIndex:")]
		void UserClickedOnBarAtIndex(nint barIndex);

		// @optional -(void)userClickedOnPieIndexItem:(NSInteger)pieIndex;
		[Export("userClickedOnPieIndexItem:")]
		void UserClickedOnPieIndexItem(nint pieIndex);

		// @optional -(void)didUnselectPieItem;
		[Export("didUnselectPieItem")]
		void DidUnselectPieItem();
	}

	// typedef NSString * (^PNYLabelFormatter)(CGFloat);
	delegate string PNYLabelFormatter(nfloat arg0);

	// @interface PNBarChart : PNGenericChart
	[BaseType(typeof(PNGenericChart))]
	interface PNBarChart
	{
		// -(void)strokeChart;
		[Export("strokeChart")]
		void StrokeChart();

		// @property (nonatomic) NSArray * xLabels;
		[Export("xLabels", ArgumentSemantic.Assign)]
		NSObject[] XLabels { get; set; }

		// @property (nonatomic) NSArray * yLabels;
		[Export("yLabels", ArgumentSemantic.Assign)]
		NSObject[] YLabels { get; set; }

		// @property (nonatomic) NSArray * yValues;
		[Export("yValues", ArgumentSemantic.Assign)]
		NSObject[] YValues { get; set; }

		// @property (nonatomic) NSMutableArray * bars;
		[Export("bars", ArgumentSemantic.Assign)]
		NSMutableArray Bars { get; set; }

		// @property (nonatomic) CGFloat xLabelWidth;
		[Export("xLabelWidth")]
		nfloat XLabelWidth { get; set; }

		// @property (nonatomic) float yValueMax;
		[Export("yValueMax")]
		float YValueMax { get; set; }

		// @property (nonatomic) UIColor * strokeColor;
		[Export("strokeColor", ArgumentSemantic.Assign)]
		UIColor StrokeColor { get; set; }

		// @property (nonatomic) NSArray * strokeColors;
		[Export("strokeColors", ArgumentSemantic.Assign)]
		NSObject[] StrokeColors { get; set; }

		// -(void)updateChartData:(NSArray *)data;
		[Export("updateChartData:")]
		void UpdateChartData(NSObject[] data);

		// @property (nonatomic) CGFloat yChartLabelWidth;
		[Export("yChartLabelWidth")]
		nfloat YChartLabelWidth { get; set; }

		// @property (copy) PNYLabelFormatter yLabelFormatter;
		[Export("yLabelFormatter", ArgumentSemantic.Copy)]
		PNYLabelFormatter YLabelFormatter { get; set; }

		// @property (nonatomic) NSString * yLabelPrefix;
		[Export("yLabelPrefix")]
		string YLabelPrefix { get; set; }

		// @property (nonatomic) NSString * yLabelSuffix;
		[Export("yLabelSuffix")]
		string YLabelSuffix { get; set; }

		// @property (nonatomic) CGFloat chartMarginLeft;
		[Export("chartMarginLeft")]
		nfloat ChartMarginLeft { get; set; }

		// @property (nonatomic) CGFloat chartMarginRight;
		[Export("chartMarginRight")]
		nfloat ChartMarginRight { get; set; }

		// @property (nonatomic) CGFloat chartMarginTop;
		[Export("chartMarginTop")]
		nfloat ChartMarginTop { get; set; }

		// @property (nonatomic) CGFloat chartMarginBottom;
		[Export("chartMarginBottom")]
		nfloat ChartMarginBottom { get; set; }

		// @property (nonatomic) BOOL showLabel;
		[Export("showLabel")]
		bool ShowLabel { get; set; }

		// @property (nonatomic) BOOL showChartBorder;
		[Export("showChartBorder")]
		bool ShowChartBorder { get; set; }

		// @property (nonatomic) UIColor * chartBorderColor;
		[Export("chartBorderColor", ArgumentSemantic.Assign)]
		UIColor ChartBorderColor { get; set; }

		// @property (assign, nonatomic) BOOL showLevelLine;
		[Export("showLevelLine")]
		bool ShowLevelLine { get; set; }

		// @property (nonatomic) CAShapeLayer * chartBottomLine;
		[Export("chartBottomLine", ArgumentSemantic.Assign)]
		CAShapeLayer ChartBottomLine { get; set; }

		// @property (nonatomic) CAShapeLayer * chartLevelLine;
		[Export("chartLevelLine", ArgumentSemantic.Assign)]
		CAShapeLayer ChartLevelLine { get; set; }

		// @property (nonatomic) CAShapeLayer * chartLeftLine;
		[Export("chartLeftLine", ArgumentSemantic.Assign)]
		CAShapeLayer ChartLeftLine { get; set; }

		// @property (nonatomic) CGFloat barRadius;
		[Export("barRadius")]
		nfloat BarRadius { get; set; }

		// @property (nonatomic) CGFloat barWidth;
		[Export("barWidth")]
		nfloat BarWidth { get; set; }

		// @property (nonatomic) CGFloat labelMarginTop;
		[Export("labelMarginTop")]
		nfloat LabelMarginTop { get; set; }

		// @property (nonatomic) UIColor * barBackgroundColor;
		[Export("barBackgroundColor", ArgumentSemantic.Assign)]
		UIColor BarBackgroundColor { get; set; }

		// @property (nonatomic) UIColor * labelTextColor;
		[Export("labelTextColor", ArgumentSemantic.Assign)]
		UIColor LabelTextColor { get; set; }

		// @property (nonatomic) UIFont * labelFont;
		[Export("labelFont", ArgumentSemantic.Assign)]
		UIFont LabelFont { get; set; }

		// @property (nonatomic) NSInteger xLabelSkip;
		[Export("xLabelSkip")]
		nint XLabelSkip { get; set; }

		// @property (nonatomic) NSInteger yLabelSum;
		[Export("yLabelSum")]
		nint YLabelSum { get; set; }

		// @property (nonatomic) CGFloat yMaxValue;
		[Export("yMaxValue")]
		nfloat YMaxValue { get; set; }

		// @property (nonatomic) CGFloat yMinValue;
		[Export("yMinValue")]
		nfloat YMinValue { get; set; }

		// @property (nonatomic) UIColor * barColorGradientStart;
		[Export("barColorGradientStart", ArgumentSemantic.Assign)]
		UIColor BarColorGradientStart { get; set; }

		// @property (nonatomic) BOOL rotateForXAxisText;
		[Export("rotateForXAxisText")]
		bool RotateForXAxisText { get; set; }

		[Wrap("WeakDelegate")]
		PNChartDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<PNChartDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (assign, nonatomic) BOOL isGradientShow;
		[Export("isGradientShow")]
		bool IsGradientShow { get; set; }

		// @property (assign, nonatomic) BOOL isShowNumbers;
		[Export("isShowNumbers")]
		bool IsShowNumbers { get; set; }
	}

	// @interface PNColor : NSObject
	[BaseType(typeof(NSObject))]
	interface PNColor
	{
		// -(UIImage *)imageFromColor:(UIColor *)color;
		[Export("imageFromColor:")]
		UIImage ImageFromColor(UIColor color);
	}

	// @interface PNLineChart : PNGenericChart
	[BaseType(typeof(PNGenericChart))]
	interface PNLineChart
	{
		// -(void)strokeChart;
		[Export("strokeChart")]
		void StrokeChart();

		[Wrap("WeakDelegate")]
		PNChartDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<PNChartDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic) NSArray * xLabels;
		[Export("xLabels", ArgumentSemantic.Assign)]
		NSObject[] XLabels { get; set; }

		// @property (nonatomic) NSArray * yLabels;
		[Export("yLabels", ArgumentSemantic.Assign)]
		NSObject[] YLabels { get; set; }

		// @property (nonatomic) NSArray * chartData;
		[Export("chartData", ArgumentSemantic.Assign)]
		NSObject[] ChartData { get; set; }

		// @property (nonatomic) NSMutableArray * pathPoints;
		[Export("pathPoints", ArgumentSemantic.Assign)]
		NSMutableArray PathPoints { get; set; }

		// @property (nonatomic) NSMutableArray * xChartLabels;
		[Export("xChartLabels", ArgumentSemantic.Assign)]
		NSMutableArray XChartLabels { get; set; }

		// @property (nonatomic) NSMutableArray * yChartLabels;
		[Export("yChartLabels", ArgumentSemantic.Assign)]
		NSMutableArray YChartLabels { get; set; }

		// @property (nonatomic) CGFloat xLabelWidth;
		[Export("xLabelWidth")]
		nfloat XLabelWidth { get; set; }

		// @property (nonatomic) UIFont * xLabelFont;
		[Export("xLabelFont", ArgumentSemantic.Assign)]
		UIFont XLabelFont { get; set; }

		// @property (nonatomic) UIColor * xLabelColor;
		[Export("xLabelColor", ArgumentSemantic.Assign)]
		UIColor XLabelColor { get; set; }

		// @property (nonatomic) CGFloat yValueMax;
		[Export("yValueMax")]
		nfloat YValueMax { get; set; }

		// @property (nonatomic) CGFloat yFixedValueMax;
		[Export("yFixedValueMax")]
		nfloat YFixedValueMax { get; set; }

		// @property (nonatomic) CGFloat yFixedValueMin;
		[Export("yFixedValueMin")]
		nfloat YFixedValueMin { get; set; }

		// @property (nonatomic) CGFloat yValueMin;
		[Export("yValueMin")]
		nfloat YValueMin { get; set; }

		// @property (nonatomic) NSInteger yLabelNum;
		[Export("yLabelNum")]
		nint YLabelNum { get; set; }

		// @property (nonatomic) CGFloat yLabelHeight;
		[Export("yLabelHeight")]
		nfloat YLabelHeight { get; set; }

		// @property (nonatomic) UIFont * yLabelFont;
		[Export("yLabelFont", ArgumentSemantic.Assign)]
		UIFont YLabelFont { get; set; }

		// @property (nonatomic) UIColor * yLabelColor;
		[Export("yLabelColor", ArgumentSemantic.Assign)]
		UIColor YLabelColor { get; set; }

		// @property (nonatomic) CGFloat chartCavanHeight;
		[Export("chartCavanHeight")]
		nfloat ChartCavanHeight { get; set; }

		// @property (nonatomic) CGFloat chartCavanWidth;
		[Export("chartCavanWidth")]
		nfloat ChartCavanWidth { get; set; }

		// @property (nonatomic) BOOL showLabel;
		[Export("showLabel")]
		bool ShowLabel { get; set; }

		// @property (nonatomic) BOOL showGenYLabels;
		[Export("showGenYLabels")]
		bool ShowGenYLabels { get; set; }

		// @property (nonatomic) BOOL showYGridLines;
		[Export("showYGridLines")]
		bool ShowYGridLines { get; set; }

		// @property (nonatomic) UIColor * yGridLinesColor;
		[Export("yGridLinesColor", ArgumentSemantic.Assign)]
		UIColor YGridLinesColor { get; set; }

		// @property (nonatomic) BOOL thousandsSeparator;
		[Export("thousandsSeparator")]
		bool ThousandsSeparator { get; set; }

		// @property (nonatomic) CGFloat chartMarginLeft;
		[Export("chartMarginLeft")]
		nfloat ChartMarginLeft { get; set; }

		// @property (nonatomic) CGFloat chartMarginRight;
		[Export("chartMarginRight")]
		nfloat ChartMarginRight { get; set; }

		// @property (nonatomic) CGFloat chartMarginTop;
		[Export("chartMarginTop")]
		nfloat ChartMarginTop { get; set; }

		// @property (nonatomic) CGFloat chartMarginBottom;
		[Export("chartMarginBottom")]
		nfloat ChartMarginBottom { get; set; }

		// @property (getter = isShowCoordinateAxis, nonatomic) BOOL showCoordinateAxis;
		[Export("showCoordinateAxis")]
		bool ShowCoordinateAxis { [Bind("isShowCoordinateAxis")] get; set; }

		// @property (nonatomic) UIColor * axisColor;
		[Export("axisColor", ArgumentSemantic.Assign)]
		UIColor AxisColor { get; set; }

		// @property (nonatomic) CGFloat axisWidth;
		[Export("axisWidth")]
		nfloat AxisWidth { get; set; }

		// @property (nonatomic, strong) NSString * xUnit;
		[Export("xUnit", ArgumentSemantic.Strong)]
		string XUnit { get; set; }

		// @property (nonatomic, strong) NSString * yUnit;
		[Export("yUnit", ArgumentSemantic.Strong)]
		string YUnit { get; set; }

		// @property (nonatomic, strong) NSString * yLabelFormat;
		[Export("yLabelFormat", ArgumentSemantic.Strong)]
		string YLabelFormat { get; set; }

		// @property (copy, nonatomic) NSString * (^yLabelBlockFormatter)(CGFloat);
		[Export("yLabelBlockFormatter", ArgumentSemantic.Copy)]
		Func<nfloat, NSString> YLabelBlockFormatter { get; set; }

		// @property (nonatomic) BOOL showSmoothLines;
		[Export("showSmoothLines")]
		bool ShowSmoothLines { get; set; }

		// -(void)setXLabels:(NSArray *)xLabels withWidth:(CGFloat)width;
		[Export("setXLabels:withWidth:")]
		void SetXLabels(NSObject[] xLabels, nfloat width);

		// -(void)updateChartData:(NSArray *)data;
		[Export("updateChartData:")]
		void UpdateChartData(NSObject[] data);

		// -(UIView *)getLegendWithMaxWidth:(CGFloat)mWidth;
		[Export("getLegendWithMaxWidth:")]
		UIView GetLegendWithMaxWidth(nfloat mWidth);

		// +(CGSize)sizeOfString:(NSString *)text withWidth:(float)width font:(UIFont *)font;
		[Static]
		[Export("sizeOfString:withWidth:font:")]
		CGSize SizeOfString(string text, float width, UIFont font);

		// +(CGPoint)midPointBetweenPoint1:(CGPoint)point1 andPoint2:(CGPoint)point2;
		[Static]
		[Export("midPointBetweenPoint1:andPoint2:")]
		CGPoint MidPointBetweenPoint1(CGPoint point1, CGPoint point2);

		// +(CGPoint)controlPointBetweenPoint1:(CGPoint)point1 andPoint2:(CGPoint)point2;
		[Static]
		[Export("controlPointBetweenPoint1:andPoint2:")]
		CGPoint ControlPointBetweenPoint1(CGPoint point1, CGPoint point2);
	}

	// typedef PNLineChartDataItem * (^LCLineChartDataGetter)(NSUInteger);
	delegate PNLineChartDataItem LCLineChartDataGetter(nuint arg0);

	// @interface PNLineChartData : NSObject
	[BaseType(typeof(NSObject))]
	interface PNLineChartData
	{
		// @property (strong) UIColor * color;
		[Export("color", ArgumentSemantic.Strong)]
		UIColor Color { get; set; }

		// @property (nonatomic) CGFloat alpha;
		[Export("alpha")]
		nfloat Alpha { get; set; }

		// @property NSUInteger itemCount;
		[Export("itemCount")]
		nuint ItemCount { get; set; }

		// @property (copy) LCLineChartDataGetter getData;
		[Export("getData", ArgumentSemantic.Copy)]
		LCLineChartDataGetter GetData { get; set; }

		// @property (nonatomic, strong) NSString * dataTitle;
		[Export("dataTitle", ArgumentSemantic.Strong)]
		string DataTitle { get; set; }

		// @property (nonatomic) BOOL showPointLabel;
		[Export("showPointLabel")]
		bool ShowPointLabel { get; set; }

		// @property (nonatomic) UIColor * pointLabelColor;
		[Export("pointLabelColor", ArgumentSemantic.Assign)]
		UIColor PointLabelColor { get; set; }

		// @property (nonatomic) UIFont * pointLabelFont;
		[Export("pointLabelFont", ArgumentSemantic.Assign)]
		UIFont PointLabelFont { get; set; }

		// @property (nonatomic) NSString * pointLabelFormat;
		[Export("pointLabelFormat")]
		string PointLabelFormat { get; set; }

		//// @property (assign, nonatomic) PNLineChartPointStyle inflexionPointStyle;
		//[Export("inflexionPointStyle", ArgumentSemantic.Assign)]
		//PNLineChartPointStyle InflexionPointStyle { get; set; }

		// @property (nonatomic) UIColor * inflexionPointColor;
		[Export("inflexionPointColor", ArgumentSemantic.Assign)]
		UIColor InflexionPointColor { get; set; }

		// @property (assign, nonatomic) CGFloat inflexionPointWidth;
		[Export("inflexionPointWidth")]
		nfloat InflexionPointWidth { get; set; }

		// @property (assign, nonatomic) CGFloat lineWidth;
		[Export("lineWidth")]
		nfloat LineWidth { get; set; }
	}

	// @interface PNLineChartDataItem : NSObject
	[BaseType(typeof(NSObject))]
	interface PNLineChartDataItem
	{
		// +(PNLineChartDataItem *)dataItemWithY:(CGFloat)y;
		[Static]
		[Export("dataItemWithY:")]
		PNLineChartDataItem DataItemWithY(nfloat y);

		// +(PNLineChartDataItem *)dataItemWithY:(CGFloat)y andRawY:(CGFloat)rawY;
		[Static]
		[Export("dataItemWithY:andRawY:")]
		PNLineChartDataItem DataItemWithY(nfloat y, nfloat rawY);

		// @property (readonly) CGFloat y;
		[Export("y")]
		nfloat Y { get; }

		// @property (readonly) CGFloat rawY;
		[Export("rawY")]
		nfloat RawY { get; }
	}

	// typedef NSString * (^UICountingLabelFormatBlock)(CGFloat);
	delegate string UICountingLabelFormatBlock(nfloat arg0);

	// typedef NSAttributedString * (^UICountingLabelAttributedFormatBlock)(CGFloat);
	delegate NSAttributedString UICountingLabelAttributedFormatBlock(nfloat arg0);

	// @interface UICountingLabel : UILabel
	[BaseType(typeof(UILabel))]
	interface UICountingLabel
	{
		// @property (nonatomic, strong) NSString * format;
		[Export("format", ArgumentSemantic.Strong)]
		string Format { get; set; }

		//// @property (assign, nonatomic) UILabelCountingMethod method;
		//[Export("method", ArgumentSemantic.Assign)]
		//UILabelCountingMethod Method { get; set; }

		// @property (assign, nonatomic) NSTimeInterval animationDuration;
		[Export("animationDuration")]
		double AnimationDuration { get; set; }

		// @property (copy, nonatomic) UICountingLabelFormatBlock formatBlock;
		[Export("formatBlock", ArgumentSemantic.Copy)]
		UICountingLabelFormatBlock FormatBlock { get; set; }

		// @property (copy, nonatomic) UICountingLabelAttributedFormatBlock attributedFormatBlock;
		[Export("attributedFormatBlock", ArgumentSemantic.Copy)]
		UICountingLabelAttributedFormatBlock AttributedFormatBlock { get; set; }

		// @property (copy, nonatomic) void (^completionBlock)();
		[Export("completionBlock", ArgumentSemantic.Copy)]
		Action CompletionBlock { get; set; }

		// -(void)countFrom:(CGFloat)startValue to:(CGFloat)endValue;
		[Export("countFrom:to:")]
		void CountFrom(nfloat startValue, nfloat endValue);

		// -(void)countFrom:(CGFloat)startValue to:(CGFloat)endValue withDuration:(NSTimeInterval)duration;
		[Export("countFrom:to:withDuration:")]
		void CountFrom(nfloat startValue, nfloat endValue, double duration);

		// -(void)countFromCurrentValueTo:(CGFloat)endValue;
		[Export("countFromCurrentValueTo:")]
		void CountFromCurrentValueTo(nfloat endValue);

		// -(void)countFromCurrentValueTo:(CGFloat)endValue withDuration:(NSTimeInterval)duration;
		[Export("countFromCurrentValueTo:withDuration:")]
		void CountFromCurrentValueTo(nfloat endValue, double duration);

		// -(void)countFromZeroTo:(CGFloat)endValue;
		[Export("countFromZeroTo:")]
		void CountFromZeroTo(nfloat endValue);

		// -(void)countFromZeroTo:(CGFloat)endValue withDuration:(NSTimeInterval)duration;
		[Export("countFromZeroTo:withDuration:")]
		void CountFromZeroTo(nfloat endValue, double duration);

		// -(CGFloat)currentValue;
		[Export("currentValue")]
		nfloat CurrentValue { get; }
	}

	// @interface PNCircleChart : UIView
	[BaseType(typeof(UIView))]
	interface PNCircleChart
	{
		// -(void)strokeChart;
		[Export("strokeChart")]
		void StrokeChart();

		// -(void)growChartByAmount:(NSNumber *)growAmount;
		[Export("growChartByAmount:")]
		void GrowChartByAmount(NSNumber growAmount);

		// -(void)updateChartByCurrent:(NSNumber *)current;
		[Export("updateChartByCurrent:")]
		void UpdateChartByCurrent(NSNumber current);

		// -(void)updateChartByCurrent:(NSNumber *)current byTotal:(NSNumber *)total;
		[Export("updateChartByCurrent:byTotal:")]
		void UpdateChartByCurrent(NSNumber current, NSNumber total);

		// -(id)initWithFrame:(CGRect)frame total:(NSNumber *)total current:(NSNumber *)current clockwise:(BOOL)clockwise;
		[Export("initWithFrame:total:current:clockwise:")]
		IntPtr Constructor(CGRect frame, NSNumber total, NSNumber current, bool clockwise);

		// -(id)initWithFrame:(CGRect)frame total:(NSNumber *)total current:(NSNumber *)current clockwise:(BOOL)clockwise shadow:(BOOL)hasBackgroundShadow shadowColor:(UIColor *)backgroundShadowColor;
		[Export("initWithFrame:total:current:clockwise:shadow:shadowColor:")]
		IntPtr Constructor(CGRect frame, NSNumber total, NSNumber current, bool clockwise, bool hasBackgroundShadow, UIColor backgroundShadowColor);

		// -(id)initWithFrame:(CGRect)frame total:(NSNumber *)total current:(NSNumber *)current clockwise:(BOOL)clockwise shadow:(BOOL)hasBackgroundShadow shadowColor:(UIColor *)backgroundShadowColor displayCountingLabel:(BOOL)displayCountingLabel;
		[Export("initWithFrame:total:current:clockwise:shadow:shadowColor:displayCountingLabel:")]
		IntPtr Constructor(CGRect frame, NSNumber total, NSNumber current, bool clockwise, bool hasBackgroundShadow, UIColor backgroundShadowColor, bool displayCountingLabel);

		// -(id)initWithFrame:(CGRect)frame total:(NSNumber *)total current:(NSNumber *)current clockwise:(BOOL)clockwise shadow:(BOOL)hasBackgroundShadow shadowColor:(UIColor *)backgroundShadowColor displayCountingLabel:(BOOL)displayCountingLabel overrideLineWidth:(NSNumber *)overrideLineWidth;
		[Export("initWithFrame:total:current:clockwise:shadow:shadowColor:displayCountingLabel:overrideLineWidth:")]
		IntPtr Constructor(CGRect frame, NSNumber total, NSNumber current, bool clockwise, bool hasBackgroundShadow, UIColor backgroundShadowColor, bool displayCountingLabel, NSNumber overrideLineWidth);

		// @property (nonatomic, strong) UICountingLabel * countingLabel;
		[Export("countingLabel", ArgumentSemantic.Strong)]
		UICountingLabel CountingLabel { get; set; }

		// @property (nonatomic) UIColor * strokeColor;
		[Export("strokeColor", ArgumentSemantic.Assign)]
		UIColor StrokeColor { get; set; }

		// @property (nonatomic) UIColor * strokeColorGradientStart;
		[Export("strokeColorGradientStart", ArgumentSemantic.Assign)]
		UIColor StrokeColorGradientStart { get; set; }

		// @property (nonatomic) NSNumber * total;
		[Export("total", ArgumentSemantic.Assign)]
		NSNumber Total { get; set; }

		// @property (nonatomic) NSNumber * current;
		[Export("current", ArgumentSemantic.Assign)]
		NSNumber Current { get; set; }

		// @property (nonatomic) NSNumber * lineWidth;
		[Export("lineWidth", ArgumentSemantic.Assign)]
		NSNumber LineWidth { get; set; }

		// @property (nonatomic) NSTimeInterval duration;
		[Export("duration")]
		double Duration { get; set; }

		//// @property (nonatomic) PNChartFormatType chartType;
		//[Export("chartType", ArgumentSemantic.Assign)]
		//PNChartFormatType ChartType { get; set; }

		// @property (nonatomic) CAShapeLayer * circle;
		[Export("circle", ArgumentSemantic.Assign)]
		CAShapeLayer Circle { get; set; }

		// @property (nonatomic) CAShapeLayer * gradientMask;
		[Export("gradientMask", ArgumentSemantic.Assign)]
		CAShapeLayer GradientMask { get; set; }

		// @property (nonatomic) CAShapeLayer * circleBackground;
		[Export("circleBackground", ArgumentSemantic.Assign)]
		CAShapeLayer CircleBackground { get; set; }

		// @property (nonatomic) BOOL displayCountingLabel;
		[Export("displayCountingLabel")]
		bool DisplayCountingLabel { get; set; }

		// @property (nonatomic) BOOL displayAnimated;
		[Export("displayAnimated")]
		bool DisplayAnimated { get; set; }
	}

	// @interface PNPieChartDataItem : NSObject
	[BaseType(typeof(NSObject))]
	interface PNPieChartDataItem
	{
		// +(instancetype)dataItemWithValue:(CGFloat)value color:(UIColor *)color;
		[Static]
		[Export("dataItemWithValue:color:")]
		PNPieChartDataItem DataItemWithValue(nfloat value, UIColor color);

		// +(instancetype)dataItemWithValue:(CGFloat)value color:(UIColor *)color description:(NSString *)description;
		[Static]
		[Export("dataItemWithValue:color:description:")]
		PNPieChartDataItem DataItemWithValue(nfloat value, UIColor color, string description);

		// @property (nonatomic) CGFloat value;
		[Export("value")]
		nfloat Value { get; set; }

		// @property (nonatomic) UIColor * color;
		[Export("color", ArgumentSemantic.Assign)]
		UIColor Color { get; set; }

		// @property (nonatomic) NSString * textDescription;
		[Export("textDescription")]
		string TextDescription { get; set; }
	}

	// @interface PNPieChart : PNGenericChart
	[BaseType(typeof(PNGenericChart))]
	interface PNPieChart
	{
		// -(id)initWithFrame:(CGRect)frame items:(NSArray *)items;
		[Export("initWithFrame:items:")]
		IntPtr Constructor(CGRect frame, NSObject[] items);

		// @property (readonly, nonatomic) NSArray * items;
		[Export("items")]
		NSObject[] Items { get; }

		// @property (nonatomic) UIFont * descriptionTextFont;
		[Export("descriptionTextFont", ArgumentSemantic.Assign)]
		UIFont DescriptionTextFont { get; set; }

		// @property (nonatomic) UIColor * descriptionTextColor;
		[Export("descriptionTextColor", ArgumentSemantic.Assign)]
		UIColor DescriptionTextColor { get; set; }

		// @property (nonatomic) UIColor * descriptionTextShadowColor;
		[Export("descriptionTextShadowColor", ArgumentSemantic.Assign)]
		UIColor DescriptionTextShadowColor { get; set; }

		// @property (nonatomic) CGSize descriptionTextShadowOffset;
		[Export("descriptionTextShadowOffset", ArgumentSemantic.Assign)]
		CGSize DescriptionTextShadowOffset { get; set; }

		// @property (nonatomic) NSTimeInterval duration;
		[Export("duration")]
		double Duration { get; set; }

		// @property (nonatomic) BOOL showOnlyValues;
		[Export("showOnlyValues")]
		bool ShowOnlyValues { get; set; }

		// @property (nonatomic) BOOL showAbsoluteValues;
		[Export("showAbsoluteValues")]
		bool ShowAbsoluteValues { get; set; }

		// @property (assign, nonatomic) CGFloat labelPercentageCutoff;
		[Export("labelPercentageCutoff")]
		nfloat LabelPercentageCutoff { get; set; }

		// @property (nonatomic) BOOL shouldHighlightSectorOnTouch;
		[Export("shouldHighlightSectorOnTouch")]
		bool ShouldHighlightSectorOnTouch { get; set; }

		// @property (nonatomic) CGFloat outerCircleRadius;
		[Export("outerCircleRadius")]
		nfloat OuterCircleRadius { get; set; }

		// @property (nonatomic) CGFloat innerCircleRadius;
		[Export("innerCircleRadius")]
		nfloat InnerCircleRadius { get; set; }

		[Wrap("WeakDelegate")]
		PNChartDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<PNChartDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(void)updateChartData:(NSArray *)data;
		[Export("updateChartData:")]
		void UpdateChartData(NSObject[] data);

		// @property (assign, nonatomic) BOOL enableMultipleSelection;
		[Export("enableMultipleSelection")]
		bool EnableMultipleSelection { get; set; }

		// @property (nonatomic) BOOL hideValues;
		[Export("hideValues")]
		bool HideValues { get; set; }

		// -(void)strokeChart;
		[Export("strokeChart")]
		void StrokeChart();

		// -(void)recompute;
		[Export("recompute")]
		void Recompute();
	}

	// typedef PNScatterChartDataItem * (^LCScatterChartDataGetter)(NSUInteger);
	delegate PNScatterChartDataItem LCScatterChartDataGetter(nuint arg0);

	// @interface PNScatterChartData : NSObject
	[BaseType(typeof(NSObject))]
	interface PNScatterChartData
	{
		// @property (strong) UIColor * fillColor;
		[Export("fillColor", ArgumentSemantic.Strong)]
		UIColor FillColor { get; set; }

		// @property (strong) UIColor * strokeColor;
		[Export("strokeColor", ArgumentSemantic.Strong)]
		UIColor StrokeColor { get; set; }

		// @property NSUInteger itemCount;
		[Export("itemCount")]
		nuint ItemCount { get; set; }

		// @property (copy) LCScatterChartDataGetter getData;
		[Export("getData", ArgumentSemantic.Copy)]
		LCScatterChartDataGetter GetData { get; set; }

		//// @property (assign, nonatomic) PNScatterChartPointStyle inflexionPointStyle;
		//[Export("inflexionPointStyle", ArgumentSemantic.Assign)]
		//PNScatterChartPointStyle InflexionPointStyle { get; set; }

		// @property (assign, nonatomic) CGFloat size;
		[Export("size")]
		nfloat Size { get; set; }
	}

	// @interface PNScatterChartDataItem : NSObject
	[BaseType(typeof(NSObject))]
	interface PNScatterChartDataItem
	{
		// +(PNScatterChartDataItem *)dataItemWithX:(CGFloat)x AndWithY:(CGFloat)y;
		[Static]
		[Export("dataItemWithX:AndWithY:")]
		PNScatterChartDataItem DataItemWithX(nfloat x, nfloat y);

		// @property (readonly) CGFloat x;
		[Export("x")]
		nfloat X { get; }

		// @property (readonly) CGFloat y;
		[Export("y")]
		nfloat Y { get; }
	}

	// @interface PNScatterChart : PNGenericChart
	[BaseType(typeof(PNGenericChart))]
	interface PNScatterChart
	{
		[Wrap("WeakDelegate")]
		PNChartDelegate Delegate { get; set; }

		// @property (retain, nonatomic) id<PNChartDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Retain)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic) NSArray * chartData;
		[Export("chartData", ArgumentSemantic.Assign)]
		NSObject[] ChartData { get; set; }

		// @property (getter = isShowCoordinateAxis, nonatomic) BOOL showCoordinateAxis;
		[Export("showCoordinateAxis")]
		bool ShowCoordinateAxis { [Bind("isShowCoordinateAxis")] get; set; }

		// @property (nonatomic) UIColor * axisColor;
		[Export("axisColor", ArgumentSemantic.Assign)]
		UIColor AxisColor { get; set; }

		// @property (nonatomic) CGFloat axisWidth;
		[Export("axisWidth")]
		nfloat AxisWidth { get; set; }

		// @property (nonatomic, strong) NSString * xLabelFormat;
		[Export("xLabelFormat", ArgumentSemantic.Strong)]
		string XLabelFormat { get; set; }

		// @property (nonatomic, strong) NSString * yLabelFormat;
		[Export("yLabelFormat", ArgumentSemantic.Strong)]
		string YLabelFormat { get; set; }

		// @property (nonatomic) BOOL showLabel;
		[Export("showLabel")]
		bool ShowLabel { get; set; }

		// @property (nonatomic) UIFont * descriptionTextFont;
		[Export("descriptionTextFont", ArgumentSemantic.Assign)]
		UIFont DescriptionTextFont { get; set; }

		// @property (nonatomic) UIColor * descriptionTextColor;
		[Export("descriptionTextColor", ArgumentSemantic.Assign)]
		UIColor DescriptionTextColor { get; set; }

		// @property (nonatomic) UIColor * descriptionTextShadowColor;
		[Export("descriptionTextShadowColor", ArgumentSemantic.Assign)]
		UIColor DescriptionTextShadowColor { get; set; }

		// @property (nonatomic) CGSize descriptionTextShadowOffset;
		[Export("descriptionTextShadowOffset", ArgumentSemantic.Assign)]
		CGSize DescriptionTextShadowOffset { get; set; }

		// @property (nonatomic) NSTimeInterval duration;
		[Export("duration")]
		double Duration { get; set; }

		// @property (nonatomic) CGFloat AxisX_minValue;
		[Export("AxisX_minValue")]
		nfloat AxisX_minValue { get; set; }

		// @property (nonatomic) CGFloat AxisX_maxValue;
		[Export("AxisX_maxValue")]
		nfloat AxisX_maxValue { get; set; }

		// @property (nonatomic) CGFloat AxisY_minValue;
		[Export("AxisY_minValue")]
		nfloat AxisY_minValue { get; set; }

		// @property (nonatomic) CGFloat AxisY_maxValue;
		[Export("AxisY_maxValue")]
		nfloat AxisY_maxValue { get; set; }

		// -(void)setAxisXWithMinimumValue:(CGFloat)minVal andMaxValue:(CGFloat)maxVal toTicks:(int)numberOfTicks;
		[Export("setAxisXWithMinimumValue:andMaxValue:toTicks:")]
		void SetAxisXWithMinimumValue(nfloat minVal, nfloat maxVal, int numberOfTicks);

		// -(void)setAxisYWithMinimumValue:(CGFloat)minVal andMaxValue:(CGFloat)maxVal toTicks:(int)numberOfTicks;
		[Export("setAxisYWithMinimumValue:andMaxValue:toTicks:")]
		void SetAxisYWithMinimumValue(nfloat minVal, nfloat maxVal, int numberOfTicks);

		// -(void)setAxisXLabel:(NSArray *)array;
		[Export("setAxisXLabel:")]
		void SetAxisXLabel(NSObject[] array);

		// -(void)setAxisYLabel:(NSArray *)array;
		[Export("setAxisYLabel:")]
		void SetAxisYLabel(NSObject[] array);

		// -(void)setup;
		[Export("setup")]
		void Setup();

		// -(void)drawLineFromPoint:(CGPoint)startPoint ToPoint:(CGPoint)endPoint WithLineWith:(CGFloat)lineWidth AndWithColor:(UIColor *)color;
		[Export("drawLineFromPoint:ToPoint:WithLineWith:AndWithColor:")]
		void DrawLineFromPoint(CGPoint startPoint, CGPoint endPoint, nfloat lineWidth, UIColor color);

		// -(void)updateChartData:(NSArray *)data;
		[Export("updateChartData:")]
		void UpdateChartData(NSObject[] data);
	}

	// @interface PNRadarChartDataItem : NSObject
	[BaseType(typeof(NSObject))]
	interface PNRadarChartDataItem
	{
		// +(instancetype)dataItemWithValue:(CGFloat)value description:(NSString *)description;
		[Static]
		[Export("dataItemWithValue:description:")]
		PNRadarChartDataItem DataItemWithValue(nfloat value, string description);

		// @property (nonatomic) CGFloat value;
		[Export("value")]
		nfloat Value { get; set; }

		// @property (copy, nonatomic) NSString * textDescription;
		[Export("textDescription")]
		string TextDescription { get; set; }
	}

	// @interface PNRadarChart : PNGenericChart
	[BaseType(typeof(PNGenericChart))]
	interface PNRadarChart
	{
		// -(id)initWithFrame:(CGRect)frame items:(NSArray *)items valueDivider:(CGFloat)unitValue;
		[Export("initWithFrame:items:valueDivider:")]
		IntPtr Constructor(CGRect frame, NSObject[] items, nfloat unitValue);

		// -(void)strokeChart;
		[Export("strokeChart")]
		void StrokeChart();

		// @property (nonatomic) NSArray * chartData;
		[Export("chartData", ArgumentSemantic.Assign)]
		NSObject[] ChartData { get; set; }

		// @property (nonatomic) CGFloat valueDivider;
		[Export("valueDivider")]
		nfloat ValueDivider { get; set; }

		// @property (nonatomic) CGFloat maxValue;
		[Export("maxValue")]
		nfloat MaxValue { get; set; }

		// @property (nonatomic) UIColor * webColor;
		[Export("webColor", ArgumentSemantic.Assign)]
		UIColor WebColor { get; set; }

		// @property (nonatomic) UIColor * plotColor;
		[Export("plotColor", ArgumentSemantic.Assign)]
		UIColor PlotColor { get; set; }

		// @property (nonatomic) UIColor * fontColor;
		[Export("fontColor", ArgumentSemantic.Assign)]
		UIColor FontColor { get; set; }

		// @property (nonatomic) UIColor * graduationColor;
		[Export("graduationColor", ArgumentSemantic.Assign)]
		UIColor GraduationColor { get; set; }

		// @property (nonatomic) CGFloat fontSize;
		[Export("fontSize")]
		nfloat FontSize { get; set; }

		//// @property (assign, nonatomic) PNRadarChartLabelStyle labelStyle;
		//[Export("labelStyle", ArgumentSemantic.Assign)]
		//PNRadarChartLabelStyle LabelStyle { get; set; }

		// @property (assign, nonatomic) BOOL isLabelTouchable;
		[Export("isLabelTouchable")]
		bool IsLabelTouchable { get; set; }

		// @property (assign, nonatomic) BOOL isShowGraduation;
		[Export("isShowGraduation")]
		bool IsShowGraduation { get; set; }
	}

	// @interface PNChartLabel : UILabel
	[BaseType(typeof(UILabel))]
	interface PNChartLabel
	{
	}
}
