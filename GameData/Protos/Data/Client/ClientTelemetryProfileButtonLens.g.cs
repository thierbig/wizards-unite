// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientTelemetryProfileButtonLens.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientTelemetryProfileButtonLens.proto</summary>
  public static partial class ClientTelemetryProfileButtonLensReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientTelemetryProfileButtonLens.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientTelemetryProfileButtonLensReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjtXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRUZWxlbWV0cnlQcm9maWxl",
            "QnV0dG9uTGVucy5wcm90bxIUV1VQcm90b3MuRGF0YS5DbGllbnQaIVdVUHJv",
            "dG9zL0VudW1zL0NhdGVnb3J5TGVucy5wcm90byJyCiBDbGllbnRUZWxlbWV0",
            "cnlQcm9maWxlQnV0dG9uTGVucxIZChFwcmVzc2VkX2J1dHRvbl9pZBgBIAEo",
            "CRIzCg1sZW5zX2NhdGVnb3J5GAIgASgOMhwuV1VQcm90b3MuRW51bXMuQ2F0",
            "ZWdvcnlMZW5zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Enums.CategoryLensReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientTelemetryProfileButtonLens), global::WUProtos.Data.Client.ClientTelemetryProfileButtonLens.Parser, new[]{ "PressedButtonId", "LensCategory" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientTelemetryProfileButtonLens : pb::IMessage<ClientTelemetryProfileButtonLens> {
    private static readonly pb::MessageParser<ClientTelemetryProfileButtonLens> _parser = new pb::MessageParser<ClientTelemetryProfileButtonLens>(() => new ClientTelemetryProfileButtonLens());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientTelemetryProfileButtonLens> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientTelemetryProfileButtonLensReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryProfileButtonLens() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryProfileButtonLens(ClientTelemetryProfileButtonLens other) : this() {
      pressedButtonId_ = other.pressedButtonId_;
      lensCategory_ = other.lensCategory_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryProfileButtonLens Clone() {
      return new ClientTelemetryProfileButtonLens(this);
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

    /// <summary>Field number for the "lens_category" field.</summary>
    public const int LensCategoryFieldNumber = 2;
    private global::WUProtos.Enums.CategoryLens lensCategory_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Enums.CategoryLens LensCategory {
      get { return lensCategory_; }
      set {
        lensCategory_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientTelemetryProfileButtonLens);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientTelemetryProfileButtonLens other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PressedButtonId != other.PressedButtonId) return false;
      if (LensCategory != other.LensCategory) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PressedButtonId.Length != 0) hash ^= PressedButtonId.GetHashCode();
      if (LensCategory != 0) hash ^= LensCategory.GetHashCode();
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
      if (LensCategory != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) LensCategory);
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
      if (LensCategory != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) LensCategory);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientTelemetryProfileButtonLens other) {
      if (other == null) {
        return;
      }
      if (other.PressedButtonId.Length != 0) {
        PressedButtonId = other.PressedButtonId;
      }
      if (other.LensCategory != 0) {
        LensCategory = other.LensCategory;
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
            LensCategory = (global::WUProtos.Enums.CategoryLens) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
