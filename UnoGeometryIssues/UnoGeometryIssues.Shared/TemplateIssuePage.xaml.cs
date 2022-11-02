// <copyright file="TemplateIssuePage.xaml.cs" company="Visual Software Systems Ltd.">Copyright (c) 2022 All rights reserved</copyright>

namespace UnoGeometryIssues.Shared
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.InteropServices.WindowsRuntime;
    using Microsoft.UI.Xaml;
    using Microsoft.UI.Xaml.Controls;
    using Vssl.Samples.Framework;
    using Vssl.Samples.ViewModels;
    using Windows.Foundation;
    using Windows.Foundation.Collections;

    // The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TemplateIssuePage : Page
    {
        public TemplateIssuePage()
        {
            this.InitializeComponent();
            this.DataContext = new MainViewModel();
        }

        /// <summary>
        /// Gets or sets the view model for the menu
        /// </summary>
        public MainViewModel VM
        {
            get
            {
                return this.DataContext as MainViewModel;
            }
        }

        /// <summary>
        /// Return to the main page.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event args</param>
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        /// <summary>
        /// Toggle the round button size.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event args</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.VM.Toggle();
        }
    }
}
