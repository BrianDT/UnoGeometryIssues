
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

    // The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class WorkAroundPage : Page
    {
#if __WASM__
        /// <summary>
        /// A value set on button press that allows the ellipse visibility to be flipped
        /// </summary>
        private bool allowFlip;
#endif

        public WorkAroundPage()
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
#if __WASM__
            this.allowFlip = true;
#endif
            this.VM.Toggle();
#if __WASM__
            this.Log().LogInformation($"Button Clicked");
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
        /// Event handler for ellipse size change.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event args</param>
        private void Ellipse_SizeChanged(object sender, SizeChangedEventArgs e)
        {
#if __WASM__
            this.Log().LogInformation($"New ellipse size {e.NewSize.Width} by {e.NewSize.Height}");
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
            ////this.ReMeasureControlsUntil(this.ellipse, this.dynamicPanel);
            if (this.allowFlip)
            {
                if (this.ellipse.Visibility == Visibility.Visible)
                {
                    this.ellipse.Visibility = Visibility.Collapsed;
                }

                this.allowFlip = false;
            }
#endif
        }

        /*
        /// <summary>
        /// Gets the owning control of a given type of the given element
        /// </summary>
        /// <param name="element">The element to start from</param>
        /// <param name="ancestor">the ancetor at which the process terminates</param>
        private void ReMeasureControlsUntil(UIElement element, UIElement ancestor)
        {
            if (element == null)
            {
                this.Log().LogInformation($"element is null");
                return;
            }

            UIElement parent = element;
            while (parent != ancestor)
            {
                // Force remeasure.
                parent.UpdateLayout();
                this.Log().LogInformation($"UpdateLayout of {parent.Name ?? "No name"} type {parent.GetType().Name}");

                parent = VisualTreeHelper.GetParent(parent) as UIElement;
                if (parent == null)
                {
                    return;
                }
            }

            return;
        }
        */
    }
}
