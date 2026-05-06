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
    public class ProtoEveOfNationalWarPVE : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int CurTier;
        [ProtoMember(3)]
        public Dictionary<int, ProtoRoleBattleGroup> CurGirls;
        [ProtoMember(4)]
        public Dictionary<int, ProtoGirlBattleStatus> GirlsStatus;
        [ProtoMember(5)]
        public List<ProtoBattleMonsterStatus> CurMonstersHP;
        [ProtoMember(6)]
        public Dictionary<int, ProtoCombinedMachineStatus> CombinedMachineStatus;
    }
}
