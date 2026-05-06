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
    public class BeforeDawnOrder
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int Count;
        [ProtoMember(3)]
        public long EndTime;
        [ProtoMember(4)]
        public bool HaveReceived;
    }
}
