// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Telemetry/PlatformEventData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Telemetry {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Telemetry/PlatformEventData.proto</summary>
  public static partial class PlatformEventDataReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Telemetry/PlatformEventData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlatformEventDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9XVVByb3Rvcy9EYXRhL1RlbGVtZXRyeS9QbGF0Zm9ybUV2ZW50RGF0YS5w",
            "cm90bxIXV1VQcm90b3MuRGF0YS5UZWxlbWV0cnkaLVdVUHJvdG9zL0RhdGEv",
            "VGVsZW1ldHJ5L1RlbGVtZXRyeUNvbW1vbi5wcm90byJXChFQbGF0Zm9ybUV2",
            "ZW50RGF0YRJCChBjb21tb25fdGVsZW1ldHJ5GAEgASgLMiguV1VQcm90b3Mu",
            "RGF0YS5UZWxlbWV0cnkuVGVsZW1ldHJ5Q29tbW9uYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Telemetry.TelemetryCommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Telemetry.PlatformEventData), global::WUProtos.Data.Telemetry.PlatformEventData.Parser, new[]{ "CommonTelemetry" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlatformEventData : pb::IMessage<PlatformEventData> {
    private static readonly pb::MessageParser<PlatformEventData> _parser = new pb::MessageParser<PlatformEventData>(() => new PlatformEventData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PlatformEventData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Telemetry.PlatformEventDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlatformEventData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlatformEventData(PlatformEventData other) : this() {
      commonTelemetry_ = other.commonTelemetry_ != null ? other.commonTelemetry_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlatformEventData Clone() {
      return new PlatformEventData(this);
    }

    /// <summary>Field number for the "common_telemetry" field.</summary>
    public const int CommonTelemetryFieldNumber = 1;
    private global::WUProtos.Data.Telemetry.TelemetryCommon commonTelemetry_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Telemetry.TelemetryCommon CommonTelemetry {
      get { return commonTelemetry_; }
      set {
        commonTelemetry_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PlatformEventData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PlatformEventData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CommonTelemetry, other.CommonTelemetry)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (commonTelemetry_ != null) hash ^= CommonTelemetry.GetHashCode();
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
      if (commonTelemetry_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CommonTelemetry);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (commonTelemetry_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CommonTelemetry);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PlatformEventData other) {
      if (other == null) {
        return;
      }
      if (other.commonTelemetry_ != null) {
        if (commonTelemetry_ == null) {
          CommonTelemetry = new global::WUProtos.Data.Telemetry.TelemetryCommon();
        }
        CommonTelemetry.MergeFrom(other.CommonTelemetry);
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
            if (commonTelemetry_ == null) {
              CommonTelemetry = new global::WUProtos.Data.Telemetry.TelemetryCommon();
            }
            input.ReadMessage(CommonTelemetry);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code