// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientTelemetryStopwatch.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientTelemetryStopwatch.proto</summary>
  public static partial class ClientTelemetryStopwatchReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientTelemetryStopwatch.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientTelemetryStopwatchReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRUZWxlbWV0cnlTdG9wd2F0",
            "Y2gucHJvdG8SFFdVUHJvdG9zLkRhdGEuQ2xpZW50IlkKGENsaWVudFRlbGVt",
            "ZXRyeVN0b3B3YXRjaBISCgpldmVudF9uYW1lGAEgASgJEgsKA21pbhgCIAEo",
            "ARILCgNtYXgYAyABKAESDwoHYXZlcmFnZRgEIAEoAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientTelemetryStopwatch), global::WUProtos.Data.Client.ClientTelemetryStopwatch.Parser, new[]{ "EventName", "Min", "Max", "Average" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientTelemetryStopwatch : pb::IMessage<ClientTelemetryStopwatch> {
    private static readonly pb::MessageParser<ClientTelemetryStopwatch> _parser = new pb::MessageParser<ClientTelemetryStopwatch>(() => new ClientTelemetryStopwatch());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientTelemetryStopwatch> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientTelemetryStopwatchReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryStopwatch() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryStopwatch(ClientTelemetryStopwatch other) : this() {
      eventName_ = other.eventName_;
      min_ = other.min_;
      max_ = other.max_;
      average_ = other.average_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryStopwatch Clone() {
      return new ClientTelemetryStopwatch(this);
    }

    /// <summary>Field number for the "event_name" field.</summary>
    public const int EventNameFieldNumber = 1;
    private string eventName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EventName {
      get { return eventName_; }
      set {
        eventName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "min" field.</summary>
    public const int MinFieldNumber = 2;
    private double min_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Min {
      get { return min_; }
      set {
        min_ = value;
      }
    }

    /// <summary>Field number for the "max" field.</summary>
    public const int MaxFieldNumber = 3;
    private double max_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Max {
      get { return max_; }
      set {
        max_ = value;
      }
    }

    /// <summary>Field number for the "average" field.</summary>
    public const int AverageFieldNumber = 4;
    private double average_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Average {
      get { return average_; }
      set {
        average_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientTelemetryStopwatch);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientTelemetryStopwatch other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EventName != other.EventName) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Min, other.Min)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Max, other.Max)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Average, other.Average)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EventName.Length != 0) hash ^= EventName.GetHashCode();
      if (Min != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Min);
      if (Max != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Max);
      if (Average != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Average);
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
      if (EventName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(EventName);
      }
      if (Min != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Min);
      }
      if (Max != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(Max);
      }
      if (Average != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Average);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EventName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EventName);
      }
      if (Min != 0D) {
        size += 1 + 8;
      }
      if (Max != 0D) {
        size += 1 + 8;
      }
      if (Average != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientTelemetryStopwatch other) {
      if (other == null) {
        return;
      }
      if (other.EventName.Length != 0) {
        EventName = other.EventName;
      }
      if (other.Min != 0D) {
        Min = other.Min;
      }
      if (other.Max != 0D) {
        Max = other.Max;
      }
      if (other.Average != 0D) {
        Average = other.Average;
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
            EventName = input.ReadString();
            break;
          }
          case 17: {
            Min = input.ReadDouble();
            break;
          }
          case 25: {
            Max = input.ReadDouble();
            break;
          }
          case 33: {
            Average = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
