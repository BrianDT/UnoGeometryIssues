// <copyright file="MainPage.xaml.cs" company="Visual Software Systems Ltd.">Copyright (c) 2019 All rights reserved</copyright>

namespace UnoGeometryIssues
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.InteropServices.WindowsRuntime;
    using System.Threading;
    using System.Threading.Tasks;
    using UnoGeometryIssues.Shared;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Controls.Primitives;
    using Windows.UI.Xaml.Data;
    using Windows.UI.Xaml.Input;
    using Windows.UI.Xaml.Media;
    using Windows.UI.Xaml.Navigation;

    // The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainPage" /> class.
        /// </summary>
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Navigate to the issue page.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event args</param>
        private void Issue_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(IssuePage));
        }

        /// <summary>
        /// Navigate to the work around page.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event args</param>
        private void WorkAround_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(WorkAroundPage));
        }

        /// <summary>
        /// Navigate to the template issue page.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event args</param>
        private void TemplateIssue_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(TemplateIssuePage));
        }

        /// <summary>
        /// Navigate to the template issue page.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event args</param>
        private void TemplateWorkAround_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(TemplateWorkAroundPage));
        }
    }
}
