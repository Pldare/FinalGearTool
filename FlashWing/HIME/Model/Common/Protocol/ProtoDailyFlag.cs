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
    public class ProtoDailyFlag
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int FreeTenRecruitTimes;
        [ProtoMember(3)]
        public int FreeATBossChallengeTimes;
        [ProtoMember(4)]
        public int NationalWarPVETimes;
        [ProtoMember(5)]
        public int NationalWarPVPTimes;
        [ProtoMember(6)]
        public int FreeReviveTimes;
        [ProtoMember(7)]
        public int PaidReviveTimes;
        [ProtoMember(8)]
        public int RecievePhaseAwardTimes;
        [ProtoMember(9)]
        public int SeasonBuyTicketTimes;
        [ProtoMember(10)]
        public int NationFinalWarBuyTicketTimes;
        [ProtoMember(11)]
        public int SakuraWarsShootingTimes;
        [ProtoMember(12)]
        public int BeforeDawnShootingTimes;
        [ProtoMember(13)]
        public int StarShipWeaponShopBuyTimes;
    }
}
