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
    public class ProtoEVABase : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int Phy;
        [ProtoMember(3)]
        public int ChallengedTimes;
        [ProtoMember(4)]
        public int BoughtTicketTimes;
        [ProtoMember(5)]
        public Dictionary<int, int> AreaDonation;
        [ProtoMember(6)]
        public long LastCalcPhyTimestamp;
        [ProtoMember(7)]
        public long LastRecoverChallengeTimesTS;
        [ProtoMember(8)]
        public int BoughtPhyTimes;
        [ProtoMember(9)]
        public Dictionary<int, int> LimitBossDic;
        [ProtoMember(10)]
        public List<string> HaveRecievedAwardFlags;
        [ProtoMember(11)]
        public List<int> AreaAwardFlags;
        [ProtoMember(12)]
        public List<int> ShopAwardFlag;
        [ProtoMember(13)]
        public int StageDropPilotItemNum;
    }
}
