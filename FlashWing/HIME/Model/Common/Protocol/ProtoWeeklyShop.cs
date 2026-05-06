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
    public class ProtoWeeklyShop
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public string WeeklyShopList;
        [ProtoMember(3)]
        public long LastRefreshTime;
        [ProtoMember(4)]
        public int RefreshCount;
        [ProtoMember(5)]
        public int TotalRefreshCount;
        [ProtoMember(6)]
        public ObjState State;
    }
}
