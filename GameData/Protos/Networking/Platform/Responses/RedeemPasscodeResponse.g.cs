// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Platform/Responses/RedeemPasscodeResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Platform.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Platform/Responses/RedeemPasscodeResponse.proto</summary>
  public static partial class RedeemPasscodeResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Platform/Responses/RedeemPasscodeResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RedeemPasscodeResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNXVVByb3Rvcy9OZXR3b3JraW5nL1BsYXRmb3JtL1Jlc3BvbnNlcy9SZWRl",
            "ZW1QYXNzY29kZVJlc3BvbnNlLnByb3RvEiZXVVByb3Rvcy5OZXR3b3JraW5n",
            "LlBsYXRmb3JtLlJlc3BvbnNlcyKVAwoWUmVkZWVtUGFzc2NvZGVSZXNwb25z",
            "ZRJVCgZyZXN1bHQYASABKA4yRS5XVVByb3Rvcy5OZXR3b3JraW5nLlBsYXRm",
            "b3JtLlJlc3BvbnNlcy5SZWRlZW1QYXNzY29kZVJlc3BvbnNlLlJlc3VsdBJi",
            "Cg1hY3F1aXJlZF9pdGVtGAIgAygLMksuV1VQcm90b3MuTmV0d29ya2luZy5Q",
            "bGF0Zm9ybS5SZXNwb25zZXMuUmVkZWVtUGFzc2NvZGVSZXNwb25zZS5BY3F1",
            "aXJlZEl0ZW0SHAoUYWNxdWlyZWRfaXRlbXNfcHJvdG8YAyABKAwSEAoIcGFz",
            "c2NvZGUYBCABKAkaKwoMQWNxdWlyZWRJdGVtEgwKBGl0ZW0YASABKAkSDQoF",
            "Y291bnQYAiABKAMiYwoGUmVzdWx0EgkKBVVOU0VUEAASCwoHU1VDQ0VTUxAB",
            "EhEKDU5PVF9BVkFJTEFCTEUQAhIYChRPVkVSX0lOVkVOVE9SWV9MSU1JVBAD",
            "EhQKEEFMUkVBRFlfUkVERUVNRUQQBGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Platform.Responses.RedeemPasscodeResponse), global::WUProtos.Networking.Platform.Responses.RedeemPasscodeResponse.Parser, new[]{ "Result", "AcquiredItem", "AcquiredItemsProto", "Passcode" }, null, new[]{ typeof(global::WUProtos.Networking.Platform.Responses.RedeemPasscodeResponse.Types.Result) }, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Platform.Responses.RedeemPasscodeResponse.Types.AcquiredItem), global::WUProtos.Networking.Platform.Responses.RedeemPasscodeResponse.Types.AcquiredItem.Parser, new[]{ "Item", "Count" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RedeemPasscodeResponse : pb::IMessage<RedeemPasscodeResponse> {
    private static readonly pb::MessageParser<RedeemPasscodeResponse> _parser = new pb::MessageParser<RedeemPasscodeResponse>(() => new RedeemPasscodeResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RedeemPasscodeResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Platform.Responses.RedeemPasscodeResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RedeemPasscodeResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RedeemPasscodeResponse(RedeemPasscodeResponse other) : this() {
      result_ = other.result_;
      acquiredItem_ = other.acquiredItem_.Clone();
      acquiredItemsProto_ = other.acquiredItemsProto_;
      passcode_ = other.passcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RedeemPasscodeResponse Clone() {
      return new RedeemPasscodeResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::WUProtos.Networking.Platform.Responses.RedeemPasscodeResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Networking.Platform.Responses.RedeemPasscodeResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "acquired_item" field.</summary>
    public const int AcquiredItemFieldNumber = 2;
    private static readonly pb::FieldCodec<global::WUProtos.Networking.Platform.Responses.RedeemPasscodeResponse.Types.AcquiredItem> _repeated_acquiredItem_codec
        = pb::FieldCodec.ForMessage(18, global::WUProtos.Networking.Platform.Responses.RedeemPasscodeResponse.Types.AcquiredItem.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Networking.Platform.Responses.RedeemPasscodeResponse.Types.AcquiredItem> acquiredItem_ = new pbc::RepeatedField<global::WUProtos.Networking.Platform.Responses.RedeemPasscodeResponse.Types.AcquiredItem>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Networking.Platform.Responses.RedeemPasscodeResponse.Types.AcquiredItem> AcquiredItem {
      get { return acquiredItem_; }
    }

    /// <summary>Field number for the "acquired_items_proto" field.</summary>
    public const int AcquiredItemsProtoFieldNumber = 3;
    private pb::ByteString acquiredItemsProto_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString AcquiredItemsProto {
      get { return acquiredItemsProto_; }
      set {
        acquiredItemsProto_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "passcode" field.</summary>
    public const int PasscodeFieldNumber = 4;
    private string passcode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Passcode {
      get { return passcode_; }
      set {
        passcode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RedeemPasscodeResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RedeemPasscodeResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if(!acquiredItem_.Equals(other.acquiredItem_)) return false;
      if (AcquiredItemsProto != other.AcquiredItemsProto) return false;
      if (Passcode != other.Passcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      hash ^= acquiredItem_.GetHashCode();
      if (AcquiredItemsProto.Length != 0) hash ^= AcquiredItemsProto.GetHashCode();
      if (Passcode.Length != 0) hash ^= Passcode.GetHashCode();
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
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      acquiredItem_.WriteTo(output, _repeated_acquiredItem_codec);
      if (AcquiredItemsProto.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(AcquiredItemsProto);
      }
      if (Passcode.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Passcode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      size += acquiredItem_.CalculateSize(_repeated_acquiredItem_codec);
      if (AcquiredItemsProto.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(AcquiredItemsProto);
      }
      if (Passcode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Passcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RedeemPasscodeResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      acquiredItem_.Add(other.acquiredItem_);
      if (other.AcquiredItemsProto.Length != 0) {
        AcquiredItemsProto = other.AcquiredItemsProto;
      }
      if (other.Passcode.Length != 0) {
        Passcode = other.Passcode;
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
            Result = (global::WUProtos.Networking.Platform.Responses.RedeemPasscodeResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            acquiredItem_.AddEntriesFrom(input, _repeated_acquiredItem_codec);
            break;
          }
          case 26: {
            AcquiredItemsProto = input.ReadBytes();
            break;
          }
          case 34: {
            Passcode = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the RedeemPasscodeResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("NOT_AVAILABLE")] NotAvailable = 2,
        [pbr::OriginalName("OVER_INVENTORY_LIMIT")] OverInventoryLimit = 3,
        [pbr::OriginalName("ALREADY_REDEEMED")] AlreadyRedeemed = 4,
      }

      public sealed partial class AcquiredItem : pb::IMessage<AcquiredItem> {
        private static readonly pb::MessageParser<AcquiredItem> _parser = new pb::MessageParser<AcquiredItem>(() => new AcquiredItem());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<AcquiredItem> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::WUProtos.Networking.Platform.Responses.RedeemPasscodeResponse.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public AcquiredItem() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public AcquiredItem(AcquiredItem other) : this() {
          item_ = other.item_;
          count_ = other.count_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public AcquiredItem Clone() {
          return new AcquiredItem(this);
        }

        /// <summary>Field number for the "item" field.</summary>
        public const int ItemFieldNumber = 1;
        private string item_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Item {
          get { return item_; }
          set {
            item_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "count" field.</summary>
        public const int CountFieldNumber = 2;
        private long count_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public long Count {
          get { return count_; }
          set {
            count_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as AcquiredItem);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(AcquiredItem other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Item != other.Item) return false;
          if (Count != other.Count) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Item.Length != 0) hash ^= Item.GetHashCode();
          if (Count != 0L) hash ^= Count.GetHashCode();
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
          if (Item.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Item);
          }
          if (Count != 0L) {
            output.WriteRawTag(16);
            output.WriteInt64(Count);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Item.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Item);
          }
          if (Count != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(Count);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(AcquiredItem other) {
          if (other == null) {
            return;
          }
          if (other.Item.Length != 0) {
            Item = other.Item;
          }
          if (other.Count != 0L) {
            Count = other.Count;
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
                Item = input.ReadString();
                break;
              }
              case 16: {
                Count = input.ReadInt64();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
