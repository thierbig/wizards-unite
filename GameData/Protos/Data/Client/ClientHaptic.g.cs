// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientHaptic.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientHaptic.proto</summary>
  public static partial class ClientHapticReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientHaptic.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientHapticReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRIYXB0aWMucHJvdG8SFFdV",
            "UHJvdG9zLkRhdGEuQ2xpZW50IqEBCgxDbGllbnRIYXB0aWMSCgoCaWQYASAB",
            "KAkSFwoPaW9zd2FpdF90aW1pbmdzGAIgAygFEhcKD2lvc2hhcHRpY190eXBl",
            "cxgDIAMoBRIcChRhbmRyb2lkX3dhaXRfdGltaW5ncxgEIAMoBRIaChJhbmRy",
            "b2lkX2FtcGxpdHVkZXMYBSADKAUSGQoRYW5kcm9pZF9kdXJhdGlvbnMYBiAD",
            "KAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientHaptic), global::WUProtos.Data.Client.ClientHaptic.Parser, new[]{ "Id", "IoswaitTimings", "IoshapticTypes", "AndroidWaitTimings", "AndroidAmplitudes", "AndroidDurations" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientHaptic : pb::IMessage<ClientHaptic> {
    private static readonly pb::MessageParser<ClientHaptic> _parser = new pb::MessageParser<ClientHaptic>(() => new ClientHaptic());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientHaptic> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientHapticReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientHaptic() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientHaptic(ClientHaptic other) : this() {
      id_ = other.id_;
      ioswaitTimings_ = other.ioswaitTimings_.Clone();
      ioshapticTypes_ = other.ioshapticTypes_.Clone();
      androidWaitTimings_ = other.androidWaitTimings_.Clone();
      androidAmplitudes_ = other.androidAmplitudes_.Clone();
      androidDurations_ = other.androidDurations_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientHaptic Clone() {
      return new ClientHaptic(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ioswait_timings" field.</summary>
    public const int IoswaitTimingsFieldNumber = 2;
    private static readonly pb::FieldCodec<int> _repeated_ioswaitTimings_codec
        = pb::FieldCodec.ForInt32(18);
    private readonly pbc::RepeatedField<int> ioswaitTimings_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> IoswaitTimings {
      get { return ioswaitTimings_; }
    }

    /// <summary>Field number for the "ioshaptic_types" field.</summary>
    public const int IoshapticTypesFieldNumber = 3;
    private static readonly pb::FieldCodec<int> _repeated_ioshapticTypes_codec
        = pb::FieldCodec.ForInt32(26);
    private readonly pbc::RepeatedField<int> ioshapticTypes_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> IoshapticTypes {
      get { return ioshapticTypes_; }
    }

    /// <summary>Field number for the "android_wait_timings" field.</summary>
    public const int AndroidWaitTimingsFieldNumber = 4;
    private static readonly pb::FieldCodec<int> _repeated_androidWaitTimings_codec
        = pb::FieldCodec.ForInt32(34);
    private readonly pbc::RepeatedField<int> androidWaitTimings_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> AndroidWaitTimings {
      get { return androidWaitTimings_; }
    }

    /// <summary>Field number for the "android_amplitudes" field.</summary>
    public const int AndroidAmplitudesFieldNumber = 5;
    private static readonly pb::FieldCodec<int> _repeated_androidAmplitudes_codec
        = pb::FieldCodec.ForInt32(42);
    private readonly pbc::RepeatedField<int> androidAmplitudes_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> AndroidAmplitudes {
      get { return androidAmplitudes_; }
    }

    /// <summary>Field number for the "android_durations" field.</summary>
    public const int AndroidDurationsFieldNumber = 6;
    private static readonly pb::FieldCodec<int> _repeated_androidDurations_codec
        = pb::FieldCodec.ForInt32(50);
    private readonly pbc::RepeatedField<int> androidDurations_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> AndroidDurations {
      get { return androidDurations_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientHaptic);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientHaptic other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if(!ioswaitTimings_.Equals(other.ioswaitTimings_)) return false;
      if(!ioshapticTypes_.Equals(other.ioshapticTypes_)) return false;
      if(!androidWaitTimings_.Equals(other.androidWaitTimings_)) return false;
      if(!androidAmplitudes_.Equals(other.androidAmplitudes_)) return false;
      if(!androidDurations_.Equals(other.androidDurations_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      hash ^= ioswaitTimings_.GetHashCode();
      hash ^= ioshapticTypes_.GetHashCode();
      hash ^= androidWaitTimings_.GetHashCode();
      hash ^= androidAmplitudes_.GetHashCode();
      hash ^= androidDurations_.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      ioswaitTimings_.WriteTo(output, _repeated_ioswaitTimings_codec);
      ioshapticTypes_.WriteTo(output, _repeated_ioshapticTypes_codec);
      androidWaitTimings_.WriteTo(output, _repeated_androidWaitTimings_codec);
      androidAmplitudes_.WriteTo(output, _repeated_androidAmplitudes_codec);
      androidDurations_.WriteTo(output, _repeated_androidDurations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      size += ioswaitTimings_.CalculateSize(_repeated_ioswaitTimings_codec);
      size += ioshapticTypes_.CalculateSize(_repeated_ioshapticTypes_codec);
      size += androidWaitTimings_.CalculateSize(_repeated_androidWaitTimings_codec);
      size += androidAmplitudes_.CalculateSize(_repeated_androidAmplitudes_codec);
      size += androidDurations_.CalculateSize(_repeated_androidDurations_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientHaptic other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      ioswaitTimings_.Add(other.ioswaitTimings_);
      ioshapticTypes_.Add(other.ioshapticTypes_);
      androidWaitTimings_.Add(other.androidWaitTimings_);
      androidAmplitudes_.Add(other.androidAmplitudes_);
      androidDurations_.Add(other.androidDurations_);
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
            Id = input.ReadString();
            break;
          }
          case 18:
          case 16: {
            ioswaitTimings_.AddEntriesFrom(input, _repeated_ioswaitTimings_codec);
            break;
          }
          case 26:
          case 24: {
            ioshapticTypes_.AddEntriesFrom(input, _repeated_ioshapticTypes_codec);
            break;
          }
          case 34:
          case 32: {
            androidWaitTimings_.AddEntriesFrom(input, _repeated_androidWaitTimings_codec);
            break;
          }
          case 42:
          case 40: {
            androidAmplitudes_.AddEntriesFrom(input, _repeated_androidAmplitudes_codec);
            break;
          }
          case 50:
          case 48: {
            androidDurations_.AddEntriesFrom(input, _repeated_androidDurations_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
