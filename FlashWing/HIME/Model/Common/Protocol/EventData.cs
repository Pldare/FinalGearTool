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
    public class EventData
    {
        [ProtoMember(1)]
        public int EID;
        [ProtoMember(2)]
        public int Data;
    }
}
