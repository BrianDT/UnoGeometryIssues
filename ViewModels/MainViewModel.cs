// <copyright file="MainViewModel.cs" company="Visual Software Systems Ltd.">Copyright (c) 2020 - 2022 All rights reserved</copyright>

namespace Vssl.Samples.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Text;

    /// <summary>
    /// The main view model for the app.
    /// </summary>
    [Bindable(bindable: true)]
    public class MainViewModel : BaseViewModel
    {
        /// <summary>
        /// Gets a value indicating whether the button size is reduced
        /// </summary>
        public bool IsReduced { get; private set; }

        /// <summary>
        /// Toggle the size of the round button
        /// </summary>
        public void Toggle()
        {
            this.IsReduced = !this.IsReduced;
            this.OnPropertyChanged("IsReduced");
        }
    }
}
