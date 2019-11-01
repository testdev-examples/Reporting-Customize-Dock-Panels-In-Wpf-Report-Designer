using System.Windows;
using DevExpress.Xpf.Core;
using DevExpress.XtraReports.UI;

namespace Reporting_Customize_Dock_Panels_In_Wpf_Report_DesignerDesigner {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			ApplicationThemeHelper.ApplicationThemeName = Theme.Office2016ColorfulSEName;
			InitializeComponent();
			designer.OpenDocument(new XtraReport());
		}
	}
}
