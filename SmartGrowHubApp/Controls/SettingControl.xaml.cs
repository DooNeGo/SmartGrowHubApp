namespace SmartGrowHubApp.Controls;

public partial class SettingControl : ContentView
{
    public static readonly BindableProperty PreviewValueProperty = BindableProperty.Create(nameof(PreviewValue), typeof(object), typeof(SettingControl), propertyChanged: (bindable, oldValue, newValue) =>
    {
        var control = (SettingControl)bindable;
        control.PreviewValueLabel.Text = newValue.ToString();
    });

    public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(SettingControl), propertyChanged: (bindable, oldValue, newValue) =>
    {
        var control = (SettingControl)bindable;
        control.TitleLabel.Text = newValue as string;
    });

    public event EventHandler<PointerEventArgs>? PointerReleased;

    public event EventHandler<PointerEventArgs>? PointerPressed;

    public event EventHandler<TappedEventArgs>? Tapped;

    public SettingControl()
    {
        InitializeComponent();
    }

    public object? PreviewValue
    {
        get => GetValue(PreviewValueProperty);
        set => SetValue(PreviewValueProperty, value);
    }

    public string? Title
    {
        get => GetValue(TitleProperty) as string;
        set => SetValue(TitleProperty, value);
    }

    private void PointerGestureRecognizer_PointerReleased(object sender, PointerEventArgs e)
    {
        PointerReleased?.Invoke(this, e);
    }

    private void PointerGestureRecognizer_PointerPressed(object sender, PointerEventArgs e)
    {
        PointerPressed?.Invoke(this, e);
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Tapped?.Invoke(this, e);
    }
}