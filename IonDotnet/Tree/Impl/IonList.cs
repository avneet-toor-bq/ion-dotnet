namespace IonDotnet.Tree.Impl
{
    /// <inheritdoc />
    /// <summary>
    /// A Ion List value.
    /// </summary>
    internal sealed class IonList : IonSequence, IIonList
    {
        public IonList() : this(false)
        {
        }

        private IonList(bool isNull) : base(isNull)
        {
        }

        /// <summary>
        /// Returns a new null.list value.
        /// </summary>
        public static IonList NewNull() => new IonList(true);

        public override IonType Type => IonType.List;
    }
}
