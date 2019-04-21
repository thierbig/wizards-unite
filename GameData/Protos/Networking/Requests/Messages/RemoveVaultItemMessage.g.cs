// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Requests/Messages/RemoveVaultItemMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Requests/Messages/RemoveVaultItemMessage.proto</summary>
  public static partial class RemoveVaultItemMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Requests/Messages/RemoveVaultItemMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RemoveVaultItemMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJXVVByb3Rvcy9OZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL1JlbW92",
            "ZVZhdWx0SXRlbU1lc3NhZ2UucHJvdG8SJVdVUHJvdG9zLk5ldHdvcmtpbmcu",
            "UmVxdWVzdHMuTWVzc2FnZXMiQQoWUmVtb3ZlVmF1bHRJdGVtTWVzc2FnZRIV",
            "Cg12YXVsdF9pdGVtX2lkGAEgASgJEhAKCHF1YW50aXR5GAIgASgEYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Requests.Messages.RemoveVaultItemMessage), global::WUProtos.Networking.Requests.Messages.RemoveVaultItemMessage.Parser, new[]{ "VaultItemId", "Quantity" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RemoveVaultItemMessage : pb::IMessage<RemoveVaultItemMessage> {
    private static readonly pb::MessageParser<RemoveVaultItemMessage> _parser = new pb::MessageParser<RemoveVaultItemMessage>(() => new RemoveVaultItemMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RemoveVaultItemMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Requests.Messages.RemoveVaultItemMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RemoveVaultItemMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RemoveVaultItemMessage(RemoveVaultItemMessage other) : this() {
      vaultItemId_ = other.vaultItemId_;
      quantity_ = other.quantity_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RemoveVaultItemMessage Clone() {
      return new RemoveVaultItemMessage(this);
    }

    /// <summary>Field number for the "vault_item_id" field.</summary>
    public const int VaultItemIdFieldNumber = 1;
    private string vaultItemId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string VaultItemId {
      get { return vaultItemId_; }
      set {
        vaultItemId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "quantity" field.</summary>
    public const int QuantityFieldNumber = 2;
    private ulong quantity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Quantity {
      get { return quantity_; }
      set {
        quantity_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RemoveVaultItemMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RemoveVaultItemMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (VaultItemId != other.VaultItemId) return false;
      if (Quantity != other.Quantity) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (VaultItemId.Length != 0) hash ^= VaultItemId.GetHashCode();
      if (Quantity != 0UL) hash ^= Quantity.GetHashCode();
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
      if (VaultItemId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(VaultItemId);
      }
      if (Quantity != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(Quantity);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (VaultItemId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(VaultItemId);
      }
      if (Quantity != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Quantity);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RemoveVaultItemMessage other) {
      if (other == null) {
        return;
      }
      if (other.VaultItemId.Length != 0) {
        VaultItemId = other.VaultItemId;
      }
      if (other.Quantity != 0UL) {
        Quantity = other.Quantity;
      }
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
            VaultItemId = input.ReadString();
            break;
          }
          case 16: {
            Quantity = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
