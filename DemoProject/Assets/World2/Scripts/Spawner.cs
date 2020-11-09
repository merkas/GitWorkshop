using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obj;

    void Update()
    {
        Vector3 randomPos = new Vector3(Random.Range(-100f, 100f), 2.5f, Random.Range(-100f, 100f));
        Instantiate(obj, randomPos, Quaternion.identity);
    }
}
