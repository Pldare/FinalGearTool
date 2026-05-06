using FlashWing.HIME.Model.Common.Enum;
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
    public class ProtoAchievement : ProtoBase
    {

        [ProtoMember(1)]
        public int Id;

        [ProtoMember(2)]
        public int Process;

        [ProtoMember(3)]
        public RewardGetState AchvState;

        [ProtoMember(5)]
        public Achievement AchievementType;

        [ProtoMember(6)]
        public int AchievementId;

    }
}
