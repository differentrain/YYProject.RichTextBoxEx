using System;

namespace YYProject.RichEdit
{
    /// <summary>
    /// Specifies the read-only mode of the text.
    /// </summary>
    [Serializable]
    public enum RTBReadOnlyMode
    {
        /// <summary>
        /// Not-read-only.
        /// </summary>
        Not,
        /// <summary>
        /// Read-only, but the text in textbox can be selected.
        /// </summary>
        Normal,
        /// <summary>
        /// Read-only, the text in textbox can NOT be selected.
        /// </summary>
        ViewOnly,
    }
}
