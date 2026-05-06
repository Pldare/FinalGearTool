using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlashWing.HIME.Model.Common.Enum;
using FlashWing.HIME.Script.Model.Common.Protocol;

namespace FlashWing.HIME.Model.Common.Protocol
{
    [ProtoContract]
    [Serializable]
    public class ProtoGirl : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(3)]
        public string WidgetGroupId;
        [ProtoMember(4)] 
        public int Level;
        [ProtoMember(5)] 
        public int Exp;
        [ProtoMember(6)] 
        public int StarLevel;
        [ProtoMember(7)] 
        public Dictionary<int, int> SkillLeveList;
        [ProtoMember(10)] 
        public int CurrentSKinId;
        [ProtoMember(12)] 
        public List<int> Skins;
        [ProtoMember(13)] 
        public long CreateTime;
        [ProtoMember(14)] 
        public int GoodwillExp;
        [ProtoMember(15)] 
        public int GoodwillLevel;
        [ProtoMember(16)] 
        public bool Wedding;
        [ProtoMember(17)] 
        public int RoomPos;
        [ProtoMember(18)] 
        public int Energy;
        [ProtoMember(19)] 
        public Dictionary<int, GirlNature> NatureDic;
        [ProtoMember(20)] 
        public List<int> UsedSkillIDs;
        [ProtoMember(21)] 
        public List<int> UnusedSkillIDs;
        [ProtoMember(22)] 
        public bool ActiveBirth;
        [ProtoMember(23)] 
        public int BirthdayPresentGetYear;
        [ProtoMember(24)] 
        public int TouchSoundID;
        [ProtoMember(25)] 
        public bool GetWeddingDress;
        [ProtoMember(26)] 
        public int TalentLayer;
        [ProtoMember(27)] 
        public List<int> TalentID;
        [ProtoMember(28)] 
        public GirlQualityType GirlQualityType;
        [ProtoMember(29)] 
        public int AwakeLevel;
        [ProtoMember(30)] 
        public int StarShipId;
        [ProtoMember(31)] 
        public int GrilScore;

    }
}
