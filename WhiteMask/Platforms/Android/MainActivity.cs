using Android.App;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;

namespace WhiteMask {
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity {

		protected override void OnCreate(Bundle savedInstanceState) {
			base.OnCreate(savedInstanceState);

			// 获取窗口
			var window = Window;

			// 检查当前系统是否为暗色模式
			bool isDarkTheme = (Resources.Configuration.UiMode & UiMode.NightMask) == UiMode.NightYes;

			// 设置状态栏颜色
			if (isDarkTheme) {
				window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#000000"));
				window.SetNavigationBarColor(Android.Graphics.Color.ParseColor("#000000"));
			} else {
				window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#477ee7"));
				window.SetNavigationBarColor(Android.Graphics.Color.ParseColor("#9ebfff"));
			}
		}
	}
}
