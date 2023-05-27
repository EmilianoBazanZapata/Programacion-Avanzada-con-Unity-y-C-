using UnityEngine;

public class SerializeFieldHideInspector : MonoBehaviour
{
    [SerializeField]//-> sigue privado pero se ve desde la ventana
    private bool canShoot;

    [HideInInspector]//-> sigue publico pero no se ve desde la ventana
    public bool canRun;
}
