using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideWalls : MonoBehaviour
{
    Vector3 start, end;
    public float targetX, targetZ,speed;
    bool inPosition;

    static float t = 0.0f;

    // Use this for initialization
    void Start ()
    {
        inPosition = false;
        start = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        end =  new Vector3(targetX,0,targetZ);
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (!inPosition)
        {
            MoveToPos();
        }
    }

    void MoveToPos()
    {
        transform.position = Vector3.Lerp(start, end, t);
        t += 0.1f * Time.deltaTime / speed;
        if(t > 1.0f)
        {
            inPosition = true;
            DestroyRigidBody();
        }
    }

    void DestroyRigidBody()
    {
        foreach (Transform t in gameObject.transform)
        {
            Destroy(t.GetComponent<Rigidbody>());
        }
    }
}
