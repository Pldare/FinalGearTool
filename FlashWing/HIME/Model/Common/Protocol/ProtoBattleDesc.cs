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
    public class ProtoBattleDesc : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public ProtoFighterDesc Winner;
        [ProtoMember(3)]
        public ProtoFighterDesc Loser;
        [ProtoMember(4)]
        public long FightBackUserId;
        [ProtoMember(5)]
        public int PointChange;
        [ProtoMember(6)]
        public int BattleLogType;
        [ProtoMember(7)]
        public long BattleEndTime;
        [ProtoMember(8)]
        public bool Reported;
    }
}
