using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveVelocity : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(10, 0, 0);
    }
}
