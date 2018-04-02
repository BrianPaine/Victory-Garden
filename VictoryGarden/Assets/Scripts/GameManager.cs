using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    int currentTick = 0;
    List<GameObject> PlantNotis = new List<GameObject>();
    public UIHolder UI;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        currentTick++;
        CheckPlants();
        UpdatePlantNotis();

	}

    void CheckPlants()
    {

        for (int a = 0; a < GameData.All_Produce.Count; a++)
        {
            if (currentTick % 60 == (a * 10))
            {
                if (GameData.All_Produce[a].TotalOwned > 0)
                {
                    GameData.Gold += GameData.All_Produce[a].TotalOwned;
                    CreateNewPlantNotification(GameData.All_Produce[a].Name + ": " + GameData.All_Produce[a].TotalOwned);
                }
            }
        }
    }

    void UpdatePlantNotis()
    {
        for (int x = 0; x < PlantNotis.Count; x++)
        {
            Debug.Log("Updating noti");
            PlantNotis[x].transform.localPosition = new Vector3(
                PlantNotis[x].transform.localPosition.x, 
                PlantNotis[x].transform.localPosition.y + 4, 
                PlantNotis[x].transform.localPosition.z);
            PlantNotis[x].GetComponent<PlantNotificationHelper>().TotalTimeAlive++;
            if (PlantNotis[x].GetComponent<PlantNotificationHelper>().TotalTimeAlive > 50)
            {
                GameObject go = PlantNotis[x];
                PlantNotis.Remove(go);
                GameObject.Destroy(go);
                x--;
            }
        }
    }

    void CreateNewPlantNotification(string text)
    {
        Debug.Log("Creating noti");
        PlantNotis.Add(GameObject.Instantiate(UI.PlantNoti));
        PlantNotis[PlantNotis.Count - 1].transform.SetParent(UI.UICanvas.transform);
        PlantNotis[PlantNotis.Count - 1].transform.localScale = new Vector3(1, 1, 1);
        PlantNotis[PlantNotis.Count - 1].transform.localPosition = new Vector3(-250, -400, 0);
        PlantNotis[PlantNotis.Count - 1].GetComponent<PlantNotificationHelper>().NotiText.text = text;
        PlantNotis[PlantNotis.Count - 1].GetComponent<PlantNotificationHelper>().NotiTextBG.text = text;
        //PlantNotis.Add(new UI)
    }
}
