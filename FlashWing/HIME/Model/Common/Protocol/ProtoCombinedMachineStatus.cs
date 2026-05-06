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
    public class ProtoCombinedMachineStatus
    {
        [ProtoMember(1)]
        public int Process;
        [ProtoMember(2)]
        public int Hp;
        [ProtoMember(3)]
        public int Mp;
    }
}
