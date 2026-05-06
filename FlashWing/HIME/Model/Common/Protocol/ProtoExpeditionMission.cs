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
    public class ProtoExpeditionMission : ProtoBase
    {

        [ProtoMember(1)]
        public int Id;

        [ProtoMember(2)]
        public int MissionId;

        [ProtoMember(3)]
        public long StartTime;

        [ProtoMember(4)]
        public long EndTime;

        [ProtoMember(5)]
        public bool IsBigSuccess;

        [ProtoMember(6)]
        public Dictionary<string, ProtoGirlLevelInfo> WidgetGroups;

        [ProtoMember(7)]
        public int AreaId;

        [ProtoMember(8)]
        public ExpeditionMissionGetTypes MissionGetTypes;

        [ProtoMember(9)]
        public ExpeditionMissionStatus MissionStatus;

        [ProtoMember(10)]
        public ExpeditionMissionTypes MissionType;

        [ProtoMember(11)]
        public long MissionTime;

        [ProtoMember(12)]
        public ObjState State;

    }
}
