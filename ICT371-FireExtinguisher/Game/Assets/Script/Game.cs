using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Game
{
    public static Game current;

    public static Character player;
    public static float time;

    //public List<GameObject> fires;
    public static GameObject [] fires;

    public Game()
    {
        player = new Character();
        fires = GameObject.FindGameObjectsWithTag("fire");
        try
        {
            time = GameObject.FindGameObjectWithTag("timer").GetComponent<Timer>().timeLeft;
        }
        catch
        {
            time = 0;
        }
        
    }

    public static int GetInactiveFires()
    {
        int inactiveFires = 0;
        if(fires[0])
        {
            for (int i=0;i<fires.Length;i++)
            {
                if(fires[i].GetComponent<ParticleSystem>().emissionRate<=0)
                {
                    inactiveFires++;
                }
            }
        }

        //Debug.Log(inactiveFires);
        return inactiveFires;
    }

    public int getFireCount()
    {
        return fires.Length;
    }
}
