// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Requests/Messages/DbgModifyCollectionItemsMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Requests/Messages/DbgModifyCollectionItemsMessage.proto</summary>
  public static partial class DbgModifyCollectionItemsMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Requests/Messages/DbgModifyCollectionItemsMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DbgModifyCollectionItemsMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CktXVVByb3Rvcy9OZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL0RiZ01v",
            "ZGlmeUNvbGxlY3Rpb25JdGVtc01lc3NhZ2UucHJvdG8SJVdVUHJvdG9zLk5l",
            "dHdvcmtpbmcuUmVxdWVzdHMuTWVzc2FnZXMaM1dVUHJvdG9zL0RhdGEvRGVi",
            "dWcvRGVidWdNb2RpZnlDb2xsZWN0aW9uSXRlbS5wcm90byJrCh9EYmdNb2Rp",
            "ZnlDb2xsZWN0aW9uSXRlbXNNZXNzYWdlEkgKEGNvbGxlY3Rpb25faXRlbXMY",
            "ASADKAsyLi5XVVByb3Rvcy5EYXRhLkRlYnVnLkRlYnVnTW9kaWZ5Q29sbGVj",
            "dGlvbkl0ZW1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Debug.DebugModifyCollectionItemReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Requests.Messages.DbgModifyCollectionItemsMessage), global::WUProtos.Networking.Requests.Messages.DbgModifyCollectionItemsMessage.Parser, new[]{ "CollectionItems" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DbgModifyCollectionItemsMessage : pb::IMessage<DbgModifyCollectionItemsMessage> {
    private static readonly pb::MessageParser<DbgModifyCollectionItemsMessage> _parser = new pb::MessageParser<DbgModifyCollectionItemsMessage>(() => new DbgModifyCollectionItemsMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DbgModifyCollectionItemsMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Requests.Messages.DbgModifyCollectionItemsMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DbgModifyCollectionItemsMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DbgModifyCollectionItemsMessage(DbgModifyCollectionItemsMessage other) : this() {
      collectionItems_ = other.collectionItems_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DbgModifyCollectionItemsMessage Clone() {
      return new DbgModifyCollectionItemsMessage(this);
    }

    /// <summary>Field number for the "collection_items" field.</summary>
    public const int CollectionItemsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::WUProtos.Data.Debug.DebugModifyCollectionItem> _repeated_collectionItems_codec
        = pb::FieldCodec.ForMessage(10, global::WUProtos.Data.Debug.DebugModifyCollectionItem.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Data.Debug.DebugModifyCollectionItem> collectionItems_ = new pbc::RepeatedField<global::WUProtos.Data.Debug.DebugModifyCollectionItem>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Data.Debug.DebugModifyCollectionItem> CollectionItems {
      get { return collectionItems_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DbgModifyCollectionItemsMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DbgModifyCollectionItemsMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!collectionItems_.Equals(other.collectionItems_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= collectionItems_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      collectionItems_.WriteTo(output, _repeated_collectionItems_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += collectionItems_.CalculateSize(_repeated_collectionItems_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DbgModifyCollectionItemsMessage other) {
      if (other == null) {
        return;
      }
      collectionItems_.Add(other.collectionItems_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            collectionItems_.AddEntriesFrom(input, _repeated_collectionItems_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code