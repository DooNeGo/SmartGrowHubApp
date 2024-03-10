using SmartGrowHubApp.ObservableObjects;

namespace SmartGrowHubApp.Controls;

public partial class ComponentControl : ContentView
{
    public static readonly BindableProperty ComponentProperty = BindableProperty.Create(nameof(Component), typeof(ComponentObservable), typeof(ComponentControl));
    public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(ComponentControl), string.Empty);

    public ComponentControl()
    {
        InitializeComponent();

        BindingContext = this; 
    }

    public ComponentObservable? Component
    {
        get => (ComponentObservable?)GetValue(ComponentProperty);
        set => SetValue(ComponentProperty, value);
    }

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }
}