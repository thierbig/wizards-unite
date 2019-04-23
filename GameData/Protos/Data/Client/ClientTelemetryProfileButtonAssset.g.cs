// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientTelemetryProfileButtonAssset.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientTelemetryProfileButtonAssset.proto</summary>
  public static partial class ClientTelemetryProfileButtonAsssetReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientTelemetryProfileButtonAssset.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientTelemetryProfileButtonAsssetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1XVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRUZWxlbWV0cnlQcm9maWxl",
            "QnV0dG9uQXNzc2V0LnByb3RvEhRXVVByb3Rvcy5EYXRhLkNsaWVudBomV1VQ",
            "cm90b3MvRW51bXMvQ2F0ZWdvcnlBc3NldFR5cGUucHJvdG8iiwEKIkNsaWVu",
            "dFRlbGVtZXRyeVByb2ZpbGVCdXR0b25Bc3NzZXQSGQoRcHJlc3NlZF9idXR0",
            "b25faWQYASABKAkSEwoLc3RpY2tlcl9hZGQYAiABKAgSNQoKYXNzZXRfdHlw",
            "ZRgDIAEoDjIhLldVUHJvdG9zLkVudW1zLkNhdGVnb3J5QXNzZXRUeXBlYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Enums.CategoryAssetTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientTelemetryProfileButtonAssset), global::WUProtos.Data.Client.ClientTelemetryProfileButtonAssset.Parser, new[]{ "PressedButtonId", "StickerAdd", "AssetType" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientTelemetryProfileButtonAssset : pb::IMessage<ClientTelemetryProfileButtonAssset> {
    private static readonly pb::MessageParser<ClientTelemetryProfileButtonAssset> _parser = new pb::MessageParser<ClientTelemetryProfileButtonAssset>(() => new ClientTelemetryProfileButtonAssset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientTelemetryProfileButtonAssset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientTelemetryProfileButtonAsssetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryProfileButtonAssset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryProfileButtonAssset(ClientTelemetryProfileButtonAssset other) : this() {
      pressedButtonId_ = other.pressedButtonId_;
      stickerAdd_ = other.stickerAdd_;
      assetType_ = other.assetType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryProfileButtonAssset Clone() {
      return new ClientTelemetryProfileButtonAssset(this);
    }

    /// <summary>Field number for the "pressed_button_id" field.</summary>
    public const int PressedButtonIdFieldNumber = 1;
    private string pressedButtonId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PressedButtonId {
      get { return pressedButtonId_; }
      set {
        pressedButtonId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sticker_add" field.</summary>
    public const int StickerAddFieldNumber = 2;
    private bool stickerAdd_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool StickerAdd {
      get { return stickerAdd_; }
      set {
        stickerAdd_ = value;
      }
    }

    /// <summary>Field number for the "asset_type" field.</summary>
    public const int AssetTypeFieldNumber = 3;
    private global::WUProtos.Enums.CategoryAssetType assetType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Enums.CategoryAssetType AssetType {
      get { return assetType_; }
      set {
        assetType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientTelemetryProfileButtonAssset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientTelemetryProfileButtonAssset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PressedButtonId != other.PressedButtonId) return false;
      if (StickerAdd != other.StickerAdd) return false;
      if (AssetType != other.AssetType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PressedButtonId.Length != 0) hash ^= PressedButtonId.GetHashCode();
      if (StickerAdd != false) hash ^= StickerAdd.GetHashCode();
      if (AssetType != 0) hash ^= AssetType.GetHashCode();
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
      if (PressedButtonId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PressedButtonId);
      }
      if (StickerAdd != false) {
        output.WriteRawTag(16);
        output.WriteBool(StickerAdd);
      }
      if (AssetType != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) AssetType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PressedButtonId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PressedButtonId);
      }
      if (StickerAdd != false) {
        size += 1 + 1;
      }
      if (AssetType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AssetType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientTelemetryProfileButtonAssset other) {
      if (other == null) {
        return;
      }
      if (other.PressedButtonId.Length != 0) {
        PressedButtonId = other.PressedButtonId;
      }
      if (other.StickerAdd != false) {
        StickerAdd = other.StickerAdd;
      }
      if (other.AssetType != 0) {
        AssetType = other.AssetType;
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
            PressedButtonId = input.ReadString();
            break;
          }
          case 16: {
            StickerAdd = input.ReadBool();
            break;
          }
          case 24: {
            AssetType = (global::WUProtos.Enums.CategoryAssetType) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code