using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnReds : MonoBehaviour
{
    public GameObject red;

    void Update()
    {
        Vector3 randomPos = new Vector3(Random.Range(-100f, 100f), 2.5f, Random.Range(-100f, 100f));
        Instantiate(red, randomPos, Quaternion.identity);
    }
}
