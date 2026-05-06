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
    public class ProtoGacya : ProtoBase
    {

        [ProtoMember(1)]
        public BikiniGacyaType Id;

        [ProtoMember(2)]
        public int GacyaId;

        [ProtoMember(3)]
        public Dictionary<int, int> CurRaffleInfo;

        [ProtoMember(4)]
        public int LeftNum;

        [ProtoMember(5)]
        public int CompleteGacyaIds;

        [ProtoMember(6)]
        public Dictionary<int, ProtoGacyaHistory> RaffleHistories;

    }
}
