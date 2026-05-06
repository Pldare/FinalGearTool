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
    public class ProtoTexun : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public Dictionary<int, NewYearBossMissions> Missions;
        [ProtoMember(3)]
        public Dictionary<int, ProtoRoleBattleGroup> PersonalStoryBattleGroup;
        [ProtoMember(4)]
        public int Ver;
        [ProtoMember(5)]
        public int LastFight;
    }
}
