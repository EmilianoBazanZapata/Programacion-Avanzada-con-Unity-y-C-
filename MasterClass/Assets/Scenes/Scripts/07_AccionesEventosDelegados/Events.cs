using UnityEngine;
using UnityEngine.Events;

public class Events : MonoBehaviour
{
    //event
    public delegate void MyDelegatevent();
    //public MyDelegateEvent myDelegateEventVar; // Delegate
    public event MyDelegatevent myEventVar; //Evento

    //UnityEvent
    public UnityEvent myUnityEventVar;
    public UnityEvent<bool> myUnityEventOneParamVar;
    public UnityEvent<bool, int, string> myUnityEventThreeParamVar;

    private void Start()
    {
        //Event --> no se visualiza en el editor para poder visualizarlo
        myEventVar += PrintMessage;
        myEventVar();
        myEventVar.Invoke();

        //UnityEvent --> se logra ver en el editor
        myUnityEventVar.AddListener(PrintMessage);// agrego
        myUnityEventVar.RemoveListener(PrintMessage);//quito
        myUnityEventVar.Invoke();//esta es la unica forma de llamarlo

        myUnityEventOneParamVar.Invoke(true);
        myUnityEventThreeParamVar.Invoke(true, 1, "asdf");
    }

    private void PrintMessage()
    {
        Debug.Log("Hello World!");
    }
}
