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
    public class ProtoNationalWar : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public NationWarFalg RegisterCampType;
        [ProtoMember(3)]
        public NationWarFalg CampType;
        [ProtoMember(4)]
        public int BornHex;
        [ProtoMember(5)]
        public int CurrArmyId;
        [ProtoMember(6)]
        public Dictionary<int, ProtoRoleBattleGroup> PVEGroup;
        [ProtoMember(7)]
        public Dictionary<int, ProtoRoleBattleGroup> PVPGroup;
        [ProtoMember(8)]
        public int RoomID;
        [ProtoMember(9)]
        public Dictionary<int, List<int>> StationedGirlIds;
        [ProtoMember(10)]
        public Dictionary<int, int> StationedMirror;
        [ProtoMember(11)]
        public bool IsRecieveAward;
        [ProtoMember(12)]
        public int pvpTimes;
        [ProtoMember(13)]
        public int pvpWinTimes;
        [ProtoMember(14)]
        public long SilverTicketTS;
        [ProtoMember(15)]
        public long GoldenTicketTS;
        [ProtoMember(16)]
        public int TotalHonorPoints;
        [ProtoMember(17)]
        public int TmpStationNum;
        [ProtoMember(18)]
        public int TmpPvpTimes;
        [ProtoMember(19)]
        public int TmpPvpWinTimes;
        [ProtoMember(20)]
        public long SilverTicket;
        [ProtoMember(21)]
        public long GoldenTicket;
    }
}
