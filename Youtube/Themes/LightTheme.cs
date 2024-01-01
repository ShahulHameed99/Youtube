using MudBlazor;

namespace Youtube.Themes
{
    public class LightTheme : MudTheme
    {
        protected void Init()
        {
            Palette = new Palette
            {
                Primary = "#008ECF",
                Secondary = "#3F67AF",
                Tertiary = Palette.Black,
                Background = Palette.White,
                AppbarBackground = Palette.White,
                DrawerText = Palette.White,
                DrawerIcon = Palette.White,
                Success = "#06d79c",
                PrimaryDarken = "#005c9a",
                PrimaryLighten = "#0faff1",
                SecondaryDarken = "#00b485",
                SecondaryLighten = "#aceada",
                TertiaryDarken = "#0019c6",
                TertiaryLighten = "#2e2cd5"
            };
        }
    }
}
