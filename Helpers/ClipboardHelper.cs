using System.Windows.Forms;

namespace CSV.Helpers
{
    /// <summary>
    /// Class ClipboardHelper.
    /// </summary>
    internal class ClipboardHelper
    {
        /// <summary>
        /// Gets the clipboard text.
        /// </summary>
        /// <returns>System.String.</returns>
        public static string GetClipboardText()
        {
            var text = string.Empty;
            if (Clipboard.ContainsText())
            {
                text = Clipboard.GetText();
            }

            return text;
        }
    }
}
