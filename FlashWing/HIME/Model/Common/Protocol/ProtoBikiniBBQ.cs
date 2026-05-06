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
    public class ProtoBikiniBBQ : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int Score;
        [ProtoMember(3)]
        public int BBQID;
        [ProtoMember(4)]
        public bool IsSuccess;
        [ProtoMember(5)]
        public int Rank;
        [ProtoMember(6)]
        public int EndlessTimes;
        [ProtoMember(7)]
        public bool BattleStart;
    }
}
