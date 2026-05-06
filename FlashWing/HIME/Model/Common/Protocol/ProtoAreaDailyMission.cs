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
    public class ProtoAreaDailyMission : ProtoBase
    {

        [ProtoMember(1)]
        public int Id;

        [ProtoMember(2)]
        public int MissionNo;

        [ProtoMember(3)]
        public short Process;

        [ProtoMember(4)]
        public RewardGetState RewardState;

        [ProtoMember(5)]
        public int AreaId;

        [ProtoMember(6)]
        public ObjState State;

    }
}
