using System;
using System.Windows;
using System.Windows.Interop;

namespace WpfExample2
{
	static class FormConfig
	{
		public static Window frmSolid {get; set;} = new SolidColor();
		public static Window frmLinearGradient {get; set;} = new LinearGradient();
		public static Window frmRadialGradient { get; set; } = new RadialGradient();
		public static Window frmImage { get; set; } = new Image();
		public static Window frmVisual { get; set; } = new Visual();
		public static Window frmStack { get; set; } = new StackWindow();
		public static Window frmWrap { get; set; } = new WrapWindow();
		public static Window frmCanvas { get; set; } = new CanvasWindow();
		public static Window frmGrid { get; set; } = new GridWindow();
		public static Window frmDock { get; set; } = new DockWindow();

		public static Window frmEditor { get; set; } = new EditorWindow();
		//public static string msg = "";

		//static FormConfig()
		//{
		//	msg+=$"[I am in FormConfig Static ctor @{DateTime.Now.ToString("T") }]{Environment.NewLine}";
		//}

	}
}
