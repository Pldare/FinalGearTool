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
    public class ProtoChristmas : ProtoBase
    {
        [ProtoMember(25)]
        public SortedDictionary<int, int> CellRndPrize;

        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int TotalStage;
        [ProtoMember(3)]
        public int Stage;
        [ProtoMember(4)]
        public int Pos;
        [ProtoMember(5)]
        public int NextPos;
        [ProtoMember(6)]
        public bool IsFate;
        [ProtoMember(7)]
        public int EventId;
        [ProtoMember(8)]
        public int EventArg1;
        [ProtoMember(9)]
        public int EventArg2;
        [ProtoMember(10)]
        public int ReFreshCount;
        [ProtoMember(11)]
        public List<string> EventHistory;
        [ProtoMember(12)]
        public int SlowNum;
        [ProtoMember(13)]
        public int StayStatus;
        [ProtoMember(14)]
        public int TotalCellNum;
        [ProtoMember(15)]
        public List<int> TotalCellPrizes;
        [ProtoMember(17)]
        public int LuckCount;
        [ProtoMember(18)]
        public int Doubled;
        [ProtoMember(19)]
        public int Dreamed;
        [ProtoMember(20)]
        public bool Stayed;
        [ProtoMember(21)]
        public bool Slowed;
        [ProtoMember(22)]
        public bool God;
        [ProtoMember(23)]
        public int StaedNum;
    }
}
