﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using JustGiving.WP8.ViewModels.Access;
namespace JustGiving.WP8.ViewModels
{
    public class MainPageViewModel : PropertyChangedBase
    {
        private readonly INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }        
    }
}