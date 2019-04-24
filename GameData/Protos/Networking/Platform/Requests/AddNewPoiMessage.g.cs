// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Platform/Requests/AddNewPoiMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Platform.Requests {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Platform/Requests/AddNewPoiMessage.proto</summary>
  public static partial class AddNewPoiMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Platform/Requests/AddNewPoiMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AddNewPoiMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjxXVVByb3Rvcy9OZXR3b3JraW5nL1BsYXRmb3JtL1JlcXVlc3RzL0FkZE5l",
            "d1BvaU1lc3NhZ2UucHJvdG8SJVdVUHJvdG9zLk5ldHdvcmtpbmcuUGxhdGZv",
            "cm0uUmVxdWVzdHMi/QEKEEFkZE5ld1BvaU1lc3NhZ2USDQoFdGl0bGUYASAB",
            "KAkSGAoQbG9uZ19kZXNjcmlwdGlvbhgCIAEoCRIaChJpbWFnZV9nc19maWxl",
            "X3BhdGgYAyABKAkSDgoGbGF0X2U2GAQgASgFEg4KBmxuZ19lNhgFIAEoBRIZ",
            "ChFpbWFnZV9zZXJ2aW5nX3VybBgGIAEoCRIlCh1zdXBwb3J0aW5nX2ltYWdl",
            "X2dzX2ZpbGVfcGF0aBgMIAEoCRIkChxzdXBwb3J0aW5nX2ltYWdlX3NlcnZp",
            "bmdfdXJsGA0gASgJEhwKFHN1cHBvcnRpbmdfc3RhdGVtZW50GA4gASgJYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Platform.Requests.AddNewPoiMessage), global::WUProtos.Networking.Platform.Requests.AddNewPoiMessage.Parser, new[]{ "Title", "LongDescription", "ImageGsFilePath", "LatE6", "LngE6", "ImageServingUrl", "SupportingImageGsFilePath", "SupportingImageServingUrl", "SupportingStatement" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AddNewPoiMessage : pb::IMessage<AddNewPoiMessage> {
    private static readonly pb::MessageParser<AddNewPoiMessage> _parser = new pb::MessageParser<AddNewPoiMessage>(() => new AddNewPoiMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddNewPoiMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Platform.Requests.AddNewPoiMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddNewPoiMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddNewPoiMessage(AddNewPoiMessage other) : this() {
      title_ = other.title_;
      longDescription_ = other.longDescription_;
      imageGsFilePath_ = other.imageGsFilePath_;
      latE6_ = other.latE6_;
      lngE6_ = other.lngE6_;
      imageServingUrl_ = other.imageServingUrl_;
      supportingImageGsFilePath_ = other.supportingImageGsFilePath_;
      supportingImageServingUrl_ = other.supportingImageServingUrl_;
      supportingStatement_ = other.supportingStatement_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddNewPoiMessage Clone() {
      return new AddNewPoiMessage(this);
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 1;
    private string title_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Title {
      get { return title_; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "long_description" field.</summary>
    public const int LongDescriptionFieldNumber = 2;
    private string longDescription_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LongDescription {
      get { return longDescription_; }
      set {
        longDescription_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "image_gs_file_path" field.</summary>
    public const int ImageGsFilePathFieldNumber = 3;
    private string imageGsFilePath_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ImageGsFilePath {
      get { return imageGsFilePath_; }
      set {
        imageGsFilePath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "lat_e6" field.</summary>
    public const int LatE6FieldNumber = 4;
    private int latE6_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int LatE6 {
      get { return latE6_; }
      set {
        latE6_ = value;
      }
    }

    /// <summary>Field number for the "lng_e6" field.</summary>
    public const int LngE6FieldNumber = 5;
    private int lngE6_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int LngE6 {
      get { return lngE6_; }
      set {
        lngE6_ = value;
      }
    }

    /// <summary>Field number for the "image_serving_url" field.</summary>
    public const int ImageServingUrlFieldNumber = 6;
    private string imageServingUrl_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ImageServingUrl {
      get { return imageServingUrl_; }
      set {
        imageServingUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "supporting_image_gs_file_path" field.</summary>
    public const int SupportingImageGsFilePathFieldNumber = 12;
    private string supportingImageGsFilePath_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SupportingImageGsFilePath {
      get { return supportingImageGsFilePath_; }
      set {
        supportingImageGsFilePath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "supporting_image_serving_url" field.</summary>
    public const int SupportingImageServingUrlFieldNumber = 13;
    private string supportingImageServingUrl_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SupportingImageServingUrl {
      get { return supportingImageServingUrl_; }
      set {
        supportingImageServingUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "supporting_statement" field.</summary>
    public const int SupportingStatementFieldNumber = 14;
    private string supportingStatement_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SupportingStatement {
      get { return supportingStatement_; }
      set {
        supportingStatement_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddNewPoiMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddNewPoiMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Title != other.Title) return false;
      if (LongDescription != other.LongDescription) return false;
      if (ImageGsFilePath != other.ImageGsFilePath) return false;
      if (LatE6 != other.LatE6) return false;
      if (LngE6 != other.LngE6) return false;
      if (ImageServingUrl != other.ImageServingUrl) return false;
      if (SupportingImageGsFilePath != other.SupportingImageGsFilePath) return false;
      if (SupportingImageServingUrl != other.SupportingImageServingUrl) return false;
      if (SupportingStatement != other.SupportingStatement) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Title.Length != 0) hash ^= Title.GetHashCode();
      if (LongDescription.Length != 0) hash ^= LongDescription.GetHashCode();
      if (ImageGsFilePath.Length != 0) hash ^= ImageGsFilePath.GetHashCode();
      if (LatE6 != 0) hash ^= LatE6.GetHashCode();
      if (LngE6 != 0) hash ^= LngE6.GetHashCode();
      if (ImageServingUrl.Length != 0) hash ^= ImageServingUrl.GetHashCode();
      if (SupportingImageGsFilePath.Length != 0) hash ^= SupportingImageGsFilePath.GetHashCode();
      if (SupportingImageServingUrl.Length != 0) hash ^= SupportingImageServingUrl.GetHashCode();
      if (SupportingStatement.Length != 0) hash ^= SupportingStatement.GetHashCode();
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
      if (Title.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Title);
      }
      if (LongDescription.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(LongDescription);
      }
      if (ImageGsFilePath.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ImageGsFilePath);
      }
      if (LatE6 != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(LatE6);
      }
      if (LngE6 != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(LngE6);
      }
      if (ImageServingUrl.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(ImageServingUrl);
      }
      if (SupportingImageGsFilePath.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(SupportingImageGsFilePath);
      }
      if (SupportingImageServingUrl.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(SupportingImageServingUrl);
      }
      if (SupportingStatement.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(SupportingStatement);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Title.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (LongDescription.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LongDescription);
      }
      if (ImageGsFilePath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ImageGsFilePath);
      }
      if (LatE6 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(LatE6);
      }
      if (LngE6 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(LngE6);
      }
      if (ImageServingUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ImageServingUrl);
      }
      if (SupportingImageGsFilePath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SupportingImageGsFilePath);
      }
      if (SupportingImageServingUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SupportingImageServingUrl);
      }
      if (SupportingStatement.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SupportingStatement);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddNewPoiMessage other) {
      if (other == null) {
        return;
      }
      if (other.Title.Length != 0) {
        Title = other.Title;
      }
      if (other.LongDescription.Length != 0) {
        LongDescription = other.LongDescription;
      }
      if (other.ImageGsFilePath.Length != 0) {
        ImageGsFilePath = other.ImageGsFilePath;
      }
      if (other.LatE6 != 0) {
        LatE6 = other.LatE6;
      }
      if (other.LngE6 != 0) {
        LngE6 = other.LngE6;
      }
      if (other.ImageServingUrl.Length != 0) {
        ImageServingUrl = other.ImageServingUrl;
      }
      if (other.SupportingImageGsFilePath.Length != 0) {
        SupportingImageGsFilePath = other.SupportingImageGsFilePath;
      }
      if (other.SupportingImageServingUrl.Length != 0) {
        SupportingImageServingUrl = other.SupportingImageServingUrl;
      }
      if (other.SupportingStatement.Length != 0) {
        SupportingStatement = other.SupportingStatement;
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
            Title = input.ReadString();
            break;
          }
          case 18: {
            LongDescription = input.ReadString();
            break;
          }
          case 26: {
            ImageGsFilePath = input.ReadString();
            break;
          }
          case 32: {
            LatE6 = input.ReadInt32();
            break;
          }
          case 40: {
            LngE6 = input.ReadInt32();
            break;
          }
          case 50: {
            ImageServingUrl = input.ReadString();
            break;
          }
          case 98: {
            SupportingImageGsFilePath = input.ReadString();
            break;
          }
          case 106: {
            SupportingImageServingUrl = input.ReadString();
            break;
          }
          case 114: {
            SupportingStatement = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
