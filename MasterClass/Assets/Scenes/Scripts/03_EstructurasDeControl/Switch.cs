using Unity.VisualScripting;
using UnityEngine;

public enum EPlatform 
{
    None,
    PC,
    Xbox,
    PlayStation,
    Switch
}

public class Switch : MonoBehaviour
{
    public int weaponType;
    public string enemyClass;
    public EPlatform currentPlatform;

    private void Start()
    {
        switch (currentPlatform) 
        {
            case EPlatform.None:
                break;
            case EPlatform.PC:
                break;
            case EPlatform.Xbox:
                break;
            case EPlatform.PlayStation:
                break;
            case EPlatform.Switch:
                break;
            default:
                break;
        }
    }
}
