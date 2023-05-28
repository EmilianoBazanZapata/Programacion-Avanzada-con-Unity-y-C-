using UnityEngine;

public class EnemyOrc : Enemy
{
    public override void Attack()
    {
        health = 999;

        base.Attack();

        Debug.Log($"{health}");
    }

    public override void Defense()
    {
        Debug.Log($"Enemy '{_title}' DEFENSE. Health '{health}'");
    }
}
