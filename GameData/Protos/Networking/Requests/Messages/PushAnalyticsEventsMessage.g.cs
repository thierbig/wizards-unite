// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Requests/Messages/PushAnalyticsEventsMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Requests/Messages/PushAnalyticsEventsMessage.proto</summary>
  public static partial class PushAnalyticsEventsMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Requests/Messages/PushAnalyticsEventsMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PushAnalyticsEventsMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkZXVVByb3Rvcy9OZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL1B1c2hB",
            "bmFseXRpY3NFdmVudHNNZXNzYWdlLnByb3RvEiVXVVByb3Rvcy5OZXR3b3Jr",
            "aW5nLlJlcXVlc3RzLk1lc3NhZ2VzGilXVVByb3Rvcy9EYXRhL0V2ZW50L0Fu",
            "YWx5dGljc0V2ZW50cy5wcm90byJSChpQdXNoQW5hbHl0aWNzRXZlbnRzTWVz",
            "c2FnZRI0CgZldmVudHMYASABKAsyJC5XVVByb3Rvcy5EYXRhLkV2ZW50LkFu",
            "YWx5dGljc0V2ZW50c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Event.AnalyticsEventsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Requests.Messages.PushAnalyticsEventsMessage), global::WUProtos.Networking.Requests.Messages.PushAnalyticsEventsMessage.Parser, new[]{ "Events" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PushAnalyticsEventsMessage : pb::IMessage<PushAnalyticsEventsMessage> {
    private static readonly pb::MessageParser<PushAnalyticsEventsMessage> _parser = new pb::MessageParser<PushAnalyticsEventsMessage>(() => new PushAnalyticsEventsMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PushAnalyticsEventsMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Requests.Messages.PushAnalyticsEventsMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PushAnalyticsEventsMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PushAnalyticsEventsMessage(PushAnalyticsEventsMessage other) : this() {
      events_ = other.events_ != null ? other.events_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PushAnalyticsEventsMessage Clone() {
      return new PushAnalyticsEventsMessage(this);
    }

    /// <summary>Field number for the "events" field.</summary>
    public const int EventsFieldNumber = 1;
    private global::WUProtos.Data.Event.AnalyticsEvents events_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Event.AnalyticsEvents Events {
      get { return events_; }
      set {
        events_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PushAnalyticsEventsMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PushAnalyticsEventsMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Events, other.Events)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (events_ != null) hash ^= Events.GetHashCode();
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
      if (events_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Events);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (events_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Events);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PushAnalyticsEventsMessage other) {
      if (other == null) {
        return;
      }
      if (other.events_ != null) {
        if (events_ == null) {
          Events = new global::WUProtos.Data.Event.AnalyticsEvents();
        }
        Events.MergeFrom(other.Events);
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
            if (events_ == null) {
              Events = new global::WUProtos.Data.Event.AnalyticsEvents();
            }
            input.ReadMessage(Events);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code