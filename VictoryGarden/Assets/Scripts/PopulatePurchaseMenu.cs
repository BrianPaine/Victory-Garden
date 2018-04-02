using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulatePurchaseMenu : MonoBehaviour {

    public GameObject PurchaseUIObject;

    bool generated = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameData.All_Produce.Count > 0 && !generated)
        {
            generated = true;
            SetupPurchaseMenu();
        }
	}

    public void ButtonPressed(int associatedVal)
    {
        GameData.All_Produce[associatedVal].TotalOwned++;
        //Debug.Log(associatedVal);
    }

    public void SetupPurchaseMenu()
    {

        Debug.Log("Starting...");
        for (int a = 0; a < GameData.All_Produce.Count; a++)
        {
            GameObject go = GameObject.Instantiate(PurchaseUIObject);
            go.transform.SetParent(this.transform);

            go.transform.localPosition = new Vector3(0, a * -135, 0);
            go.transform.localScale = new Vector3(1.25f, 1.25f, 1.25f);

            go.GetComponent<PurchaseObjectHelper>().Name.text = GameData.All_Produce[a].Name;
            go.GetComponent<PurchaseObjectHelper>().NameBG.text = GameData.All_Produce[a].Name;
            go.GetComponent<PurchaseObjectHelper>().Desc.text = GameData.All_Produce[a].Description;
            go.GetComponent<PurchaseObjectHelper>().DescBG.text = GameData.All_Produce[a].Description;
            go.GetComponent<PurchaseObjectHelper>().Cost.text = GameData.All_Produce[a].DefaultCost.ToString();
            go.GetComponent<PurchaseObjectHelper>().CostBG.text = GameData.All_Produce[a].DefaultCost.ToString();
            go.GetComponent<PurchaseObjectHelper>().AssociatedProduceItem = a;

            go.GetComponent<PurchaseObjectHelper>().PPM = this;

            //go.GetComponent<PurchaseObjectHelper>().Picture.sprite = new Sprite();//Sprite(Resources.Load<Texture>("Assets/"));
        }
    }
}
