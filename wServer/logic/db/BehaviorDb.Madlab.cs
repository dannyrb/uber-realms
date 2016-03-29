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
        static _ Madlab = Behav()
            .Init(0x0976, Behaves("Dr Terrible",
        	    new RunBehaviors(
					new State("idle",
                        SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                        If.Instance(
                            IsEntityPresent.Instance(7, null),
                            new RunBehaviors(
                            SetState.Instance("attack")
                           )
                           )
                       ),
        	               new State("attack",
                        Cooldown.Instance(5000, TossEnemy.Instance(0f, 4f, 0x0978)),
                        Cooldown.Instance(15000, TossEnemy.Instance(0f, 4f, 0x12aa)),
                        SimpleWandering.Instance(2, 1)
                       ),
                    Cooldown.Instance(1000,
                        Rand.Instance(
                            new RandomTaunt(0.01, "Taste Posion"),
                            new RandomTaunt(0.01, "Run while you still can!")
                           )),
        	                HpLesserPercent.Instance(0.2500f,
                            new RunBehaviors(
                                Chasing.Instance(3, 25, 2, null),
                                Once.Instance(SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)),
                                Once.Instance(SpawnMinionImmediate.Instance(0x1e23, 6, 3, 3)),
                                If.Instance(
                                    IsEntityPresent.Instance(20000, 0x1e23),
                                    SetState.Instance("heal")                                  
                                )
                                
                            )
						  )
                        ),
        	                      new State("heal",
        	                    new RunBehaviors(
                                Once.Instance(SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)),
                                Heal.Instance(100, 100000, 0x0976),
                              
                                IfNot.Instance(
                                    IsEntityPresent.Instance(20000, 0x1e23),
                                    SetState.Instance("idle")                               
                                )
                                
                            )                            
                        ),
        	                                
        	          new QueuedBehavior(
                    CooldownExact.Instance(3000, UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable))
                   ),
					loot: new LootBehavior(LootDef.Empty,
                        Tuple.Create(100, new LootDef(0, 2, 0, 2,
                            Tuple.Create(0.01, (ILoot)new ItemLoot("Robe of the Mad Scientist")),
                            Tuple.Create(0.01, (ILoot)new ItemLoot("Scepter of Fulmination")),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Def)),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Wis))
                ))
        	                      	                      )))
				
			.Init(0x0978, Behaves("Green Potion",
					condBehaviors: new ConditionalBehavior[] {
					new OnDeath(Once.Instance(RingAttack.Instance(8, 0, 2, projectileIndex: 0)))
        	                      }
        	                     ))
        	
			.Init(0x12aa, Behaves("Turret Attack",
                    new RunBehaviors(
                     Cooldown.Instance(1000, MultiAttack.Instance(10, 10 * (float)Math.PI / 180, 2, 0, projectileIndex: 0))
                ))
        	)
        	
			.Init(0x0979, Behaves("Mini Bot",
					Chasing.Instance(5,10,2,null),
                    new RunBehaviors(
                        Cooldown.Instance(900, MultiAttack.Instance(10, 10 * (float)Math.PI / 180, 2, 0, projectileIndex: 0))
                        
                    )
				))
			
			.Init(0x0980, Behaves("Rampage Cyborg",
					Chasing.Instance(5,10,2,null),
                    new RunBehaviors(
                        Cooldown.Instance(900, MultiAttack.Instance(10, 10 * (float)Math.PI / 180, 2, 0, projectileIndex: 0)),
                        Cooldown.Instance(1000, MultiAttack.Instance(10, 10 * (float)Math.PI / 180, 1, 0, projectileIndex: 1))
                        
                    ),
					condBehaviors: new ConditionalBehavior[] {
					new OnDeath(Once.Instance(RingAttack.Instance(8, 0, 2, projectileIndex: 1)))
					}
                ))
				
        	        .Init(0x0982, Behaves("Enforcer Bot 3000",
                    new RunBehaviors(
                        Cooldown.Instance(1000, MultiAttack.Instance(25, 10 * (float)Math.PI / 180, 3, 0, projectileIndex: 0)),
                        Cooldown.Instance(900, MultiAttack.Instance(25, 10 * (float)Math.PI / 180, 5, 0, projectileIndex: 1)),
                        SimpleWandering.Instance(1, 1)
                    )
                  )
                )
        	
        	       .Init(0x0983, Behaves("Crusher Abomination",
                    new RunBehaviors(
                        Cooldown.Instance(1300, MultiAttack.Instance(25, 10 * (float)Math.PI / 180, 3, 0, projectileIndex: 3)),
                        SimpleWandering.Instance(3, 3)
                    )
                  )
               )
        	      		        	       .Init(0x1e23, Behaves("Dr Terrible Escaped Experiment",
                    new RunBehaviors(
                        Cooldown.Instance(400, MultiAttack.Instance(25, 10 * (float)Math.PI / 180, 1, 0, projectileIndex: 0)),
                        SimpleWandering.Instance(3, 3),
                       CooldownExact.Instance(40000,
                        new RunBehaviors( 
                            Despawn.Instance
                        ))
                    )
                  )
               )
        	
        		        	       .Init(0x0981, Behaves("Escaped Experiment",
                    new RunBehaviors(
                        Cooldown.Instance(400, MultiAttack.Instance(25, 10 * (float)Math.PI / 180, 1, 0, projectileIndex: 0)),
                        SimpleWandering.Instance(3, 3)
                    )
                  )
               )
        
        .Init(0x5e1c, Behaves("Horrific Creation",
                    new RunBehaviors(
                        Cooldown.Instance(1000, MultiAttack.Instance(25, 10 * (float)Math.PI / 180, 4, 0, projectileIndex: 1)),
                        SimpleWandering.Instance(2, 2)
                    ),
                    Cooldown.Instance(1000,
                        Rand.Instance(
                            new RandomTaunt(0.01, "Die creations!"),
                            new RandomTaunt(0.01, "Die already!")
                        )
                    ),
        	                      
        	                      loot: new LootBehavior(LootDef.Empty,
                        Tuple.Create(100, new LootDef(0, 2, 0, 2,
                            Tuple.Create(0.01, (ILoot)new ItemLoot("Conducting Wand")),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Def)),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Wis))
                           )))
                ));
    }
}
