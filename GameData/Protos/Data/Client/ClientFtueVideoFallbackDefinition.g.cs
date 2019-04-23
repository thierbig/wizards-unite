// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientFtueVideoFallbackDefinition.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientFtueVideoFallbackDefinition.proto</summary>
  public static partial class ClientFtueVideoFallbackDefinitionReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientFtueVideoFallbackDefinition.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientFtueVideoFallbackDefinitionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjxXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRGdHVlVmlkZW9GYWxsYmFj",
            "a0RlZmluaXRpb24ucHJvdG8SFFdVUHJvdG9zLkRhdGEuQ2xpZW50GjhXVVBy",
            "b3Rvcy9EYXRhL0NsaWVudC9DbGllbnRGdHVlVmlkZW9OYW1lRGVmaW5pdGlv",
            "bi5wcm90byJyCiFDbGllbnRGdHVlVmlkZW9GYWxsYmFja0RlZmluaXRpb24S",
            "TQoQbmFtZV9kZWZpbml0aW9ucxgBIAMoCzIzLldVUHJvdG9zLkRhdGEuQ2xp",
            "ZW50LkNsaWVudEZ0dWVWaWRlb05hbWVEZWZpbml0aW9uYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Client.ClientFtueVideoNameDefinitionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientFtueVideoFallbackDefinition), global::WUProtos.Data.Client.ClientFtueVideoFallbackDefinition.Parser, new[]{ "NameDefinitions" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientFtueVideoFallbackDefinition : pb::IMessage<ClientFtueVideoFallbackDefinition> {
    private static readonly pb::MessageParser<ClientFtueVideoFallbackDefinition> _parser = new pb::MessageParser<ClientFtueVideoFallbackDefinition>(() => new ClientFtueVideoFallbackDefinition());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientFtueVideoFallbackDefinition> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientFtueVideoFallbackDefinitionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientFtueVideoFallbackDefinition() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientFtueVideoFallbackDefinition(ClientFtueVideoFallbackDefinition other) : this() {
      nameDefinitions_ = other.nameDefinitions_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientFtueVideoFallbackDefinition Clone() {
      return new ClientFtueVideoFallbackDefinition(this);
    }

    /// <summary>Field number for the "name_definitions" field.</summary>
    public const int NameDefinitionsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::WUProtos.Data.Client.ClientFtueVideoNameDefinition> _repeated_nameDefinitions_codec
        = pb::FieldCodec.ForMessage(10, global::WUProtos.Data.Client.ClientFtueVideoNameDefinition.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Data.Client.ClientFtueVideoNameDefinition> nameDefinitions_ = new pbc::RepeatedField<global::WUProtos.Data.Client.ClientFtueVideoNameDefinition>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Data.Client.ClientFtueVideoNameDefinition> NameDefinitions {
      get { return nameDefinitions_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientFtueVideoFallbackDefinition);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientFtueVideoFallbackDefinition other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!nameDefinitions_.Equals(other.nameDefinitions_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= nameDefinitions_.GetHashCode();
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
      nameDefinitions_.WriteTo(output, _repeated_nameDefinitions_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += nameDefinitions_.CalculateSize(_repeated_nameDefinitions_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientFtueVideoFallbackDefinition other) {
      if (other == null) {
        return;
      }
      nameDefinitions_.Add(other.nameDefinitions_);
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
            nameDefinitions_.AddEntriesFrom(input, _repeated_nameDefinitions_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code