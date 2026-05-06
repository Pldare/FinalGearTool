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
    public class ProtoGirlBattleStatus
    {
        [ProtoMember(1)]
        public int Hp;
        [ProtoMember(2)]
        public int Power;
    }
}
