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
    public class ProtoStarshipExploreChapter
    {
        [ProtoMember(1)]
        public Dictionary<int, int> Stars;
        [ProtoMember(2)]
        public List<int> StarAward;
        [ProtoMember(3)]
        public int CheckPointValue;
        [ProtoMember(4)]
        public bool IsChapterComplete;
        [ProtoMember(5)]
        public int CheckPoint;
    }
}
