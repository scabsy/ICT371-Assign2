using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour {
    public float timeLeft = 5.0f;
    public GameObject panell;
    public GameObject losePanel;
    public GameObject winPanel;
    public Text timer;
    [SerializeField]
    private Vector3 ble;
    bool pause = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (panell.active || winPanel.active)
        {
            pause = false;
        }
        else
            pause = true;
            
           

        if (timeLeft >= 0)
        {
            if(pause)
            {
                timeLeft -= Time.deltaTime;
                //Mathf.Round(timeLeft);
                timer.text = timeLeft.ToString("F2");
            }

        }
        else
        {
            timer.text = "0";
            panell.active = false;
            losePanel.active = true;
        }
        
            
	}
    public void setTimer(float time)
    {
        time = timeLeft;
    }

    public float getTime()
    {
        return timeLeft;
    }
}
