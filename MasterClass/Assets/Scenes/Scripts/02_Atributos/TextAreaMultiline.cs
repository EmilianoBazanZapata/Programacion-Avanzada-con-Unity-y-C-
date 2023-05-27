using UnityEngine;

public class TextAreaMultiline : MonoBehaviour
{
    [TextArea(1,10)]
    public string description;

    [Multiline(6)]//-> por defecto viene en 3
    public string note;
}
