// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/PerformanceSnapshot.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data {

  /// <summary>Holder for reflection information generated from WUProtos/Data/PerformanceSnapshot.proto</summary>
  public static partial class PerformanceSnapshotReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/PerformanceSnapshot.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PerformanceSnapshotReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidXVVByb3Rvcy9EYXRhL1BlcmZvcm1hbmNlU25hcHNob3QucHJvdG8SDVdV",
            "UHJvdG9zLkRhdGEi8wEKE1BlcmZvcm1hbmNlU25hcHNob3QSSwoTZnJhbWVf",
            "bWV0cmljX3JhbmdlcxgBIAMoCzIuLldVUHJvdG9zLkRhdGEuUGVyZm9ybWFu",
            "Y2VTbmFwc2hvdC5Eb3VibGVSYW5nZRIZChFvbl9kZW1hbmRfbWV0cmljcxgC",
            "IAMoARIUCgxmcmFtZV9udW1iZXIYAyABKAMSGQoRcmVhbF90aW1lX3NlY29u",
            "ZHMYBCABKAISDQoFbGFiZWwYBSABKAkaNAoLRG91YmxlUmFuZ2USCwoDYXZn",
            "GAEgASgBEgsKA21pbhgCIAEoARILCgNtYXgYAyABKAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.PerformanceSnapshot), global::WUProtos.Data.PerformanceSnapshot.Parser, new[]{ "FrameMetricRanges", "OnDemandMetrics", "FrameNumber", "RealTimeSeconds", "Label" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.PerformanceSnapshot.Types.DoubleRange), global::WUProtos.Data.PerformanceSnapshot.Types.DoubleRange.Parser, new[]{ "Avg", "Min", "Max" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PerformanceSnapshot : pb::IMessage<PerformanceSnapshot> {
    private static readonly pb::MessageParser<PerformanceSnapshot> _parser = new pb::MessageParser<PerformanceSnapshot>(() => new PerformanceSnapshot());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PerformanceSnapshot> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.PerformanceSnapshotReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PerformanceSnapshot() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PerformanceSnapshot(PerformanceSnapshot other) : this() {
      frameMetricRanges_ = other.frameMetricRanges_.Clone();
      onDemandMetrics_ = other.onDemandMetrics_.Clone();
      frameNumber_ = other.frameNumber_;
      realTimeSeconds_ = other.realTimeSeconds_;
      label_ = other.label_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PerformanceSnapshot Clone() {
      return new PerformanceSnapshot(this);
    }

    /// <summary>Field number for the "frame_metric_ranges" field.</summary>
    public const int FrameMetricRangesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::WUProtos.Data.PerformanceSnapshot.Types.DoubleRange> _repeated_frameMetricRanges_codec
        = pb::FieldCodec.ForMessage(10, global::WUProtos.Data.PerformanceSnapshot.Types.DoubleRange.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Data.PerformanceSnapshot.Types.DoubleRange> frameMetricRanges_ = new pbc::RepeatedField<global::WUProtos.Data.PerformanceSnapshot.Types.DoubleRange>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Data.PerformanceSnapshot.Types.DoubleRange> FrameMetricRanges {
      get { return frameMetricRanges_; }
    }

    /// <summary>Field number for the "on_demand_metrics" field.</summary>
    public const int OnDemandMetricsFieldNumber = 2;
    private static readonly pb::FieldCodec<double> _repeated_onDemandMetrics_codec
        = pb::FieldCodec.ForDouble(18);
    private readonly pbc::RepeatedField<double> onDemandMetrics_ = new pbc::RepeatedField<double>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<double> OnDemandMetrics {
      get { return onDemandMetrics_; }
    }

    /// <summary>Field number for the "frame_number" field.</summary>
    public const int FrameNumberFieldNumber = 3;
    private long frameNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long FrameNumber {
      get { return frameNumber_; }
      set {
        frameNumber_ = value;
      }
    }

    /// <summary>Field number for the "real_time_seconds" field.</summary>
    public const int RealTimeSecondsFieldNumber = 4;
    private float realTimeSeconds_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float RealTimeSeconds {
      get { return realTimeSeconds_; }
      set {
        realTimeSeconds_ = value;
      }
    }

    /// <summary>Field number for the "label" field.</summary>
    public const int LabelFieldNumber = 5;
    private string label_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Label {
      get { return label_; }
      set {
        label_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PerformanceSnapshot);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PerformanceSnapshot other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!frameMetricRanges_.Equals(other.frameMetricRanges_)) return false;
      if(!onDemandMetrics_.Equals(other.onDemandMetrics_)) return false;
      if (FrameNumber != other.FrameNumber) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(RealTimeSeconds, other.RealTimeSeconds)) return false;
      if (Label != other.Label) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= frameMetricRanges_.GetHashCode();
      hash ^= onDemandMetrics_.GetHashCode();
      if (FrameNumber != 0L) hash ^= FrameNumber.GetHashCode();
      if (RealTimeSeconds != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(RealTimeSeconds);
      if (Label.Length != 0) hash ^= Label.GetHashCode();
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
      frameMetricRanges_.WriteTo(output, _repeated_frameMetricRanges_codec);
      onDemandMetrics_.WriteTo(output, _repeated_onDemandMetrics_codec);
      if (FrameNumber != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(FrameNumber);
      }
      if (RealTimeSeconds != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(RealTimeSeconds);
      }
      if (Label.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Label);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += frameMetricRanges_.CalculateSize(_repeated_frameMetricRanges_codec);
      size += onDemandMetrics_.CalculateSize(_repeated_onDemandMetrics_codec);
      if (FrameNumber != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(FrameNumber);
      }
      if (RealTimeSeconds != 0F) {
        size += 1 + 4;
      }
      if (Label.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Label);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PerformanceSnapshot other) {
      if (other == null) {
        return;
      }
      frameMetricRanges_.Add(other.frameMetricRanges_);
      onDemandMetrics_.Add(other.onDemandMetrics_);
      if (other.FrameNumber != 0L) {
        FrameNumber = other.FrameNumber;
      }
      if (other.RealTimeSeconds != 0F) {
        RealTimeSeconds = other.RealTimeSeconds;
      }
      if (other.Label.Length != 0) {
        Label = other.Label;
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
            frameMetricRanges_.AddEntriesFrom(input, _repeated_frameMetricRanges_codec);
            break;
          }
          case 18:
          case 17: {
            onDemandMetrics_.AddEntriesFrom(input, _repeated_onDemandMetrics_codec);
            break;
          }
          case 24: {
            FrameNumber = input.ReadInt64();
            break;
          }
          case 37: {
            RealTimeSeconds = input.ReadFloat();
            break;
          }
          case 42: {
            Label = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the PerformanceSnapshot message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class DoubleRange : pb::IMessage<DoubleRange> {
        private static readonly pb::MessageParser<DoubleRange> _parser = new pb::MessageParser<DoubleRange>(() => new DoubleRange());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<DoubleRange> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::WUProtos.Data.PerformanceSnapshot.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public DoubleRange() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public DoubleRange(DoubleRange other) : this() {
          avg_ = other.avg_;
          min_ = other.min_;
          max_ = other.max_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public DoubleRange Clone() {
          return new DoubleRange(this);
        }

        /// <summary>Field number for the "avg" field.</summary>
        public const int AvgFieldNumber = 1;
        private double avg_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public double Avg {
          get { return avg_; }
          set {
            avg_ = value;
          }
        }

        /// <summary>Field number for the "min" field.</summary>
        public const int MinFieldNumber = 2;
        private double min_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public double Min {
          get { return min_; }
          set {
            min_ = value;
          }
        }

        /// <summary>Field number for the "max" field.</summary>
        public const int MaxFieldNumber = 3;
        private double max_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public double Max {
          get { return max_; }
          set {
            max_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as DoubleRange);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(DoubleRange other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Avg, other.Avg)) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Min, other.Min)) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Max, other.Max)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Avg != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Avg);
          if (Min != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Min);
          if (Max != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Max);
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
          if (Avg != 0D) {
            output.WriteRawTag(9);
            output.WriteDouble(Avg);
          }
          if (Min != 0D) {
            output.WriteRawTag(17);
            output.WriteDouble(Min);
          }
          if (Max != 0D) {
            output.WriteRawTag(25);
            output.WriteDouble(Max);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Avg != 0D) {
            size += 1 + 8;
          }
          if (Min != 0D) {
            size += 1 + 8;
          }
          if (Max != 0D) {
            size += 1 + 8;
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(DoubleRange other) {
          if (other == null) {
            return;
          }
          if (other.Avg != 0D) {
            Avg = other.Avg;
          }
          if (other.Min != 0D) {
            Min = other.Min;
          }
          if (other.Max != 0D) {
            Max = other.Max;
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
              case 9: {
                Avg = input.ReadDouble();
                break;
              }
              case 17: {
                Min = input.ReadDouble();
                break;
              }
              case 25: {
                Max = input.ReadDouble();
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
