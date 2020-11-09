using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ball;

    public void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(ball, this.gameObject.transform);
        }
    }
}
