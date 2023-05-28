using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [Header("Enemy")]
    protected string _title;
    [SerializeField] protected int damage;
    [SerializeField] protected float health;

    //permite dividir el get y el set
    public string Title { get { return _title; } set => _title = value; }

    private void Start()
    {
        Attack();
    }

    public virtual void Attack()
    {
        Debug.Log($"Enemy '{_title}' ATTACK. Damage: '{damage}'");
    }

    public abstract void Defense();
}
