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
    public class SweetAchievement
    {
        [ProtoMember(1)]
        public int GroupId;
        [ProtoMember(2)]
        public int TableId;
        [ProtoMember(3)]
        public int Process;
        [ProtoMember(4)]
        public RewardGetState RewardState;
    }
}
