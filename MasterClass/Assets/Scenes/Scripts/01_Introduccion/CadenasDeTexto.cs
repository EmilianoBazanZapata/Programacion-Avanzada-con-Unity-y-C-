using UnityEngine;

public class CadenasDeTexto : MonoBehaviour
{
    public string myString;

    // Start is called before the first frame update
    private void Start()
    {
        myString = "Emiliano";

        //esto no es recomendable, ya que al concatenar los string
        //estamos usando mas memora de lo habitual
        // y a la larga genera basura

        #region mala practica
        myString = "Emiliano" + " " + "Bazan";

        int age = 23;

        myString = "Emiliano's Birthday : " + age.ToString();
        #endregion

        #region buena practica
        myString = string.Format("{0}'s Birthday : {1}","Emiliano",age);
        myString = $"Emiliano's Birthday : {age}";
        #endregion

        myString = "27_Mariano_Rifle";
        string[] characterInfo = myString.Split('_');
        //characterInfo[0] = "27";
        //characterInfo[1] = "Mariano";
        //characterInfo[2] = "Rifle";
    }
}
