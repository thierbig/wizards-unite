// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientWeather.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientWeather.proto</summary>
  public static partial class ClientWeatherReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientWeather.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientWeatherReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRXZWF0aGVyLnByb3RvEhRX",
            "VVByb3Rvcy5EYXRhLkNsaWVudBoiV1VQcm90b3MvRGF0YS9EaXNwbGF5V2Vh",
            "dGhlci5wcm90bxojV1VQcm90b3MvRGF0YS9HYW1lcGxheVdlYXRoZXIucHJv",
            "dG8aIFdVUHJvdG9zL0RhdGEvV2VhdGhlckFsZXJ0LnByb3RvIsIBCg1DbGll",
            "bnRXZWF0aGVyEhIKCnMyX2NlbGxfaWQYASABKAMSNgoPZGlzcGxheV93ZWF0",
            "aGVyGAIgASgLMh0uV1VQcm90b3MuRGF0YS5EaXNwbGF5V2VhdGhlchI4ChBn",
            "YW1lcGxheV93ZWF0aGVyGAMgASgLMh4uV1VQcm90b3MuRGF0YS5HYW1lcGxh",
            "eVdlYXRoZXISKwoGYWxlcnRzGAQgAygLMhsuV1VQcm90b3MuRGF0YS5XZWF0",
            "aGVyQWxlcnRiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.DisplayWeatherReflection.Descriptor, global::WUProtos.Data.GameplayWeatherReflection.Descriptor, global::WUProtos.Data.WeatherAlertReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientWeather), global::WUProtos.Data.Client.ClientWeather.Parser, new[]{ "S2CellId", "DisplayWeather", "GameplayWeather", "Alerts" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientWeather : pb::IMessage<ClientWeather> {
    private static readonly pb::MessageParser<ClientWeather> _parser = new pb::MessageParser<ClientWeather>(() => new ClientWeather());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientWeather> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientWeatherReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientWeather() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientWeather(ClientWeather other) : this() {
      s2CellId_ = other.s2CellId_;
      displayWeather_ = other.displayWeather_ != null ? other.displayWeather_.Clone() : null;
      gameplayWeather_ = other.gameplayWeather_ != null ? other.gameplayWeather_.Clone() : null;
      alerts_ = other.alerts_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientWeather Clone() {
      return new ClientWeather(this);
    }

    /// <summary>Field number for the "s2_cell_id" field.</summary>
    public const int S2CellIdFieldNumber = 1;
    private long s2CellId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long S2CellId {
      get { return s2CellId_; }
      set {
        s2CellId_ = value;
      }
    }

    /// <summary>Field number for the "display_weather" field.</summary>
    public const int DisplayWeatherFieldNumber = 2;
    private global::WUProtos.Data.DisplayWeather displayWeather_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.DisplayWeather DisplayWeather {
      get { return displayWeather_; }
      set {
        displayWeather_ = value;
      }
    }

    /// <summary>Field number for the "gameplay_weather" field.</summary>
    public const int GameplayWeatherFieldNumber = 3;
    private global::WUProtos.Data.GameplayWeather gameplayWeather_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.GameplayWeather GameplayWeather {
      get { return gameplayWeather_; }
      set {
        gameplayWeather_ = value;
      }
    }

    /// <summary>Field number for the "alerts" field.</summary>
    public const int AlertsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::WUProtos.Data.WeatherAlert> _repeated_alerts_codec
        = pb::FieldCodec.ForMessage(34, global::WUProtos.Data.WeatherAlert.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Data.WeatherAlert> alerts_ = new pbc::RepeatedField<global::WUProtos.Data.WeatherAlert>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Data.WeatherAlert> Alerts {
      get { return alerts_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientWeather);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientWeather other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (S2CellId != other.S2CellId) return false;
      if (!object.Equals(DisplayWeather, other.DisplayWeather)) return false;
      if (!object.Equals(GameplayWeather, other.GameplayWeather)) return false;
      if(!alerts_.Equals(other.alerts_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (S2CellId != 0L) hash ^= S2CellId.GetHashCode();
      if (displayWeather_ != null) hash ^= DisplayWeather.GetHashCode();
      if (gameplayWeather_ != null) hash ^= GameplayWeather.GetHashCode();
      hash ^= alerts_.GetHashCode();
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
      if (S2CellId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(S2CellId);
      }
      if (displayWeather_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DisplayWeather);
      }
      if (gameplayWeather_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(GameplayWeather);
      }
      alerts_.WriteTo(output, _repeated_alerts_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (S2CellId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(S2CellId);
      }
      if (displayWeather_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DisplayWeather);
      }
      if (gameplayWeather_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GameplayWeather);
      }
      size += alerts_.CalculateSize(_repeated_alerts_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientWeather other) {
      if (other == null) {
        return;
      }
      if (other.S2CellId != 0L) {
        S2CellId = other.S2CellId;
      }
      if (other.displayWeather_ != null) {
        if (displayWeather_ == null) {
          DisplayWeather = new global::WUProtos.Data.DisplayWeather();
        }
        DisplayWeather.MergeFrom(other.DisplayWeather);
      }
      if (other.gameplayWeather_ != null) {
        if (gameplayWeather_ == null) {
          GameplayWeather = new global::WUProtos.Data.GameplayWeather();
        }
        GameplayWeather.MergeFrom(other.GameplayWeather);
      }
      alerts_.Add(other.alerts_);
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
            S2CellId = input.ReadInt64();
            break;
          }
          case 18: {
            if (displayWeather_ == null) {
              DisplayWeather = new global::WUProtos.Data.DisplayWeather();
            }
            input.ReadMessage(DisplayWeather);
            break;
          }
          case 26: {
            if (gameplayWeather_ == null) {
              GameplayWeather = new global::WUProtos.Data.GameplayWeather();
            }
            input.ReadMessage(GameplayWeather);
            break;
          }
          case 34: {
            alerts_.AddEntriesFrom(input, _repeated_alerts_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
