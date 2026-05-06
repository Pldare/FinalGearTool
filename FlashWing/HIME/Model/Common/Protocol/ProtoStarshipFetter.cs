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
    public class ProtoStarshipFetter : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public Dictionary<int, StarshipFetter> Fetters;
        [ProtoMember(3)]
        public int MaxEftCfgId;
        [ProtoMember(4)]
        public int MaxEftCfgVal;
        [ProtoMember(5)]
        public int TotalEftOkNum;
        [ProtoMember(6)]
        public int EftCfgId;
        [ProtoMember(7)]
        public int EftOkNum;
        [ProtoMember(8)]
        public int EftCfgNum;
        [ProtoMember(9)]
        public int EftState;
    }
}
