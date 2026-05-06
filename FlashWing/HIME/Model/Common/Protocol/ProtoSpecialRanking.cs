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
    public class ProtoSpecialRanking : ProtoBase
    {
        [ProtoMember(2)]
        public RankingTypes rankingType;

        [ProtoMember(1)]
        public long Id;
        [ProtoMember(3)]
        public int Rank;
        [ProtoMember(4)]
        public long Value;
    }
}
