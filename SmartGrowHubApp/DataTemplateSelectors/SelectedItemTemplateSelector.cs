namespace SmartGrowHubApp.DataTemplateSelectors;

public class SelectedItemTemplateSelector : DataTemplateSelector
{
    public DataTemplate? DefaultTemplate { get; set; }

    public DataTemplate? SelectedItemTemplate { get; set; }

    protected override DataTemplate? OnSelectTemplate(object item, BindableObject container)
    {
        if (container is not SelectableItemsView selectableItemsView)
        {
            return null;
        }

        if (item.Equals(selectableItemsView.SelectedItem))
        {
            return SelectedItemTemplate;
        }
        else
        {
            return DefaultTemplate;
        }
    }
}
