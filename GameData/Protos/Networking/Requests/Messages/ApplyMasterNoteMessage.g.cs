// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Requests/Messages/ApplyMasterNoteMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Requests/Messages/ApplyMasterNoteMessage.proto</summary>
  public static partial class ApplyMasterNoteMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Requests/Messages/ApplyMasterNoteMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ApplyMasterNoteMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJXVVByb3Rvcy9OZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL0FwcGx5",
            "TWFzdGVyTm90ZU1lc3NhZ2UucHJvdG8SJVdVUHJvdG9zLk5ldHdvcmtpbmcu",
            "UmVxdWVzdHMuTWVzc2FnZXMaJldVUHJvdG9zL0VudW1zL01hc3Rlck5vdGVH",
            "ZXN0dXJlLnByb3RvImEKFkFwcGx5TWFzdGVyTm90ZU1lc3NhZ2USEwoLY2F1",
            "bGRyb25faWQYASABKAMSMgoHZ2VzdHVyZRgCIAMoDjIhLldVUHJvdG9zLkVu",
            "dW1zLk1hc3Rlck5vdGVHZXN0dXJlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Enums.MasterNoteGestureReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Requests.Messages.ApplyMasterNoteMessage), global::WUProtos.Networking.Requests.Messages.ApplyMasterNoteMessage.Parser, new[]{ "CauldronId", "Gesture" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ApplyMasterNoteMessage : pb::IMessage<ApplyMasterNoteMessage> {
    private static readonly pb::MessageParser<ApplyMasterNoteMessage> _parser = new pb::MessageParser<ApplyMasterNoteMessage>(() => new ApplyMasterNoteMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ApplyMasterNoteMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Requests.Messages.ApplyMasterNoteMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplyMasterNoteMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplyMasterNoteMessage(ApplyMasterNoteMessage other) : this() {
      cauldronId_ = other.cauldronId_;
      gesture_ = other.gesture_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplyMasterNoteMessage Clone() {
      return new ApplyMasterNoteMessage(this);
    }

    /// <summary>Field number for the "cauldron_id" field.</summary>
    public const int CauldronIdFieldNumber = 1;
    private long cauldronId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long CauldronId {
      get { return cauldronId_; }
      set {
        cauldronId_ = value;
      }
    }

    /// <summary>Field number for the "gesture" field.</summary>
    public const int GestureFieldNumber = 2;
    private static readonly pb::FieldCodec<global::WUProtos.Enums.MasterNoteGesture> _repeated_gesture_codec
        = pb::FieldCodec.ForEnum(18, x => (int) x, x => (global::WUProtos.Enums.MasterNoteGesture) x);
    private readonly pbc::RepeatedField<global::WUProtos.Enums.MasterNoteGesture> gesture_ = new pbc::RepeatedField<global::WUProtos.Enums.MasterNoteGesture>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Enums.MasterNoteGesture> Gesture {
      get { return gesture_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ApplyMasterNoteMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ApplyMasterNoteMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CauldronId != other.CauldronId) return false;
      if(!gesture_.Equals(other.gesture_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CauldronId != 0L) hash ^= CauldronId.GetHashCode();
      hash ^= gesture_.GetHashCode();
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
      if (CauldronId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(CauldronId);
      }
      gesture_.WriteTo(output, _repeated_gesture_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CauldronId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CauldronId);
      }
      size += gesture_.CalculateSize(_repeated_gesture_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ApplyMasterNoteMessage other) {
      if (other == null) {
        return;
      }
      if (other.CauldronId != 0L) {
        CauldronId = other.CauldronId;
      }
      gesture_.Add(other.gesture_);
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
            CauldronId = input.ReadInt64();
            break;
          }
          case 18:
          case 16: {
            gesture_.AddEntriesFrom(input, _repeated_gesture_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
