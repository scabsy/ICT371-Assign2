using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTimes : MonoBehaviour {
    public Text timer;
    public GameObject time;
	// Use this for initialization
	void Start () {
        time = GameObject.FindGameObjectWithTag("timer");
    }
	
	// Update is called once per frame
	void Update () {
        string[] tmp = timer.text.Split(':');
        timer.text = tmp[0] + ": " + GameObject.FindGameObjectWithTag("timer").GetComponent<Timer>().timeLeft; 
    }


}
