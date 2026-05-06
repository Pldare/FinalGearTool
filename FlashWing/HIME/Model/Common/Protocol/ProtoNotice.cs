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
    public class ProtoNotice : ProtoBase
    {

        [ProtoMember(1)]
        public int Id;

        [ProtoMember(2)]
        public string NoticeName;

        [ProtoMember(3)]
        public string NoticeContent;

        [ProtoMember(4)]
        public int Array;

    }
}
