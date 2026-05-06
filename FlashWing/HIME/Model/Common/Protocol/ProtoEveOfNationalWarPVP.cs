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
    public class ProtoEveOfNationalWarPVP : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public long EnemyUserId;
        [ProtoMember(3)]
        public long EffectiveTS;
        [ProtoMember(4)]
        public Dictionary<int, ProtoRoleBattleGroup> CurGirls;
        [ProtoMember(5)]
        public bool IsClear;
        [ProtoMember(6)]
        public int point;
    }
}
