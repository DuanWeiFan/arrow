// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Apache.Arrow.Flatbuf
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

/// ----------------------------------------------------------------------
/// A field represents a named column in a record / row batch or child of a
/// nested type.
internal struct Field : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_9(); }
  public static Field GetRootAsField(ByteBuffer _bb) { return GetRootAsField(_bb, new Field()); }
  public static Field GetRootAsField(ByteBuffer _bb, Field obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Field __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  /// Name is not required, in i.e. a List
  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(4); }
  /// Whether or not this field can contain nulls. Should be true in general.
  public bool Nullable { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public Type TypeType { get { int o = __p.__offset(8); return o != 0 ? (Type)__p.bb.Get(o + __p.bb_pos) : Apache.Arrow.Flatbuf.Type.NONE; } }
  /// This is the type of the decoded value if the field is dictionary encoded.
  public TTable? Type<TTable>() where TTable : struct, IFlatbufferObject { int o = __p.__offset(10); return o != 0 ? (TTable?)__p.__union<TTable>(o + __p.bb_pos) : null; }
  public Null TypeAsNull() { return Type<Null>().Value; }
  public Int TypeAsInt() { return Type<Int>().Value; }
  public FloatingPoint TypeAsFloatingPoint() { return Type<FloatingPoint>().Value; }
  public Binary TypeAsBinary() { return Type<Binary>().Value; }
  public Utf8 TypeAsUtf8() { return Type<Utf8>().Value; }
  public Bool TypeAsBool() { return Type<Bool>().Value; }
  public Decimal TypeAsDecimal() { return Type<Decimal>().Value; }
  public Date TypeAsDate() { return Type<Date>().Value; }
  public Time TypeAsTime() { return Type<Time>().Value; }
  public Timestamp TypeAsTimestamp() { return Type<Timestamp>().Value; }
  public Interval TypeAsInterval() { return Type<Interval>().Value; }
  public List TypeAsList() { return Type<List>().Value; }
  public Struct_ TypeAsStruct_() { return Type<Struct_>().Value; }
  public Union TypeAsUnion() { return Type<Union>().Value; }
  public FixedSizeBinary TypeAsFixedSizeBinary() { return Type<FixedSizeBinary>().Value; }
  public FixedSizeList TypeAsFixedSizeList() { return Type<FixedSizeList>().Value; }
  public Map TypeAsMap() { return Type<Map>().Value; }
  public Duration TypeAsDuration() { return Type<Duration>().Value; }
  public LargeBinary TypeAsLargeBinary() { return Type<LargeBinary>().Value; }
  public LargeUtf8 TypeAsLargeUtf8() { return Type<LargeUtf8>().Value; }
  public LargeList TypeAsLargeList() { return Type<LargeList>().Value; }
  public RunEndEncoded TypeAsRunEndEncoded() { return Type<RunEndEncoded>().Value; }
  public BinaryView TypeAsBinaryView() { return Type<BinaryView>().Value; }
  public Utf8View TypeAsUtf8View() { return Type<Utf8View>().Value; }
  public ListView TypeAsListView() { return Type<ListView>().Value; }
  public LargeListView TypeAsLargeListView() { return Type<LargeListView>().Value; }
  /// Present only if the field is dictionary encoded.
  public DictionaryEncoding? Dictionary { get { int o = __p.__offset(12); return o != 0 ? (DictionaryEncoding?)(new DictionaryEncoding()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  /// children apply only to nested data types like Struct, List and Union. For
  /// primitive types children will have length 0.
  public Field? Children(int j) { int o = __p.__offset(14); return o != 0 ? (Field?)(new Field()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ChildrenLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
  /// User-defined metadata
  public KeyValue? CustomMetadata(int j) { int o = __p.__offset(16); return o != 0 ? (KeyValue?)(new KeyValue()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int CustomMetadataLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<Field> CreateField(FlatBufferBuilder builder,
      StringOffset nameOffset = default(StringOffset),
      bool nullable = false,
      Type type_type = Apache.Arrow.Flatbuf.Type.NONE,
      int typeOffset = 0,
      Offset<DictionaryEncoding> dictionaryOffset = default(Offset<DictionaryEncoding>),
      VectorOffset childrenOffset = default(VectorOffset),
      VectorOffset custom_metadataOffset = default(VectorOffset)) {
    builder.StartTable(7);
    Field.AddCustomMetadata(builder, custom_metadataOffset);
    Field.AddChildren(builder, childrenOffset);
    Field.AddDictionary(builder, dictionaryOffset);
    Field.AddType(builder, typeOffset);
    Field.AddName(builder, nameOffset);
    Field.AddTypeType(builder, type_type);
    Field.AddNullable(builder, nullable);
    return Field.EndField(builder);
  }

  public static void StartField(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(0, nameOffset.Value, 0); }
  public static void AddNullable(FlatBufferBuilder builder, bool nullable) { builder.AddBool(1, nullable, false); }
  public static void AddTypeType(FlatBufferBuilder builder, Type typeType) { builder.AddByte(2, (byte)typeType, 0); }
  public static void AddType(FlatBufferBuilder builder, int typeOffset) { builder.AddOffset(3, typeOffset, 0); }
  public static void AddDictionary(FlatBufferBuilder builder, Offset<DictionaryEncoding> dictionaryOffset) { builder.AddOffset(4, dictionaryOffset.Value, 0); }
  public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset) { builder.AddOffset(5, childrenOffset.Value, 0); }
  public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, Offset<Field>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, Offset<Field>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Field>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<Field>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartChildrenVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCustomMetadata(FlatBufferBuilder builder, VectorOffset customMetadataOffset) { builder.AddOffset(6, customMetadataOffset.Value, 0); }
  public static VectorOffset CreateCustomMetadataVector(FlatBufferBuilder builder, Offset<KeyValue>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateCustomMetadataVectorBlock(FlatBufferBuilder builder, Offset<KeyValue>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCustomMetadataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<KeyValue>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCustomMetadataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<KeyValue>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCustomMetadataVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Field> EndField(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Field>(o);
  }
}


static internal class FieldVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyString(tablePos, 4 /*Name*/, false)
      && verifier.VerifyField(tablePos, 6 /*Nullable*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 8 /*TypeType*/, 1 /*Type*/, 1, false)
      && verifier.VerifyUnion(tablePos, 8, 10 /*Type*/, TypeVerify.Verify, false)
      && verifier.VerifyTable(tablePos, 12 /*Dictionary*/, DictionaryEncodingVerify.Verify, false)
      && verifier.VerifyVectorOfTables(tablePos, 14 /*Children*/, FieldVerify.Verify, false)
      && verifier.VerifyVectorOfTables(tablePos, 16 /*CustomMetadata*/, KeyValueVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
