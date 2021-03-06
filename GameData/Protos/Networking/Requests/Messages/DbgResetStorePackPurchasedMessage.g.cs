// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Requests/Messages/DbgResetStorePackPurchasedMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Requests/Messages/DbgResetStorePackPurchasedMessage.proto</summary>
  public static partial class DbgResetStorePackPurchasedMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Requests/Messages/DbgResetStorePackPurchasedMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DbgResetStorePackPurchasedMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ck1XVVByb3Rvcy9OZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL0RiZ1Jl",
            "c2V0U3RvcmVQYWNrUHVyY2hhc2VkTWVzc2FnZS5wcm90bxIlV1VQcm90b3Mu",
            "TmV0d29ya2luZy5SZXF1ZXN0cy5NZXNzYWdlcxomV1VQcm90b3MvRGF0YS9T",
            "dG9yZVBhY2tQdXJjaGFzZWQucHJvdG8iWgohRGJnUmVzZXRTdG9yZVBhY2tQ",
            "dXJjaGFzZWRNZXNzYWdlEjUKCnN0b3JlX3BhY2sYASADKAsyIS5XVVByb3Rv",
            "cy5EYXRhLlN0b3JlUGFja1B1cmNoYXNlZGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.StorePackPurchasedReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Requests.Messages.DbgResetStorePackPurchasedMessage), global::WUProtos.Networking.Requests.Messages.DbgResetStorePackPurchasedMessage.Parser, new[]{ "StorePack" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DbgResetStorePackPurchasedMessage : pb::IMessage<DbgResetStorePackPurchasedMessage> {
    private static readonly pb::MessageParser<DbgResetStorePackPurchasedMessage> _parser = new pb::MessageParser<DbgResetStorePackPurchasedMessage>(() => new DbgResetStorePackPurchasedMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DbgResetStorePackPurchasedMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Requests.Messages.DbgResetStorePackPurchasedMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DbgResetStorePackPurchasedMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DbgResetStorePackPurchasedMessage(DbgResetStorePackPurchasedMessage other) : this() {
      storePack_ = other.storePack_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DbgResetStorePackPurchasedMessage Clone() {
      return new DbgResetStorePackPurchasedMessage(this);
    }

    /// <summary>Field number for the "store_pack" field.</summary>
    public const int StorePackFieldNumber = 1;
    private static readonly pb::FieldCodec<global::WUProtos.Data.StorePackPurchased> _repeated_storePack_codec
        = pb::FieldCodec.ForMessage(10, global::WUProtos.Data.StorePackPurchased.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Data.StorePackPurchased> storePack_ = new pbc::RepeatedField<global::WUProtos.Data.StorePackPurchased>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Data.StorePackPurchased> StorePack {
      get { return storePack_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DbgResetStorePackPurchasedMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DbgResetStorePackPurchasedMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!storePack_.Equals(other.storePack_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= storePack_.GetHashCode();
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
      storePack_.WriteTo(output, _repeated_storePack_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += storePack_.CalculateSize(_repeated_storePack_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DbgResetStorePackPurchasedMessage other) {
      if (other == null) {
        return;
      }
      storePack_.Add(other.storePack_);
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
            storePack_.AddEntriesFrom(input, _repeated_storePack_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
