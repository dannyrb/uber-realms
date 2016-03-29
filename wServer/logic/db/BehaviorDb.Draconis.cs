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
        static _ Draconis = Behav()
            .Init(0x7504, Behaves("Black Dragon God",
                    new RunBehaviors(
                        IfExist.Instance(-1, NullBehavior.Instance,
                            new RunBehaviors(
                                new QueuedBehavior(
                                    CooldownExact.Instance(400)
                                ),
                                SetAltTexture.Instance(1),
                                new QueuedBehavior(HpLesserPercent.Instance(0.99f, new SetKey(-1, 1)))

                            )
                        ),
                        IfEqual.Instance(-1, 1,
                            new RunBehaviors(
                                SetAltTexture.Instance(3),
                                Chasing.Instance(3, 11, 1, null),
                        Cooldown.Instance(450, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 5, 6f, projectileIndex: 2)),
                        Cooldown.Instance(800, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 5, 3f, projectileIndex: 3)),
                        Cooldown.Instance(450, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 3, 6f, projectileIndex: 4)),
                        Cooldown.Instance(600, MultiAttack.Instance(300, 20 * (float)Math.PI / 360, 1, 0, projectileIndex: 1)),
                        Cooldown.Instance(850, MultiAttack.Instance(300, 20 * (float)Math.PI / 360, 15, 0, projectileIndex: 7)),
                                new QueuedBehavior(HpLesserPercent.Instance(0.96f, new SetKey(-1, 2)))
                            )
                        ),
                        IfEqual.Instance(-1, 2,
                            new RunBehaviors(
  						SetAltTexture.Instance(2),
                            Chasing.Instance(3, 11, 1, null),
                        Cooldown.Instance(450, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 5, 6f, projectileIndex: 2)),
                        Cooldown.Instance(800, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 5, 3f, projectileIndex: 3)),
                        Cooldown.Instance(450, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 3, 6f, projectileIndex: 4)),
                        Cooldown.Instance(600, MultiAttack.Instance(300, 20 * (float)Math.PI / 360, 1, 0, projectileIndex: 1)),
                         Cooldown.Instance(850, MultiAttack.Instance(300, 20 * (float)Math.PI / 360, 15, 0, projectileIndex: 7)),
                                new QueuedBehavior(HpLesserPercent.Instance(0.75f, new SetKey(-1, 3)))
                            )
                        ),
                        IfEqual.Instance(-1, 3,
                            new RunBehaviors(
                                SetAltTexture.Instance(3),
                                Chasing.Instance(3, 11, 1, null),
                        Cooldown.Instance(450, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 5, 6f, projectileIndex: 2)),
                        Cooldown.Instance(800, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 5, 3f, projectileIndex: 3)),
                        Cooldown.Instance(450, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 3, 6f, projectileIndex: 4)),
                        Cooldown.Instance(600, MultiAttack.Instance(300, 20 * (float)Math.PI / 360, 1, 0, projectileIndex: 1)),
                         Cooldown.Instance(850, MultiAttack.Instance(300, 20 * (float)Math.PI / 360, 15, 0, projectileIndex: 7)),
                                new QueuedBehavior(HpLesserPercent.Instance(0.50f, new SetKey(-1, 4)))
                            )
                        ),
                        IfEqual.Instance(-1, 4,
                            new RunBehaviors(
                                SetAltTexture.Instance(2),
                                Chasing.Instance(3, 11, 1, null),
                        Cooldown.Instance(450, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 5, 6f, projectileIndex: 2)),
                        Cooldown.Instance(800, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 5, 3f, projectileIndex: 3)),
                        Cooldown.Instance(450, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 3, 6f, projectileIndex: 4)),
                        Cooldown.Instance(600, MultiAttack.Instance(300, 20 * (float)Math.PI / 360, 1, 0, projectileIndex: 1)),
                         Cooldown.Instance(850, MultiAttack.Instance(300, 20 * (float)Math.PI / 360, 15, 0, projectileIndex: 7)),
                         new QueuedBehavior(HpLesserPercent.Instance(0.25f, new SetKey(-1, 5)))
                            
                        )
                    ),
                    IfEqual.Instance(-1, 5,
                            new RunBehaviors(
                                SetAltTexture.Instance(3),
                                Chasing.Instance(3, 11, 1, null),
                        Cooldown.Instance(450, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 5, 6f, projectileIndex: 2)),
                        Cooldown.Instance(800, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 5, 3f, projectileIndex: 3)),
                        Cooldown.Instance(450, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 3, 6f, projectileIndex: 4)),
                        Cooldown.Instance(600, MultiAttack.Instance(300, 20 * (float)Math.PI / 360, 1, 0, projectileIndex: 1)),
                         Cooldown.Instance(850, MultiAttack.Instance(300, 20 * (float)Math.PI / 360, 15, 0, projectileIndex: 7)),
                         new QueuedBehavior(HpLesserPercent.Instance(0.03f, SetState.Instance(("chest"))))
        	                        )),
        	                      	
        	                      	new State("chest",
        	                      	new QueuedBehavior(
        	                      	SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
        	                      	Cooldown.Instance(1000),
        	                      	ReturnSpawn.Instance(15.0f),
        	                      	Cooldown.Instance(3000),
        	                      	Once.Instance(new SimpleTaunt("Until we meet again...sub-creature...")),
        	                      	TossEnemy.Instance(90 * (float)Math.PI / 180, 1, 0x7dcf),
        	            			CooldownExact.Instance(2000),
                        			Die.Instance
        	                      	
                        		))
                            )
        	                     ))
                    

            .Init(0x7499, Behaves("Blue Dragon God",
                    new RunBehaviors(
                        IfExist.Instance(-1, NullBehavior.Instance,
                            new RunBehaviors(
                                new QueuedBehavior(
                                    CooldownExact.Instance(400)
                                ),
                                SetAltTexture.Instance(1),
                                new QueuedBehavior(HpLesserPercent.Instance(0.99f, new SetKey(-1, 1)))

                            )
                        ),
                        IfEqual.Instance(-1, 1,
                            new RunBehaviors(
                                SetAltTexture.Instance(3),
                                Chasing.Instance(6, 11, 1, null),
								Cooldown.Instance(900, RingAttack.Instance(10, 2, 0, projectileIndex: 1)),
								Cooldown.Instance(900, RingAttack.Instance(18, 2, 0, projectileIndex: 0)),
								Cooldown.Instance(1260, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 3, 0, projectileIndex: 3)),
								Cooldown.Instance(1260, MultiAttack.Instance(300, 20 * (float)Math.PI / 360, 15, 0, projectileIndex: 5)),
								Cooldown.Instance(1260, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 15, 2f, projectileIndex: 6)),
								new QueuedBehavior(HpLesserPercent.Instance(0.03f, SetState.Instance(("chest"))))
							)),
        	                      	
        	                      	new State("chest",
        	                      	new QueuedBehavior(
        	                      	SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
        	                      	Cooldown.Instance(1000),
        	                      	ReturnSpawn.Instance(15.0f),
        	                      	Cooldown.Instance(3000),
        	                      	Once.Instance(new SimpleTaunt("Nooooooo! This cannot be! I have underestimated your power...")),
        	                      	TossEnemy.Instance(90 * (float)Math.PI / 180, 1, 0x7ccf),
        	            			CooldownExact.Instance(2000),
                        			Die.Instance
        	                      	
        	                      	     
        	                      

        	                      
                        		))
                            )
        	                     
            ))
            .Init(0x7543, Behaves("Red Dragon God",
                    new RunBehaviors(
                        IfExist.Instance(-1, NullBehavior.Instance,
                            new RunBehaviors(
                                new QueuedBehavior(
                                    CooldownExact.Instance(400)
                                ),
                                SetAltTexture.Instance(1),
                                new QueuedBehavior(HpLesserPercent.Instance(0.99f, new SetKey(-1, 1)))

                            )
                        ),
                        IfEqual.Instance(-1, 1,
                            new RunBehaviors(
                                SetAltTexture.Instance(3),
                                Cooldown.Instance(500, AngleAttack.Instance(0, projectileIndex: 0)),
								Cooldown.Instance(500, AngleAttack.Instance(45, projectileIndex: 0)),
								Cooldown.Instance(500, AngleAttack.Instance(90, projectileIndex: 0)),
								Cooldown.Instance(500, AngleAttack.Instance(135, projectileIndex: 0)),
								Cooldown.Instance(500, AngleAttack.Instance(180, projectileIndex: 0)),
								Cooldown.Instance(500, AngleAttack.Instance(225, projectileIndex: 0)),
								new QueuedBehavior(HpLesserPercent.Instance(0.33f, new SetKey(-1, 2)))
                            )
                        ),
						IfEqual.Instance(-1, 2,
                            new RunBehaviors(
                                    Cooldown.Instance(500, AngleAttack.Instance(0, projectileIndex: 0)),
                                    Cooldown.Instance(500, AngleAttack.Instance(45, projectileIndex: 0)),
                                    Cooldown.Instance(500, AngleAttack.Instance(90, projectileIndex: 0)),
                                    Cooldown.Instance(500, AngleAttack.Instance(135, projectileIndex: 0)),
                                    Cooldown.Instance(500, AngleAttack.Instance(180, projectileIndex: 0)),
                                    Cooldown.Instance(500, AngleAttack.Instance(225, projectileIndex: 0)),
                                    new QueuedBehavior(HpLesserPercent.Instance(0.03f, SetState.Instance(("chest"))))
                            )
                        ),
                        IfEqual.Instance(-1, 2,
                            new QueuedBehavior(
                                    Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 0 * (float)Math.PI / 180, projectileIndex: 3))),
                                    Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 18 * (float)Math.PI / 180, projectileIndex: 3))),
                                    Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 36 * (float)Math.PI / 180, projectileIndex: 3))),
                                    Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 54 * (float)Math.PI / 180, projectileIndex: 3))),
                                    Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 72 * (float)Math.PI / 180, projectileIndex: 3))),
                                    Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 90 * (float)Math.PI / 180, projectileIndex: 3))),
                                    Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 108 * (float)Math.PI / 180, projectileIndex: 3))),
                                    Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 126 * (float)Math.PI / 180, projectileIndex: 3))),
                                    Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 144 * (float)Math.PI / 180, projectileIndex: 3))),
                                    Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 162 * (float)Math.PI / 180, projectileIndex: 3))),
                                    Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 180 * (float)Math.PI / 180, projectileIndex: 3))),
                                    Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 198 * (float)Math.PI / 180, projectileIndex: 3))),
                                    Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 216 * (float)Math.PI / 180, projectileIndex: 3))),
                                    Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 234 * (float)Math.PI / 180, projectileIndex: 3))),
                                    Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 252 * (float)Math.PI / 180, projectileIndex: 3))),
                                    Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 270 * (float)Math.PI / 180, projectileIndex: 3))),
                                    Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 288 * (float)Math.PI / 180, projectileIndex: 3))),
                                    Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 306 * (float)Math.PI / 180, projectileIndex: 3))),
                                    Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 324 * (float)Math.PI / 180, projectileIndex: 3))),
                                    Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 342 * (float)Math.PI / 180, projectileIndex: 3))),
                                    new QueuedBehavior(HpLesserPercent.Instance(0.03f, SetState.Instance(("chest"))))
        	                        )),
        	                      	
        	                      	new State("chest",
        	                      	new QueuedBehavior(
        	                      	SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
        	                      	Cooldown.Instance(1000),
        	                      	Once.Instance(new SimpleTaunt("I will fight you until my last breath...")),
        	                      	TossEnemy.Instance(270 * (float)Math.PI / 360, 5, 0x7ecf),
        	            			CooldownExact.Instance(2000),
                        			Die.Instance
        	                      	
                        		))
                            ))
                    )
            .Init(0x7541, Behaves("Green Dragon God",
                    new RunBehaviors(
                        IfExist.Instance(-1, NullBehavior.Instance,
                            new RunBehaviors(
                                new QueuedBehavior(
                                    CooldownExact.Instance(400)
                                ),
                                SetAltTexture.Instance(1),
                                new QueuedBehavior(HpLesserPercent.Instance(0.99f, new SetKey(-1, 1)))

                            )
                        ),
                        IfEqual.Instance(-1, 1,
                            new RunBehaviors(
                                SetAltTexture.Instance(3),
                            Once.Instance(TossEnemy.Instance(0 * (float)Math.PI / 180, 4, 0x7545)),
                            Once.Instance(TossEnemy.Instance(45 * (float)Math.PI / 180, 4, 0x7545)),
                            Once.Instance(TossEnemy.Instance(90 * (float)Math.PI / 180, 4, 0x7545)),
                            Once.Instance(TossEnemy.Instance(135 * (float)Math.PI / 180, 4, 0x7545)),
                            Once.Instance(TossEnemy.Instance(180 * (float)Math.PI / 180, 4, 0x7545)),
                            Once.Instance(TossEnemy.Instance(225 * (float)Math.PI / 180, 4, 0x7545)),
							Cooldown.Instance(500, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 7, 0, projectileIndex: 6)),
							Cooldown.Instance(600, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 4, 0, projectileIndex: 1)),
							Cooldown.Instance(450, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 1, 0, projectileIndex: 3)),
							new QueuedBehavior(HpLesserPercent.Instance(0.03f, SetState.Instance(("chest")))),
							new QueuedBehavior(EntityLesserThan.Instance(5, 0, 0x7545),
                                new SetKey (-1, 2)
                                )
                            )
                        ),
						IfEqual.Instance(-1, 2,
                            new RunBehaviors(
							SetAltTexture.Instance(3),
                            Chasing.Instance(3, 11, 1, null),
							Cooldown.Instance(450, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 5, 6f, projectileIndex: 2)),
							Cooldown.Instance(800, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 5, 3f, projectileIndex: 3)),
							Cooldown.Instance(450, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 3, 6f, projectileIndex: 4)),
							Cooldown.Instance(600, MultiAttack.Instance(300, 20 * (float)Math.PI / 360, 1, 0, projectileIndex: 1)),
							Cooldown.Instance(850, MultiAttack.Instance(300, 20 * (float)Math.PI / 360, 15, 0, projectileIndex: 7)),
                            new QueuedBehavior(Timed.Instance(30000, new SetKey(-1, 1))),
                            new QueuedBehavior(HpLesserPercent.Instance(0.03f, SetState.Instance(("chest"))))
        	                        )),
        	                      	
        	                      	new State("chest",
        	                      	new QueuedBehavior(
        	                      	SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
        	                      	Cooldown.Instance(1000),
        	                      	Once.Instance(new SimpleTaunt("Flee my servants, I can no longer protect you as you have protected me...")),
        	                      	TossEnemy.Instance(90 * (float)Math.PI / 180, 1, 0x7dcf),
        	            			CooldownExact.Instance(2000),
                        			Die.Instance
        	                      	
                        		))
        	                      )))

            .Init(0x7545, Behaves("NM Green Dragon Shield",
                    new RunBehaviors(
                        Circling.Instance(4, 100, 5, 0x7541)
                        )
            ))
        .Init(0x299f, Behaves("Ivory Wyvern",
        	       new RunBehaviors(
                    new State("idle",
                        SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                            SetState.Instance("flash")
                       ),
                    new State("flash",
                        SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                        Once.Instance(new RunBehaviors(new SimpleTaunt("Thank you adventurer, you have freed the souls of the four dragons so that I may consume their powers."))),
                        Timed.Instance(24000, False.Instance(Flashing.Instance(250, 0xffff0000))),
                        CooldownExact.Instance(5000, Once.Instance(new SimpleTaunt("I owe you much, but I cannot let you leave.  These walls will make a fine graveyard for your bones."))),
                        CooldownExact.Instance(10000, Once.Instance(new SimpleTaunt("Behold the glory of my true powers..."))),
                        CooldownExact.Instance(12000, UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)),
                        CooldownExact.Instance(12000, SetState.Instance("battle"))
						),
        	                      	
                        new State("battle",
                    	   Once.Instance(TossEnemy.Instance(180 * (float)Math.PI / 180, 4, 0x2a9f)),
                           Once.Instance(TossEnemy.Instance(180 * (float)Math.PI / 180, 8, 0x2a9f)),
                           Once.Instance(TossEnemy.Instance(0 * (float)Math.PI / 180, 4, 0x2a9f)),
                           Once.Instance(TossEnemy.Instance(0 * (float)Math.PI / 180, 8, 0x2a9f)),
                           new QueuedBehavior(
							AngleMove.Instance(10.0f,135.075f,10.0f),
							Cooldown.Instance(4000),
                           AngleMove.Instance(10.0f,0f,20.0f),
                           Cooldown.Instance(4000),
                           AngleMove.Instance(10.0f,135.075f,20.0f),
                           Cooldown.Instance(2000)),
                            Once.Instance(new SimpleTaunt("Run little hero, as fast as you can.")),
                     		Cooldown.Instance(2500, SimpleAttack.Instance(10, projectileIndex: 0)),
        	          		Cooldown.Instance(2500, SimpleAttack.Instance(10, projectileIndex: 0)),
        	           		Cooldown.Instance(2500, SimpleAttack.Instance(10, projectileIndex: 0)),
        	            	Cooldown.Instance(2500, SimpleAttack.Instance(10, projectileIndex: 0)),
        	             	Cooldown.Instance(2500, SimpleAttack.Instance(10, projectileIndex: 0)),
        	             	(CooldownExact.Instance(10000, SetState.Instance(("-1, 2"))))),
        	                      	
                    	  new State("-1, 2",
        	                new RunBehaviors(
        	                Cooldown.Instance(2000),
        	                ReturnSpawn.Instance(20.0f),
        	                Cooldown.Instance(4000),
        	                Once.Instance(new SimpleTaunt("My magic can no longer sustain my mirrors what have you done?!")),
        	                Cooldown.Instance(1500, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 8, 6f, projectileIndex: 0)),
        	                new QueuedBehavior(HpLesserPercent.Instance(0.60f, SetState.Instance(("-1, 3"))))
        	               )),
        	      
        	      			new State("-1, 3",
                           Cooldown.Instance(1500, MultiAttack.Instance(12, 10 * (float)Math.PI / 180, 8, 6f, projectileIndex: 0)),
        	               new QueuedBehavior(HpLesserPercent.Instance(0.50f, SetState.Instance(("-1, 4"))))
        	               ),
        	                
        	              new State("-1, 4",
        	                new RunBehaviors(
        	                SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
        	                Once.Instance(new SimpleTaunt("The souls of past dragons will deal with you!")),
        	               Once.Instance(TossEnemy.Instance(180 * (float)Math.PI / 180, 4, 0x699f)),
                           Once.Instance(TossEnemy.Instance(180 * (float)Math.PI / 180, 8, 0x499f)),
                           Once.Instance(TossEnemy.Instance(0 * (float)Math.PI / 180, 4, 0x69af)),
                           Once.Instance(TossEnemy.Instance(0 * (float)Math.PI / 180, 8, 0x69bf)),
							new QueuedBehavior(Cooldown.Instance(6000, IfNot.Instance(
                            IsEntityPresent.Instance(20000, 0x69bf),
                            SetState.Instance("predeath"))))
                                                           )),
        	              new State("predeath",
        	            Once.Instance(new SimpleTaunt("So you wish to fight your fate? Alright then I will not hold back any longer!")),
                        UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                        new QueuedBehavior(
                        	AngleMove.Instance(10.0f,58.15f,10.0f),
                        	Cooldown.Instance(8000000)),
                        
                         new QueuedBehavior(
                        	Cooldown.Instance(7000),
                        
        	               Once.Instance(TossEnemy.Instance(45 * (float)Math.PI / 180, 11, 0x7bcf)),
                           Once.Instance(TossEnemy.Instance(135 * (float)Math.PI / 180, 11, 0x7bcf)),
                           Once.Instance(TossEnemy.Instance(225 * (float)Math.PI / 180, 11, 0x7bcf)),
                           Once.Instance(TossEnemy.Instance(315 * (float)Math.PI / 180, 11, 0x7bcf))),
                           
        	            Cooldown.Instance(1500, MultiAttack.Instance(4, 10 * (float)Math.PI / 360, 12, 6f, projectileIndex: 0)),
        	            Cooldown.Instance(1000, RingAttack.Instance(1, offset: 50 * (float)Math.PI / 90, projectileIndex: 3)),
        	             Cooldown.Instance(1000, RingAttack.Instance(1, offset: 60 * (float)Math.PI / 90, projectileIndex: 3)),
        	              Cooldown.Instance(1000, RingAttack.Instance(1, offset: 70 * (float)Math.PI / 90, projectileIndex: 3)),
        	               Cooldown.Instance(1000, RingAttack.Instance(1, offset: 80 * (float)Math.PI / 90, projectileIndex: 3)),
        	                Cooldown.Instance(1000, RingAttack.Instance(1, offset: 90 * (float)Math.PI / 90, projectileIndex: 3)),
        	                
        	                Cooldown.Instance(1000, RingAttack.Instance(1, offset: 0 * (float)Math.PI / 90, projectileIndex: 2)),
        	             Cooldown.Instance(1000, RingAttack.Instance(1, offset: 10 * (float)Math.PI / 90, projectileIndex: 2)),
        	              Cooldown.Instance(1000, RingAttack.Instance(1, offset: 20 * (float)Math.PI / 90, projectileIndex: 2)),
        	               Cooldown.Instance(1000, RingAttack.Instance(1, offset: 30 * (float)Math.PI / 90, projectileIndex: 2)),
        	                Cooldown.Instance(1000, RingAttack.Instance(1, offset: 40 * (float)Math.PI / 90, projectileIndex: 2)),
        	                
        	             Cooldown.Instance(1000, RingAttack.Instance(1, offset: -0 * (float)Math.PI / 90, projectileIndex: 4)),
        	             Cooldown.Instance(1000, RingAttack.Instance(1, offset: -10 * (float)Math.PI / 90, projectileIndex: 4)),
        	              Cooldown.Instance(1000, RingAttack.Instance(1, offset: -20 * (float)Math.PI / 90, projectileIndex: 4)),
        	               Cooldown.Instance(1000, RingAttack.Instance(1, offset: -30 * (float)Math.PI / 90, projectileIndex: 4)),
        	                Cooldown.Instance(1000, RingAttack.Instance(1, offset: -40 * (float)Math.PI / 90, projectileIndex: 4)),
        	                
        	            Cooldown.Instance(1000, RingAttack.Instance(1, offset: -60 * (float)Math.PI / 90, projectileIndex: 1)),
        	             Cooldown.Instance(1000, RingAttack.Instance(1, offset: -70 * (float)Math.PI / 90, projectileIndex: 1)),
        	              Cooldown.Instance(1000, RingAttack.Instance(1, offset: -80 * (float)Math.PI / 90, projectileIndex: 1)),
        	               Cooldown.Instance(1000, RingAttack.Instance(1, offset: -90 * (float)Math.PI / 90, projectileIndex: 1)),
        	                Cooldown.Instance(1000, RingAttack.Instance(1, offset: -50 * (float)Math.PI / 90, projectileIndex: 1)),
        	                
                           	
        	                new QueuedBehavior(HpLesserPercent.Instance(0.20f, SetState.Instance(("-1, 5"))))),
        	                
        	                      new State("-1, 5",
        	                     Chasing.Instance(7,10,2,null),
        	                     new RunBehaviors(
        	                     Cooldown.Instance(2500, SimpleAttack.Instance(10, projectileIndex: 0)),
        	                     new QueuedBehavior(HpLesserPercent.Instance(0.10f, SetState.Instance(("death")))
        	                                       ))),
        	                      
        	                      new State("death",
        	                       Chasing.Instance(7,10,2,null),
        	                     new RunBehaviors(
        	                         Cooldown.Instance(1500, MultiAttack.Instance(12, 10 * (float)Math.PI / 360, 12, 6f, projectileIndex: 0)),
        	                         new QueuedBehavior(HpLesserPercent.Instance(0.03f, SetState.Instance(("chest"))))
        	                        )),
        	                      	
        	                      	new State("chest",
        	                      	new QueuedBehavior(
        	                      	SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
        	                      	Cooldown.Instance(1000),
        	                      	Once.Instance(new SimpleTaunt("You may have beaten me this time, but I will find a way to leave this place! And on that day, you will suffer greatly...")),
        	                      	TossEnemy.Instance(90 * (float)Math.PI / 180, 1, 0x7acf),
        	            			CooldownExact.Instance(2000),
                        			Die.Instance
        	                      	
        	                      	     
        	                      

        	                      
                        		))
        	                      )))
        	                    
        	                      	

        	                      
        	 .Init(0x2a9f, Behaves("Mirror Wyvern",
                    new RunBehaviors(
        	         Cooldown.Instance(2500, SimpleAttack.Instance(5, projectileIndex: 0)),
        	          Cooldown.Instance(2500, SimpleAttack.Instance(5, projectileIndex: 0)),
        	           Cooldown.Instance(2500, SimpleAttack.Instance(5, projectileIndex: 0)),
        	            Cooldown.Instance(2500, SimpleAttack.Instance(5, projectileIndex: 0)),
        	             Cooldown.Instance(2500, SimpleAttack.Instance(5, projectileIndex: 0)),
        	             CooldownExact.Instance(10000,
                        new RunBehaviors( 
                            Despawn.Instance
                           )))))
        	
        	.Init(0x7bcf, Behaves("White Dragon Orb",
                    new RunBehaviors(
        	         SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
        	         Cooldown.Instance(1000, RingAttack.Instance(8, offset: 20 * (float)Math.PI / 180, projectileIndex: 1)),
        	          Cooldown.Instance(1200, RingAttack.Instance(8, offset: 40 * (float)Math.PI / 180, projectileIndex: 1)),
                         IfNot.Instance(
                            IsEntityPresent.Instance(20000, 0x299f),
                            Despawn.Instance
                           ))))
        	
        	
        	.Init(0x499f, Behaves("Blue Soul of Nikao",
                    new RunBehaviors(
        	   Once.Instance(new SimpleTaunt("Look at my beautiful flames")),
        	   Once.Instance(SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)),
			   CooldownExact.Instance(6000, UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)),
        	   Cooldown.Instance(450, RingAttack.Instance(1, offset: 60 * (float)Math.PI / 180)),
        	   Cooldown.Instance(450, RingAttack.Instance(1, offset: 70 * (float)Math.PI / 180)),
        	   Cooldown.Instance(450, RingAttack.Instance(1, offset: 80 * (float)Math.PI / 180)),
        	   Cooldown.Instance(450, RingAttack.Instance(1, offset: 90 * (float)Math.PI / 180)),
        	   Cooldown.Instance(450, RingAttack.Instance(1, offset: 100 * (float)Math.PI / 180)),
        	   Cooldown.Instance(450, RingAttack.Instance(1, offset: 110 * (float)Math.PI / 180))
        	  )))
        	
        	
			.Init(0x69af, Behaves("Red Soul of Pyyr",
                    new RunBehaviors(
        	   Once.Instance(new SimpleTaunt("Look at my beautiful flames")),
               Once.Instance(SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)),
			   CooldownExact.Instance(6000, UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)),
        	   Cooldown.Instance(450, RingAttack.Instance(1, offset: 60 * (float)Math.PI / 180)),
        	   Cooldown.Instance(450, RingAttack.Instance(1, offset: 70 * (float)Math.PI / 180)),
        	   Cooldown.Instance(450, RingAttack.Instance(1, offset: 80 * (float)Math.PI / 180)),
        	   Cooldown.Instance(450, RingAttack.Instance(1, offset: 90 * (float)Math.PI / 180)),
        	   Cooldown.Instance(450, RingAttack.Instance(1, offset: 100 * (float)Math.PI / 180)),
        	   Cooldown.Instance(450, RingAttack.Instance(1, offset: 110 * (float)Math.PI / 180))
        	  )))
        	
        	.Init(0x69bf, Behaves("Black Soul of Feargus",
                    new RunBehaviors(
        	   Once.Instance(new SimpleTaunt("Look at my beautiful flames")),
        	   Once.Instance(SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)),
			   CooldownExact.Instance(6000, UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)),
        	   Cooldown.Instance(450, RingAttack.Instance(1, offset: 60 * (float)Math.PI / 180)),
        	   Cooldown.Instance(450, RingAttack.Instance(1, offset: 70 * (float)Math.PI / 180)),
        	   Cooldown.Instance(450, RingAttack.Instance(1, offset: 80 * (float)Math.PI / 180)),
        	   Cooldown.Instance(450, RingAttack.Instance(1, offset: 90 * (float)Math.PI / 180)),
        	   Cooldown.Instance(450, RingAttack.Instance(1, offset: 100 * (float)Math.PI / 180)),
        	   Cooldown.Instance(450, RingAttack.Instance(1, offset: 110 * (float)Math.PI / 180))
        	  )))
        
        	 .Init(0x699f, Behaves("Green Soul of Limoz",
                    new RunBehaviors(
        	   Once.Instance(new SimpleTaunt("Look at my beautiful flames")),
        	   Once.Instance(SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)),
			   CooldownExact.Instance(6000, UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)),
        	   Cooldown.Instance(450, RingAttack.Instance(1, offset: 60 * (float)Math.PI / 180)),
        	   Cooldown.Instance(450, RingAttack.Instance(1, offset: 70 * (float)Math.PI / 180)),
        	   Cooldown.Instance(450, RingAttack.Instance(1, offset: 80 * (float)Math.PI / 180)),
        	   Cooldown.Instance(450, RingAttack.Instance(1, offset: 90 * (float)Math.PI / 180)),
        	   Cooldown.Instance(450, RingAttack.Instance(1, offset: 100 * (float)Math.PI / 180)),
        	   Cooldown.Instance(450, RingAttack.Instance(1, offset: 110 * (float)Math.PI / 180))
        	  )))
        
        
        .Init(0x7acf, Behaves("Wyvern Chest",
        	         new RunBehaviors(
        	                      	Once.Instance(SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)),
					CooldownExact.Instance(6000, UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable))        	         
        	                      ),
        	         loot: new LootBehavior(LootDef.Empty,
                 Tuple.Create(100, new LootDef(0, 3, 0, 8,
                 Tuple.Create(0.05, (ILoot)new TierLoot(12, ItemType.Weapon)),
                 Tuple.Create(0.05, (ILoot)new TierLoot(13, ItemType.Armor)),
                 Tuple.Create(0.01, (ILoot)new ItemLoot("Wine Cellar Incantation")),
                 Tuple.Create(0.1, (ILoot)new ItemLoot("Large Purple Pinstripe Cloth")),
                 Tuple.Create(0.1, (ILoot)new ItemLoot("Small Rainbow Cloth")),
                 Tuple.Create(0.1, (ILoot)new ItemLoot("Large Rainbow Cloth")),
                 Tuple.Create(0.1, (ILoot)new ItemLoot("Small Black Striped Cloth")),
                 Tuple.Create(0.1, (ILoot)new ItemLoot("Small Purple Pinstripe Cloth")),
                 
                 Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Att)),
                 Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Wis)),
                 Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Vit)),
                 Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Spd))
                ))))
                             )
        	
        	.Init(0x7ccf, Behaves("Blue Chest",
        	         new RunBehaviors(
        	        Once.Instance(SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)),
					CooldownExact.Instance(6000, UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable))        	         
        	                      ),
                     loot: new LootBehavior(LootDef.Empty,
                        Tuple.Create(100, new LootDef(0, 2, 0, 2,
                            Tuple.Create(0.01, (ILoot)new ItemLoot("Water Dragon Silk Robe")),
                            Tuple.Create(0.0001, (ILoot)new ItemLoot("Captain America Sword")),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Def)),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Vit)),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Wis)),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Dex)),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Att)),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Spd))
                            
                    ))),
        	            condBehaviors: new ConditionalBehavior[] {
                        new DeathPortal(0x1909, 50)
                    }
        	                     )
                             )
        	
        	        	.Init(0x7ecf, Behaves("Red Chest",
        	         new RunBehaviors(
        	        Once.Instance(SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)),
					CooldownExact.Instance(6000, UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable))        	         
        	                      ),
                    loot: new LootBehavior(LootDef.Empty,
                        Tuple.Create(100, new LootDef(0, 2, 0, 2,
                            Tuple.Create(0.005, (ILoot)new ItemLoot("Fire Dragon Battle Armor")),
                            Tuple.Create(0.0001, (ILoot)new ItemLoot("Captain America Shield")),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Def)),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Vit)),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Wis)),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Dex)),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Att)),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Spd))
                    ))))
                             )
        	
        	        	        	.Init(0x7fcf, Behaves("Black Chest",
        	         new RunBehaviors(
        	        Once.Instance(SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)),
					CooldownExact.Instance(6000, UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable))        	         
        	                      ),
                    loot: new LootBehavior(LootDef.Empty,
                        Tuple.Create(100, new LootDef(0, 2, 0, 2,
                            Tuple.Create(0.005, (ILoot)new ItemLoot("Celestial Blade")),
                            Tuple.Create(0.0001, (ILoot)new ItemLoot("Spell of El Diablo")),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Def)),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Vit)),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Wis)),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Dex)),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Att)),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Spd))
                    )))
        	                     ))
        	
                .Init(0x7dcf, Behaves("Green Chest",
        	         new RunBehaviors(
        	        Once.Instance(SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)),
					CooldownExact.Instance(6000, UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable))        	         
        	                      ),
        	         loot: new LootBehavior(LootDef.Empty,
                        Tuple.Create(100, new LootDef(0, 2, 0, 2,
                            Tuple.Create(0.005, (ILoot)new ItemLoot("Leaf Dragon Hide Armor")),
                            Tuple.Create(0.0001, (ILoot)new ItemLoot("Captain America Armor")),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Def)),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Vit)),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Wis)),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Dex)),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Att)),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Spd))
                )))));
    }
}

