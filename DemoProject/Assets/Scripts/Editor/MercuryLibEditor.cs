using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MercuryLibBehaviour))]
public class MercuryLibEditor : Editor
{
    //Texture texture;
    //Texture myTexture;

    public override void OnInspectorGUI()
    {
        var myTexture = Resources.Load("Test", typeof(Texture)) as Texture;

        GUILayout.Label(myTexture);
        //GUI.DrawTexture(new Rect(10, 10, 60, 60), myTexture);
        DrawDefaultInspector();
    }
}
