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
    public class ProtoTenRecruitConfig : ProtoBase
    {

        [ProtoMember(1)]
        public int ID;

        [ProtoMember(2)]
        public string Name;

        [ProtoMember(3)]
        public string IosOpenTime;

        [ProtoMember(4)]
        public string IosCloseTime;

        [ProtoMember(5)]
        public string AndOpenTime;

        [ProtoMember(6)]
        public string AndCloseTime;

        [ProtoMember(7)]
        public string ResourceName;

        [ProtoMember(8)]
        public int ListOrder;

        [ProtoMember(9)]
        public RecruitActivityType RecruitActivityType;

        [ProtoMember(10)]
        public int LibraryID;

        [ProtoMember(11)]
        public int RecruitingType;

        [ProtoMember(12)]
        public string URExchangeShopID;

    }
}
