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
    public class ProtoATAssistRecord : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public List<long> IInitiateOthersLst;
        [ProtoMember(3)]
        public List<long> OthersInviteMeLst;
        [ProtoMember(4)]
        public List<long> IHelpedOthersLst;
        [ProtoMember(5)]
        public long LastRefreshOthersInviteMeLstTS;
    }
}
