using UnityEngine;

public class Variables : MonoBehaviour
{
    //Tipos de datos(Valor)
    public int myInt;
    public float myFloat;
    public double myDouble;
    public bool myBool;
    public string myString;
    public char myChar;
    public Vector3 myStructVector;
    public Quaternion myStructQuaternion;

    //Tipos de datos(Referencia)
    public Transform myClassTransform;
    public GameObject myClassGameObject;
    public Variables myClass;

    // Start is called before the first frame update
    private void Start()
    {
        //Tipos de datos(Valor)
        myInt = 0;
        myFloat = 0;
        myDouble = 0;
        myBool = false;
        myString = string.Empty;
        myChar = '\0';
        myStructVector = new Vector3(1,2,3);
        myStructQuaternion = Quaternion.identity;

        //Tipos de datos(Referencia)
        myClass = this;
        myClassGameObject = gameObject;
        myClassTransform = gameObject.transform;
    }
}
