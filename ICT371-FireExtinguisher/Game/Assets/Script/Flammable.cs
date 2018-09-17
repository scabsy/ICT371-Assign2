using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flammable : MonoBehaviour {
    public string extinguisherType;
    public ParticleSystem partSystem;
    public float fireSize;
    public int flameLeft = 5;
    int count;
    private void Start()
    {
        count = 0;
        //print("test");
        fireSize = partSystem.emissionRate;
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag(extinguisherType))
        {
            count++;
           // print("particle collision detected " + count);
            if (count >= flameLeft)
            {
                //print("emissionrate dropped");
                partSystem.emissionRate = partSystem.emissionRate - 1.0f;
                fireSize = partSystem.emissionRate;
                count = 0;
            }
        }
        //else
            //print("particle collision detected but wrong type " + count);

    }
}
