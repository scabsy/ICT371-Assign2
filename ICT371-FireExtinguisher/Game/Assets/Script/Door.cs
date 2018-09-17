using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public float timer = 3.0f;
    Vector3 upPos;
    Vector3 downPos;

    static float t = 0.0f;
    bool up = true;

    public Material white;

    // Use this for initialization
    void Start ()
    {
        downPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        upPos = new Vector3(transform.position.x, transform.position.y + 4.0f, transform.position.z);
        GetComponent<Renderer>().material = white;
    }
	
	// Update is called once per frame
	void Update ()
    {
        timer -= Time.deltaTime;

        if(timer<=0.0f)
        {

            SlideDoor();
        }
	}

    void SlideDoor()
    {
        transform.position = Vector3.Lerp(downPos, upPos, t);

        if(up)
        {
            t += 0.9f * Time.deltaTime;
        }
        else
        {
            t -= 0.9f * Time.deltaTime;
        }

        if (t > 1.0f)
        {          
            //up = false;
            GetComponent<Renderer>().material = white;
        }
        else if(t<0.0f)
        {
            up = true;
        }
    }
}
