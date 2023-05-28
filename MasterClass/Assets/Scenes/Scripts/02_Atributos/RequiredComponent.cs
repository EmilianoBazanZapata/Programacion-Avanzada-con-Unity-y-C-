using UnityEngine;

[RequireComponent(typeof(BoxCollider), typeof(Rigidbody))]
public class RequiredComponent : MonoBehaviour
{
    private BoxCollider boxCollider;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        boxCollider = rb.GetComponent<BoxCollider>();
    }

    private void Start()
    {
        boxCollider.enabled = true;
        rb.isKinematic = true;  
    }
}
