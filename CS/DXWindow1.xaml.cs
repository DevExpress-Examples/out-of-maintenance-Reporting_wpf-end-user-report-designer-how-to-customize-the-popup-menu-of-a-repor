using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.PropertyGrid;
using DevExpress.Xpf.Reports.UserDesigner;
using DevExpress.XtraReports.UI;


namespace CustomCommands {
    /// <summary>
    /// Interaction logic for DXWindow1.xaml
    /// </summary>
    public partial class DXWindow1 : DXWindow {
        public DXWindow1() {
            InitializeComponent();
            reportDesigner.OpenDocument(new XtraReport());
        }
    }
   

}
