﻿using Abp.Application.Navigation;
using Abp.Localization;

namespace coolez.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class coolezNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("HomePage"),
                        url: "",
                        icon: "fa fa-home"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.About,
                        L("About"),
                        url: "Home/About",
                        icon: "fa fa-info"
                        )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, coolezConsts.LocalizationSourceName);
        }
    }
}
