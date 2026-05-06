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
    public class ProtoMCVRoomOrderProcess
    {
        [ProtoMember(1)]
        public long LastStopTimestamp;
        [ProtoMember(2)]
        public List<ProtoMCVRoomOrder> OrderList;
        [ProtoMember(3)]
        public Dictionary<int, List<int>> OrderConfIds;
    }
}
