using System.Collections;

namespace SmartGrowHubApp.DataTemplateSelectors;

public class LastItemSpecialTemplateSelector : DataTemplateSelector
{
    public DataTemplate? DefaultTemplate { get; set; }

    public DataTemplate? LastItemTemplate { get; set; }

    protected override DataTemplate? OnSelectTemplate(object item, BindableObject container)
    {
        if (container is ItemsView itemsView)
        {
            if (itemsView.ItemsSource is IList itemsList && item.Equals(itemsList[^1]))
            {
                return LastItemTemplate;
            }

            return DefaultTemplate;
        }
        else if (container is Layout)
        {
            var itemsSource = (IList)BindableLayout.GetItemsSource(container);

            if (item.Equals(itemsSource[^1]))
            {
                return LastItemTemplate;
            }

            return DefaultTemplate;
        }
        else
        {
            throw new ArgumentException($"Invalid container type: {item.GetType()}", nameof(container));
        }
    }
}