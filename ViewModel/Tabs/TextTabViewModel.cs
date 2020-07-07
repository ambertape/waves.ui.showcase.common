﻿using Waves.Presentation.Base;
using Waves.UI.Showcase.Common.Services.Interfaces;

namespace Waves.UI.Showcase.Common.ViewModel.Tabs
{
    /// <summary>
    ///     Text tab view model.
    /// </summary>
    public class TextTabViewModel : ShowcaseTabViewModel
    {
        private ITextGeneratorService _textGeneratorService;

        /// <inheritdoc />
        public TextTabViewModel(Core core) : base(core)
        {
        }

        /// <summary>
        ///     Gets "Header 1" text.
        /// </summary>
        public string Header1Text { get; set; }

        /// <summary>
        ///     Gets "Header 2" text.
        /// </summary>
        public string Header2Text { get; set; }

        /// <summary>
        ///     Gets "Header 3" text.
        /// </summary>
        public string Header3Text { get; set; }

        /// <summary>
        ///     Gets "Regular 1" text.
        /// </summary>
        public string Regular1Text { get; set; }

        /// <summary>
        ///     Gets "Regular 2" text.
        /// </summary>
        public string Regular2Text { get; set; }

        /// <summary>
        ///     Gets "Hint" text.
        /// </summary>
        public string Hint1Text { get; set; }

        /// <inheritdoc />
        public override void Initialize()
        {
            _textGeneratorService = Core.GetService<ITextGeneratorService>();

            GenerateData();
        }

        /// <summary>
        ///     Generates data.
        /// </summary>
        private void GenerateData()
        {
            Header1Text = _textGeneratorService.GenerateText();
            Header2Text = _textGeneratorService.GenerateText();
            Header3Text = _textGeneratorService.GenerateText();
            Regular1Text = _textGeneratorService.GenerateText();
            Regular2Text = _textGeneratorService.GenerateText();
            Hint1Text = _textGeneratorService.GenerateText();
        }
    }
}