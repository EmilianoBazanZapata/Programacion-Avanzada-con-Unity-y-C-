using UnityEngine;

namespace MasterClass.Assets.Scenes.Scripts.Patrones.Facade
{
    public class GameManager : MonoBehaviour
    {
        public BattleFacade battleFacade;

        public void BattleStart()
        {
            battleFacade.BattleStart();
        }

        public void BattleEnd()
        {
            battleFacade.BattleEnd();
        }
    }
}