// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/StoryboardAdviceOverlayStep.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data {

  /// <summary>Holder for reflection information generated from WUProtos/Data/StoryboardAdviceOverlayStep.proto</summary>
  public static partial class StoryboardAdviceOverlayStepReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/StoryboardAdviceOverlayStep.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StoryboardAdviceOverlayStepReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9XVVByb3Rvcy9EYXRhL1N0b3J5Ym9hcmRBZHZpY2VPdmVybGF5U3RlcC5w",
            "cm90bxINV1VQcm90b3MuRGF0YRogV1VQcm90b3MvRGF0YS9TcGVlY2hCdWJi",
            "bGUucHJvdG8aKldVUHJvdG9zL0RhdGEvQWR2aWNlT3ZlcmxheUFsaWdubWVu",
            "dC5wcm90byLGAQobU3Rvcnlib2FyZEFkdmljZU92ZXJsYXlTdGVwEjIKDXNw",
            "ZWVjaF9idWJibGUYASABKAsyGy5XVVByb3Rvcy5EYXRhLlNwZWVjaEJ1YmJs",
            "ZRIWCg5yZXF1aXJlc19zY3JpbRgCIAEoCBI4CglhbGlnbm1lbnQYAyABKA4y",
            "JS5XVVByb3Rvcy5EYXRhLkFkdmljZU92ZXJsYXlBbGlnbm1lbnQSIQoZc2hv",
            "d19jb250aW51ZV9hY3Rpb25fdGV4dBgEIAEoCGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.SpeechBubbleReflection.Descriptor, global::WUProtos.Data.AdviceOverlayAlignmentReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.StoryboardAdviceOverlayStep), global::WUProtos.Data.StoryboardAdviceOverlayStep.Parser, new[]{ "SpeechBubble", "RequiresScrim", "Alignment", "ShowContinueActionText" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class StoryboardAdviceOverlayStep : pb::IMessage<StoryboardAdviceOverlayStep> {
    private static readonly pb::MessageParser<StoryboardAdviceOverlayStep> _parser = new pb::MessageParser<StoryboardAdviceOverlayStep>(() => new StoryboardAdviceOverlayStep());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StoryboardAdviceOverlayStep> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.StoryboardAdviceOverlayStepReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StoryboardAdviceOverlayStep() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StoryboardAdviceOverlayStep(StoryboardAdviceOverlayStep other) : this() {
      speechBubble_ = other.speechBubble_ != null ? other.speechBubble_.Clone() : null;
      requiresScrim_ = other.requiresScrim_;
      alignment_ = other.alignment_;
      showContinueActionText_ = other.showContinueActionText_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StoryboardAdviceOverlayStep Clone() {
      return new StoryboardAdviceOverlayStep(this);
    }

    /// <summary>Field number for the "speech_bubble" field.</summary>
    public const int SpeechBubbleFieldNumber = 1;
    private global::WUProtos.Data.SpeechBubble speechBubble_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.SpeechBubble SpeechBubble {
      get { return speechBubble_; }
      set {
        speechBubble_ = value;
      }
    }

    /// <summary>Field number for the "requires_scrim" field.</summary>
    public const int RequiresScrimFieldNumber = 2;
    private bool requiresScrim_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool RequiresScrim {
      get { return requiresScrim_; }
      set {
        requiresScrim_ = value;
      }
    }

    /// <summary>Field number for the "alignment" field.</summary>
    public const int AlignmentFieldNumber = 3;
    private global::WUProtos.Data.AdviceOverlayAlignment alignment_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.AdviceOverlayAlignment Alignment {
      get { return alignment_; }
      set {
        alignment_ = value;
      }
    }

    /// <summary>Field number for the "show_continue_action_text" field.</summary>
    public const int ShowContinueActionTextFieldNumber = 4;
    private bool showContinueActionText_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ShowContinueActionText {
      get { return showContinueActionText_; }
      set {
        showContinueActionText_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StoryboardAdviceOverlayStep);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StoryboardAdviceOverlayStep other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(SpeechBubble, other.SpeechBubble)) return false;
      if (RequiresScrim != other.RequiresScrim) return false;
      if (Alignment != other.Alignment) return false;
      if (ShowContinueActionText != other.ShowContinueActionText) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (speechBubble_ != null) hash ^= SpeechBubble.GetHashCode();
      if (RequiresScrim != false) hash ^= RequiresScrim.GetHashCode();
      if (Alignment != 0) hash ^= Alignment.GetHashCode();
      if (ShowContinueActionText != false) hash ^= ShowContinueActionText.GetHashCode();
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
      if (speechBubble_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(SpeechBubble);
      }
      if (RequiresScrim != false) {
        output.WriteRawTag(16);
        output.WriteBool(RequiresScrim);
      }
      if (Alignment != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Alignment);
      }
      if (ShowContinueActionText != false) {
        output.WriteRawTag(32);
        output.WriteBool(ShowContinueActionText);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (speechBubble_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SpeechBubble);
      }
      if (RequiresScrim != false) {
        size += 1 + 1;
      }
      if (Alignment != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Alignment);
      }
      if (ShowContinueActionText != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StoryboardAdviceOverlayStep other) {
      if (other == null) {
        return;
      }
      if (other.speechBubble_ != null) {
        if (speechBubble_ == null) {
          SpeechBubble = new global::WUProtos.Data.SpeechBubble();
        }
        SpeechBubble.MergeFrom(other.SpeechBubble);
      }
      if (other.RequiresScrim != false) {
        RequiresScrim = other.RequiresScrim;
      }
      if (other.Alignment != 0) {
        Alignment = other.Alignment;
      }
      if (other.ShowContinueActionText != false) {
        ShowContinueActionText = other.ShowContinueActionText;
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
            if (speechBubble_ == null) {
              SpeechBubble = new global::WUProtos.Data.SpeechBubble();
            }
            input.ReadMessage(SpeechBubble);
            break;
          }
          case 16: {
            RequiresScrim = input.ReadBool();
            break;
          }
          case 24: {
            Alignment = (global::WUProtos.Data.AdviceOverlayAlignment) input.ReadEnum();
            break;
          }
          case 32: {
            ShowContinueActionText = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
