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
    public class ProtoFriendData : ProtoBase
    {
        [ProtoMember(1)]
        public int StoryProgress;
        [ProtoMember(2)]
        public int UnLockArea;
        [ProtoMember(3)]
        public int StageProgress;
        [ProtoMember(4)]
        public int WidgetCount;
        [ProtoMember(5)]
        public int WeaponCount;
        [ProtoMember(6)]
        public int GirlCount;
        [ProtoMember(7)]
        public int GirlSSRCount;
        [ProtoMember(8)]
        public int BountyPoint;
        [ProtoMember(9)]
        public int MissionCompleteCount;
        [ProtoMember(10)]
        public int HotMissionCompleteCount;
        [ProtoMember(11)]
        public int BattleMaxDamage;
        [ProtoMember(12)]
        public int StageMaxDamage;
        [ProtoMember(13)]
        public int SkillEnemyCount;
        [ProtoMember(14)]
        public int UseSkillCount;
        [ProtoMember(15)]
        public DateTime BirthDay;
        [ProtoMember(16)]
        public int PlayerExp;
        [ProtoMember(17)]
        public int FriendCount;
        [ProtoMember(18)]
        public int CollectWidgetCount;
    }
}
