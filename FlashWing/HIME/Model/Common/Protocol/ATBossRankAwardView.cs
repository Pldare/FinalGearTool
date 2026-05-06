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
    public class ATBossRankAwardView : ProtoBase
    {
        [ProtoMember(1)]
        public long PlayerId;
        [ProtoMember(2)]
        public string PlayerName;
        [ProtoMember(3)]
        public int ViewIcon;
        [ProtoMember(4)]
        public int DamageValue;
        [ProtoMember(5)]
        public int TitleId;
    }
}
