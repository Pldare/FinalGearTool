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
    public class ProtoFriend : ProtoBase
    {
        [ProtoMember(1)]
        public long Id;
        [ProtoMember(2)]
        public FriendTypes FriendType;
        [ProtoMember(3)]
        public RewardGetState FriendGiftState;
        [ProtoMember(4)]
        public long GiveGiftTime;
        [ProtoMember(5)]
        public long BecomeFriendTime;
        [ProtoMember(10)]
        public ObjState State;
    }
}
