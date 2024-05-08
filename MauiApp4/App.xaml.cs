using MauiApp4.Views;

namespace MauiApp4;

public partial class App : Application
{
    // Add a public static CatFactRepository property
    public static CatFactRepository CatFactRepo { get; set; }
    
    public App(CatFactRepository repo)
    {
        InitializeComponent();

        MainPage = new MainPage();
        UserAppTheme = PlatformAppTheme;
        
        // Initialize the CatFactRepository property with the CatFactRepository singleton
        // the dependency inject process automatically populates the repo parameter to the constructor
        CatFactRepo = repo;
    }

    //protected override Window CreateWindow(IActivationState? activationState)
    //{
     //   var window = base.CreateWindow(activationState);
     //   window.Title = "MauiApp4";
     //   return window;
    //}
}
