using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wServer.realm;
using wServer.logic.attack;
using wServer.logic.movement;
using wServer.logic.loot;
using wServer.logic.taunt;
using wServer.logic.cond;

namespace wServer.logic
{
    partial class BehaviorDb
    {
        static _ Pets2 = Behav()
            .InitMany(0x1600, 0x1641, Behaves("Pet",
                If.Instance(new PetBehaves(), PetChasing.Instance(9, 5, 1)),
                    Cooldown.Instance(1750, new PetHealHpMp2()),
                    Cooldown.Instance(1500, new PetAttack(30, 50, 10))
            ));
    }
}