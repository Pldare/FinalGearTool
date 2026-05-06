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
    public class BikiniBossMission
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int Proc;
        [ProtoMember(3)]
        public RewardGetState State;
    }
}
