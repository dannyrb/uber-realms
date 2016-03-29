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
        static _ EyeBalls = Behav()
            .Init(0x7f93, Behaves("Avatar EyeBall",
                    new RunBehaviors(
                        Circling.Instance(2.0f, 25, 7, 0x0f94),
                        Cooldown.Instance(5000, MultiAttack.Instance(120, 120 * (float)Math.PI / 180, 3, 0, projectileIndex: 0))
                 ))
         );
    }
}