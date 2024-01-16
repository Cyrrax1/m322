using System;
using Microsoft.Maui.Controls;

namespace MixMaster.View
{
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
            BindingContext = new SearchViewModel();
        }
    }

}
