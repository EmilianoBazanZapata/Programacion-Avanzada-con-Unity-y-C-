using UnityEngine;

namespace MasterClass.Assets.Scenes.Scripts.Patrones.Template
{
    public class Elf : Character
    {
        protected override bool CanAttack()
        {
            if (health >= 30)
            {
                return true;
            }

            Debug.Log("I can't attack - I'm too weak!");
            return false;
        }

        protected override void DoAttack()
        {
            //attack
        }

        protected override void DamageReceive(bool isDead)
        {
            if(isDead)
            {
                //gameover
            }
        }
    }
}