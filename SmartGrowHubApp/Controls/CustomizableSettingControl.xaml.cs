using System.Windows.Input;

namespace SmartGrowHubApp.Controls;

public partial class CustomizableSettingControl
{
	public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(CustomizableSettingControl), propertyChanged: (bindable, oldValue, newValue) =>
    {
        var control = (CustomizableSettingControl)bindable;
        control.titleLabel.Text = newValue as string;
    });
    
    public static readonly BindableProperty ContentAreaProperty = BindableProperty.Create(nameof(ContentArea), typeof(View), typeof(CustomizableSettingControl), propertyChanged: (bindable, oldValue, newValue) =>
    {
        var control = (CustomizableSettingControl)bindable;
        control.contentArea.Content = newValue as View;
    });

    public static readonly BindableProperty TapCommandProperty = BindableProperty.Create(nameof(TapCommand), typeof(ICommand), typeof(CustomizableSettingControl), propertyChanged: (bindable, oldValue, newValue) =>
    {
        var control = (CustomizableSettingControl)bindable;
        control.tapGestureRecognizer.Command = newValue as ICommand;
    });

    public static readonly BindableProperty TapCommandParameterProperty = BindableProperty.Create(nameof(TapCommandParameter), typeof(object), typeof(CustomizableSettingControl), propertyChanged: (bindable, oldValue, newValue) =>
    {
        var control = (CustomizableSettingControl)bindable;
        control.tapGestureRecognizer.CommandParameter = newValue;
    });

    public event EventHandler<PointerEventArgs>? PointerReleased;

    public event EventHandler<PointerEventArgs>? PointerPressed;

    public event EventHandler<TappedEventArgs>? Tapped;

	public CustomizableSettingControl()
	{
		InitializeComponent();
	}

    public string? Title
    {
        get => GetValue(TitleProperty) as string;
        set => SetValue(TitleProperty, value);
    }

    public View? ContentArea
    {
        get => GetValue(ContentProperty) as View;
        set => SetValue(ContentProperty, value);
    }

    public ICommand? TapCommand
    {
        get => GetValue(ContentProperty) as ICommand;
        set => SetValue(ContentProperty, value);
    }

    public object? TapCommandParameter
    {
        get => GetValue(ContentProperty);
        set => SetValue(ContentProperty, value);
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