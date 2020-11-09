using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityFall : MonoBehaviour
{
    public int gravityValue = 1;
    bool isFalling = true;
    bool calledOnce;

    void FixedUpdate()
    {
        if (isFalling)
        {
            Vector3 currentPos = gameObject.transform.position;
            gameObject.transform.position = currentPos - new Vector3(0, gravityValue, 0);
        }
        isFalling = !Physics.Raycast(transform.position, -Vector3.up, 3f);
        Debug.Log("isFalling = " + isFalling);
        Debug.DrawRay(transform.position, -Vector3.up, Color.green);

        if (!isFalling && !calledOnce)
        {
            this.GetComponent<ParticleEffectSpawner>().SpawnParticleEffectOneTime();
            this.GetComponent<TimedDestroy>().WaitAndDestroy();
            calledOnce = true;
        }
    }
}
