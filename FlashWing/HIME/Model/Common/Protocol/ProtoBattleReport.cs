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
    public class ProtoBattleReport : ProtoBase
    {
        [ProtoMember(1)]
        public int BattleReportNum;
        [ProtoMember(2)]
        public int BattleId;
        [ProtoMember(3)]
        public int MaxTurn;
        [ProtoMember(4)]
        public int EndTurn;
        [ProtoMember(5)]
        public bool BattleWin;
        [ProtoMember(6)]
        public bool BattleEnd;
        [ProtoMember(7)]
        public List<ProtoBattleEventData> EventQueue;
    }
}
