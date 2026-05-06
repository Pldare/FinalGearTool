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
    public class ProtoAreaMission : ProtoBase
    {

        [ProtoMember(1)]
        public int Id;

        [ProtoMember(2)]
        public int AreaId;

        [ProtoMember(4)]
        public SceneType SceneType;

        [ProtoMember(5)]
        public SceneSubType SceneSubType;

        [ProtoMember(7)]
        public long MissionEndTime;

        [ProtoMember(8)]
        public bool DailyMissionCompleted;

        [ProtoMember(9)]
        public ObjState State;

        [ProtoMember(10)]
        public int RegionMapLocation;

        [ProtoMember(11)]
        public StageStatus Status;

        [ProtoMember(12)]
        public Dictionary<int, ProtoGirlBattleStatus> GirlsStatus;

        [ProtoMember(13)]
        public List<int> BattleIds;

        [ProtoMember(14)]
        public long CreateTime;

        [ProtoMember(15)]
        public int TotalExp;

        [ProtoMember(16)]
        public int TotalCoin;

        [ProtoMember(17)]
        public int MissionLevel;

        [ProtoMember(18)]
        public int MissionGroupId;

        [ProtoMember(19)]
        public string AuthCode;

        [ProtoMember(20)]
        public Dictionary<int, ProtoCombinedMachineStatus> CombinedMachineStatus;

    }
}
