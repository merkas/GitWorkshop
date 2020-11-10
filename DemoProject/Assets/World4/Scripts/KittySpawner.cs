using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro.Examples;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class KittySpawner : MonoBehaviour
{
    public Transform kittyPrefab;
    public Transform parent;
    private int counter = 0;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnKitty(Input.mousePosition);
        }
    }

    private void SpawnKitty(Vector3 position)
    {
        Debug.Log(position);
        GameObject kitty = GameObject.Instantiate(kittyPrefab.gameObject, position, Quaternion.identity, parent);

        kitty.name = "SuperKitty" + counter;
        counter++;
    }
}
