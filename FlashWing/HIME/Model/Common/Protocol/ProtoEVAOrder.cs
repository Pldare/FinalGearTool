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
    public class ProtoEVAOrder : ProtoBase
    {
        [ProtoMember(1)]
        public int ID;
        [ProtoMember(2)]
        public bool IsUnlock;
        [ProtoMember(3)]
        public int OrderID;
        [ProtoMember(4)]
        public int ReduceTimeLength;
        [ProtoMember(5)]
        public long StartTimestamp;
        [ProtoMember(6)]
        public int TechEffectReduceTimeLength;
    }
}
