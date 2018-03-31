using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startup : MonoBehaviour {

	// Use this for initialization
	void Start () {

        CsvHandler.ImportAll();
        Debug.Log(GameData.All_Produce.Count);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
