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
    public class ProtoMail : ProtoBase
    {
        [ProtoMember(1)]
        public string Id;
        [ProtoMember(2)]
        public string Title;
        [ProtoMember(3)]
        public string Content;
        [ProtoMember(4)]
        public string Attachment;
        [ProtoMember(5)]
        public long CreateTime;
        [ProtoMember(6)]
        public long ExpirationTime;
        [ProtoMember(7)]
        public string SysMailId;
        [ProtoMember(8)]
        public int MailTemplateId;
        [ProtoMember(9)]
        public string MailTemplateParam1;
        [ProtoMember(10)]
        public string MailTemplateParam2;
        [ProtoMember(11)]
        public string MailTemplateParam3;
        [ProtoMember(12)]
        public bool IsDeleted;
        [ProtoMember(13)]
        public bool IsCharge;
        [ProtoMember(220)]
        public FGMailType MailType;
    }
}
