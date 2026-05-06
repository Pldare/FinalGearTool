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
    public class ProtoATPlayer
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int AssistEnergy;
        [ProtoMember(3)]
        public long LastCalcEnergyTS;
        [ProtoMember(4)]
        public Dictionary<int, int> ATBattleCountDic;
        [ProtoMember(5)]
        public int LastChallengeBossConfId;
        [ProtoMember(6)]
        public long LastChallengeEffeciveTS;
        [ProtoMember(7)]
        public Dictionary<int, int> MonsterDamageInfo;
        [ProtoMember(8)]
        public long PreBossUuid;
        [ProtoMember(9)]
        public List<int> ChallengeSuccBossIds;
    }
}
