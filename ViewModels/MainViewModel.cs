
namespace Vssl.Samples.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;

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
