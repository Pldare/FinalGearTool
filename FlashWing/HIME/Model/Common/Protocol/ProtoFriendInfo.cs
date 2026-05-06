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
    public class ProtoFriendInfo : ProtoBase
    {
        [ProtoMember(1)]
        public long Id;
        [ProtoMember(2)]
        public int HeadGirlId;
        [ProtoMember(3)]
        public int HeadGirlSkinId;
        [ProtoMember(4)]
        public int HeadGirlLevel;
        [ProtoMember(5)]
        public int HeadGirlStarLevel;
        [ProtoMember(6)]
        public int Level;
        [ProtoMember(7)]
        public string Name;
        [ProtoMember(8)]
        public int PlayerTitle;
        [ProtoMember(9)]
        public long LastLoginTime;
        [ProtoMember(10)]
        public int BattlePower;
        [ProtoMember(11)]
        public ProtoFriendGirlInfo[] Girls;
        [ProtoMember(12)]
        public ProtoFriendData FriendData;
    }
}
