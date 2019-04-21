// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/GetGreenhouseDetailsResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/GetGreenhouseDetailsResponse.proto</summary>
  public static partial class GetGreenhouseDetailsResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/GetGreenhouseDetailsResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetGreenhouseDetailsResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBXVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9HZXRHcmVlbmhvdXNl",
            "RGV0YWlsc1Jlc3BvbnNlLnByb3RvEh1XVVByb3Rvcy5OZXR3b3JraW5nLlJl",
            "c3BvbnNlcxoeV1VQcm90b3MvRGF0YS9Qb2lEZXRhaWxzLnByb3RvGiVXVVBy",
            "b3Rvcy9FbnVtcy9Qb2lBY2Nlc3NpYmlsaXR5LnByb3RvIp8BChxHZXRHcmVl",
            "bmhvdXNlRGV0YWlsc1Jlc3BvbnNlEhIKCnBhcnRuZXJfaWQYASABKAkSLgoL",
            "cG9pX2RldGFpbHMYAiABKAsyGS5XVVByb3Rvcy5EYXRhLlBvaURldGFpbHMS",
            "OwoRcG9pX2FjY2Vzc2liaWxpdHkYAyABKA4yIC5XVVByb3Rvcy5FbnVtcy5Q",
            "b2lBY2Nlc3NpYmlsaXR5YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.PoiDetailsReflection.Descriptor, global::WUProtos.Enums.PoiAccessibilityReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.GetGreenhouseDetailsResponse), global::WUProtos.Networking.Responses.GetGreenhouseDetailsResponse.Parser, new[]{ "PartnerId", "PoiDetails", "PoiAccessibility" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetGreenhouseDetailsResponse : pb::IMessage<GetGreenhouseDetailsResponse> {
    private static readonly pb::MessageParser<GetGreenhouseDetailsResponse> _parser = new pb::MessageParser<GetGreenhouseDetailsResponse>(() => new GetGreenhouseDetailsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetGreenhouseDetailsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.GetGreenhouseDetailsResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGreenhouseDetailsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGreenhouseDetailsResponse(GetGreenhouseDetailsResponse other) : this() {
      partnerId_ = other.partnerId_;
      poiDetails_ = other.poiDetails_ != null ? other.poiDetails_.Clone() : null;
      poiAccessibility_ = other.poiAccessibility_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGreenhouseDetailsResponse Clone() {
      return new GetGreenhouseDetailsResponse(this);
    }

    /// <summary>Field number for the "partner_id" field.</summary>
    public const int PartnerIdFieldNumber = 1;
    private string partnerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PartnerId {
      get { return partnerId_; }
      set {
        partnerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "poi_details" field.</summary>
    public const int PoiDetailsFieldNumber = 2;
    private global::WUProtos.Data.PoiDetails poiDetails_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.PoiDetails PoiDetails {
      get { return poiDetails_; }
      set {
        poiDetails_ = value;
      }
    }

    /// <summary>Field number for the "poi_accessibility" field.</summary>
    public const int PoiAccessibilityFieldNumber = 3;
    private global::WUProtos.Enums.PoiAccessibility poiAccessibility_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Enums.PoiAccessibility PoiAccessibility {
      get { return poiAccessibility_; }
      set {
        poiAccessibility_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetGreenhouseDetailsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetGreenhouseDetailsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PartnerId != other.PartnerId) return false;
      if (!object.Equals(PoiDetails, other.PoiDetails)) return false;
      if (PoiAccessibility != other.PoiAccessibility) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PartnerId.Length != 0) hash ^= PartnerId.GetHashCode();
      if (poiDetails_ != null) hash ^= PoiDetails.GetHashCode();
      if (PoiAccessibility != 0) hash ^= PoiAccessibility.GetHashCode();
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
      if (PartnerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PartnerId);
      }
      if (poiDetails_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PoiDetails);
      }
      if (PoiAccessibility != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) PoiAccessibility);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PartnerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PartnerId);
      }
      if (poiDetails_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PoiDetails);
      }
      if (PoiAccessibility != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PoiAccessibility);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetGreenhouseDetailsResponse other) {
      if (other == null) {
        return;
      }
      if (other.PartnerId.Length != 0) {
        PartnerId = other.PartnerId;
      }
      if (other.poiDetails_ != null) {
        if (poiDetails_ == null) {
          PoiDetails = new global::WUProtos.Data.PoiDetails();
        }
        PoiDetails.MergeFrom(other.PoiDetails);
      }
      if (other.PoiAccessibility != 0) {
        PoiAccessibility = other.PoiAccessibility;
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
            PartnerId = input.ReadString();
            break;
          }
          case 18: {
            if (poiDetails_ == null) {
              PoiDetails = new global::WUProtos.Data.PoiDetails();
            }
            input.ReadMessage(PoiDetails);
            break;
          }
          case 24: {
            PoiAccessibility = (global::WUProtos.Enums.PoiAccessibility) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
