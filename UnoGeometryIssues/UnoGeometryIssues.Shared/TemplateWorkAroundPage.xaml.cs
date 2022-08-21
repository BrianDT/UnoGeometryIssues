namespace UnoGeometryIssues.Shared
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.InteropServices.WindowsRuntime;
    using Microsoft.Extensions.Logging;
    using Uno.Extensions;
    using Vssl.Samples.Framework;
    using Vssl.Samples.ViewModels;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Microsoft.UI.Xaml;
    using Microsoft.UI.Xaml.Controls;
#if __WASM__
    using Microsoft.UI.Xaml.Shapes;
#endif

    // The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TemplateWorkAroundPage : Page
    {
#if __WASM__
        /// <summary>
        /// A value set on button press that allows the ellipse visibility to be flipped
        /// </summary>
        private bool allowFlip;

        /// <summary>
        /// The ellipse shape control in the template.
        /// </summary>
        private Ellipse ellipse;
#endif

        public TemplateWorkAroundPage()
        {
            this.InitializeComponent();
            this.DataContext = new MainViewModel();
        }

        /// <summary>
        /// Gets the view model for the menu
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
#if __WASM__
            this.allowFlip = true;
#endif
            this.VM.Toggle();
        }

        private void Ellipse_Loaded(object sender, RoutedEventArgs args)
        {
#if __WASM__
            this.ellipse = sender as Ellipse;
#endif
        }

        /// <summary>
        /// Event handler for container size change.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event args</param>
        private void Container_SizeChanged(object sender, SizeChangedEventArgs e)
        {
#if __WASM__
            this.Log().LogInformation($"Container size {e.NewSize.Width} by {e.NewSize.Height}");
            if (this.ellipse.Visibility != Visibility.Visible)
            {
                this.ellipse.Visibility = Visibility.Visible;
            }
#endif
        }

        /// <summary>
        /// Event handler for button text size change.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event args</param>
        private void ButtonText_SizeChanged(object sender, SizeChangedEventArgs e)
        {
#if __WASM__
            this.Log().LogInformation($"New button size {e.NewSize.Width} by {e.NewSize.Height}");
            if (this.allowFlip && this.ellipse != null)
            {
                if (this.ellipse.Visibility == Visibility.Visible)
                {
                    this.ellipse.Visibility = Visibility.Collapsed;
                }

                this.allowFlip = false;
            }
#endif
        }
    }
}
