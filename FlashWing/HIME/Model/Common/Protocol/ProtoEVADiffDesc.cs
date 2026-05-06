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
    public class ProtoEVADiffDesc : ProtoBase
    {
        [ProtoMember(1)]
        public int DiffId;
        [ProtoMember(2)]
        public int CurOrder;
        [ProtoMember(3)]
        public Dictionary<int, int> StarInfo;
        [ProtoMember(4)]
        public List<int> RecieveAreaStarAward;
        [ProtoMember(5)]
        public Dictionary<int, int> DailyBattleTimes;
    }
}
