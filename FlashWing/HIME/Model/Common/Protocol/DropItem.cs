using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlashWing.HIME.Model.Common.Enum;

namespace FlashWing.HIME.Script.Model.Common.Protocol
{
    [ProtoContract]
    [Serializable]
    public class DropItem
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int Num;
        [ProtoMember(3)]
        public StuffType StuffType;
        [ProtoMember(4)]
        public int WidgetLevel;
        [ProtoMember(5)]
        public int UseLevel;
        [ProtoMember(6)]
        public WidgetQualityType WidgetQualityType;
    }
}
