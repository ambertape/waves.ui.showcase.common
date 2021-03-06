﻿using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Waves.Core.Base.Interfaces;
using Waves.UI.Plugins.Services.Interfaces;
using Waves.UI.Presentation;

namespace Waves.UI.Showcase.Common.Presentation.ViewModel.Pages
{
    /// <summary>
    /// Tab view model abstraction.
    /// </summary>
    public abstract class PageViewModel : WavesViewModelBase
    {
        /// <summary>
        /// Creates new instance of <see cref="PageViewModel"/>.
        /// </summary>
        /// <param name="core">Instance of <see cref="IWavesCore"/>.</param>
        /// <param name="navigationService">Instance of <see cref="IWavesNavigationService"/>.</param>
        protected PageViewModel(
            IWavesCore core,
            IWavesNavigationService navigationService)
        {
            Core = core;
            NavigationService = navigationService;
            InitializeCommands();
        }

        /// <summary>
        /// Gets title.
        /// </summary>
        public abstract string Title { get; }

        /// <summary>
        /// Gets title.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Gets icon resource string.
        /// </summary>
        public abstract string Icon { get; }

        /// <summary>
        /// Gets navigate command.
        /// </summary>
        public ICommand NavigateCommand { get; protected set; }

        /// <summary>
        /// Gets "Go to API" command.
        /// </summary>
        public ICommand GoToApiCommand { get; protected set; }

        /// <summary>
        /// Gets collection of related pages.
        /// </summary>
        [Reactive]
        public ObservableCollection<PageViewModel> RelatedPages { get; protected set; }

        /// <summary>
        /// Gets core.
        /// </summary>
        protected IWavesCore Core { get; }

        /// <summary>
        /// Gets navigation service.
        /// </summary>
        protected IWavesNavigationService NavigationService { get; }

        /// <inheritdoc />
        public override Task InitializeAsync()
        {
            RelatedPages = new ObservableCollection<PageViewModel>();

            return Task.CompletedTask;
        }

        /// <summary>
        /// Adds tab to collection by current type.
        /// </summary>
        /// <typeparam name="T">Type of tab view model.</typeparam>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        protected async Task AddRelatedPage<T>()
            where T : PageViewModel
        {
            var viewModel = await Core.GetInstanceAsync<T>();
            RelatedPages.Add(viewModel);
        }

        /// <summary>
        /// Initializes commands.
        /// </summary>
        private void InitializeCommands()
        {
            NavigateCommand = ReactiveCommand.CreateFromTask(OnNavigate);
            GoToApiCommand = ReactiveCommand.Create(OnGoToApi);
        }

        /// <summary>
        /// Goes to API.
        /// </summary>
        private void OnGoToApi()
        {
        }

        /// <summary>
        /// Actions when navigate.
        /// </summary>
        private Task OnNavigate()
        {
            return NavigationService.NavigateAsync(this);
        }
    }
}
