using FlashWing.HIME.Model.Common.Enum;
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
    public class ProtoBattleEventData
    {
        [ProtoMember(1)]
        public int Turn;
        [ProtoMember(2)]
        public BattleEventTypes BattleEventType;
        [ProtoMember(3)]
        public int AttackerHP;
        [ProtoMember(4)]
        public int AttackerShieldHp;
        [ProtoMember(5)]
        public StarshipMoveAction AttackerMoveAction;
        [ProtoMember(6)]
        public int AttackerInitPosition;
        [ProtoMember(7)]
        public int DefenderHP;
        [ProtoMember(8)]
        public int DefenderShieldHp;
        [ProtoMember(9)]
        public StarshipMoveAction DefenderMoveAction;
        [ProtoMember(10)]
        public int DefenderInitPosition;
        [ProtoMember(11)]
        public int PositionBefore;
        [ProtoMember(12)]
        public int PositionAfter;
        [ProtoMember(13)]
        public StarshipAttackUnitTypes AttackerType;
        [ProtoMember(14)]
        public StarshipAttackUnitTypes TargetType;
        [ProtoMember(15)]
        public List<StarshipAttackUnitTypes> AttackUnits;
        [ProtoMember(16)]
        public int SkillId;
        [ProtoMember(17)]
        public int Damage;
        [ProtoMember(18)]
        public int ShieldDamage;
        [ProtoMember(19)]
        public DamageTypes DamageType;
        [ProtoMember(20)]
        public Dictionary<StarshipAttackUnitTypes, List<ProtoEffectChange>> BuffEffectChange;
    }
}
