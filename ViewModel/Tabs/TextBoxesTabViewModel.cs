﻿using Waves.Presentation.Base;
using Waves.UI.Showcase.Common.Services.Interfaces;

namespace Waves.UI.Showcase.Common.ViewModel.Tabs
{
    /// <summary>
    ///     TextBoxes tab view model.
    /// </summary>
    public class TextBoxesTabViewModel : PresentationViewModel
    {
        private readonly ITextGeneratorService _textGeneratorService;

        /// <summary>
        ///     Creates new instance of <see cref="TextBoxesTabViewModel" />.
        /// </summary>
        /// <param name="textGeneratorService">Text generator service.</param>
        public TextBoxesTabViewModel(ITextGeneratorService textGeneratorService)
        {
            _textGeneratorService = textGeneratorService;
        }

        /// <summary>
        ///     Gets or sets text1.
        /// </summary>
        public string Text1 { get; set; }

        /// <summary>
        ///     Gets or sets text1.
        /// </summary>
        public string Text2 { get; set; }

        /// <inheritdoc />
        public override void Initialize()
        {
            GenerateData();
        }

        /// <summary>
        ///     Generates data.
        /// </summary>
        private void GenerateData()
        {
            Text1 = _textGeneratorService.GenerateText();
            Text2 = _textGeneratorService.GenerateText();
        }
    }
}