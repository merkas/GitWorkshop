using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDestroy : MonoBehaviour
{
    public float waitTime;

    public void WaitAndDestroy(float waitTimeInSeconds)
    {
        StartCoroutine(WaitAndDestroyCoroutine(waitTimeInSeconds));
    }

    IEnumerator WaitAndDestroyCoroutine(float waitTimeInSeconds)
    {
        yield return new WaitForSeconds(waitTimeInSeconds);
        Destroy(gameObject);
    }

    public void WaitAndDestroy()
    {
        StartCoroutine(WaitAndDestroyCoroutine());
    }

    IEnumerator WaitAndDestroyCoroutine()
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject);
    }
}
