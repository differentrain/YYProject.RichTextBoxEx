using System;

namespace YYProject.RichEdit
{
    /// <summary>
    ///  Describes the Spacing between lines of the text.
    /// </summary>
    [Serializable]
    readonly public struct RTBLineSpacing : IEquatable<RTBLineSpacing>
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="size">The spacing between lines, in twips.</param>
        /// <param name="rule">The type of the line spacing.</param>
        /// <exception cref="ArgumentOutOfRangeException">The value of <paramref name="rule"/> argument is invalid.</exception>
        public RTBLineSpacing(Int32 size, RTBLineSpacingRule rule)
        {
            if (rule < RTBLineSpacingRule.Single || rule > RTBLineSpacingRule.CustomMultiple)
            {
                throw new ArgumentOutOfRangeException("The value of rule argument is invalid.");
            }
            this.Spacing = size;
            this.Rule = rule;
        }
        /// <summary>
        /// Gets the spacing between lines. It's unit depends on <see cref="RTBLineSpacing.Rule"/> .
        /// </summary>
        public Int32 Spacing { get; }
        /// <summary>
        /// Gets the type of the line spacing.
        /// </summary>
        public RTBLineSpacingRule Rule { get; }

        /// <summary>
        /// Indicates whether this instance and a specified <see cref="RTBLineSpacing"/> are equal.
        /// </summary>
        /// <param name="other">The <see cref="RTBLineSpacing"/> to compare with the current instance.</param>
        /// <returns>True if both <see cref="RTBLineSpacing"/> structures contain the same Spacing and Rule values; otherwise, false.</returns>
        public Boolean Equals(RTBLineSpacing other) => this.Spacing == other.Spacing && this.Rule == other.Rule;
        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        /// <param name="obj">The object to compare with the current instance.</param>
        /// <returns>True if <paramref name="obj"/> is a <see cref="RTBLineSpacing"/> and contains the same Spacing and Rule values as this instance; otherwise, false.</returns>
        public override Boolean Equals(Object obj)
        {
            if ((null == obj) || !(obj is RTBLineSpacing))
            {
                return false;
            }
            return Equals((RTBLineSpacing)obj);
        }
        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>Hash code.</returns>
        public override int GetHashCode() => Spacing.GetHashCode() ^ Rule.GetHashCode();
        /// <summary>
        /// Creates a human-readable string that represents this <see cref="RTBParaSpacing"/> structure.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{Spacing},{Rule.ToString()}";
        /// <summary>
        /// Compares two <see cref="RTBLineSpacing"/> structures for equality.
        /// </summary>
        /// <param name="a">The first <see cref="RTBLineSpacing"/> structure to compare.</param>
        /// <param name="b">The second <see cref="RTBLineSpacing"/> structure to compare.</param>
        /// <returns>True if both the Spacing and Rule values of <paramref name="a"/> and <paramref name="b"/> are equal; otherwise, false.</returns>
        public static Boolean operator ==(RTBLineSpacing a, RTBLineSpacing b) => a.Equals(b);
        /// <summary>
        /// Compares two <see cref="RTBLineSpacing"/> structures for inequality.
        /// </summary>
        /// <param name="a">The first <see cref="RTBLineSpacing"/> structure to compare.</param>
        /// <param name="b">The second <see cref="RTBLineSpacing"/> structure to compare.</param>
        /// <returns>True if any properties between <paramref name="a"/> and <paramref name="b"/> are inequal; otherwise, false.</returns>
        public static Boolean operator !=(RTBLineSpacing a, RTBLineSpacing b) => !a.Equals(b);
         
    }
}
