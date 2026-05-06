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
    public class ProtoTower : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int TowerEnergy;
        [ProtoMember(3)]
        public long LastCalcEnergyTime;
        [ProtoMember(4)]
        public int TowerPoint;
        [ProtoMember(5)]
        public int TowerBossCount;
        [ProtoMember(7)]
        public int UsedAwardTicketNum;
        [ProtoMember(8)]
        public List<int> ClearAchievementIds;
        [ProtoMember(10)]
        public List<string> HaveRecievedRankingAward;
    }

}
