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
    public class ProtoRookieTask : ProtoBase
    {

        [ProtoMember(1)]
        public int Id;

        [ProtoMember(2)]
        public RookieTaskState FirstState;

        [ProtoMember(3)]
        public RewardGetState SecondState;

        [ProtoMember(4)]
        public int Process;

    }
}
