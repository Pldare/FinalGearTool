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
    public class ProtoMCVRoomProduce
    {
        [ProtoMember(1)]
        public long LastStopTimestamp;
        [ProtoMember(2)]
        public long LastStartTimestamp;
        [ProtoMember(3)]
        public long CurEffectCycle;
        [ProtoMember(4)]
        public int AddPercent;
        [ProtoMember(5)]
        public bool CostEnergyFlag;
        [ProtoMember(6)]
        public List<int> CostSuccGirlIds;
        [ProtoMember(7)]
        public Dictionary<int, int> haveProduced;
    }
}
