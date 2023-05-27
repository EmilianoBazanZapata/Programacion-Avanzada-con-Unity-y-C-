using UnityEngine;

public class Conversion : MonoBehaviour
{
    private void Start()
    {
        //Conversion(cast)
        int myCastInt = (int)2.55f;

        Collider myCollider = GetComponent<Collider>();
        
        BoxCollider myBoxCollider;
       
        myBoxCollider = (BoxCollider)myCollider;
        
        myBoxCollider = myCollider as BoxCollider;

        //Conversion(parse)
        string myStringInt = "123";
        int myIntParsed;

        myIntParsed = int.Parse(myStringInt);//--> 128
        bool resultParse = int.TryParse(myStringInt,out myIntParsed);

        //Conversion(enum)
        string myStringEnum = "Fire";

        AttackType myEnum;

        myEnum = (AttackType)System.Enum.Parse(typeof(AttackType), myStringEnum);

    }
}
