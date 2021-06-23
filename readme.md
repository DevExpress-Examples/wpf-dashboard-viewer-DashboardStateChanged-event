*Files to look at*:

* [MainWindow.xaml.cs](./CS/WPF-DashboardStateChanged-Event/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WPF-DashboardStateChanged-Event/MainWindow.xaml.vb))

# Dashboard for WPF - How to Use the DashboardStateChanged Event to Display User Interactions

This example demonstrates how to use the **DashboardStateChanged** event to display user interactions.

The [DevExpress.DashboardWpf.DashboardControl.DashboardStateChanged](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControl.DashboardStateChanged?v=20.1) is handled each time the dashboard state is changed and obtains a dashboard's state. The information about [MasterFilter](https://docs.devexpress.com/Dashboard/400011/designer-and-viewer-applications/wpf-viewer/manage-interactivity-capabilities?v=20.1), [DrillDown](https://docs.devexpress.com/Dashboard/400011/designer-and-viewer-applications/wpf-viewer/manage-interactivity-capabilities?v=20.1) and [RangeFilter](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.RangeFilterState?v=20.1) values displays in the text editor if these values are changed.


The following API is used in this example:
* [DevExpress.DashboardWpf.DashboardControl.DashboardStateChanged](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControl.DashboardStateChanged?v=20.1)
* [DashboardItemState.RangeFilterState](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardItemState.RangeFilterState?v=20.1)
* [DashboardItemState.MasterFilterValues](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardItemState.MasterFilterValues?v=20.1)
* [DashboardItemState.DrillDownValues](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardItemState.DrillDownValues?v=20.1)


## See Also
**WinForms Dashboard Designer:**
- [How to Set the Initial Dashboard State](https://github.com/DevExpress-Examples/winforms-designer-save-and-apply-dashboard-state)

- [How to Clear Filter Values in a Dashboard State](https://github.com/DevExpress-Examples/How-to-Clear-Filter-Values-in-a-Dashboard-State-)

**WinForms Dashboard Viewer:**
- [How to Use the DashboardStateChanged Event to Manage the Dashboard State](https://github.com/DevExpress-Examples/WinForms-Dashboard-Viewer-DashboardStateChanged-Event)

- [How to Save and Restore the Dashboard State](https://github.com/DevExpress-Examples/winforms-dashboard-save-restore-dashboard-state)

- [How to Set the Initial Dashboard State](https://github.com/DevExpress-Examples/winforms-viewer-save-and-apply-dashboard-state)

**WPF Dashboard:**

- [How to Set the Initial Dashboard State](https://github.com/DevExpress-Examples/wpf-dashboard-how-to-set-initial-dashboard-state)

