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
    public class ProtoShopItem
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int ShopId;
        [ProtoMember(3)]
        public int BuyCount;
        [ProtoMember(4)]
        public long RefreshTime;
        [ProtoMember(5)]
        public int LikeCount;
        [ProtoMember(6)]
        public ObjState State;
        [ProtoMember(7)]
        public long GiftEndTime;
    }
}
