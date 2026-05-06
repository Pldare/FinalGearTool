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
    public class ProtoPang : ProtoBase
    {
        [ProtoMember(1)]
        public long ServerTime;
        [ProtoMember(2)]
        public long DelaySeconds;
        [ProtoMember(3)]
        public int Timezone;
        [ProtoMember(200)]
        public int NoticeVer;
    }
}
