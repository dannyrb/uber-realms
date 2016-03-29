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
        static _ StoneG = Behav()

                 .Init(0x0d78, Behaves("Oryx Stone Guardian Right",
                 new RunBehaviors(
                 SmoothWandering.Instance(2f, 2f),
                 Cooldown.Instance(800, MultiAttack.Instance(200, 40 * (float)Math.PI / 360, 4, 0, projectileIndex: 2)),
                 Cooldown.Instance(900, MultiAttack.Instance(200, 55 * (float)Math.PI / 360, 6, 0, projectileIndex: 1)),
                 Cooldown.Instance(850, MultiAttack.Instance(200, 70 * (float)Math.PI / 360, 4, 0, projectileIndex: 0))
                 ),
                 loot: new LootBehavior(LootDef.Empty,
                 Tuple.Create(100, new LootDef(0, 3, 0, 8,
                 Tuple.Create(0.01, (ILoot)new ItemLoot("Ancient Stone Sword"))
                 ))),
        	                      condBehaviors: new ConditionalBehavior[] {
                        new DeathPortal(0x297f, 100)
                        }
        	                     ))

                 .Init(0x0d79, Behaves("Oryx Stone Guardian Left",
                 new RunBehaviors(
                 SmoothWandering.Instance(2f, 2f),
                 Cooldown.Instance(800, MultiAttack.Instance(200, 40 * (float)Math.PI / 360, 4, 0, projectileIndex: 2)),
                 Cooldown.Instance(900, MultiAttack.Instance(200, 55 * (float)Math.PI / 360, 6, 0, projectileIndex: 1)),
                 Cooldown.Instance(850, MultiAttack.Instance(200, 70 * (float)Math.PI / 360, 4, 0, projectileIndex: 0))
                 ),
                 loot: new LootBehavior(LootDef.Empty,
                 Tuple.Create(100, new LootDef(0, 3, 0, 8,
                 Tuple.Create(0.01, (ILoot)new ItemLoot("Ancient Stone Sword"))
                 )))))

        	
        	.Init(0x0d82, Behaves("Oryx Brute",
                    Chasing.Instance(5,10,2,null),
                    new RunBehaviors(
                        new State("idle",
					Cooldown.Instance(800, MultiAttack.Instance(200, 10 * (float)Math.PI / 360, 4, 0, projectileIndex: 1))
                    ),
                    new RunBehaviors(
                        Cooldown.Instance(600, MultiAttack.Instance(10, 6 * (float)Math.PI / 180, 7)),

                        HpLesserPercent.Instance(0.2f,
                            new RunBehaviors(
                                Chasing.Instance(3, 25, 2, null),
                                
                                Cooldown.Instance(8000, Once.Instance(RingAttack.Instance(5, 0, 2, projectileIndex: 0)))
                               ))))))
        	
        	        	.Init(0x0d7f, Behaves("Oryx Insect Commander",
                    Chasing.Instance(3,10,2,null),
                    new RunBehaviors(
                        new State("idle",
					Cooldown.Instance(800, MultiAttack.Instance(200, 10 * (float)Math.PI / 360, 5)),
					 Once.Instance(TossEnemy.Instance(0 * (float)Math.PI / 180, 4, 0x0d80)),
                           	Once.Instance(TossEnemy.Instance(45 * (float)Math.PI / 180, 4, 0x0d80)),
                            Once.Instance(TossEnemy.Instance(90 * (float)Math.PI / 180, 4, 0x0d80)),
                            Once.Instance(TossEnemy.Instance(135 * (float)Math.PI / 180, 4, 0x0d80)),
                            Once.Instance(TossEnemy.Instance(180 * (float)Math.PI / 180, 4, 0x0d80)),
                            Once.Instance(TossEnemy.Instance(225 * (float)Math.PI / 180, 4, 0x0d80))
                    ),
                    new RunBehaviors(
                        Cooldown.Instance(600, MultiAttack.Instance(10, 6 * (float)Math.PI / 180, 7)),

                        HpLesserPercent.Instance(0.2f,
                            new RunBehaviors(
                                Chasing.Instance(3, 25, 2, null),
                                
                                Cooldown.Instance(8000, Once.Instance(RingAttack.Instance(5, 0, 2, projectileIndex: 0)))
                               ))))))
        	
        	        	.Init(0x0d80, Behaves("Oryx Insect Minion",
                    Chasing.Instance(3,10,2,null),
                    new RunBehaviors(
                        new State("idle",
					Cooldown.Instance(800, MultiAttack.Instance(90000, 10 * (float)Math.PI / 360, 4, 0, projectileIndex: 1))
                    ),
                    new RunBehaviors(
                        Cooldown.Instance(600, MultiAttack.Instance(10, 6 * (float)Math.PI / 180, 5)),

                        HpLesserPercent.Instance(0.2f,
                            new RunBehaviors(
                                Chasing.Instance(3, 25, 2, null),
                                
                                Cooldown.Instance(8000, Once.Instance(RingAttack.Instance(5, 0, 2, projectileIndex: 0)))
                               ))))))
        	
        	
        	        	        	.Init(0x0d7e, Behaves("Oryx Suit of Armor",
                    Chasing.Instance(3,10,2,null),
                    new RunBehaviors(
                        new State("idle",
					Cooldown.Instance(800, MultiAttack.Instance(90000, 10 * (float)Math.PI / 360, 4, 0, projectileIndex: 1))
                    ),
                    new RunBehaviors(
                        Cooldown.Instance(400, MultiAttack.Instance(10, 6 * (float)Math.PI / 180, 2)),

                        HpLesserPercent.Instance(0.2f,
                            new RunBehaviors(
                                Chasing.Instance(3, 25, 2, null),
                                
                                Cooldown.Instance(8000, Once.Instance(RingAttack.Instance(5, 0, 2, projectileIndex: 0)))
                               ))))))
        	
        	
        	
        	.Init(0x0d81, Behaves("Oryx Eye Warrior",
                    Chasing.Instance(3,10,2,null),
                    new RunBehaviors(
                        new State("idle",
                        Cooldown.Instance(1200, MultiAttack.Instance(200, 50 * (float)Math.PI / 180, 7))
                    ),
                    new RunBehaviors(
                        Cooldown.Instance(1000, MultiAttack.Instance(10, 6 * (float)Math.PI / 180, 3, 0, projectileIndex: 1)),

                        HpLesserPercent.Instance(0.2f,
                            new RunBehaviors(
                                Chasing.Instance(3, 25, 2, null),
                                
                                Cooldown.Instance(8000, Once.Instance(RingAttack.Instance(5, 0, 2, projectileIndex: 0)))
                               ))))))
        	
                       .Init(0x0d83, Behaves("Oryx Knight",
                    Chasing.Instance(3,10,2,null),
                    new RunBehaviors(
                        new State("idle",
                        Cooldown.Instance(1000, AngleAttack.Instance(45f,projectileIndex:0))
                    ),
                    new RunBehaviors(
                        Cooldown.Instance(1000, MultiAttack.Instance(10, 6 * (float)Math.PI / 180, 5, 0, projectileIndex: 0)),
                        Cooldown.Instance(800, MultiAttack.Instance(10, 6 * (float)Math.PI / 180, 1, 0, projectileIndex: 1)),
                        Cooldown.Instance(400, MultiAttack.Instance(10, 6 * (float)Math.PI / 180, 3, 0, projectileIndex: 2)),

                        HpLesserPercent.Instance(0.2f,
                            new RunBehaviors(
                                Chasing.Instance(3, 25, 2, null),
                                
                                Cooldown.Instance(8000, Once.Instance(RingAttack.Instance(5, 0, 2, projectileIndex: 0)))
                               ))))));
    }
}