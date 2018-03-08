﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo
{
    using Models;

    /// <summary>
    /// Menu
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        #region -- Methods --

        /// <summary>
        /// Initialize
        /// </summary>
        public Menu()
        {
            InitializeComponent();
            Icon = (FileImageSource)ImageSource.FromFile("logo.png");
            MasterPage.Title = "RedDotPower";
            //MasterPage.Icon = "logo.png";
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
            Detail = new NavigationPage(new Views.RedDot_Landing());
        }

        /// <summary>
        /// List view item selected
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">Event</param>
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MenuModel;
            if (item == null)
            {
                return;
            }

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;
            Detail = new NavigationPage(page);
            IsPresented = false;
            MasterPage.ListView.SelectedItem = null;
        }

        #endregion
    }
}