// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientStoryboardStep.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientStoryboardStep.proto</summary>
  public static partial class ClientStoryboardStepReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientStoryboardStep.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientStoryboardStepReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9XVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRTdG9yeWJvYXJkU3RlcC5w",
            "cm90bxIUV1VQcm90b3MuRGF0YS5DbGllbnQaOldVUHJvdG9zL0RhdGEvU3Rv",
            "cnlib2FyZC9TdG9yeWJvYXJkR2VuZXJpY0RpYWxvZ1N0ZXAucHJvdG8aMldV",
            "UHJvdG9zL0RhdGEvU3Rvcnlib2FyZC9TdG9yeWJvYXJkUGF1c2VTdGVwLnBy",
            "b3RvGjpXVVByb3Rvcy9EYXRhL1N0b3J5Ym9hcmQvU3Rvcnlib2FyZEFkdmlj",
            "ZU92ZXJsYXlTdGVwLnByb3RvGj9XVVByb3Rvcy9EYXRhL1N0b3J5Ym9hcmQv",
            "U3Rvcnlib2FyZEFkdmljZUludGVyamVjdGlvblN0ZXAucHJvdG8aRVdVUHJv",
            "dG9zL0RhdGEvU3Rvcnlib2FyZC9TdG9yeWJvYXJkQ29udmVyc2F0aW9uSW50",
            "ZXJqZWN0aW9uU3RlcC5wcm90byKgBAoUQ2xpZW50U3Rvcnlib2FyZFN0ZXAS",
            "FAoMY3VzdG9tX3N0YXRlGAEgASgJEk8KDmdlbmVyaWNfZGlhbG9nGAIgASgL",
            "MjUuV1VQcm90b3MuRGF0YS5TdG9yeWJvYXJkLlN0b3J5Ym9hcmRHZW5lcmlj",
            "RGlhbG9nU3RlcEgAEj4KBXBhdXNlGAMgASgLMi0uV1VQcm90b3MuRGF0YS5T",
            "dG9yeWJvYXJkLlN0b3J5Ym9hcmRQYXVzZVN0ZXBIABJPCg5hZHZpY2Vfb3Zl",
            "cmxheRgEIAEoCzI1LldVUHJvdG9zLkRhdGEuU3Rvcnlib2FyZC5TdG9yeWJv",
            "YXJkQWR2aWNlT3ZlcmxheVN0ZXBIABJZChNhZHZpY2VfaW50ZXJqZWN0aW9u",
            "GAUgASgLMjouV1VQcm90b3MuRGF0YS5TdG9yeWJvYXJkLlN0b3J5Ym9hcmRB",
            "ZHZpY2VJbnRlcmplY3Rpb25TdGVwSAASZQoZY29udmVyc2F0aW9uX2ludGVy",
            "amVjdGlvbhgGIAEoCzJALldVUHJvdG9zLkRhdGEuU3Rvcnlib2FyZC5TdG9y",
            "eWJvYXJkQ29udmVyc2F0aW9uSW50ZXJqZWN0aW9uU3RlcEgAEhwKFGNhbGxf",
            "dG9fYWN0aW9uX2Fzc2V0GAcgASgJEigKIGNhbGxfdG9fYWN0aW9uX2J1dHRv",
            "bl9pZGVudGlmaWVyGAggASgJQgYKBERhdGFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Storyboard.StoryboardGenericDialogStepReflection.Descriptor, global::WUProtos.Data.Storyboard.StoryboardPauseStepReflection.Descriptor, global::WUProtos.Data.Storyboard.StoryboardAdviceOverlayStepReflection.Descriptor, global::WUProtos.Data.Storyboard.StoryboardAdviceInterjectionStepReflection.Descriptor, global::WUProtos.Data.Storyboard.StoryboardConversationInterjectionStepReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientStoryboardStep), global::WUProtos.Data.Client.ClientStoryboardStep.Parser, new[]{ "CustomState", "GenericDialog", "Pause", "AdviceOverlay", "AdviceInterjection", "ConversationInterjection", "CallToActionAsset", "CallToActionButtonIdentifier" }, new[]{ "Data" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientStoryboardStep : pb::IMessage<ClientStoryboardStep> {
    private static readonly pb::MessageParser<ClientStoryboardStep> _parser = new pb::MessageParser<ClientStoryboardStep>(() => new ClientStoryboardStep());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientStoryboardStep> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientStoryboardStepReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientStoryboardStep() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientStoryboardStep(ClientStoryboardStep other) : this() {
      customState_ = other.customState_;
      callToActionAsset_ = other.callToActionAsset_;
      callToActionButtonIdentifier_ = other.callToActionButtonIdentifier_;
      switch (other.DataCase) {
        case DataOneofCase.GenericDialog:
          GenericDialog = other.GenericDialog.Clone();
          break;
        case DataOneofCase.Pause:
          Pause = other.Pause.Clone();
          break;
        case DataOneofCase.AdviceOverlay:
          AdviceOverlay = other.AdviceOverlay.Clone();
          break;
        case DataOneofCase.AdviceInterjection:
          AdviceInterjection = other.AdviceInterjection.Clone();
          break;
        case DataOneofCase.ConversationInterjection:
          ConversationInterjection = other.ConversationInterjection.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientStoryboardStep Clone() {
      return new ClientStoryboardStep(this);
    }

    /// <summary>Field number for the "custom_state" field.</summary>
    public const int CustomStateFieldNumber = 1;
    private string customState_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CustomState {
      get { return customState_; }
      set {
        customState_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "generic_dialog" field.</summary>
    public const int GenericDialogFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Storyboard.StoryboardGenericDialogStep GenericDialog {
      get { return dataCase_ == DataOneofCase.GenericDialog ? (global::WUProtos.Data.Storyboard.StoryboardGenericDialogStep) data_ : null; }
      set {
        data_ = value;
        dataCase_ = value == null ? DataOneofCase.None : DataOneofCase.GenericDialog;
      }
    }

    /// <summary>Field number for the "pause" field.</summary>
    public const int PauseFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Storyboard.StoryboardPauseStep Pause {
      get { return dataCase_ == DataOneofCase.Pause ? (global::WUProtos.Data.Storyboard.StoryboardPauseStep) data_ : null; }
      set {
        data_ = value;
        dataCase_ = value == null ? DataOneofCase.None : DataOneofCase.Pause;
      }
    }

    /// <summary>Field number for the "advice_overlay" field.</summary>
    public const int AdviceOverlayFieldNumber = 4;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Storyboard.StoryboardAdviceOverlayStep AdviceOverlay {
      get { return dataCase_ == DataOneofCase.AdviceOverlay ? (global::WUProtos.Data.Storyboard.StoryboardAdviceOverlayStep) data_ : null; }
      set {
        data_ = value;
        dataCase_ = value == null ? DataOneofCase.None : DataOneofCase.AdviceOverlay;
      }
    }

    /// <summary>Field number for the "advice_interjection" field.</summary>
    public const int AdviceInterjectionFieldNumber = 5;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Storyboard.StoryboardAdviceInterjectionStep AdviceInterjection {
      get { return dataCase_ == DataOneofCase.AdviceInterjection ? (global::WUProtos.Data.Storyboard.StoryboardAdviceInterjectionStep) data_ : null; }
      set {
        data_ = value;
        dataCase_ = value == null ? DataOneofCase.None : DataOneofCase.AdviceInterjection;
      }
    }

    /// <summary>Field number for the "conversation_interjection" field.</summary>
    public const int ConversationInterjectionFieldNumber = 6;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Storyboard.StoryboardConversationInterjectionStep ConversationInterjection {
      get { return dataCase_ == DataOneofCase.ConversationInterjection ? (global::WUProtos.Data.Storyboard.StoryboardConversationInterjectionStep) data_ : null; }
      set {
        data_ = value;
        dataCase_ = value == null ? DataOneofCase.None : DataOneofCase.ConversationInterjection;
      }
    }

    /// <summary>Field number for the "call_to_action_asset" field.</summary>
    public const int CallToActionAssetFieldNumber = 7;
    private string callToActionAsset_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CallToActionAsset {
      get { return callToActionAsset_; }
      set {
        callToActionAsset_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "call_to_action_button_identifier" field.</summary>
    public const int CallToActionButtonIdentifierFieldNumber = 8;
    private string callToActionButtonIdentifier_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CallToActionButtonIdentifier {
      get { return callToActionButtonIdentifier_; }
      set {
        callToActionButtonIdentifier_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private object data_;
    /// <summary>Enum of possible cases for the "Data" oneof.</summary>
    public enum DataOneofCase {
      None = 0,
      GenericDialog = 2,
      Pause = 3,
      AdviceOverlay = 4,
      AdviceInterjection = 5,
      ConversationInterjection = 6,
    }
    private DataOneofCase dataCase_ = DataOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DataOneofCase DataCase {
      get { return dataCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearData() {
      dataCase_ = DataOneofCase.None;
      data_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientStoryboardStep);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientStoryboardStep other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CustomState != other.CustomState) return false;
      if (!object.Equals(GenericDialog, other.GenericDialog)) return false;
      if (!object.Equals(Pause, other.Pause)) return false;
      if (!object.Equals(AdviceOverlay, other.AdviceOverlay)) return false;
      if (!object.Equals(AdviceInterjection, other.AdviceInterjection)) return false;
      if (!object.Equals(ConversationInterjection, other.ConversationInterjection)) return false;
      if (CallToActionAsset != other.CallToActionAsset) return false;
      if (CallToActionButtonIdentifier != other.CallToActionButtonIdentifier) return false;
      if (DataCase != other.DataCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CustomState.Length != 0) hash ^= CustomState.GetHashCode();
      if (dataCase_ == DataOneofCase.GenericDialog) hash ^= GenericDialog.GetHashCode();
      if (dataCase_ == DataOneofCase.Pause) hash ^= Pause.GetHashCode();
      if (dataCase_ == DataOneofCase.AdviceOverlay) hash ^= AdviceOverlay.GetHashCode();
      if (dataCase_ == DataOneofCase.AdviceInterjection) hash ^= AdviceInterjection.GetHashCode();
      if (dataCase_ == DataOneofCase.ConversationInterjection) hash ^= ConversationInterjection.GetHashCode();
      if (CallToActionAsset.Length != 0) hash ^= CallToActionAsset.GetHashCode();
      if (CallToActionButtonIdentifier.Length != 0) hash ^= CallToActionButtonIdentifier.GetHashCode();
      hash ^= (int) dataCase_;
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
      if (CustomState.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CustomState);
      }
      if (dataCase_ == DataOneofCase.GenericDialog) {
        output.WriteRawTag(18);
        output.WriteMessage(GenericDialog);
      }
      if (dataCase_ == DataOneofCase.Pause) {
        output.WriteRawTag(26);
        output.WriteMessage(Pause);
      }
      if (dataCase_ == DataOneofCase.AdviceOverlay) {
        output.WriteRawTag(34);
        output.WriteMessage(AdviceOverlay);
      }
      if (dataCase_ == DataOneofCase.AdviceInterjection) {
        output.WriteRawTag(42);
        output.WriteMessage(AdviceInterjection);
      }
      if (dataCase_ == DataOneofCase.ConversationInterjection) {
        output.WriteRawTag(50);
        output.WriteMessage(ConversationInterjection);
      }
      if (CallToActionAsset.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(CallToActionAsset);
      }
      if (CallToActionButtonIdentifier.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(CallToActionButtonIdentifier);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CustomState.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomState);
      }
      if (dataCase_ == DataOneofCase.GenericDialog) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GenericDialog);
      }
      if (dataCase_ == DataOneofCase.Pause) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pause);
      }
      if (dataCase_ == DataOneofCase.AdviceOverlay) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AdviceOverlay);
      }
      if (dataCase_ == DataOneofCase.AdviceInterjection) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AdviceInterjection);
      }
      if (dataCase_ == DataOneofCase.ConversationInterjection) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ConversationInterjection);
      }
      if (CallToActionAsset.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CallToActionAsset);
      }
      if (CallToActionButtonIdentifier.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CallToActionButtonIdentifier);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientStoryboardStep other) {
      if (other == null) {
        return;
      }
      if (other.CustomState.Length != 0) {
        CustomState = other.CustomState;
      }
      if (other.CallToActionAsset.Length != 0) {
        CallToActionAsset = other.CallToActionAsset;
      }
      if (other.CallToActionButtonIdentifier.Length != 0) {
        CallToActionButtonIdentifier = other.CallToActionButtonIdentifier;
      }
      switch (other.DataCase) {
        case DataOneofCase.GenericDialog:
          if (GenericDialog == null) {
            GenericDialog = new global::WUProtos.Data.Storyboard.StoryboardGenericDialogStep();
          }
          GenericDialog.MergeFrom(other.GenericDialog);
          break;
        case DataOneofCase.Pause:
          if (Pause == null) {
            Pause = new global::WUProtos.Data.Storyboard.StoryboardPauseStep();
          }
          Pause.MergeFrom(other.Pause);
          break;
        case DataOneofCase.AdviceOverlay:
          if (AdviceOverlay == null) {
            AdviceOverlay = new global::WUProtos.Data.Storyboard.StoryboardAdviceOverlayStep();
          }
          AdviceOverlay.MergeFrom(other.AdviceOverlay);
          break;
        case DataOneofCase.AdviceInterjection:
          if (AdviceInterjection == null) {
            AdviceInterjection = new global::WUProtos.Data.Storyboard.StoryboardAdviceInterjectionStep();
          }
          AdviceInterjection.MergeFrom(other.AdviceInterjection);
          break;
        case DataOneofCase.ConversationInterjection:
          if (ConversationInterjection == null) {
            ConversationInterjection = new global::WUProtos.Data.Storyboard.StoryboardConversationInterjectionStep();
          }
          ConversationInterjection.MergeFrom(other.ConversationInterjection);
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
            CustomState = input.ReadString();
            break;
          }
          case 18: {
            global::WUProtos.Data.Storyboard.StoryboardGenericDialogStep subBuilder = new global::WUProtos.Data.Storyboard.StoryboardGenericDialogStep();
            if (dataCase_ == DataOneofCase.GenericDialog) {
              subBuilder.MergeFrom(GenericDialog);
            }
            input.ReadMessage(subBuilder);
            GenericDialog = subBuilder;
            break;
          }
          case 26: {
            global::WUProtos.Data.Storyboard.StoryboardPauseStep subBuilder = new global::WUProtos.Data.Storyboard.StoryboardPauseStep();
            if (dataCase_ == DataOneofCase.Pause) {
              subBuilder.MergeFrom(Pause);
            }
            input.ReadMessage(subBuilder);
            Pause = subBuilder;
            break;
          }
          case 34: {
            global::WUProtos.Data.Storyboard.StoryboardAdviceOverlayStep subBuilder = new global::WUProtos.Data.Storyboard.StoryboardAdviceOverlayStep();
            if (dataCase_ == DataOneofCase.AdviceOverlay) {
              subBuilder.MergeFrom(AdviceOverlay);
            }
            input.ReadMessage(subBuilder);
            AdviceOverlay = subBuilder;
            break;
          }
          case 42: {
            global::WUProtos.Data.Storyboard.StoryboardAdviceInterjectionStep subBuilder = new global::WUProtos.Data.Storyboard.StoryboardAdviceInterjectionStep();
            if (dataCase_ == DataOneofCase.AdviceInterjection) {
              subBuilder.MergeFrom(AdviceInterjection);
            }
            input.ReadMessage(subBuilder);
            AdviceInterjection = subBuilder;
            break;
          }
          case 50: {
            global::WUProtos.Data.Storyboard.StoryboardConversationInterjectionStep subBuilder = new global::WUProtos.Data.Storyboard.StoryboardConversationInterjectionStep();
            if (dataCase_ == DataOneofCase.ConversationInterjection) {
              subBuilder.MergeFrom(ConversationInterjection);
            }
            input.ReadMessage(subBuilder);
            ConversationInterjection = subBuilder;
            break;
          }
          case 58: {
            CallToActionAsset = input.ReadString();
            break;
          }
          case 66: {
            CallToActionButtonIdentifier = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code