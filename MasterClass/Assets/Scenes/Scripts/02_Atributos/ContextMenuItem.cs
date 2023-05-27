using UnityEngine;

public class ContextMenuItem : MonoBehaviour
{
    [ContextMenu("Execute")]
    private void PrintExecute() 
    {
        Debug.Log("Execute");
    }

    [ContextMenuItem("Get a Random Scale", "ExecuteRandomScale")]
    public float randomScale;

    private void ExecuteRandomScale() 
    {
        randomScale = Random.Range(0, 10f);
    }
}
