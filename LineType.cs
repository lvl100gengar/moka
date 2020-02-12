namespace moka
{
    /// <summary>
    /// Possible values for user line types.
    /// </summary>
    public enum LineType : short
    {
        /// <summary>
        /// Line type is not known.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Line type is 14.4K dial-up.
        /// </summary>
        DialUp14K = 1,

        /// <summary>
        /// Line type is 28.8K dial-up.
        /// </summary>
        DialUp28K = 2,

        /// <summary>
        /// Line type is 33.6K dial-up.
        /// </summary>
        DialUp33K = 3,

        /// <summary>
        /// Line type is 56K dial-up.
        /// </summary>
        DialUp56K = 4,

        /// <summary>
        /// Line type is 64K ISDN or satelite.
        /// </summary>
        Isdn64K = 5,

        /// <summary>
        /// Line type is 128K ISDN.
        /// </summary>
        Isdn128K = 6,

        /// <summary>
        /// Line type is cable.
        /// </summary>
        Cable = 7,

        /// <summary>
        /// Line type is DSL.
        /// </summary>
        Dsl = 8,

        /// <summary>
        /// Line type is Tier 1.
        /// </summary>
        T1 = 9,

        /// <summary>
        /// Line type is Tier 3 or better.
        /// </summary>
        T3 = 10
    }
}