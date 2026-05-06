using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashWing.HIME.Script.Model.Common.Protocol
{
    [ProtoContract]
    [Serializable]
    public class ResponsePack
    {
        [ProtoMember(1)]
        public bool IsGZip;
        [ProtoMember(2)]
        public byte[] Data;
        [ProtoMember(3)]
        public int DataLen;
    }
}
