using FlashWing.HIME.Model.Common.Enum;
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
    public class ProtoCriticalPointJackpot : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public List<CriticalPointRewardPoolCell> CurrentRewardPool;
        [ProtoMember(3)]
        public List<int> RewardIndexList;
        [ProtoMember(4)]
        public Dictionary<int, int> RewardedDatas;
        [ProtoMember(5)]
        public bool IsHaveFreeResetTimes;
        [ProtoMember(6)]
        public int LuckyValue;
        [ProtoMember(7)]
        public JackpotID JackpotType;
        [ProtoMember(8)]
        public int RewardPoolFreeResetTimes;
        [ProtoMember(9)]
        public int RewardPoolGoldResetTimes;
        [ProtoMember(10)]
        public int CurrJackpotDrawTimes;
    }
}
