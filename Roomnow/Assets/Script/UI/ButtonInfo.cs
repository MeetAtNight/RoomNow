using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{

    public int ItemID;
    public Text PriceTxt;
    public Text QuantityTxt;
    public GameObject ShopMagager;

    // Update is called once per frame
    void Start()
    {
        PriceTxt.text = "Price: $" + ShopMagager.GetComponent<ShopManagerScript>().shopItem[2, ItemID].ToString();
        QuantityTxt.text = ShopMagager.GetComponent<ShopManagerScript>().shopItem[3, ItemID].ToString();
    }
}
