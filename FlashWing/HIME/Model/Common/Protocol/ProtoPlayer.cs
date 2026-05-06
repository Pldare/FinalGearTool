using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlashWing.HIME.Model.Common;
using FlashWing.HIME.Model.Common.Enum;
using FlashWing.HIME.Model.Common.Protocol;

namespace FlashWing.HIME.Script.Model.Common.Protocol
{
    [ProtoContract]
    [Serializable]
    public class ProtoPlayer : ProtoBase
    {
        public static string TableName;
        [ProtoMember(2)]
        public string Name;
        [ProtoMember(3)]
        public int Level;
        [ProtoMember(4)]
        public int Exp;
        [ProtoMember(5)]
        public long CreateTime;
        [ProtoMember(6)]
        public long LastLoginTime;
        [ProtoMember(7)]
        public long LastLogoutTime;
        [ProtoMember(8)]
        public int AttackLevel;
        [ProtoMember(9)]
        public int AttackExp;
        [ProtoMember(10)]
        public int DefenceLevel;
        [ProtoMember(11)]
        public int DefenceExp;
        [ProtoMember(12)]
        public int ProtectLevel;
        [ProtoMember(13)]
        public int ProtectExp;
        [ProtoMember(14)]
        public int LeaderLevel;
        [ProtoMember(15)]
        public int LeaderExp;
        [ProtoMember(16)]
        public int PromotionMissionId;
        [ProtoMember(17)]
        public int OpenedRecruitQueueNum;
        [ProtoMember(18)]
        public int OpenedBuildQueueNum;
        [ProtoMember(19)]
        public int WidgetPackageCount;
        [ProtoMember(20)]
        public int RecruitValue;
        [ProtoMember(21)]
        public int BuildValue;
        [ProtoMember(22)]
        public int BgGirlId;
        [ProtoMember(23)]
        public int LimitBuildValue;
        [ProtoMember(24)]
        public bool IsPlayerInfoComplete;
        [ProtoMember(25)]
        public DateTime BirthDay;
        [ProtoMember(26)]
        public Dictionary<int, int> Guides;
        [ProtoMember(28)]
        public int PlayerTitle;
        [ProtoMember(29)]
        public int TotalRecharge;
        [ProtoMember(30)]
        public long MonthCardTimeout;
        [ProtoMember(31)]
        public long LastGetMonthCardRewardTime;
        [ProtoMember(32)]
        public int GetTotalRewardDays;
        [ProtoMember(33)]
        public long LastGetTotalRechargeRewardTime;
        [ProtoMember(34)]
        public long LastRefreshTime;
        [ProtoMember(35)]
        public int LastStageId;
        [ProtoMember(36)]
        public Dictionary<int, int> AreaMissionHistory;
        [ProtoMember(37)]
        public long SixHourMissionRefreshTime;
        [ProtoMember(39)]
        public int PersonalStoryDailyCount;
        [ProtoMember(40)]
        public long LastActivityTime;
        [ProtoMember(41)]
        public int Battle_StageId;
        [ProtoMember(42)]
        public int Battle_BattleId;
        [ProtoMember(43)]
        public int Battle_BattleGroupId;
        [ProtoMember(44)]
        public long BattleStartTime;
        [ProtoMember(45)]
        public List<DropItem> Battle_Drops;
        [ProtoMember(46)]
        public int JingGongMissionCompleteCount;
        [ProtoMember(47)]
        public int FangShouMissionCompleteCount;
        [ProtoMember(48)]
        public int HuSongMissionCompleteCount;
        [ProtoMember(49)]
        public int HotMissionCompleteCount;
        [ProtoMember(50)]
        public int DailyHotMissionCompleteCount;
        [ProtoMember(51)]
        public int NormalMissionCompleteCount;
        [ProtoMember(52)]
        public string SuccessOrders;
        [ProtoMember(53)]
        public bool HasExpedition;
        [ProtoMember(54)]
        public int RankingBattlePower;
        [ProtoMember(55)]
        public int RankingBountyPoint;
        [ProtoMember(56)]
        public int RankingAchievement;
        [ProtoMember(57)]
        public int Logintimes;
        [ProtoMember(58)]
        public int RecruitCount;
        [ProtoMember(59)]
        public byte FunctionVal;
        [ProtoMember(60)]
        public long SysMailTime;
        [ProtoMember(61)]
        public int BgId;
        [ProtoMember(62)]
        public bool ActiveBirth;
        [ProtoMember(63)]
        public int NewUnlockMissionId;
        [ProtoMember(64)]
        public int MaxPersonalStoryDailyCount;
        [ProtoMember(65)]
        public int MaxPersonalCopyDailyCount;
        [ProtoMember(66)]
        public int PersonalCopyDailyCount;
        [ProtoMember(67)]
        public bool IsClearActivityRewardList;
        [ProtoMember(68)]
        public bool MonthCardCompensation;
        [ProtoMember(69)]
        public bool IsSycUserInfoOk;
        [ProtoMember(70)]
        public bool IsRechargeCompensation;
        [ProtoMember(71)]
        public bool IsResetCorberoActivity;
        [ProtoMember(72)]
        public bool IsRepairCorberoPointReward;
        [ProtoMember(73)]
        public bool IsRepairedGirlAboutMCV;
        [ProtoMember(74)]
        public bool IsCompletedMCVPreTask;
        [ProtoMember(75)]
        public bool IsRepairExpeditionMission;
        [ProtoMember(76)]
        public bool IsRepairDailyMission;
        [ProtoMember(77)]
        public int GhostVer;
        [ProtoMember(78)]
        public bool IsRepairedAisimeiladaSkill;
        [ProtoMember(79)]
        public Dictionary<int, DailyStageCount> DailyStage;
        [ProtoMember(80)]
        public int Battle_TowerLayerId;
        [ProtoMember(81)]
        public bool IsComeBackPlayer;
        [ProtoMember(82)]
        public Dictionary<int, RewardGetState> ComeBackPlayerReward;
        [ProtoMember(83)]
        public int Battle_DailyStageDayOfWeek;
        [ProtoMember(84)]
        public int Battle_ATID;
        [ProtoMember(85)]
        public int DailyGetFriendGiftNum;
        [ProtoMember(86)]
        public int DailyGiveFriendGiftNum;
        [ProtoMember(87)]
        public long LastGetRecommendFriend;
        [ProtoMember(88)]
        public long SevenLoginJoinTime;
        [ProtoMember(89)]
        public bool IsFreeChangedName;
        [ProtoMember(90)]
        public List<int> Titles;
        [ProtoMember(103)]
        public int BattleTimes;
        [ProtoMember(104)]
        public bool RepairMonthCard;
        [ProtoMember(211)]
        public bool IsRepairCriticalPointStage;
        [ProtoMember(212)]
        public bool IsRepairGirlQuality;
        [ProtoMember(220)]
        public long TotalOnlineTime;
        [ProtoMember(221)]
        public long LastStageTime;
        [ProtoMember(222)]
        public long LastUserInfoTime;
        [ProtoMember(223)]
        public long LastLogin;
        [ProtoMember(224)]
        public int MissionCurCount;
        [ProtoMember(225)]
        public int MissionBuyCount;
        [ProtoMember(226)]
        public int CurDataFlag;
        [ProtoMember(227)]
        public long LstReTime;
        [ProtoMember(228)]
        public long Battle_EnemyUserId;
        [ProtoMember(229)]
        public int Battle_NationWarId;
        [ProtoMember(230)]
        public int Battle_NationRoomId;
        [ProtoMember(231)]
        public int Battle_NationHexId;
        [ProtoMember(232)]
        public Dictionary<int, int> NationWarStory;
        [ProtoMember(233)]
        public Dictionary<int, int> SumConsume;
        [ProtoMember(234)]
        public Dictionary<int, int> SumConsumeRewardDays;
        [ProtoMember(235)]
        public Dictionary<int, long> LastGetSumConsumeRewardTime;
        [ProtoMember(236)]
        public Dictionary<int, int> TotalRecharges;
        [ProtoMember(237)]
        public List<int> SelSkill;
        [ProtoMember(238)]
        public List<int> AllSkill;
        [ProtoMember(327)]
        public Dictionary<int, int> GetTotalRechargeRewardDays;
        [ProtoMember(328)]
        public Dictionary<ActivityType, long> ActivityLastResetTime;
        [ProtoMember(301)]
        public long BigLstReTime;
    }
}
