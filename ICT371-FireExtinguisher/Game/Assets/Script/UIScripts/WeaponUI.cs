using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class WeaponUI : MonoBehaviour
{
    private string fireExt1 = "Extinguish 1";
    private string fireExt2 = "Extinguish 2";
    private string fireExt3 = "Extinguish 3";
    private string fireExt4 = "Extinguish 4";
    private string fireExt5 = "Extinguish 5";


    public string FireExt1
    {
        get
        {
            return fireExt1;
        }

        set
        {
            fireExt1 = value;
        }
    }

    public string FireExt2
    {
        get
        {
            return fireExt2;
        }

        set
        {
            fireExt2 = value;
        }
    }

    public string FireExt3
    {
        get
        {
            return fireExt3;
        }

        set
        {
            fireExt3 = value;
        }
    }

    public string FireExt4
    {
        get
        {
            return fireExt4;
        }

        set
        {
            fireExt4 = value;
        }
    }

    public string FireExt5
    {
        get
        {
            return fireExt5;
        }

        set
        {
            fireExt5 = value;
        }
    }
}
