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
    public class ProtoStarshipPVPFormation
    {
        [ProtoMember(1)]
        public int StarshipId;
        [ProtoMember(2)]
        public StarshipMoveAction MoveAction;
    }
}
