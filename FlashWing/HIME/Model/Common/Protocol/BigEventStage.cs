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
    public class BigEventStage
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int CompleteNum;
        [ProtoMember(3)]
        public int StarMark;
        [ProtoMember(4)]
        public int TodayComplteNum;
        [ProtoMember(6)]
        public List<ProtoBattleMonsterStatus> MonsterStatus;
    }
}
