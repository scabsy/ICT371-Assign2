using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Character
{
    public float x, y, z;
    [SerializeField]
    public Vector3 loc;
    public float rotataion;
    
    public Character()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        UpdateCharacter(player.transform.position);
        rotataion = 0;
    }	

    public void UpdateCharacter(Vector3 nloc)
    {
        loc = nloc;
    }


}
