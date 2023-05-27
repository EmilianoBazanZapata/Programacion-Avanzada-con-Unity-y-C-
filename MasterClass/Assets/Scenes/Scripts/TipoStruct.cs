using UnityEngine;

public class TipoStruct : MonoBehaviour
{
    public string playerName;
    public int playerHealth;
    public bool playerIsDead;
    
    [System.Serializable]
    public struct PlayerData
    {
        public string playerName;
        public int playerHealth;
        public bool isDead;
        public int ammo;
    }

    public PlayerData playerData;

    private void Start()
    {
        playerData.isDead = false;
        playerData.playerName = "Emiliano";
        playerData.playerHealth = 100;
    }

    private void ChangeInfo(PlayerData playerData)
    {
        playerData.ammo = 10;
    }
}
