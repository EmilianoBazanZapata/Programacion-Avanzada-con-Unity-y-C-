using UnityEngine;

public class Delegate : MonoBehaviour
{
    //void
    public delegate void MyDelegate();
    public MyDelegate myDelegateVar;

    //return
    public delegate int MyDelegateInt();
    public MyDelegateInt myDelegateIntVar;

    //params
    public delegate void MyDelegateOneParam(string myString);
    public MyDelegateOneParam myDelegateOneParamVar;

    //multicast
    public delegate void MyDelegateMultiCast();
    public MyDelegateMultiCast myDelegateMultiCastVar;

    //callback
    public delegate void MyDelegateCallBack(bool success);
    public MyDelegateCallBack myDelegateCallBackVar;

    bool connectionReady = true;

    private void Start()
    {
        //void 
        myDelegateVar = PrintMessage;
        //las dos maneras de ejecutarlo
        myDelegateVar();
        myDelegateVar.Invoke();

        //return 
        myDelegateIntVar = GetWeaponId;
        int myWeapon;
        myWeapon = myDelegateIntVar();
        myWeapon = myDelegateIntVar.Invoke();

        //params
        myDelegateOneParamVar = PrintMessageWithValue;
        myDelegateOneParamVar("Mundo");
        myDelegateOneParamVar.Invoke("World");

        //multicast
        myDelegateMultiCastVar += ChangeWeapon;
        myDelegateMultiCastVar += ChangeCar;
        myDelegateMultiCastVar();
        myDelegateMultiCastVar.Invoke();

        //callback
        myDelegateCallBackVar = RequestCompleted;
        RequestConnection(myDelegateCallBackVar);
    }

    private void PrintMessage()
    {
        Debug.Log("Hola Mundo");
    }

    private int GetWeaponId()
    {
        return 5;
    }

    private void PrintMessageWithValue(string message)
    {
        Debug.Log($"Hello {message}!");
    }

    private void ChangeWeapon()
    {
        Debug.Log($"Weapon 5");
    }

    private void ChangeCar()
    {
        Debug.Log($"Car 5");
    }


    private void RequestConnection(MyDelegateCallBack callBack)
    {
        if (connectionReady)
        callBack(true);
        else
        callBack(false);
    }

    private void RequestCompleted(bool success)
    {
        Debug.Log($"Connection Ready: {success}");
    }
}