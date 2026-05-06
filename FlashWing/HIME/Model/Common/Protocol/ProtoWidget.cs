using FlashWing.HIME.Model.Common.Enum;
using FlashWing.HIME.Script.Model.Common.Protocol;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace FlashWing.HIME.Model.Common.Protocol
{
    [ProtoContract]
    [Serializable]
    public class ProtoWidget : ProtoBase
    {
        [ProtoMember(1)]
        public string Id;
        [ProtoMember(2)]
        public int WidgetConfigId;
        [ProtoMember(3)]
        public string WidgetGroupId;
        [ProtoMember(4)]
        public int Level;
        [ProtoMember(5)]
        public int UseLevel;
        [ProtoMember(6)]
        public WidgetQualityType QualityType;
        [ProtoMember(7)]
        public int StrengthLevel;
        [ProtoMember(10)]
        public List<ProtoAttribute> DeputyAttributes;
        [ProtoMember(11)]
        public int BattlePower;
        [ProtoMember(12)]
        public bool Locked;
        [ProtoMember(14)]
        public int State;
        [ProtoMember(15)]
        public int QualityUpTimes;
        [ProtoMember(16)]
        public int ModuleLevel;
        [ProtoMember(17)]
        public int ModuleExp;
        [ProtoMember(18)]
        public int HeresyBreakLevel;
        [ProtoMember(19)]
        public List<ProtoAttribute> ModuleAttributes;
        [ProtoMember(20)]
        public bool IsInherit;
        [ProtoMember(21)]
        public Dictionary<int, List<ProtoAttribute>> RefineAttributes;
        [ProtoMember(22)]
        public int OpenPositionNum;
        [ProtoMember(23)]
        public int RefineTimes;
    }
}
