using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseDoor : MonoBehaviour
{
    public GameObject door;
    public bool goingDown;
    public bool SoundOnEnd;
    float high;
    float low;
    public int firesRequired;

    static float t = 0.0f;
    bool done = true;
    
    AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
        high = 3.930143f;
        low = 1.206551f;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if(firesRequired>0)
            {
                if (Game.GetInactiveFires() >= firesRequired)
                {
                    t = 0.0f;
                    done = false;
                }
                if(!SoundOnEnd)
                {
                    if (Game.GetInactiveFires() < firesRequired)
                    {
                        if (source != null)
                        {
                            source.Play();
                        }
                    }
                }
                if (SoundOnEnd)
                {
                    if (Game.GetInactiveFires() == firesRequired)
                    {
                        if (source != null)
                        {
                            source.Play();
                        }
                    }
                }

            }
            else
            {
                if(door!=null)
                {
                    t = 0.0f;
                    done = false;
                }
                if (source != null)
                {
                    source.Play();
                }
            }
            
                //if (Game.GetInactiveFires() == firesRequired)
            
        }
    }

    // Update is called once per frame
    void Update ()
    {
        if (!done && door != null)
        {
            OpenCloseDoors();
        }
    }

    void OpenCloseDoors()
    {
        if(goingDown)
            door.transform.position = Vector3.Lerp(door.transform.position, new Vector3(door.transform.position.x, low, door.transform.position.z), t);
        else
            door.transform.position = Vector3.Lerp(door.transform.position, new Vector3(door.transform.position.x, high, door.transform.position.z), t);

        t += Time.deltaTime * 2;

        if (t >= 1)
        {
            done = true;
        }
    }
}
