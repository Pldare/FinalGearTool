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
    public class ProtoMCVBase : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int CurLevel;
        [ProtoMember(3)]
        public List<int> UnlockRoomIds;
        [ProtoMember(4)]
        public int CurStatus;
        [ProtoMember(5)]
        public long StartTimestamp;
        [ProtoMember(6)]
        public ProtoMCVLowCostInfo LowCostInfo;
        [ProtoMember(7)]
        public ProtoMCVLeakSourceInfo LeakSourceInfo;
    }
}
