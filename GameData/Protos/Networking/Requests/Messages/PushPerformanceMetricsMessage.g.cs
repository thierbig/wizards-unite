// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Requests/Messages/PushPerformanceMetricsMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Requests/Messages/PushPerformanceMetricsMessage.proto</summary>
  public static partial class PushPerformanceMetricsMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Requests/Messages/PushPerformanceMetricsMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PushPerformanceMetricsMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CklXVVByb3Rvcy9OZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL1B1c2hQ",
            "ZXJmb3JtYW5jZU1ldHJpY3NNZXNzYWdlLnByb3RvEiVXVVByb3Rvcy5OZXR3",
            "b3JraW5nLlJlcXVlc3RzLk1lc3NhZ2VzGidXVVByb3Rvcy9EYXRhL1BlcmZv",
            "cm1hbmNlU25hcHNob3QucHJvdG8iYQodUHVzaFBlcmZvcm1hbmNlTWV0cmlj",
            "c01lc3NhZ2USQAoUcGVyZm9ybWFuY2Vfc25hcHNob3QYASABKAsyIi5XVVBy",
            "b3Rvcy5EYXRhLlBlcmZvcm1hbmNlU25hcHNob3RiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.PerformanceSnapshotReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Requests.Messages.PushPerformanceMetricsMessage), global::WUProtos.Networking.Requests.Messages.PushPerformanceMetricsMessage.Parser, new[]{ "PerformanceSnapshot" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PushPerformanceMetricsMessage : pb::IMessage<PushPerformanceMetricsMessage> {
    private static readonly pb::MessageParser<PushPerformanceMetricsMessage> _parser = new pb::MessageParser<PushPerformanceMetricsMessage>(() => new PushPerformanceMetricsMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PushPerformanceMetricsMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Requests.Messages.PushPerformanceMetricsMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PushPerformanceMetricsMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PushPerformanceMetricsMessage(PushPerformanceMetricsMessage other) : this() {
      performanceSnapshot_ = other.performanceSnapshot_ != null ? other.performanceSnapshot_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PushPerformanceMetricsMessage Clone() {
      return new PushPerformanceMetricsMessage(this);
    }

    /// <summary>Field number for the "performance_snapshot" field.</summary>
    public const int PerformanceSnapshotFieldNumber = 1;
    private global::WUProtos.Data.PerformanceSnapshot performanceSnapshot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.PerformanceSnapshot PerformanceSnapshot {
      get { return performanceSnapshot_; }
      set {
        performanceSnapshot_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PushPerformanceMetricsMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PushPerformanceMetricsMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PerformanceSnapshot, other.PerformanceSnapshot)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (performanceSnapshot_ != null) hash ^= PerformanceSnapshot.GetHashCode();
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
      if (performanceSnapshot_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(PerformanceSnapshot);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (performanceSnapshot_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PerformanceSnapshot);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PushPerformanceMetricsMessage other) {
      if (other == null) {
        return;
      }
      if (other.performanceSnapshot_ != null) {
        if (performanceSnapshot_ == null) {
          PerformanceSnapshot = new global::WUProtos.Data.PerformanceSnapshot();
        }
        PerformanceSnapshot.MergeFrom(other.PerformanceSnapshot);
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
            if (performanceSnapshot_ == null) {
              PerformanceSnapshot = new global::WUProtos.Data.PerformanceSnapshot();
            }
            input.ReadMessage(PerformanceSnapshot);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
