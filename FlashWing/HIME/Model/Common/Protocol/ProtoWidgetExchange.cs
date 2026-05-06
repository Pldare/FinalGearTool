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
    public class ProtoWidgetExchange : ProtoBase
    {

        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public Dictionary<int, int> ExchangeInfo;
        [ProtoMember(3)]
        public List<int> GetAwardInfo;
        [ProtoMember(4)]
        public List<int> GetBigSaleInfo;
}
}
