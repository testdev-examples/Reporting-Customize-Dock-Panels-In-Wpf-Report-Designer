Imports System.Windows
Imports DevExpress.Xpf.Core
Imports DevExpress.XtraReports.UI

Namespace Reporting_Customize_Dock_Panels_In_Wpf_Report_DesignerDesigner
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			ApplicationThemeHelper.ApplicationThemeName = Theme.Office2016ColorfulSEName
			InitializeComponent()
			designer.OpenDocument(New XtraReport())
		End Sub
	End Class
End Namespace
