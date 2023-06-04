using UnityEngine;

namespace MasterClass.Assets.Scenes.Scripts.Patrones.Facade
{
    public class BattleFacade : MonoBehaviour
    {
        public BattleUI battleUI;
        public CharacterSpawner characterSpawner;
        public CharacterUI characterUI;

        public void BattleStart()
        {
            battleUI.Show();

            characterSpawner.SpawnPlayers();
            characterSpawner.SpawnEnemies();

            characterUI.ShowPlayersUI();
            characterUI.ShowEnemiesUI();

            battleUI.Hide();
        }

        public void BattleEnd()
        {
            battleUI.Show();

            characterSpawner.DestroyEnemies();
            characterSpawner.DestroyEnemies();

            characterUI.HidePlyersUI();
            characterUI.HideEnemiesUI();

            battleUI.Hide();
        }
    }
}