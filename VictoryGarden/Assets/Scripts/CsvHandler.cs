using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CsvHandler {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void ImportAll()
    {
        ImportProduce();
    }

    public static void ImportProduce()
    {
        StreamReader reader = new StreamReader("Assets/Data/Produce.csv");
        while (!reader.EndOfStream)
        {
            Produce.AddProduce(reader.ReadLine().Split(','));
        }
    }
}
