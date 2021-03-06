// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Requests/Messages/ReleaseEscrowedRewardsMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Requests/Messages/ReleaseEscrowedRewardsMessage.proto</summary>
  public static partial class ReleaseEscrowedRewardsMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Requests/Messages/ReleaseEscrowedRewardsMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReleaseEscrowedRewardsMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CklXVVByb3Rvcy9OZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL1JlbGVh",
            "c2VFc2Nyb3dlZFJld2FyZHNNZXNzYWdlLnByb3RvEiVXVVByb3Rvcy5OZXR3",
            "b3JraW5nLlJlcXVlc3RzLk1lc3NhZ2VzGjBXVVByb3Rvcy9EYXRhL0NsYWlt",
            "QnlDYXRlZ29yeVJlcXVlc3RBY3Rpb24ucHJvdG8aK1dVUHJvdG9zL0RhdGEv",
            "QWJhbmRvbkFsbFJlcXVlc3RBY3Rpb24ucHJvdG8isgEKHVJlbGVhc2VFc2Ny",
            "b3dlZFJld2FyZHNNZXNzYWdlEkgKEWNsYWltX2J5X2NhdGVnb3J5GAEgASgL",
            "MisuV1VQcm90b3MuRGF0YS5DbGFpbUJ5Q2F0ZWdvcnlSZXF1ZXN0QWN0aW9u",
            "SAASPQoLYWJhbmRvbl9hbGwYAiABKAsyJi5XVVByb3Rvcy5EYXRhLkFiYW5k",
            "b25BbGxSZXF1ZXN0QWN0aW9uSABCCAoGQWN0aW9uYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.ClaimByCategoryRequestActionReflection.Descriptor, global::WUProtos.Data.AbandonAllRequestActionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Requests.Messages.ReleaseEscrowedRewardsMessage), global::WUProtos.Networking.Requests.Messages.ReleaseEscrowedRewardsMessage.Parser, new[]{ "ClaimByCategory", "AbandonAll" }, new[]{ "Action" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReleaseEscrowedRewardsMessage : pb::IMessage<ReleaseEscrowedRewardsMessage> {
    private static readonly pb::MessageParser<ReleaseEscrowedRewardsMessage> _parser = new pb::MessageParser<ReleaseEscrowedRewardsMessage>(() => new ReleaseEscrowedRewardsMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReleaseEscrowedRewardsMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Requests.Messages.ReleaseEscrowedRewardsMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReleaseEscrowedRewardsMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReleaseEscrowedRewardsMessage(ReleaseEscrowedRewardsMessage other) : this() {
      switch (other.ActionCase) {
        case ActionOneofCase.ClaimByCategory:
          ClaimByCategory = other.ClaimByCategory.Clone();
          break;
        case ActionOneofCase.AbandonAll:
          AbandonAll = other.AbandonAll.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReleaseEscrowedRewardsMessage Clone() {
      return new ReleaseEscrowedRewardsMessage(this);
    }

    /// <summary>Field number for the "claim_by_category" field.</summary>
    public const int ClaimByCategoryFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.ClaimByCategoryRequestAction ClaimByCategory {
      get { return actionCase_ == ActionOneofCase.ClaimByCategory ? (global::WUProtos.Data.ClaimByCategoryRequestAction) action_ : null; }
      set {
        action_ = value;
        actionCase_ = value == null ? ActionOneofCase.None : ActionOneofCase.ClaimByCategory;
      }
    }

    /// <summary>Field number for the "abandon_all" field.</summary>
    public const int AbandonAllFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.AbandonAllRequestAction AbandonAll {
      get { return actionCase_ == ActionOneofCase.AbandonAll ? (global::WUProtos.Data.AbandonAllRequestAction) action_ : null; }
      set {
        action_ = value;
        actionCase_ = value == null ? ActionOneofCase.None : ActionOneofCase.AbandonAll;
      }
    }

    private object action_;
    /// <summary>Enum of possible cases for the "Action" oneof.</summary>
    public enum ActionOneofCase {
      None = 0,
      ClaimByCategory = 1,
      AbandonAll = 2,
    }
    private ActionOneofCase actionCase_ = ActionOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ActionOneofCase ActionCase {
      get { return actionCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearAction() {
      actionCase_ = ActionOneofCase.None;
      action_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReleaseEscrowedRewardsMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReleaseEscrowedRewardsMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ClaimByCategory, other.ClaimByCategory)) return false;
      if (!object.Equals(AbandonAll, other.AbandonAll)) return false;
      if (ActionCase != other.ActionCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (actionCase_ == ActionOneofCase.ClaimByCategory) hash ^= ClaimByCategory.GetHashCode();
      if (actionCase_ == ActionOneofCase.AbandonAll) hash ^= AbandonAll.GetHashCode();
      hash ^= (int) actionCase_;
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
      if (actionCase_ == ActionOneofCase.ClaimByCategory) {
        output.WriteRawTag(10);
        output.WriteMessage(ClaimByCategory);
      }
      if (actionCase_ == ActionOneofCase.AbandonAll) {
        output.WriteRawTag(18);
        output.WriteMessage(AbandonAll);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (actionCase_ == ActionOneofCase.ClaimByCategory) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ClaimByCategory);
      }
      if (actionCase_ == ActionOneofCase.AbandonAll) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AbandonAll);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReleaseEscrowedRewardsMessage other) {
      if (other == null) {
        return;
      }
      switch (other.ActionCase) {
        case ActionOneofCase.ClaimByCategory:
          if (ClaimByCategory == null) {
            ClaimByCategory = new global::WUProtos.Data.ClaimByCategoryRequestAction();
          }
          ClaimByCategory.MergeFrom(other.ClaimByCategory);
          break;
        case ActionOneofCase.AbandonAll:
          if (AbandonAll == null) {
            AbandonAll = new global::WUProtos.Data.AbandonAllRequestAction();
          }
          AbandonAll.MergeFrom(other.AbandonAll);
          break;
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
            global::WUProtos.Data.ClaimByCategoryRequestAction subBuilder = new global::WUProtos.Data.ClaimByCategoryRequestAction();
            if (actionCase_ == ActionOneofCase.ClaimByCategory) {
              subBuilder.MergeFrom(ClaimByCategory);
            }
            input.ReadMessage(subBuilder);
            ClaimByCategory = subBuilder;
            break;
          }
          case 18: {
            global::WUProtos.Data.AbandonAllRequestAction subBuilder = new global::WUProtos.Data.AbandonAllRequestAction();
            if (actionCase_ == ActionOneofCase.AbandonAll) {
              subBuilder.MergeFrom(AbandonAll);
            }
            input.ReadMessage(subBuilder);
            AbandonAll = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
