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
    public class ProtoNationalWarBattleDesc : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public ProtoNationalWarFighterDesc Winner;
        [ProtoMember(3)]
        public ProtoNationalWarFighterDesc Loser;
        [ProtoMember(7)]
        public long BattleEndTime;
        [ProtoMember(8)]
        public bool Reported;
    }
}
