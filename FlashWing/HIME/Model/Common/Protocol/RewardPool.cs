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
    public class RewardPool : ProtoBase
    {

        [ProtoMember(1)]
        public int PoolId;

        [ProtoMember(2)]
        public int SelectLevelIndex;

        [ProtoMember(3)]
        public Dictionary<int, int> RewardList;

    }
}
