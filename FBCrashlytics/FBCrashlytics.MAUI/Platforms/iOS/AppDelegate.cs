using Firebase.Core;
using Firebase.Crashlytics;
using Foundation;

namespace FBCrashlytics.MAUI;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    [Export("application:didFinishLaunchingWithOptions:")]
    public bool FinishedLaunching(UIKit.UIApplication application, NSDictionary launchOptions)
    {
        Firebase.Core.App.Configure();
        // Accessing shared instance to make sure all reports are sent 
        Crashlytics.SharedInstance.Init();
        Crashlytics.SharedInstance.SetCrashlyticsCollectionEnabled(true);
        Crashlytics.SharedInstance.SendUnsentReports();
        return base.FinishedLaunching(application,launchOptions);
    }
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}

