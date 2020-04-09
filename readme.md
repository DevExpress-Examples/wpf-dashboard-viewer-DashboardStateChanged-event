*Files to look at*:

* [Form1.cs](./CS/WPF-DashboardStateChanged-Event/Form1.cs) (VB: [Form1.vb](./VB/WPF-DashboardStateChanged-Event/Form1.vb))

# How to use the DashboardStateChanged event to manage the Dashboard state.

This example demonstrates how to manage a dashboard state to display user selections.

The [DevExpress.DashboardWpf.DashboardControl.DashboardStateChanged](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControl.DashboardStateChanged?v=20.1) handles each time the dashboard state is changed and obtains a dashboard's state object. The information about [MasterFilter](https://docs.devexpress.com/Dashboard/400011/designer-and-viewer-applications/wpf-viewer/manage-interactivity-capabilities?v=20.1), [DrillDown](https://docs.devexpress.com/Dashboard/400011/designer-and-viewer-applications/wpf-viewer/manage-interactivity-capabilities?v=20.1) and [RangeFilter](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.RangeFilterState?v=20.1) values displays in the text editor if they are changed.


The following API is used in this example:
* [DevExpress.DashboardWpf.DashboardControl.DashboardStateChanged](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControl.DashboardStateChanged?v=20.1)
* [DashboardItemState.RangeFilterState](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardItemState.RangeFilterState?v=20.1)
* [DashboardItemState.MasterFilterValues](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardItemState.MasterFilterValues?v=20.1)
* [DashboardItemState.DrillDownValues](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardItemState.DrillDownValues?v=20.1)
