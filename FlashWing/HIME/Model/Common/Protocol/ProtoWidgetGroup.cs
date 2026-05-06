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
    public class ProtoWidgetGroup : ProtoBase
    {
        [ProtoMember(1)]
        public string Id;
        [ProtoMember(2)]
        public int GirlId;
        [ProtoMember(3)]
        public Dictionary<WidgetType, string> Widgets;
        [ProtoMember(4)]
        public int BattleGroupId;
        [ProtoMember(5)]
        public int BattlePower;
        [ProtoMember(6)]
        public bool IsActivated;
        [ProtoMember(7)]
        public bool IsExpedition;
    }
}
