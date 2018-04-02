using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CURR_GOLD : MonoBehaviour {

    public Text Gold;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Gold.text = GameData.Gold.ToString();

    }
}
