using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAmmoFill : MonoBehaviour
{

    public GameObject gameManager;
    // Use this for initialization
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("gamemanager");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameManager.GetComponent<Player>().ammo.CurrentVal = gameManager.GetComponent<Player>().ammo.MaxVal;
            gameManager.GetComponent<Player>().ammo1.CurrentVal = gameManager.GetComponent<Player>().ammo1.MaxVal;
            gameManager.GetComponent<Player>().ammo2.CurrentVal = gameManager.GetComponent<Player>().ammo2.MaxVal;
        }

    }
}