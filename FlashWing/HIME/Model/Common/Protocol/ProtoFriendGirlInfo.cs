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
    public class ProtoFriendGirlInfo : ProtoBase
    {
        [ProtoMember(1)]
        public int GirlId;
        [ProtoMember(2)]
        public int GirlSkinId;
        [ProtoMember(3)]
        public int Level;
        [ProtoMember(4)]
        public int StarLevel;
        [ProtoMember(5)]
        public int BattlePower;
        [ProtoMember(6)]
        public Dictionary<WidgetType, int> Widgets;
    }
}
