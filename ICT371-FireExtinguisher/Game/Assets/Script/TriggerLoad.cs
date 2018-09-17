using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerLoad : MonoBehaviour
{
    private GameObject player;

    public GameObject timer;
    //private string time;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SaveLoad.Load();
            
            //Vector3 a = new Vector3(Game.player.x, Game.player.y, Game.player.z);
            other.gameObject.transform.position = Game.player.loc;
            Debug.Log(other.gameObject.transform.position.x + " " + other.gameObject.transform.position.y + " " + other.gameObject.transform.position.z);
        }
    }

    public void OnButtonClick()
    {
        print("asdhfasdhfashdf");
        player = GameObject.FindGameObjectWithTag("Player");
        timer = GameObject.FindGameObjectWithTag("timer");
        SaveLoad.Load();

        //Vector3 a = new Vector3(Game.player.x, Game.player.y, Game.player.z);
        timer.gameObject.GetComponent<Timer>().timeLeft = Game.time;
        player.gameObject.transform.position = Game.player.loc;
        Debug.Log(player.gameObject.transform.position.x + " " + player.gameObject.transform.position.y + " " + player.gameObject.transform.position.z);
    }
}
