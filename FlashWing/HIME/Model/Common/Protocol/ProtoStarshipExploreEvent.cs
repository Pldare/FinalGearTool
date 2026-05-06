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
    public class ProtoStarshipExploreEvent
    {
        [ProtoMember(1)]
        public List<int> ExploreEventValue;
        [ProtoMember(2)]
        public StarshipExploreEventStarType EventQuality;
        [ProtoMember(3)]
        public StarshipExploreEventTerrainType EventTerrain;
        [ProtoMember(4)]
        public int EventPos;
    }
}
