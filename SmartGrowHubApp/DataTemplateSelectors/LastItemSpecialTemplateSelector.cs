using System.Collections;

namespace SmartGrowHubApp.DataTemplateSelectors;

public class LastItemSpecialTemplateSelector : DataTemplateSelector
{
    public DataTemplate? DefaultTemplate { get; set; }

    public DataTemplate? SelectedTemplate { get; set; }

    public DataTemplate? LastItemTemplate { get; set; }

    protected override DataTemplate? OnSelectTemplate(object item, BindableObject container)
    {
        if (container is not ItemsView itemsView)
        {
            return null;
        }

        return DefaultTemplate;

        if (itemsView.ItemsSource is IList itemsList && item.Equals(itemsList[^1]))
        {
            return LastItemTemplate;
        }
        else
        {
            return DefaultTemplate;
        }
    }
}
