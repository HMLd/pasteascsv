using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.ComponentModelHost;
using Microsoft.VisualStudio.Editor;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.TextManager.Interop;

namespace CSV.Services
{
    /// <summary>
    /// Class WpfService.
    /// Implements the <see cref="CSV.Services.IWpfService" />
    /// </summary>
    /// <seealso cref="CSV.Services.IWpfService" />
    public class WpfService : IWpfService
    {
        /// <summary>
        /// Gets the WPF text view.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        /// <returns>IWpfTextView.</returns>
        /// <exception cref="System.ArgumentNullException">textManager</exception>
        /// <exception cref="System.ArgumentNullException">componentModel</exception>
        public async Task<IWpfTextView> GetWpfTextViewAsync(IAsyncServiceProvider serviceProvider)
        {
            var textManager = await serviceProvider.GetServiceAsync(typeof(SVsTextManager)) as IVsTextManager;
            if (textManager == null)
                throw new ArgumentNullException(nameof(textManager));

            var componentModel = await serviceProvider.GetServiceAsync(typeof(SComponentModel)) as IComponentModel;
            if (componentModel == null)
                throw new ArgumentNullException(nameof(componentModel));

            var editor = componentModel.GetService<IVsEditorAdaptersFactoryService>();

            textManager.GetActiveView(1, null, out var currentTextView);
            return editor.GetWpfTextView(currentTextView);
        }

        /// <summary>
        /// Gets the caret position.
        /// </summary>
        /// <param name="wpfTextView">The WPF text view.</param>
        /// <returns>System.Int32.</returns>
        public int GetCaretPosition(IWpfTextView wpfTextView)
        {
            if (wpfTextView == null)
                throw new ArgumentNullException(nameof(wpfTextView));

            return wpfTextView.Caret.Position.BufferPosition.Position;
        }
    }
}
