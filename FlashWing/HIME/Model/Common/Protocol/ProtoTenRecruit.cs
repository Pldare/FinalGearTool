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
    public class ProtoTenRecruit : ProtoBase
    {

        [ProtoMember(1)]
        public int Id;

        [ProtoMember(2)]
        public int Num;

        [ProtoMember(3)]
        public int TotalNum;

        [ProtoMember(4)]
        public int SSRN;

        [ProtoMember(5)]
        public int SSRUPN;

        [ProtoMember(6)]
        public int URNum;

    }
}
