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
    public class ProtoATRecordForView : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public List<ATBossView> IInitiateOthersLst;
        [ProtoMember(3)]
        public List<ATBossView> OthersInviteMeLst;
        [ProtoMember(4)]
        public List<ATBossView> IHelpedOthersLst;
        [ProtoMember(5)]
        public long LastRefreshOthersInviteMeLstTS;
    }
}
