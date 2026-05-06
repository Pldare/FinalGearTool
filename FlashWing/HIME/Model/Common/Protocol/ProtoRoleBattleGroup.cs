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
    public class ProtoRoleBattleGroup
    {
        [ProtoMember(1)]
        public int BattleGroupId;
        [ProtoMember(2)]
        public List<int> Girls;
    }
}
