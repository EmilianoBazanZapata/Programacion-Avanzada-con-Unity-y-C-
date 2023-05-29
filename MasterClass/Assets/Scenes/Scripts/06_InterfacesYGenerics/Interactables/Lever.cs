using UnityEngine;

public class Lever : MonoBehaviour, IIntractable
{
    public void Interact()
    {
        Debug.Log("Interaction: Lever");
    }

}
