using UnityEngine;
namespace MasterClass.Assets.Scenes.Scripts.Patrones.Template
{
    public class Orc : Character
    {
        protected override bool CanAttack()
        {
            return true;
        }

        protected override void DoAttack()
        {
            //atack
        }

        protected override void DamageReceive(bool isDead)
        {
            if(isDead)
            {
                // drop some item 
            }

            Debug.Log("HA HA HA!");
        }
    }
}