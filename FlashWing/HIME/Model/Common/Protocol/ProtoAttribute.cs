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
    public class ProtoAttribute
    {
        [ProtoMember(1)]
        public string AttributeName;
        [ProtoMember(2)]
        public float AttributeValue;
        [ProtoMember(3)]
        public float Min;
        [ProtoMember(4)]
        public float Max;
        [ProtoMember(5)]
        public bool IsNew;
    }
}
