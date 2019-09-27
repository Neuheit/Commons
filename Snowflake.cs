using System;

namespace Vysn.Commons
{
    /// <summary>
    /// 
    /// </summary>
    public readonly struct Snowflake : IEquatable<Snowflake>
    {
        /// <summary>
        /// 
        /// </summary>
        public ulong Raw { get; }

        internal Snowflake(ReadOnlySpan<char> ulongId)
            => Raw = ulong.Parse(ulongId);

        internal Snowflake(ulong number)
            => Raw = number;

        /// <inheritdoc />
        public override string ToString()
            => $"{Raw}";

        /// <inheritdoc />
        public bool Equals(Snowflake other)
            => Raw == other.Raw;

        /// <inheritdoc />
        public override bool Equals(object obj)
            => obj is Snowflake other && Equals(other);

        /// <inheritdoc />
        public override int GetHashCode()
            => Raw.GetHashCode();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator ==(Snowflake left, Snowflake right)
            => left.Equals(right);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator !=(Snowflake left, Snowflake right)
            => !left.Equals(right);
    }
}