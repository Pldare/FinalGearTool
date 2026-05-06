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
    public class ProtoMCVPreTaskActivity : ProtoBase
    {
        [ProtoMember(1)]
        public int ActId;
        [ProtoMember(2)]
        public List<ProtoMCVPreTaskRoomInfo> RoomsInfo;
        [ProtoMember(3)]
        public string StageIds;
        [ProtoMember(4)]
        public bool IsFistPlayPlot;
    }
}
