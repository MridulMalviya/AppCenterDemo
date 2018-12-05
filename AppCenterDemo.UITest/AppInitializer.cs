using Xamarin.UITest;

namespace AppCenterDemo.UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.EnableLocalScreenshots().InstalledApp("com.companyname.AppCenterDemo").StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}
