using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FireExtingusher : MonoBehaviour {

    public ParticleSystem flameParticle;

    private float emitRate = 400;
	// Use this for initialization
	void Start () {
        //emitRate = flameParticle.emissionRate;
        flameParticle.emissionRate = 0.0f;
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Fire1")!=0)
        {
            flameParticle.emissionRate = emitRate;
        }
        else// if(Input.GetMouseButtonUp(0))
        {
            flameParticle.emissionRate = 0.0f;
        }
	}
}
