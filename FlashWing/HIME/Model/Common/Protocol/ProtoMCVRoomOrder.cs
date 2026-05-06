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
    public class ProtoMCVRoomOrder
    {
        [ProtoMember(1)]
        public int OrderID;
        [ProtoMember(2)]
        public long StartCountDownTS;
        [ProtoMember(3)]
        public int OrderCompleteCycle;
        [ProtoMember(4)]
        public int AddPercent;
        [ProtoMember(5)]
        public int OrderStatus;
        [ProtoMember(6)]
        public bool CostEnergyFlag;
        [ProtoMember(7)]
        public List<int> CostSuccGirlIds;
        [ProtoMember(8)]
        public int UsedChips;
    }
}
