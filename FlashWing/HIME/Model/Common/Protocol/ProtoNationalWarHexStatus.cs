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
    public class ProtoNationalWarHexStatus : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public long OwnerID;
        [ProtoMember(3)]
        public NationWarFalg CampID;
        [ProtoMember(4)]
        public List<int> GirlIds;
        [ProtoMember(5)]
        public long MirrorID;
        [ProtoMember(6)]
        public long TmpUserID;
        [ProtoMember(7)]
        public bool TmpIsWin;
        [ProtoMember(8)]
        public long TmpEffectTS;
        [ProtoMember(9)]
        public long TmpDispatchTS;
        [ProtoMember(10)]
        public List<int> TmpUsedGirlIds;
        [ProtoMember(11)]
        public long monsterDamage;
        [ProtoMember(12)]
        public long LastDispatchHonorTS;
        [ProtoMember(13)]
        public long LastOwnerID;
        [ProtoMember(14)]
        public List<ProtoBattleMonsterStatus> CurMonstersHP;
    }
}
