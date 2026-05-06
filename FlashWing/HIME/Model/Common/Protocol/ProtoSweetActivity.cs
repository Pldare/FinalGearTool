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
    public class ProtoSweetActivity : ProtoBase
    {
        [ProtoMember(8)]
        public long LastRestoreTime;

        [ProtoMember(9)]
        public int TotalExp;

        [ProtoMember(10)]
        public int TotalCoin;

        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public long ActivityOpenTime;
        [ProtoMember(3)]
        public long ActivityCloseTime;
        [ProtoMember(4)]
        public int PhyBuyTimes;
        [ProtoMember(5)]
        public Dictionary<int, SweetGirl> SweetGirls;
        [ProtoMember(6)]
        public Dictionary<int, SweetStage> SweetStages;
        [ProtoMember(7)]
        public Dictionary<int, SweetAchievement> SweetAchievements;
    }
}
