using UnityEngine;

public interface IIntractable
{
    void Interact();
}

public class Interfaces : MonoBehaviour
{
    public GameObject[] myInteractables;

    private void Start()
    {
        for (int i = 0; i < myInteractables.Length; i++)
        {
            IIntractable myInteractable = myInteractables[i].GetComponent<IIntractable>();
            myInteractable?.Interact();
        }
    }
}
