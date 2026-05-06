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
    public class ProtoGirlMirror : ProtoBase
    {
        [ProtoMember(1)]
        public int GirlId;
        [ProtoMember(2)]
        public int SkinId;
        [ProtoMember(3)]
        public int Power;
        [ProtoMember(4)]
        public bool IsActivated;
        [ProtoMember(5)]
        public Dictionary<string, float> AttrDic;
        [ProtoMember(6)]
        public Dictionary<WidgetType, int> WidgetDic;
        [ProtoMember(7)]
        public Dictionary<int, int> SkillDic;
        [ProtoMember(8)]
        public GirlQualityType GirlQuality;
        [ProtoMember(9)]
        public int GirlLevel;
    }
}
