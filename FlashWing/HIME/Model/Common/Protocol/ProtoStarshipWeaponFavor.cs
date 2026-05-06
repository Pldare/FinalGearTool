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
    public class ProtoStarshipWeaponFavor : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public Dictionary<StarshipGunType, int> Favor1;
        [ProtoMember(3)]
        public Dictionary<StarshipGunType, int> Favor2;
        [ProtoMember(4)]
        public Dictionary<StarshipGunType, int> Favor3;
    }
}
