// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientTelemetryPortkeysAdvancedARCheck.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientTelemetryPortkeysAdvancedARCheck.proto</summary>
  public static partial class ClientTelemetryPortkeysAdvancedARCheckReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientTelemetryPortkeysAdvancedARCheck.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientTelemetryPortkeysAdvancedARCheckReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkFXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRUZWxlbWV0cnlQb3J0a2V5",
            "c0FkdmFuY2VkQVJDaGVjay5wcm90bxIUV1VQcm90b3MuRGF0YS5DbGllbnQa",
            "GldVUHJvdG9zL0RhdGEvQVJNb2RlLnByb3RvInwKJkNsaWVudFRlbGVtZXRy",
            "eVBvcnRrZXlzQWR2YW5jZWRBUkNoZWNrEhYKDmFkdmFuY2VkX2FyX29uGAEg",
            "ASgIEhIKCnBvcnRrZXlfaWQYAiABKAkSJgoHYXJfbW9kZRgDIAEoDjIVLldV",
            "UHJvdG9zLkRhdGEuQVJNb2RlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.ARModeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientTelemetryPortkeysAdvancedARCheck), global::WUProtos.Data.Client.ClientTelemetryPortkeysAdvancedARCheck.Parser, new[]{ "AdvancedArOn", "PortkeyId", "ArMode" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientTelemetryPortkeysAdvancedARCheck : pb::IMessage<ClientTelemetryPortkeysAdvancedARCheck> {
    private static readonly pb::MessageParser<ClientTelemetryPortkeysAdvancedARCheck> _parser = new pb::MessageParser<ClientTelemetryPortkeysAdvancedARCheck>(() => new ClientTelemetryPortkeysAdvancedARCheck());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientTelemetryPortkeysAdvancedARCheck> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientTelemetryPortkeysAdvancedARCheckReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryPortkeysAdvancedARCheck() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryPortkeysAdvancedARCheck(ClientTelemetryPortkeysAdvancedARCheck other) : this() {
      advancedArOn_ = other.advancedArOn_;
      portkeyId_ = other.portkeyId_;
      arMode_ = other.arMode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryPortkeysAdvancedARCheck Clone() {
      return new ClientTelemetryPortkeysAdvancedARCheck(this);
    }

    /// <summary>Field number for the "advanced_ar_on" field.</summary>
    public const int AdvancedArOnFieldNumber = 1;
    private bool advancedArOn_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool AdvancedArOn {
      get { return advancedArOn_; }
      set {
        advancedArOn_ = value;
      }
    }

    /// <summary>Field number for the "portkey_id" field.</summary>
    public const int PortkeyIdFieldNumber = 2;
    private string portkeyId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PortkeyId {
      get { return portkeyId_; }
      set {
        portkeyId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ar_mode" field.</summary>
    public const int ArModeFieldNumber = 3;
    private global::WUProtos.Data.ARMode arMode_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.ARMode ArMode {
      get { return arMode_; }
      set {
        arMode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientTelemetryPortkeysAdvancedARCheck);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientTelemetryPortkeysAdvancedARCheck other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AdvancedArOn != other.AdvancedArOn) return false;
      if (PortkeyId != other.PortkeyId) return false;
      if (ArMode != other.ArMode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (AdvancedArOn != false) hash ^= AdvancedArOn.GetHashCode();
      if (PortkeyId.Length != 0) hash ^= PortkeyId.GetHashCode();
      if (ArMode != 0) hash ^= ArMode.GetHashCode();
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
      if (AdvancedArOn != false) {
        output.WriteRawTag(8);
        output.WriteBool(AdvancedArOn);
      }
      if (PortkeyId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PortkeyId);
      }
      if (ArMode != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) ArMode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (AdvancedArOn != false) {
        size += 1 + 1;
      }
      if (PortkeyId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PortkeyId);
      }
      if (ArMode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ArMode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientTelemetryPortkeysAdvancedARCheck other) {
      if (other == null) {
        return;
      }
      if (other.AdvancedArOn != false) {
        AdvancedArOn = other.AdvancedArOn;
      }
      if (other.PortkeyId.Length != 0) {
        PortkeyId = other.PortkeyId;
      }
      if (other.ArMode != 0) {
        ArMode = other.ArMode;
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
          case 8: {
            AdvancedArOn = input.ReadBool();
            break;
          }
          case 18: {
            PortkeyId = input.ReadString();
            break;
          }
          case 24: {
            ArMode = (global::WUProtos.Data.ARMode) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
