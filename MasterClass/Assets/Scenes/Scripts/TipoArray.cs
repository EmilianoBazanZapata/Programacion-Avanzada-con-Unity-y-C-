using UnityEngine;

public class TipoArray : MonoBehaviour
{
    public int[] enemyArrayList = { 10, 20, 30, 40 };

    private void Start()
    {
        int enemyId = enemyArrayList[0]; //--> 100
    }
}
