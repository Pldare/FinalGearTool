using FlashWing.HIME.Model.Common.Enum;
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
    public class ProtoStarship : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int Level;
        [ProtoMember(3)]
        public int Exp;
        [ProtoMember(4)]
        public int StarLevel;
        [ProtoMember(5)]
        public int StarModule;
        [ProtoMember(6)]
        public ShipQualityType ShipQualityType;
        [ProtoMember(7)]
        public List<int> Girls;
        [ProtoMember(8)]
        public int[] PosLevel;
        [ProtoMember(9)]
        public Dictionary<StarshipGunType, int> Weapons;
        [ProtoMember(10)]
        public int BattlePower;
        [ProtoMember(11)]
        public Dictionary<LocationType, string> Chips;
        [ProtoMember(12)]
        public Dictionary<string, float> ChipSuitAttr;
        [ProtoMember(13)]
        public int Suit4Id;
        [ProtoMember(14)]
        public List<int> Suit2Ids;
    }
}
