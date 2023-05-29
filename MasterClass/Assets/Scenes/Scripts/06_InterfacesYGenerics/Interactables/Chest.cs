using UnityEngine;

public class Chest : MonoBehaviour, IIntractable
{
    public void Interact()
    {
        Debug.Log("Interaction: Chest");
    }
}
