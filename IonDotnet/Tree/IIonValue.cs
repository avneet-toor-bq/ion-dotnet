using System.Collections.Generic;
using IonDotnet.Tree.Impl;

namespace IonDotnet.Tree
{
    public interface IIonValue : IIonNull, IIonBool, IIonInt, IIonFloat,
        IIonDecimal, IIonTimestamp, IIonSymbol, IIonString, IIonClob,
        IIonBlob, IIonList, IIonSexp, IIonStruct, IIonDatagram
    {
        IReadOnlyCollection<SymbolToken> GetTypeAnnotations();
        IIonContainer Container { get; set; }
        SymbolToken FieldNameSymbol { get; set; }
        bool HasAnnotation(string text);
        void AddTypeAnnotation(string annotation);
        void AddTypeAnnotation(SymbolToken annotation);
        void ClearAnnotations();
        void MakeReadOnly();
        string ToPrettyString();
        void WriteTo(IIonWriter writer);
        bool IsEquivalentTo(IIonValue value);
        bool IsReadOnly { get; }
        void MakeNull();
    }
}
