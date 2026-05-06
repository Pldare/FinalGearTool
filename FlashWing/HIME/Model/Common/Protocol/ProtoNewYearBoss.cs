using FlashWing.HIME.Script.Model.Common.Protocol;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashWing.HIME.Model.Common.Protocol
{
    public class ProtoNewYearBoss : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int CurrentFloor;
        [ProtoMember(3)]
        public int LestSpendTime;
        [ProtoMember(4)]
        public Dictionary<int, long> Scores;
        [ProtoMember(5)]
        public Dictionary<int, NewYearBossMissions> Missions;
        [ProtoMember(6)]
        public long LastRefreshTime;
        [ProtoMember(7)]
        public int WeekNum;
        [ProtoMember(8)]
        public long NextWeek;
        [ProtoMember(9)]
        public List<int> SelectedSkill;
        [ProtoMember(10)]
        public int BattleFloor;
        [ProtoMember(11)]
        public int FloorMaxDamage;
        [ProtoMember(12)]
        public int FinalyRank;
        [ProtoMember(13)]
        public List<TeamMember> BattleTeam;
        [ProtoMember(14)]
        public int Ver;
        [ProtoMember(15)]
        public int BuyTimes;
        [ProtoMember(16)]
        public List<int> CalOk;
    }
}
