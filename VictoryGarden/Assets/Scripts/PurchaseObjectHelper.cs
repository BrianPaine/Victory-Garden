using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseObjectHelper : MonoBehaviour {

    public Text Name;
    public Text NameBG;
    public Text Desc;
    public Text DescBG;
    public Text Cost;
    public Text CostBG;

    public Image Picture;
    public Button PurchaseButton;

    public int AssociatedProduceItem;

    public PopulatePurchaseMenu PPM;

    public void ButtonPressed()
    {
        PPM.ButtonPressed(AssociatedProduceItem);
    }
}
