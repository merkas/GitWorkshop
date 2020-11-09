using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactDistributer : MonoBehaviour
{
    public float maxImpactDist = 5.0f;
    public float impactForce = 10;

    public void DistributeImpact()
    {
        Collider[] collisions = Physics.OverlapSphere(transform.position, maxImpactDist, LayerMask.GetMask("Cubes"));
        Debug.Log("collisions.Length = " + collisions.Length);

        foreach (Collider current in collisions)
        {
            if (current.gameObject == this.gameObject) continue;

            Rigidbody currentRb = current.GetComponent<Rigidbody>();

            Vector3 forceDirection = (current.transform.position - transform.position).normalized;
            float dist = Vector3.Distance(current.transform.position, transform.position);

            float forceValue = (1 - (dist / maxImpactDist)) * impactForce;
            //maxDist 10  current 3  for current 0 maxForce; for current 10 minForce::       3 / 10 = 0.3 -> 1-0.3 * 10
            Debug.Log(forceDirection * forceValue);
            currentRb.velocity = (forceDirection * forceValue);
        }
    }
}
