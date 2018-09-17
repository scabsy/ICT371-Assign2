using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FiresRemaining : MonoBehaviour {
    public int fireRemaining;
    public Text fireText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        fireText.text =  (Game.fires.Length - Game.GetInactiveFires()).ToString() ;
	}
}
