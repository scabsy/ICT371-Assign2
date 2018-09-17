using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    
    public Stats ammo;
    public Stats ammo1;
    public Stats ammo2;
    public Stats ammo3;
    public Stats ammo4;
    public ParticleSystem co2;
    public ParticleSystem water;
    public ParticleSystem abe;

    [SerializeField]
    private GameObject panel;
    public GameObject objectiveTab;
    public GameObject winScreen ;

    private float emitRate = 400;

    AudioSource complete;

    [SerializeField]
    private ExtinguishInfo extinguisher;


    private void Awake ()
    {
        ammo.Initialize();


        //extinguisher.Initialize();
    }
	// Use this for initialization
	void Start () {
        winScreen.active = false;
    }
	
    float getAmmo1()
    {
        return ammo1.CurrentVal;
    }
	// Update is called once per frame
	void Update () {

        if(Game.GetInactiveFires() == Game.fires.Length)
        {
            winScreen.active = true;

            complete = GetComponent<AudioSource>();
            complete.Play();
        }

        if (Input.GetAxis("Fire1") != 0)
        {
            if (extinguisher.tool.text == extinguisher.FireExt1)
            {
                if(ammo.CurrentVal > 0)
                {
                    co2.emissionRate = emitRate;
                    ammo.CurrentVal = ammo.CurrentVal;
                    ammo.CurrentVal -= 0.5f;
                }
                else
                {
                    co2.emissionRate = 0.0f;
                }
                    
            }
            if (extinguisher.tool.text == extinguisher.FireExt2)
            {
                if (ammo1.CurrentVal > 0){
                    water.emissionRate = emitRate;
                    ammo1.CurrentVal = ammo1.CurrentVal;
                    ammo1.CurrentVal -= 0.5f;
                }
                else
                {
                    water.emissionRate = 0.0f;
                }
                
            }
            if (extinguisher.tool.text == extinguisher.FireExt3)
            {
                if (ammo2.CurrentVal > 0)
                {
                    abe.emissionRate = emitRate;
                    ammo2.CurrentVal = ammo2.CurrentVal;
                    ammo2.CurrentVal -= 0.5f;
                }
                else
                {
                    abe.emissionRate = 0.0f;
                }

            }
            if (extinguisher.tool.text == extinguisher.FireExt4)
            {
                ammo3.CurrentVal = ammo3.CurrentVal;
                ammo3.CurrentVal -= 10;
            }
            if (extinguisher.tool.text == extinguisher.FireExt5)
            {
                ammo4.CurrentVal = ammo4.CurrentVal;
                ammo4.CurrentVal -= 10;
            }
        }
        else
        {
            co2.emissionRate = 0.0f;
            water.emissionRate = 0.0f;
            abe.emissionRate = 0.0f;
        }

        
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(extinguisher.tool.text == extinguisher.FireExt1)
            {
                ammo.CurrentVal = ammo.CurrentVal;
                ammo.CurrentVal += 10;
            }
            if (extinguisher.tool.text == extinguisher.FireExt2)
            {
                ammo1.CurrentVal = ammo1.CurrentVal;
                ammo1.CurrentVal += 10;
            }
            if (extinguisher.tool.text == extinguisher.FireExt3)
            {
                ammo2.CurrentVal = ammo2.CurrentVal;
                ammo2.CurrentVal += 10;
            }
            if (extinguisher.tool.text == extinguisher.FireExt4)
            {
                ammo3.CurrentVal = ammo3.CurrentVal;
                ammo3.CurrentVal += 10;
            }
            if (extinguisher.tool.text == extinguisher.FireExt5)
            {
                ammo4.CurrentVal = ammo4.CurrentVal;
                ammo4.CurrentVal += 10;
            }

        }

        
        if (Input.GetAxis("weapon1") != 0)
        {
            extinguisher.tool.text = extinguisher.FireExt1;
            ammo.CurrentVal = ammo.CurrentVal;
        }
        if (Input.GetAxis("weapon2") != 0)
        {
            extinguisher.tool.text = extinguisher.FireExt2;
            ammo1.CurrentVal = ammo1.CurrentVal;
        }
        if (Input.GetAxis("weapon3") != 0)
        {
            extinguisher.tool.text = extinguisher.FireExt3;
            ammo2.CurrentVal = ammo2.CurrentVal;
        }

        if (Input.GetAxis("Cancel") != 0) 
        {
            if (panel.active)
            {
                panel.active = false;
            }
            else
            {
                panel.active = true;
            }
        }

        if (Input.GetAxis("objective") != 0)
        {
            if (objectiveTab.active)
            {
                objectiveTab.active = false;
            }
            else
            {
                objectiveTab.active = true;
            }
        }

    }
}
