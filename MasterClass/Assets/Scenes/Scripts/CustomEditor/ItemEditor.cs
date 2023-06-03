using UnityEditor;
using UnityEngine;

[UnityEditor.CustomEditor(typeof(Item))]
public class ItemEditor : Editor
{
    private Item currentTarget;
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        currentTarget = (Item)target;

        //agrego un espacio en el editor
        GUILayout.Space(10);

        if (!EditorApplication.isPlaying)
            GUILayout.Box($"Data: {currentTarget.data.title} (${currentTarget.data.price})");

        if (IsTargetReady())
        {
            //se deactiva todo lo que esta dento de begin y en el end
            EditorGUI.BeginDisabledGroup(EditorApplication.isPlaying);

            string buttonText = EditorApplication.isPlaying ? "Consume (Only in editor mode)" : "Consume";

            //crear un boton --> me permite validar si todo esta correctamente o si hay algun error
            //aumento la altura del boton a 30
            if (GUILayout.Button(buttonText, GUILayout.Height(30)))
            {
                currentTarget.Consume();
            }
            //este es el end
            EditorGUI.EndDisabledGroup();
        }
        else
        {
            //caartel visual
            EditorGUILayout.HelpBox($"Error: {GetErrorMessage()}", MessageType.Error);
        }
    }

    private bool IsTargetReady()
    {
        return currentTarget.data &&
               currentTarget.itemImg &&
               currentTarget.itemTitleTxt &&
               currentTarget.itemPriceTxt;
    }

    private string GetErrorMessage()
    {
        if(!currentTarget.data) return "Data Empty!";
        if(!currentTarget.itemImg) return "Image reference Empty!";
        if(!currentTarget.itemPriceTxt) return "Title reference Empty!";
        if(!currentTarget.itemTitleTxt) return "Price reference Empty!";

        return "Unknown";
    }
}