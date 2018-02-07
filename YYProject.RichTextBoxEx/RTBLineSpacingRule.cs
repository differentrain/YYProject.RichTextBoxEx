using System;

namespace YYProject.RichEdit
{
    /// <summary>
    /// Specifies the type of the line spacing.
    /// </summary>
    [Serializable]
    public enum RTBLineSpacingRule:Byte
    {
        /// <summary>
        /// Single spacing, the <see cref="RTBLineSpacing.Spacing"/> property is ignored.
        /// </summary>
        Single,
        /// <summary>
        /// One-and-a-half spacing, the <see cref="RTBLineSpacing.Spacing"/> property is ignored.
        /// </summary>
        OneAndHalf,
        /// <summary>
        /// Double spacing, the <see cref="RTBLineSpacing.Spacing"/> property is ignored.
        /// </summary>
        Double,
        /// <summary>
        /// Adopt the value of <see cref="RTBLineSpacing.Spacing"/> if  it's greater than or equla to <see cref="RTBLineSpacingRule.Single"/>, in twips; otherwise, the control displays single-spaced text.
        /// </summary>
        CustomMin,
        /// <summary>
        /// Adopt the value of <see cref="RTBLineSpacing.Spacing"/> unconditionally, in twips.
        /// </summary>
        CustomExactly,
        /// <summary>
        /// The value of <see cref="RTBLineSpacing.Spacing"/> divided by 20 is the spacing, in lines.
        /// <para>Thus, setting to 20 produces single-spaced text, 40 is double spaced, 60 is triple spaced, and so on.</para>
        /// </summary>
        CustomMultiple
    }
}
