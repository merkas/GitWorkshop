using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MercuryLibBehaviour), true)]
public class MercuryLibEditor : Editor
{
    public override void OnInspectorGUI()
    {
        var myTexture = Resources.Load("Test", typeof(Texture)) as Texture;

        GUILayout.Label(myTexture);
        DrawDefaultInspector();
    }
}
