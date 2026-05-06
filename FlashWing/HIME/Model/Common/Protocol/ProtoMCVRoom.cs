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
    public class ProtoMCVRoom : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int RoomID;
        [ProtoMember(3)]
        public int RoomLevel;
        [ProtoMember(4)]
        public int RoomPos;
        [ProtoMember(5)]
        public int SrcRoom;
        [ProtoMember(6)]
        public int CurStatus;
        [ProtoMember(7)]
        public int DesRoom;
        [ProtoMember(8)]
        public long StartTimestamp;
        [ProtoMember(9)]
        public Dictionary<int, ProtoMCVDispatchGirlInfo> DispatchedGirls;
        [ProtoMember(10)]
        public int ProduceStatus;
        [ProtoMember(11)]
        public ProtoMCVRoomProduce ProduceSourceInfo;
        [ProtoMember(12)]
        public ProtoMCVRoomOrderProcess ProduceOrderInfo;
    }
}
