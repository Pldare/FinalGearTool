using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashWing.HIME.Model.Common
{
    public enum BattleEventTypes
    {
        Init = 1,
        FightTurn = 21,
        Move = 3,
        Attack,
        BuffChange
    }
}
