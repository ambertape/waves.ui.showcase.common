﻿using System;
using Waves.Presentation.Interfaces;
using Waves.UI.Presentation.Tabs;
using Waves.UI.Showcase.Common.Presentation.ViewModel.Tabs;

namespace Waves.UI.Showcase.Common.Presentation.Tabs
{
    /// <summary>
    ///     Core tab presentation.
    /// </summary>
    public class CoreTabPresentation : ShowcaseTabPresentation
    {
        /// <inheritdoc />
        public CoreTabPresentation(Core core) : base(core)
        {
        }
        
        /// <inheritdoc />
        public override Guid Id { get; } = Guid.NewGuid();

        /// <inheritdoc />
        public override string Name { get; set; } = "Core";

        /// <inheritdoc />
        public override string VectorIconPathData { get; } =
            "M16.396484 2C16.266484 2 16.157484 2.0995156 16.146484 2.2285156L16.072266 3.1191406C15.304515 3.3022632 14.626398 3.7031712 14.101562 4.2578125L13.294922 3.8769531C13.176922 3.8209531 13.035703 3.8655156 12.970703 3.9785156L12.367188 5.0234375C12.302188 5.1354375 12.334406 5.2795156 12.441406 5.3535156L13.183594 5.8671875C13.076254 6.2286214 13 6.6037391 13 7C13 7.396917 13.075912 7.7728043 13.183594 8.1347656L12.443359 8.6484375C12.336359 8.7224375 12.304141 8.8655156 12.369141 8.9785156L12.972656 10.023438C13.037656 10.135438 13.176922 10.178047 13.294922 10.123047L14.101562 9.7421875C14.626398 10.296829 15.304515 10.697737 16.072266 10.880859L16.146484 11.771484C16.157484 11.900484 16.266484 12 16.396484 12L17.603516 12C17.733516 12 17.842516 11.900484 17.853516 11.771484L17.927734 10.880859C18.695485 10.697737 19.373602 10.296829 19.898438 9.7421875L20.705078 10.123047C20.823078 10.179047 20.964297 10.134484 21.029297 10.021484L21.632812 8.9765625C21.697813 8.8645625 21.665594 8.7204844 21.558594 8.6464844L20.816406 8.1328125C20.923746 7.7713786 21 7.3962609 21 7C21 6.603083 20.924088 6.2271957 20.816406 5.8652344L21.556641 5.3515625C21.663641 5.2775625 21.695859 5.1344844 21.630859 5.0214844L21.027344 3.9765625C20.962344 3.8645625 20.823078 3.8219531 20.705078 3.8769531L19.898438 4.2578125C19.373602 3.7031712 18.695485 3.3022632 17.927734 3.1191406L17.853516 2.2285156C17.842516 2.0995156 17.733516 2 17.603516 2L16.396484 2 z M 6.3964844 4C6.2664844 4 6.1574844 4.0995156 6.1464844 4.2285156L6.0722656 5.1191406C5.304515 5.3022632 4.6263982 5.7031712 4.1015625 6.2578125L3.2949219 5.8769531C3.1769219 5.8209531 3.0357031 5.8655156 2.9707031 5.9785156L2.3671875 7.0234375C2.3021875 7.1354375 2.3344062 7.2795156 2.4414062 7.3535156L3.1835938 7.8671875C3.0762545 8.2286214 3 8.6037391 3 9C3 9.396917 3.0759119 9.7728043 3.1835938 10.134766L2.4433594 10.648438C2.3363594 10.722437 2.3041406 10.865516 2.3691406 10.978516L2.9726562 12.023438C3.0376562 12.135438 3.1769219 12.178047 3.2949219 12.123047L4.1015625 11.742188C4.6268162 12.29727 5.3057198 12.697944 6.0742188 12.880859L6.1484375 13.771484C6.1594375 13.900484 6.2664844 14 6.3964844 14L7.6035156 14C7.7335156 14 7.8425156 13.900484 7.8535156 13.771484L7.9277344 12.880859C8.695485 12.697737 9.3736018 12.296829 9.8984375 11.742188L10.705078 12.123047C10.823078 12.179047 10.964297 12.134484 11.029297 12.021484L11.632812 10.976562C11.697812 10.864563 11.665594 10.720484 11.558594 10.646484L10.816406 10.132812C10.923746 9.7713786 11 9.3962609 11 9C11 8.603083 10.924088 8.2271957 10.816406 7.8652344L11.556641 7.3515625C11.663641 7.2775625 11.695859 7.1344844 11.630859 7.0214844L11.027344 5.9765625C10.962344 5.8645625 10.823078 5.8219531 10.705078 5.8769531L9.8984375 6.2578125C9.3736018 5.7031712 8.695485 5.3022632 7.9277344 5.1191406L7.8535156 4.2285156C7.8425156 4.0995156 7.7335156 4 7.6035156 4L6.3964844 4 z M 17 5.5C17.828 5.5 18.5 6.172 18.5 7C18.5 7.828 17.828 8.5 17 8.5C16.172 8.5 15.5 7.828 15.5 7C15.5 6.172 16.172 5.5 17 5.5 z M 7 7.5C7.828 7.5 8.5 8.172 8.5 9C8.5 9.828 7.828 10.5 7 10.5C6.172 10.5 5.5 9.828 5.5 9C5.5 8.172 6.172 7.5 7 7.5 z M 13.396484 12C13.266484 12 13.157484 12.099516 13.146484 12.228516L13.072266 13.119141C12.304515 13.302263 11.626398 13.703171 11.101562 14.257812L10.294922 13.876953C10.176922 13.820953 10.035703 13.865516 9.9707031 13.978516L9.3671875 15.023438C9.3021875 15.135437 9.3344063 15.279516 9.4414062 15.353516L10.183594 15.867188C10.076254 16.228621 10 16.603739 10 17C10 17.396917 10.075912 17.772804 10.183594 18.134766L9.4433594 18.648438C9.3363594 18.722437 9.3041406 18.865516 9.3691406 18.978516L9.9726562 20.023438C10.037656 20.135437 10.176922 20.178047 10.294922 20.123047L11.101562 19.742188C11.626398 20.296829 12.304515 20.697737 13.072266 20.880859L13.146484 21.771484C13.157484 21.900484 13.266484 22 13.396484 22L14.603516 22C14.733516 22 14.842516 21.900484 14.853516 21.771484L14.927734 20.880859C15.695485 20.697737 16.373602 20.296829 16.898438 19.742188L17.705078 20.123047C17.823078 20.179047 17.964297 20.134484 18.029297 20.021484L18.632812 18.976562C18.697813 18.864562 18.665594 18.720484 18.558594 18.646484L17.816406 18.132812C17.923746 17.771379 18 17.396261 18 17C18 16.603083 17.924088 16.227196 17.816406 15.865234L18.556641 15.351562C18.663641 15.277563 18.695859 15.134484 18.630859 15.021484L18.027344 13.976562C17.962344 13.864562 17.823078 13.821953 17.705078 13.876953L16.898438 14.257812C16.373602 13.703171 15.695485 13.302263 14.927734 13.119141L14.853516 12.228516C14.842516 12.099516 14.733516 12 14.603516 12L13.396484 12 z M 14 15.5C14.828 15.5 15.5 16.172 15.5 17C15.5 17.828 14.828 18.5 14 18.5C13.172 18.5 12.5 17.828 12.5 17C12.5 16.172 13.172 15.5 14 15.5 z";

        /// <inheritdoc />
        public override double[] VectorIconThickness { get; } = new double[4] {0, -2, 0, 0};

        /// <inheritdoc />
        public override void Initialize()
        {
            DataContext = new CoreTabViewModel(Core);

            base.Initialize();
        }
    }
}