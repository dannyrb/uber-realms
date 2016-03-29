using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wServer.realm;
using wServer.realm.entities;
using wServer.svrPackets;

namespace wServer.logic.cond
{
    class PetHealHpMp : Behavior
    {
        protected override bool TickCore(RealmTime time)
        {
            float dist = 20;
            Player entity = (Host.Self.PlayerOwner) as Player;
            while (entity != null)
            {
                int mp = entity.MP;
                int maxMp = entity.Stats[1] + entity.Boost[1];
                mp = Math.Min(mp + 33, maxMp);
                if (mp != entity.MP)
                {
                    int n = mp - entity.MP;
                    entity.MP = mp;
                    entity.UpdateCount++;
                    entity.Owner.BroadcastPacket(new ShowEffectPacket()
                    {
                        EffectType = EffectType.Potion,
                        TargetId = entity.Id,
                        Color = new ARGB(0xffffffff)
                    }, null);
                    entity.Owner.BroadcastPacket(new NotificationPacket()
                    {
                        ObjectId = entity.Id,
                        Text = "+" + n,
                        Color = new ARGB(0xff0000ff)
                    }, null);
                }
                int hp = entity.HP;
                int maxHp = entity.Stats[0] + entity.Boost[0];
                hp = Math.Min(hp + 69, maxHp);
                if (hp != entity.HP)
                {
                    int m = hp - entity.HP;
                    entity.HP = hp;
                    entity.UpdateCount++;
                    entity.Owner.BroadcastPacket(new ShowEffectPacket()
                    {
                        EffectType = EffectType.Potion,
                        TargetId = entity.Id,
                        Color = new ARGB(0xffffffff)
                    }, null);
                    entity.Owner.BroadcastPacket(new ShowEffectPacket()
                    {

                        EffectType = EffectType.Trail,
                        TargetId = Host.Self.Id,
                        PosA = new Position() { X = entity.X, Y = entity.Y },
                        Color = new ARGB(0xffffffff)
                    }, null);
                    entity.Owner.BroadcastPacket(new NotificationPacket()
                    {
                        ObjectId = entity.Id,
                        Text = "+" + m,
                        Color = new ARGB(0xffff0000)
                    }, null);

                    return true;
                }
                entity = null;
            }
            return false;
        }
    }
}