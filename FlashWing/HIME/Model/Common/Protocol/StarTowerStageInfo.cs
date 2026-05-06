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
    public class StarTowerStageInfo
    {

        [ProtoMember(1)]
        public int Diff;

        [ProtoMember(2)]
        public int Stage;

        [ProtoMember(3)]
        public int ShipStage;

        [ProtoMember(4)]
        public int FastRound;

        [ProtoMember(5)]
        public int FastTime;

    }
}
