using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffectSpawner : MonoBehaviour
{
    public GameObject particleEffect;

    public void SpawnParticleEffectOneTime()
    {
        Instantiate(particleEffect, gameObject.transform);
        this.enabled = false;
        //Destroy(this);
    }
}
