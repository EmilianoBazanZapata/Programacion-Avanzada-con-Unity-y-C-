using UnityEngine;

public class Window : MonoBehaviour, IIntractable
{
    public void Interact()
    {
        Debug.Log("Interaction: Window");
    }
}
