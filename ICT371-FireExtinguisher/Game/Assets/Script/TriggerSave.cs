using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerSave : MonoBehaviour
{
    public GameObject opendoor;
    public GameObject closedoor;
    public GameObject timer;
    float high;
    float low;

    static float t = 0.0f;
    bool done = true;

    void Start()
    {
        high = 3.930143f;
        low = 1.206551f;
        timer = GameObject.FindGameObjectWithTag("timer");
        print("Test1");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Game.player.loc = other.gameObject.transform.position;
            
            Game.time = timer.GetComponent<Timer>().timeLeft;
            print("Test2");
            SaveLoad.Save();
            t = 0.0f;
            done = false;
        }
    }

    void Update()
    {
        if(!done)
        {
            OpenCloseDoors();
        }
    }

    void OpenCloseDoors()
    {
        opendoor.transform.position = Vector3.Lerp(opendoor.transform.position, new Vector3(opendoor.transform.position.x, low, opendoor.transform.position.z), t);
        closedoor.transform.position = Vector3.Lerp(closedoor.transform.position, new Vector3(closedoor.transform.position.x, high, closedoor.transform.position.z), t);

        t += Time.deltaTime;

        if(t>=1)
        {
            done = true;
        }
    }
}
