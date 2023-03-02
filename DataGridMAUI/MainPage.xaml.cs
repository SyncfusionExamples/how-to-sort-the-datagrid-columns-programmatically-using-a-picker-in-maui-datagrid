using Syncfusion.Maui.DataGrid;

namespace DataGridMAUI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
public void OnSelectionChanged(object sender, EventArgs e)
{
    if (SelectionPicker.SelectedIndex == 0)
    {
        this.dataGrid.SortColumnDescriptions.Clear();
        this.dataGrid.SortColumnDescriptions.Add(new SortColumnDescription() { ColumnName = "OrderID" });
    }
    else if (SelectionPicker.SelectedIndex == 1)
    {
        this.dataGrid.SortColumnDescriptions.Clear();
        this.dataGrid.SortColumnDescriptions.Add(new SortColumnDescription() { ColumnName = "CustomerID" });
    }
    else if (SelectionPicker.SelectedIndex == 2)
    {
        this.dataGrid.SortColumnDescriptions.Clear();
        this.dataGrid.SortColumnDescriptions.Add(new SortColumnDescription() { ColumnName = "Freight" });
    }
    else if (SelectionPicker.SelectedIndex == 3)
    {
        this.dataGrid.SortColumnDescriptions.Clear();
        this.dataGrid.SortColumnDescriptions.Add(new SortColumnDescription() { ColumnName = "Country" });
    }
}
}

