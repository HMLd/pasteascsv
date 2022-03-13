using System.Threading.Tasks;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Text.Editor;

namespace CSV.Services
{
    /// <summary>
    /// Interface IWpfService
    /// </summary>
    public interface IWpfService
    {
        /// <summary>
        /// Gets the WPF text view asynchronous.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        /// <returns>Task&lt;IWpfTextView&gt;.</returns>
        Task<IWpfTextView> GetWpfTextViewAsync(IAsyncServiceProvider serviceProvider);

        /// <summary>
        /// Gets the caret position.
        /// </summary>
        /// <param name="wpfTextView">The WPF text view.</param>
        /// <returns>System.Int32.</returns>
        int GetCaretPosition(IWpfTextView wpfTextView);
    }
}
