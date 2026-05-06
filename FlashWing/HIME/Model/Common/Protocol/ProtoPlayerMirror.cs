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
    public class ProtoPlayerMirror : ProtoBase
    {
        [ProtoMember(1)]
        public long Id;
        [ProtoMember(2)]
        public List<ProtoGirlMirror> Girls;
        [ProtoMember(3)]
        public int BGGirlId;
        [ProtoMember(4)]
        public int PlayerLvl;
        [ProtoMember(5)]
        public string PlayerName;
        [ProtoMember(6)]
        public int TitleId;
        [ProtoMember(7)]
        public int SeasonRank;
        [ProtoMember(8)]
        public int SeasonPoint;
        [ProtoMember(9)]
        public int CurrArmyId;
    }
}
