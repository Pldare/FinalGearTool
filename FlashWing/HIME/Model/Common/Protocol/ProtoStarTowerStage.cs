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
    public class ProtoStarTowerStage : ProtoBase
    {

        [ProtoMember(1)]
        public int Id;

        [ProtoMember(2)]
        public Dictionary<int, int> CurLayer;

        [ProtoMember(3)]
        public int BuyTimes;

        [ProtoMember(4)]
        public int LastConfigId;

        [ProtoMember(5)]
        public List<int> BatGirl;

        [ProtoMember(6)]
        public Dictionary<int, StarTowerStageInfo> Tower1;

        [ProtoMember(7)]
        public Dictionary<int, StarTowerStageInfo> Tower2;

        [ProtoMember(8)]
        public Dictionary<int, StarTowerStageInfo> Tower3;

    }
}
