using FlashWing.HIME.Script.Model.Common.Protocol;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashWing.HIME.Model.Common.Protocol
{
    [ProtoContract]
    [Serializable]
    public class ProtoActivity : ProtoBase
    {

        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public Dictionary<int, ProtoActivityAchievement> ActivityAchievements;
        [ProtoMember(3)]
        public Dictionary<int, ProtoActivityMission> ActivityMissions;
        [ProtoMember(4)]
        public Dictionary<int, ProtoActivityDailyMission> ActivityDailyMissions;

        [ProtoMember(5)]
        public byte CorberoPointRewardGetList;

        [ProtoMember(6)]
        public RewardPool CurrentRewardPool;

        [ProtoMember(7)]
        public Dictionary<int, int> PointConversionDatas;

        [ProtoMember(8)]
        public int ActivityMissionDailyCompleteCount;

        [ProtoMember(9)]
        public long ActivityOpenTime;

        [ProtoMember(10)]
        public long ActivityCloseTime;

    }
}
