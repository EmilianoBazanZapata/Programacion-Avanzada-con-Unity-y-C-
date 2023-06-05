using UnityEngine;

namespace MasterClass.Assets.Scenes.Scripts.Patrones.NullObject
{
    public class WeaponNull : Weapon
    {
        public override void Attack(IDamage damageReceiver)
        {
            //Do Nothing
        }
    }
}