using DevExpress.DashboardCommon;
using DevExpress.DashboardWpf;
using System;
using System.Linq;
using System.Windows;

namespace WPF_DashboardStateChanged_Event {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow: Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void DashboardControl_DashboardStateChanged(object sender, DashboardStateChangedWpfEventArgs e) {
            var newState = e.DashboardState;
            var message = string.Empty;
            foreach(DashboardItemState itemState in newState.Items) {
                var item = dashboardControl1.Dashboard.Items[itemState.ItemName];
                message += item.Name;
                if( itemState.DrillDownValues.Count != 0) {
                    message += "\n" + "Filter Drill-Down:" + " " + string.Join("," , itemState.DrillDownValues);
                }
                if(itemState.MasterFilterValues.Count != 0) {
                    message +=  "\n" + "Master Filter:" + " " + string.Join(" | ", itemState.MasterFilterValues.Select(v=> string.Join(",",v))); 
                }
                if (itemState.RangeFilterState.Selection.Minimum !=null || itemState.RangeFilterState.Selection.Maximum != null) {
                    message += "\n" + "Range Filter:" + " " + ((DateTime)itemState.RangeFilterState.Selection.Minimum).ToString("y") + "-" + ((DateTime)itemState.RangeFilterState.Selection.Maximum).ToString("y");
                }
                message += Environment.NewLine;
                message += "\n";
            }
                 TextEdit.Text = message;  
        }            
    }       
}


        
    

