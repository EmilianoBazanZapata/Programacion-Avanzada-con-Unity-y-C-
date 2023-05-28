using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string title;
    public int damage;
    public float health;

    private void Start()
    {
        Attack();
    }

    public virtual void Attack()
    {
        Debug.Log($"Enemy '{title}' ATTACK. Damage: '{damage}'");
    }

    private void OnDestroy()
    {
        Debug.Log($"Enemy '{title}' DEFENSE. Health '{health}'");
    }
}
