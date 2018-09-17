using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour {

    public Text wep;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            wep.text = "Extinguisher 1";
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            wep.text = "Extinguisher 2";
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            wep.text = "Extinguisher 3";
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            wep.text = "Extinguisher 4";
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            wep.text = "Extinguisher 5";
        }
    }
}
