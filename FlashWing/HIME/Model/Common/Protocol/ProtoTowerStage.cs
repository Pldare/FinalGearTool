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
    public class ProtoTowerStage : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int CurTowerLayer;
        [ProtoMember(3)]
        public List<int> SuccStageIDs;
        [ProtoMember(4)]
        public Dictionary<int, List<int>> SuccExtraStageIDs;
        [ProtoMember(5)]
        public int AutoBattleStageId;
        [ProtoMember(6)]
        public long AutoBattleStopTS;
        [ProtoMember(7)]
        public int AutoBattleNum;
        [ProtoMember(8)]
        public int KillFinalBossNumToday;
        [ProtoMember(9)]
        public int AutoBattleLayerId;
        [ProtoMember(10)]
        public bool AutoBattleUseTickets;
        [ProtoMember(11)]
        public Dictionary<int, int> FinalBossStageExpandInfo;
        [ProtoMember(12)]
        public bool IsFinalBossClear;
    }
}
