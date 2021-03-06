// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/RedeemGoogleReceiptResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/RedeemGoogleReceiptResponse.proto</summary>
  public static partial class RedeemGoogleReceiptResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/RedeemGoogleReceiptResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RedeemGoogleReceiptResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9XVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9SZWRlZW1Hb29nbGVS",
            "ZWNlaXB0UmVzcG9uc2UucHJvdG8SHVdVUHJvdG9zLk5ldHdvcmtpbmcuUmVz",
            "cG9uc2VzImcKG1JlZGVlbUdvb2dsZVJlY2VpcHRSZXNwb25zZRIZChF0cmFu",
            "c2FjdGlvbl90b2tlbhgBIAEoCSItCgZTdGF0dXMSCQoFVU5TRVQQABILCgdT",
            "VUNDRVNTEAESCwoHRkFJTFVSRRACYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.RedeemGoogleReceiptResponse), global::WUProtos.Networking.Responses.RedeemGoogleReceiptResponse.Parser, new[]{ "TransactionToken" }, null, new[]{ typeof(global::WUProtos.Networking.Responses.RedeemGoogleReceiptResponse.Types.Status) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RedeemGoogleReceiptResponse : pb::IMessage<RedeemGoogleReceiptResponse> {
    private static readonly pb::MessageParser<RedeemGoogleReceiptResponse> _parser = new pb::MessageParser<RedeemGoogleReceiptResponse>(() => new RedeemGoogleReceiptResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RedeemGoogleReceiptResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.RedeemGoogleReceiptResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RedeemGoogleReceiptResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RedeemGoogleReceiptResponse(RedeemGoogleReceiptResponse other) : this() {
      transactionToken_ = other.transactionToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RedeemGoogleReceiptResponse Clone() {
      return new RedeemGoogleReceiptResponse(this);
    }

    /// <summary>Field number for the "transaction_token" field.</summary>
    public const int TransactionTokenFieldNumber = 1;
    private string transactionToken_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TransactionToken {
      get { return transactionToken_; }
      set {
        transactionToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RedeemGoogleReceiptResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RedeemGoogleReceiptResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TransactionToken != other.TransactionToken) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (TransactionToken.Length != 0) hash ^= TransactionToken.GetHashCode();
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
      if (TransactionToken.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(TransactionToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (TransactionToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TransactionToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RedeemGoogleReceiptResponse other) {
      if (other == null) {
        return;
      }
      if (other.TransactionToken.Length != 0) {
        TransactionToken = other.TransactionToken;
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
            TransactionToken = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the RedeemGoogleReceiptResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("FAILURE")] Failure = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
