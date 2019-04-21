// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/ClaimDailyRewardResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/ClaimDailyRewardResponse.proto</summary>
  public static partial class ClaimDailyRewardResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/ClaimDailyRewardResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClaimDailyRewardResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjxXVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9DbGFpbURhaWx5UmV3",
            "YXJkUmVzcG9uc2UucHJvdG8SHVdVUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9u",
            "c2VzGidXVVByb3Rvcy9EYXRhL0xvb3QvTG9vdENvbGxlY3Rpb24ucHJvdG8i",
            "uAEKGENsYWltRGFpbHlSZXdhcmRSZXNwb25zZRIdChV0aW1lX3VudGlsX25l",
            "eHRfY2xhaW0YASABKAQSKAogZGFpbHlfcmV3YXJkX21vbnRobHlfc2NoZWR1",
            "bGVfaWQYAiABKAkSHwoXZGF5c19jbGFpbWVkX3RoaXNfbW9udGgYAyABKA0S",
            "MgoGcmV3YXJkGAQgASgLMiIuV1VQcm90b3MuRGF0YS5Mb290Lkxvb3RDb2xs",
            "ZWN0aW9uYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Loot.LootCollectionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.ClaimDailyRewardResponse), global::WUProtos.Networking.Responses.ClaimDailyRewardResponse.Parser, new[]{ "TimeUntilNextClaim", "DailyRewardMonthlyScheduleId", "DaysClaimedThisMonth", "Reward" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClaimDailyRewardResponse : pb::IMessage<ClaimDailyRewardResponse> {
    private static readonly pb::MessageParser<ClaimDailyRewardResponse> _parser = new pb::MessageParser<ClaimDailyRewardResponse>(() => new ClaimDailyRewardResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClaimDailyRewardResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.ClaimDailyRewardResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClaimDailyRewardResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClaimDailyRewardResponse(ClaimDailyRewardResponse other) : this() {
      timeUntilNextClaim_ = other.timeUntilNextClaim_;
      dailyRewardMonthlyScheduleId_ = other.dailyRewardMonthlyScheduleId_;
      daysClaimedThisMonth_ = other.daysClaimedThisMonth_;
      reward_ = other.reward_ != null ? other.reward_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClaimDailyRewardResponse Clone() {
      return new ClaimDailyRewardResponse(this);
    }

    /// <summary>Field number for the "time_until_next_claim" field.</summary>
    public const int TimeUntilNextClaimFieldNumber = 1;
    private ulong timeUntilNextClaim_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong TimeUntilNextClaim {
      get { return timeUntilNextClaim_; }
      set {
        timeUntilNextClaim_ = value;
      }
    }

    /// <summary>Field number for the "daily_reward_monthly_schedule_id" field.</summary>
    public const int DailyRewardMonthlyScheduleIdFieldNumber = 2;
    private string dailyRewardMonthlyScheduleId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DailyRewardMonthlyScheduleId {
      get { return dailyRewardMonthlyScheduleId_; }
      set {
        dailyRewardMonthlyScheduleId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "days_claimed_this_month" field.</summary>
    public const int DaysClaimedThisMonthFieldNumber = 3;
    private uint daysClaimedThisMonth_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint DaysClaimedThisMonth {
      get { return daysClaimedThisMonth_; }
      set {
        daysClaimedThisMonth_ = value;
      }
    }

    /// <summary>Field number for the "reward" field.</summary>
    public const int RewardFieldNumber = 4;
    private global::WUProtos.Data.Loot.LootCollection reward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Loot.LootCollection Reward {
      get { return reward_; }
      set {
        reward_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClaimDailyRewardResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClaimDailyRewardResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TimeUntilNextClaim != other.TimeUntilNextClaim) return false;
      if (DailyRewardMonthlyScheduleId != other.DailyRewardMonthlyScheduleId) return false;
      if (DaysClaimedThisMonth != other.DaysClaimedThisMonth) return false;
      if (!object.Equals(Reward, other.Reward)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (TimeUntilNextClaim != 0UL) hash ^= TimeUntilNextClaim.GetHashCode();
      if (DailyRewardMonthlyScheduleId.Length != 0) hash ^= DailyRewardMonthlyScheduleId.GetHashCode();
      if (DaysClaimedThisMonth != 0) hash ^= DaysClaimedThisMonth.GetHashCode();
      if (reward_ != null) hash ^= Reward.GetHashCode();
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
      if (TimeUntilNextClaim != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(TimeUntilNextClaim);
      }
      if (DailyRewardMonthlyScheduleId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DailyRewardMonthlyScheduleId);
      }
      if (DaysClaimedThisMonth != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DaysClaimedThisMonth);
      }
      if (reward_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Reward);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (TimeUntilNextClaim != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TimeUntilNextClaim);
      }
      if (DailyRewardMonthlyScheduleId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DailyRewardMonthlyScheduleId);
      }
      if (DaysClaimedThisMonth != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DaysClaimedThisMonth);
      }
      if (reward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reward);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClaimDailyRewardResponse other) {
      if (other == null) {
        return;
      }
      if (other.TimeUntilNextClaim != 0UL) {
        TimeUntilNextClaim = other.TimeUntilNextClaim;
      }
      if (other.DailyRewardMonthlyScheduleId.Length != 0) {
        DailyRewardMonthlyScheduleId = other.DailyRewardMonthlyScheduleId;
      }
      if (other.DaysClaimedThisMonth != 0) {
        DaysClaimedThisMonth = other.DaysClaimedThisMonth;
      }
      if (other.reward_ != null) {
        if (reward_ == null) {
          Reward = new global::WUProtos.Data.Loot.LootCollection();
        }
        Reward.MergeFrom(other.Reward);
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
            TimeUntilNextClaim = input.ReadUInt64();
            break;
          }
          case 18: {
            DailyRewardMonthlyScheduleId = input.ReadString();
            break;
          }
          case 24: {
            DaysClaimedThisMonth = input.ReadUInt32();
            break;
          }
          case 34: {
            if (reward_ == null) {
              Reward = new global::WUProtos.Data.Loot.LootCollection();
            }
            input.ReadMessage(Reward);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
