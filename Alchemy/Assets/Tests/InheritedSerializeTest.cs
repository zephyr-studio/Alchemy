using System;
using Alchemy.Serialization;

[ShowAlchemySerializationData]
[AlchemySerialize]
public partial class InheritedSerializeTest : InheritedSerializeTestBase<string>
{
    [AlchemySerializeField, NonSerialized] int? nullableInt;
}