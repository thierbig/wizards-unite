// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Platform/Responses/ListLoginActionResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Platform.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Platform/Responses/ListLoginActionResponse.proto</summary>
  public static partial class ListLoginActionResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Platform/Responses/ListLoginActionResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ListLoginActionResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkRXVVByb3Rvcy9OZXR3b3JraW5nL1BsYXRmb3JtL1Jlc3BvbnNlcy9MaXN0",
            "TG9naW5BY3Rpb25SZXNwb25zZS5wcm90bxImV1VQcm90b3MuTmV0d29ya2lu",
            "Zy5QbGF0Zm9ybS5SZXNwb25zZXMaH1dVUHJvdG9zL0RhdGEvTG9naW5EZXRh",
            "aWwucHJvdG8iXAoXTGlzdExvZ2luQWN0aW9uUmVzcG9uc2USDwoHc3VjY2Vz",
            "cxgBIAEoCBIwCgxsb2dpbl9kZXRhaWwYAiADKAsyGi5XVVByb3Rvcy5EYXRh",
            "LkxvZ2luRGV0YWlsYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.LoginDetailReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Platform.Responses.ListLoginActionResponse), global::WUProtos.Networking.Platform.Responses.ListLoginActionResponse.Parser, new[]{ "Success", "LoginDetail" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ListLoginActionResponse : pb::IMessage<ListLoginActionResponse> {
    private static readonly pb::MessageParser<ListLoginActionResponse> _parser = new pb::MessageParser<ListLoginActionResponse>(() => new ListLoginActionResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListLoginActionResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Platform.Responses.ListLoginActionResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListLoginActionResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListLoginActionResponse(ListLoginActionResponse other) : this() {
      success_ = other.success_;
      loginDetail_ = other.loginDetail_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListLoginActionResponse Clone() {
      return new ListLoginActionResponse(this);
    }

    /// <summary>Field number for the "success" field.</summary>
    public const int SuccessFieldNumber = 1;
    private bool success_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Success {
      get { return success_; }
      set {
        success_ = value;
      }
    }

    /// <summary>Field number for the "login_detail" field.</summary>
    public const int LoginDetailFieldNumber = 2;
    private static readonly pb::FieldCodec<global::WUProtos.Data.LoginDetail> _repeated_loginDetail_codec
        = pb::FieldCodec.ForMessage(18, global::WUProtos.Data.LoginDetail.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Data.LoginDetail> loginDetail_ = new pbc::RepeatedField<global::WUProtos.Data.LoginDetail>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Data.LoginDetail> LoginDetail {
      get { return loginDetail_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListLoginActionResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListLoginActionResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Success != other.Success) return false;
      if(!loginDetail_.Equals(other.loginDetail_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Success != false) hash ^= Success.GetHashCode();
      hash ^= loginDetail_.GetHashCode();
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
      if (Success != false) {
        output.WriteRawTag(8);
        output.WriteBool(Success);
      }
      loginDetail_.WriteTo(output, _repeated_loginDetail_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Success != false) {
        size += 1 + 1;
      }
      size += loginDetail_.CalculateSize(_repeated_loginDetail_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListLoginActionResponse other) {
      if (other == null) {
        return;
      }
      if (other.Success != false) {
        Success = other.Success;
      }
      loginDetail_.Add(other.loginDetail_);
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
            Success = input.ReadBool();
            break;
          }
          case 18: {
            loginDetail_.AddEntriesFrom(input, _repeated_loginDetail_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code