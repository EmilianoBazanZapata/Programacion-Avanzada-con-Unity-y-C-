using UnityEngine;

public class TipoEnum : MonoBehaviour
{
    // 0 = fire
    // 1 = ice
    // 2 = sword
    // 3 = punch
    public int attackTypeInt;

    public enum AttackType
    {
        None,
        Fire,
        Ice,
        Sword,
        Punch
    }

    public AttackType attackEnum;

    private void Start()
    {
        attackEnum = AttackType.Sword;
    }
}
