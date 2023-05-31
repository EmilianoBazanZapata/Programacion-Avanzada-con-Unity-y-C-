using UnityEngine;

public class ScriptableObjects : MonoBehaviour
{
    public DataSO data;

    private void Start()
    {
        data.damage = 110;
    }
}
