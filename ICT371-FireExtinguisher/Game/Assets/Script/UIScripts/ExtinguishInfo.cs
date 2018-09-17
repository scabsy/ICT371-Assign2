using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[Serializable]
public class ExtinguishInfo  {

    public string fireExt1;
    public string fireExt2;
    public string fireExt3;
    public string fireExt4;
    public string fireExt5;
    public Text tool;

    public void Initialize()
    {
        this.FireExt1 = fireExt1;
        this.FireExt2 = fireExt2;
        this.FireExt3 = fireExt3;
        this.FireExt4 = fireExt4;
        this.FireExt5 = fireExt5;

        //fireExt1 = "Extinguish 1";
        //fireExt2 = "Extinguish 2";
        //fireExt3 = "Extinguish 3";
        //fireExt4 = "Extinguish 4";
        //fireExt5 = "Extinguish 5";
    }

    public void Tool1()
    {
        tool.text = fireExt1;
    }

    public void Tool2()
    {
        tool.text = fireExt2;
    }

    public void Tool3()
    {
        tool.text = fireExt3;
    }

    public void Tool4()
    {
        tool.text = fireExt4;
    }

    public string FireExt1
    {
        get
        {
            return fireExt1;
        }

        set
        {
            tool.text = fireExt1;
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
            tool.text = fireExt2;
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
            tool.text = fireExt3;
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
            tool.text = fireExt4;
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
