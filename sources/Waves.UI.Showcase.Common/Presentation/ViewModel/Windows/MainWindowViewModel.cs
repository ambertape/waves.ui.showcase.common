﻿using System.Threading.Tasks;
using Waves.UI.Presentation;
using Waves.UI.Presentation.Attributes;

namespace Waves.UI.Showcase.Common.Presentation.ViewModel.Windows
{
    /// <summary>
    /// View model for showcase main window.
    /// </summary>
    [WavesViewModel(typeof(MainWindowViewModel))]
    public class MainWindowViewModel : WavesViewModelBase
    {
        /// <inheritdoc />
        public override Task InitializeAsync()
        {
            if (IsInitialized)
            {
                return Task.CompletedTask;
            }

            IsInitialized = true;

            return Task.CompletedTask;
        }

        /// <inheritdoc />
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // TODO: your code for release managed resources.
            }

            // TODO: your code for release unmanaged resources.
        }
    }
}
