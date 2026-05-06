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
    public class ProtoSeriesLogin : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int CurDay;
        [ProtoMember(3)]
        public long LastRecievedTS;
        [ProtoMember(4)]
        public long EndActivityTS;
        [ProtoMember(5)]
        public long StartActivityTs;
    }
}
