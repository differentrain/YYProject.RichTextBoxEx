using System;
using System.ComponentModel;

namespace YYProject.RichEdit
{
    /// <summary>
    /// Describes the spacing above and below of paragraph of the text.
    /// </summary>
    [Serializable]
    [TypeConverter(typeof(SpacingConverter))]
    readonly public struct RTBParaSpacing : IEquatable<RTBParaSpacing>
    {
        /// <summary>
        /// Gets the spacing above the paragraph, in twips.
        /// </summary>
        public Int32 Before { get; }
        /// <summary>
        /// Gets the size of the spacing below the paragraph, in twips.
        /// </summary>
        public Int32 After { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="before">
        /// The size of the spacing above the paragraph, in twips.
        /// <para>This value must be greater than or equal to zero.</para>
        /// </param>
        /// <param name="after">
        /// The size of the spacing below the paragraph, in twips.
        /// <para>This value must be greater than or equal to zero.</para>
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">Any values of <paramref name="before"/> and <paramref name="after"/> is less than zero.</exception>
        public RTBParaSpacing(Int32 before, Int32 after)
        {
            if (before < 0 || after < 0) throw new ArgumentOutOfRangeException("Any values of before and after property can not be less than zero.");
            this.Before = before;
            this.After = after;
        }
        /// <summary>
        /// Indicates whether this instance and a specified <see cref="RTBParaSpacing"/> are equal.
        /// </summary>
        /// <param name="other">The <see cref="RTBParaSpacing"/> to compare with the current instance.</param>
        /// <returns>True if both <see cref="RTBParaSpacing"/> structures contain the same Before and After values; otherwise, false.</returns>
        public Boolean Equals(RTBParaSpacing other) => this.Before == other.Before && this.After == other.After;

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        /// <param name="obj">The object to compare with the current instance.</param>
        /// <returns>True if <paramref name="obj"/> is a <see cref="RTBParaSpacing"/> and contains the same Before and After values as this instance; otherwise, false.</returns>
        public override Boolean Equals(Object obj)
        {
            if ((null == obj) || !(obj is RTBParaSpacing))
            {
                return false;
            }
            return Equals((RTBParaSpacing)obj);
        }
        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>Hash code.</returns>
        public override Int32 GetHashCode() => Before.GetHashCode() ^ After.GetHashCode();

        /// <summary>
        /// Creates a human-readable string that represents this <see cref="RTBParaSpacing"/> structure.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{Before},{After}";

        /// <summary>
        /// Compares two <see cref="RTBParaSpacing"/> structures for equality.
        /// </summary>
        /// <param name="a">The first <see cref="RTBParaSpacing"/> structure to compare.</param>
        /// <param name="b">The second <see cref="RTBParaSpacing"/> structure to compare.</param>
        /// <returns>True if both the Before and After values of <paramref name="a"/> and <paramref name="b"/> are equal; otherwise, false.</returns>
        public static Boolean operator ==(RTBParaSpacing a, RTBParaSpacing b) => a.Equals(b);
        /// <summary>
        /// Compares two <see cref="RTBParaSpacing"/> structures for inequality.
        /// </summary>
        /// <param name="a">The first <see cref="RTBParaSpacing"/> structure to compare.</param>
        /// <param name="b">The second <see cref="RTBParaSpacing"/> structure to compare.</param>
        /// <returns>True if any properties between <paramref name="a"/> and <paramref name="b"/> are inequal; otherwise, false.</returns>
        public static Boolean operator !=(RTBParaSpacing a, RTBParaSpacing b) => !a.Equals(b);


    }
}
