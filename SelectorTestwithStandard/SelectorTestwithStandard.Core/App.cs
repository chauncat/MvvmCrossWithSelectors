﻿using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.ViewModels;

namespace SelectorTestwithStandard.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<MainViewModel>();
        }
    }
}
