using UnityEngine;

public class Door : MonoBehaviour, IIntractable
{
    public void Interact()
    {
        Debug.Log("Interaction: Door");
    }
}
