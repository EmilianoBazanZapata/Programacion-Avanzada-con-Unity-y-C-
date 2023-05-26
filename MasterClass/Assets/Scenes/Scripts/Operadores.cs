using UnityEngine;

public class Operadores : MonoBehaviour
{
    public int myInt;
    public bool myBool;


    private void Start()
    {
        //Operadores Aritmeticos 
        myInt = 2 + 2;
        myInt = 2 - 2;
        myInt = 2 * 2;
        myInt = 2 / 2;

        //operadores de Asignacion
        myInt += 2;
        myInt -= 2;
        myInt *= 2;
        myInt /= 2;

        //Operadores Relacionales
        myBool = 2 > 1;
        myBool = 2 < 1;
        myBool = 2 == 1;
        myBool = 2 >= 1;
        myBool = 2 <= 1;
        myBool = 2 != 1;

        //Operadores Logicos

        myBool = 2 == 2 || 4 == 4;
        myBool = 2 == 2 && 4 == 4;
        myBool = !(2 == 2);
    }
}
