using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Markup;
using DevExpress.Mvvm;
using DevExpress.Xpf.Reports.UserDesigner;
using DevExpress.Xpf.Reports.UserDesigner.Native;

namespace CustomCommands {
    public static class ReportDesignerCommands {
        public static DelegateCommand<ReportDesigner> ToggleReportDrawGridCommand {
            get {
                return new DelegateCommand<ReportDesigner>(ShowGrid);
            }
        }
        static void ShowGrid(ReportDesigner designer) {
            Tracker.Set(designer.ActiveDocument.XRObject, x => x.DrawGrid, !designer.ActiveDocument.XRObject.DrawGrid);
        }
    }
    public class CustomCommandConverter : MarkupExtension, IValueConverter {
        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }

        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            if(value is bool && (bool)value)
                return "Hide Grid Lines";
            return "Show Grid Lines";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }

        #endregion
    }
}
