using SmartGrowHubApp.Model;
using SmartGrowHubApp.ViewModels.Abstractions;
using System.Collections.ObjectModel;

namespace SmartGrowHubApp.ViewModels;

public class HomePageModel : ViewModelBase
{
    public HomePageModel()
    {
        Load();

        if (Items is null)
        {
            throw new NullReferenceException(nameof(Items));
        }

        Items.CollectionChanged += (_, _) => InvokePropertyChanged(nameof(Items));
    }

    public ObservableCollection<ControllerModel>? Items { get; private set; }

    public ControllerModel? SelectedItem { get; set; }

    public IList<object> SelectedItems { get; set; }

    public void ClearSelection()
    {
        SelectedItem = null;
        SelectedItems.Clear();
        SelectionChanged?.Invoke(SelectedItems);
    }

    public event Action<IList<object>>? SelectionChanged;

    private void Load()
    {
        Items =
        [
            new() { Name = "Main", Description = "In livingroom", Status = "Working" },
            new() { Name = "Secondery", Description = "In livingroom", Status = "Working" },
            new() { Name = "Main", Description = "In livingroom", Status = "Working" },
            new() { Name = "Secondery", Description = "In livingroom", Status = "Working" },
            new() { Name = "Main", Description = "In livingroom", Status = "Working" },
            new() { Name = "Secondery", Description = "In livingroom", Status = "Working" },
            new() { Name = "Main", Description = "In livingroom", Status = "Working" },
            new() { Name = "Secondery", Description = "In livingroom", Status = "Working" },
            new() { Name = "Main", Description = "In livingroom", Status = "Working" },
            new() { Name = "Secondery", Description = "In livingroom", Status = "Working" },
        ];
    }
}
