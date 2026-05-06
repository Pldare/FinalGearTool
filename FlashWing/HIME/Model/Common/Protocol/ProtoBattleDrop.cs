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
    public class ProtoBattleDrop : ProtoBase
    {

        [ProtoMember(1)]
        public int DropId;

        [ProtoMember(2)]
        public int DropNum;

        [ProtoMember(3)]
        public StuffType DropStuffType;

        [ProtoMember(4)]
        public int WidgetLevel;

        [ProtoMember(5)]
        public int UseLevel;

        [ProtoMember(6)]
        public WidgetQualityType WidgetQualityType;

    }
}
