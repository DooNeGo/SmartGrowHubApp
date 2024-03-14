using SmartGrowHubApp.Model;
using SmartGrowHubApp.ViewModels.ControllerPageModels;
using System.ComponentModel;

namespace SmartGrowHubApp.Pages.ControllerPages;

public partial class SettingModeSwitchPage : ContentPage
{
    private readonly SettingModeSwitchPageModel _pageModel;

    private Label? _previousCheckMark;

    public SettingModeSwitchPage(SettingModeSwitchPageModel pageModel)
    {
        InitializeComponent();

        _pageModel = pageModel;
        BindingContext = _pageModel;

        _pageModel.PropertyChanged += (_, args) =>
        {
            if (args.PropertyName is not nameof(_pageModel.ModeComponent))
            {
                return;
            }

            if (_pageModel.ModeComponent is null)
            {
                throw new NullReferenceException("ModeComponent is null");
            }

            ModeComponent_PropertyChanged(null, new PropertyChangedEventArgs(null));
            _pageModel.ModeComponent.PropertyChanged += ModeComponent_PropertyChanged;
        };
    }

    private void ModeComponent_PropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        var settingMode = (SettingMode)_pageModel.ModeComponent!.Value;

        if (settingMode is SettingMode.Off)
        {
            SetCheckMark(OffCheckMark);
        }
        else if (settingMode is SettingMode.On)
        {
            SetCheckMark(OnCheckMark);
        }
        else
        {
            SetCheckMark(AutoCheckMark);
        }
    }

    private void SetCheckMark(Label checkMark)
    {
        if (_previousCheckMark is not null)
        {
            _previousCheckMark.IsVisible = false;
        }

        checkMark.IsVisible = true;
        _previousCheckMark = checkMark;
    }

    private void SetSettingMode(SettingMode settingMode)
    {
        if (_pageModel.ModeComponent is not null)
        {
            _pageModel.ModeComponent.Value = settingMode;
        }
    }

    private void Off_Tapped(object sender, TappedEventArgs e)
    {
        SetSettingMode(SettingMode.Off);
    }

    private void On_Tapped(object sender, TappedEventArgs e)
    {
        SetSettingMode(SettingMode.On);
    }

    private void Auto_Tapped(object sender, TappedEventArgs e)
    {
        SetSettingMode(SettingMode.Auto);
    }
}