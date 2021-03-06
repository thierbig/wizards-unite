// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/ContainerConsumptionResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/ContainerConsumptionResponse.proto</summary>
  public static partial class ContainerConsumptionResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/ContainerConsumptionResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ContainerConsumptionResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBXVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9Db250YWluZXJDb25z",
            "dW1wdGlvblJlc3BvbnNlLnByb3RvEh1XVVByb3Rvcy5OZXR3b3JraW5nLlJl",
            "c3BvbnNlcxonV1VQcm90b3MvRGF0YS9Mb290L0xvb3RDb2xsZWN0aW9uLnBy",
            "b3RvIpkCChxDb250YWluZXJDb25zdW1wdGlvblJlc3BvbnNlElIKBnN0YXR1",
            "cxgBIAEoDjJCLldVUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2VzLkNvbnRh",
            "aW5lckNvbnN1bXB0aW9uUmVzcG9uc2UuU3RhdHVzEj4KEmNvbnRhaW5lcl9j",
            "b250ZW50cxgCIAEoCzIiLldVUHJvdG9zLkRhdGEuTG9vdC5Mb290Q29sbGVj",
            "dGlvbiJlCgZTdGF0dXMSCAoETk9ORRAAEigKJFVOS05PV05fQ09OVEFJTkVS",
            "X0NPTlNVTVBUSU9OX1JFU1VMVBABEgsKB1NVQ0NFU1MQAhIaChZDT05UQUlO",
            "RVJfTk9UX0lOX1ZBVUxUEANiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Loot.LootCollectionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.ContainerConsumptionResponse), global::WUProtos.Networking.Responses.ContainerConsumptionResponse.Parser, new[]{ "Status", "ContainerContents" }, null, new[]{ typeof(global::WUProtos.Networking.Responses.ContainerConsumptionResponse.Types.Status) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ContainerConsumptionResponse : pb::IMessage<ContainerConsumptionResponse> {
    private static readonly pb::MessageParser<ContainerConsumptionResponse> _parser = new pb::MessageParser<ContainerConsumptionResponse>(() => new ContainerConsumptionResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ContainerConsumptionResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.ContainerConsumptionResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContainerConsumptionResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContainerConsumptionResponse(ContainerConsumptionResponse other) : this() {
      status_ = other.status_;
      containerContents_ = other.containerContents_ != null ? other.containerContents_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContainerConsumptionResponse Clone() {
      return new ContainerConsumptionResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::WUProtos.Networking.Responses.ContainerConsumptionResponse.Types.Status status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Networking.Responses.ContainerConsumptionResponse.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "container_contents" field.</summary>
    public const int ContainerContentsFieldNumber = 2;
    private global::WUProtos.Data.Loot.LootCollection containerContents_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Loot.LootCollection ContainerContents {
      get { return containerContents_; }
      set {
        containerContents_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ContainerConsumptionResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ContainerConsumptionResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (!object.Equals(ContainerContents, other.ContainerContents)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      if (containerContents_ != null) hash ^= ContainerContents.GetHashCode();
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
      if (Status != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      if (containerContents_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ContainerContents);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (containerContents_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ContainerContents);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ContainerConsumptionResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.containerContents_ != null) {
        if (containerContents_ == null) {
          ContainerContents = new global::WUProtos.Data.Loot.LootCollection();
        }
        ContainerContents.MergeFrom(other.ContainerContents);
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
          case 8: {
            Status = (global::WUProtos.Networking.Responses.ContainerConsumptionResponse.Types.Status) input.ReadEnum();
            break;
          }
          case 18: {
            if (containerContents_ == null) {
              ContainerContents = new global::WUProtos.Data.Loot.LootCollection();
            }
            input.ReadMessage(ContainerContents);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ContainerConsumptionResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("UNKNOWN_CONTAINER_CONSUMPTION_RESULT")] UnknownContainerConsumptionResult = 1,
        [pbr::OriginalName("SUCCESS")] Success = 2,
        [pbr::OriginalName("CONTAINER_NOT_IN_VAULT")] ContainerNotInVault = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
