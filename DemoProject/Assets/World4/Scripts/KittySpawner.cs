using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class KittySpawner : MonoBehaviour
{
    public Transform kittyPrefab;
    public Transform parent;

    public void Update()
    {
        //TODO: how do i get the pointereventdata?
        //OnPointerDown();
        Debug.Log("should a kitty be spawned?");
    }

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        Debug.Log("clicked");
        SpawnKitty(pointerEventData.position);
    }

    private void SpawnKitty(Vector3 position)
    {
        Debug.Log("kitty spawned");
        GameObject kitty = GameObject.Instantiate(kittyPrefab.gameObject, position, Quaternion.identity, parent);
    }


}
