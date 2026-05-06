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
    public class BubbleInfo
    {
        [ProtoMember(1)]
        public int BubbleId;
        [ProtoMember(2)]
        public long CanRecieveTS;
        [ProtoMember(3)]
        public bool IsReceived;
        [ProtoMember(4)]
        public int StepId;
    }
}
