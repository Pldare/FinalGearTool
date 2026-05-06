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
    public class ProtoSignInMonth : ProtoBase
    {
        [ProtoMember(1)]
        public int ID;
        [ProtoMember(2)]
        public int Count;
        [ProtoMember(3)]
        public int SignDay;
        [ProtoMember(4)]
        public int Month;
        [ProtoMember(5)]
        public int Year;
    }
}
