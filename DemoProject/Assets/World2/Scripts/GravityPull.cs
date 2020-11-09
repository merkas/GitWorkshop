using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityPull : MonoBehaviour
{
    public int gravityValue = 1;

    void FixedUpdate()
    {
        Vector3 currentPos = gameObject.transform.position;
        gameObject.transform.position = currentPos - new Vector3(0, gravityValue, 0);
    }
}
