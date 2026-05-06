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
    public class ProtoRanking : ProtoBase
    {

        [ProtoMember(1)]
        public int Rank;

        [ProtoMember(2)]
        public long Id;

        [ProtoMember(3)]
        public string Name;

        [ProtoMember(4)]
        public int Level;

        [ProtoMember(5)]
        public int BgGirl;

        [ProtoMember(7)]
        public long Value;

        [ProtoMember(8)]
        public int BossLevel;

        [ProtoMember(9)]
        public int BossCompleteSecond;

        [ProtoMember(10)]
        public long BossCompleteTime;

        [ProtoMember(11)]
        public int PlayerTitle;

        [ProtoMember(12)]
        public NationWarFalg CampType;

        [ProtoMember(13)]
        public int CurrArmyId;

        [ProtoMember(14)]
        public long UserNum;

        [ProtoMember(15)]
        public List<TeamMember> BattleGirls;

    }
}
