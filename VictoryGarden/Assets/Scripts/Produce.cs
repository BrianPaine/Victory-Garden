using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Produce : MonoBehaviour {

    public int DefaultCost;
    public string Name;
    public string Description;
    public string ImageString;

    public int TotalOwned;

    public Produce(string[] vals)
    {
        Name = vals[0];
        Description = vals[1];
        DefaultCost = Convert.ToInt32(vals[2]);
        ImageString = vals[3];
        TotalOwned = 0;
    }

    public static void AddProduce(string[] vals)
    {
        GameData.All_Produce.Add(new Produce(vals));
    }
}
