using UnityEngine;

public class Player : MonoBehaviour
{
    public Enemy enemy;

    private void Start()
    {
        enemy.Title = "leer titulo";
    }
}
