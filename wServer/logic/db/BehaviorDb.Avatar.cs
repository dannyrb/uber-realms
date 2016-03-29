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
        static _ KingsAvatar = Behav()
            .Init(0x00ff7, Behaves("Avatar of the Forgotten King",
                new RunBehaviors(
                ),
                Once.Instance(IsEntityPresent.Instance(1, null)),
                new QueuedBehavior(
        #region Circle Attack 1

Cooldown.Instance(150),
                      new RunBehaviors(
                           TossEnemy.Instance(0f * (float)Math.PI / 180, 5f, 0x7f93),
                                    TossEnemy.Instance(90f * (float)Math.PI / 180, 5f, 0x7f93),
                                    TossEnemy.Instance(180f * (float)Math.PI / 180, 5f, 0x7f93),
                                    TossEnemy.Instance(270f * (float)Math.PI / 180, 5f, 0x7f93),
                          Once.Instance(SpawnMinionImmediate.Instance(0x7f93, 2, 1, 4)),
                          SimpleAttack.Instance(5, projectileIndex: 3),
                          RingAttack.Instance(3, offset: 0 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 18 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 36 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 54 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 72 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                          SimpleAttack.Instance(5, projectileIndex: 3),
                          RingAttack.Instance(3, offset: 90 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 108 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 126 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 144 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 162 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          SimpleAttack.Instance(5, projectileIndex: 3),
                          RingAttack.Instance(3, offset: 180 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 198 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 216 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 234 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 252 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          SimpleAttack.Instance(5, projectileIndex: 3),
                          RingAttack.Instance(3, offset: 270 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 288 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 306 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 324 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 342 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(250),
                      new RunBehaviors(
                          UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                          RingAttack.Instance(3, offset: 360 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(100),
        #endregion

        #region Circle Attack 2
 Cooldown.Instance(150),
                      new RunBehaviors(
                          SimpleAttack.Instance(5, projectileIndex: 3),
                          RingAttack.Instance(3, offset: 0 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 18 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 36 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 54 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 72 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                          SimpleAttack.Instance(5, projectileIndex: 3),
                          RingAttack.Instance(3, offset: 90 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 108 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 126 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 144 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 162 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          SimpleAttack.Instance(5, projectileIndex: 3),
                          RingAttack.Instance(3, offset: 180 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 198 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 216 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 234 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 252 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          SimpleAttack.Instance(5, projectileIndex: 3),
                          RingAttack.Instance(3, offset: 270 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),
                          RingAttack.Instance(3, offset: 288 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 306 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 324 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 342 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(250),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 360 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(100),
        #endregion
                    //not used
        #region Circle Attack 3
                    /*Cooldown.Instance(150),
                              new RunBehaviors(
                                  SimpleAttack.Instance(5, projectileIndex: 3),
                                  RingAttack.Instance(3, offset: 0 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 18 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 36 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 54 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 72 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  SimpleAttack.Instance(5, projectileIndex: 3),
                                  RingAttack.Instance(3, offset: 90 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 108 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 126 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 144 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 162 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  SimpleAttack.Instance(5, projectileIndex: 3),
                                  RingAttack.Instance(3, offset: 180 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 198 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 216 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 234 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 252 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  SimpleAttack.Instance(5, projectileIndex: 3),
                                  RingAttack.Instance(3, offset: 270 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 288 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 306 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 324 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 342 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(250),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 360 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(100),*/
        #endregion

        #region Circle Attack 4
                    /*Cooldown.Instance(150),
                              new RunBehaviors(
                                  SimpleAttack.Instance(5, projectileIndex: 3),
                                  RingAttack.Instance(3, offset: 0 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 18 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 36 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 54 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 72 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  SimpleAttack.Instance(5, projectileIndex: 3),
                                  RingAttack.Instance(3, offset: 90 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 108 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 126 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 144 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 162 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  SimpleAttack.Instance(5, projectileIndex: 3),
                                  RingAttack.Instance(3, offset: 180 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 198 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 216 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 234 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 252 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  SimpleAttack.Instance(5, projectileIndex: 3),
                                  RingAttack.Instance(3, offset: 270 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 288 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 306 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 324 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(150),
                              new RunBehaviors(
                                  RingAttack.Instance(3, offset: 342 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(250),
                              new RunBehaviors(
                                  SimpleAttack.Instance(5, projectileIndex: 3),
                                  RingAttack.Instance(3, offset: 360 * (float)Math.PI / 180)
                            ),
                            Cooldown.Instance(100),*/
        #endregion
                    //end

        #region RingAttack + Flashing 1

                    new QueuedBehavior(
                        Flashing.Instance(500, 0x0000FF0C),
                        Flashing.Instance(500, 0x0000FF0C),
                        Flashing.Instance(500, 0x0000FF0C),
                        Flashing.Instance(500, 0x0000FF0C),
                        Cooldown.Instance(2500, RingAttack.Instance(12, 10, 12, projectileIndex: 3)),
                        Cooldown.Instance(2500, RingAttack.Instance(12, 10, 12, projectileIndex: 3)),
                        Cooldown.Instance(2500, RingAttack.Instance(12, 10, 12, projectileIndex: 3)),
                        Cooldown.Instance(2500, RingAttack.Instance(12, 10, 12, projectileIndex: 3)),

        #endregion

        #region Flashing 2

 Flashing.Instance(200, 0x0000FF0C),
                        Flashing.Instance(200, 0x0000FF0C),
                        Flashing.Instance(200, 0x0000FF0C),
                        Flashing.Instance(200, 0x0000FF0C),
                        Flashing.Instance(200, 0x0000FF0C),
                        Flashing.Instance(200, 0x0000FF0C),
                        Flashing.Instance(200, 0x0000FF0C),
                        Flashing.Instance(200, 0x0000FF0C),
                        UnsetConditionEffect.Instance(ConditionEffectIndex.Invulnerable),

        #endregion



        #region Circleshoot
        #region Circleshoot

        #region Circle Attack 1

 Cooldown.Instance(150),
                      new RunBehaviors(
                          MultiAttack.Instance(5, 1 * (float)Math.PI / 30, 3, 0, projectileIndex: 4),
                          RingAttack.Instance(3, offset: 0 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 18 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 36 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 54 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 72 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          MultiAttack.Instance(5, 1 * (float)Math.PI / 30, 3, 0, projectileIndex: 4),
                          RingAttack.Instance(3, offset: 90 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 108 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 126 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 144 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 162 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          MultiAttack.Instance(5, 1 * (float)Math.PI / 30, 3, 0, projectileIndex: 4),
                          RingAttack.Instance(3, offset: 180 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 198 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 216 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 234 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 252 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          MultiAttack.Instance(5, 1 * (float)Math.PI / 30, 3, 0, projectileIndex: 4),
                          RingAttack.Instance(3, offset: 270 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 288 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 306 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 324 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 342 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(250),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 360 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(100),
        #endregion

        #region Circle Attack 2

 Cooldown.Instance(150),
                      new RunBehaviors(
                          MultiAttack.Instance(5, 1 * (float)Math.PI / 30, 3, 0, projectileIndex: 4),
                          RingAttack.Instance(3, offset: 0 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 18 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 36 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 54 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 72 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          MultiAttack.Instance(5, 1 * (float)Math.PI / 30, 3, 0, projectileIndex: 4),
                          RingAttack.Instance(3, offset: 90 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 108 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 126 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 144 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 162 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          MultiAttack.Instance(5, 1 * (float)Math.PI / 30, 3, 0, projectileIndex: 4),
                          RingAttack.Instance(3, offset: 180 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 198 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 216 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 234 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 252 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          MultiAttack.Instance(5, 1 * (float)Math.PI / 30, 3, 0, projectileIndex: 4),
                          RingAttack.Instance(3, offset: 270 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 288 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 306 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 324 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(150),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 342 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(250),
                      new RunBehaviors(
                          RingAttack.Instance(3, offset: 360 * (float)Math.PI / 180)
                    ),
                    Cooldown.Instance(1100))
        #endregion

        #endregion

        #endregion

),
                loot: new LootBehavior(LootDef.Empty,
                    Tuple.Create(100, new LootDef(0, 4, 0, 4,
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Vit)),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Wis)),
                            Tuple.Create(0.001, (ILoot)new ItemLoot("Tablet of the King's Avatar")),
                            Tuple.Create(0.01, (ILoot)new ItemLoot("Amulet of Resurrection")),

                            Tuple.Create(0.3, (ILoot)new TierLoot(3, ItemType.Ring)),
                            Tuple.Create(0.2, (ILoot)new TierLoot(4, ItemType.Ring)),
                            Tuple.Create(0.3, (ILoot)new TierLoot(7, ItemType.Weapon)),
                            Tuple.Create(0.2, (ILoot)new TierLoot(8, ItemType.Weapon)),
                            Tuple.Create(0.3, (ILoot)new TierLoot(3, ItemType.Ability)),
                            Tuple.Create(0.2, (ILoot)new TierLoot(4, ItemType.Ability)),
                            Tuple.Create(0.05, (ILoot)new TierLoot(5, ItemType.Ability))
                             ))
                                      ) ));
                
    }
}