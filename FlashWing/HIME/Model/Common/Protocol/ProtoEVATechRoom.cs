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
    public class ProtoEVATechRoom : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int Level;
        [ProtoMember(3)]
        public int Exp;
        [ProtoMember(4)]
        public Dictionary<int, ProtoEVAOrder> ResearchInfo;
        [ProtoMember(5)]
        public Dictionary<int, int> OrderCount;
    }
}
