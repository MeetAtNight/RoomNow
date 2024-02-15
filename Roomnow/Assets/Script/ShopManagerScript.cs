using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManagerScript : MonoBehaviour
{
    public int[,] shopItem = new int[5,5];
    public float coins;
    public Text CoinsTXT;

    public GameAsset item1;
    public GameObject shopPanel;
    public GameObject sofa;

    public void ActivateShop(bool activate)
    {
        shopPanel.SetActive(activate);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        CoinsTXT.text = "Coins:" + coins.ToString();

        shopItem[1, 1] = 1;
        shopItem[1, 2] = 2;
        shopItem[1, 3] = 3;
        shopItem[1, 4] = 4;
        
        //Price
        shopItem[2, 1] = 100;
        shopItem[2, 2] = 150;
        shopItem[2, 3] = 200;
        shopItem[2, 4] = 250;
        
        //Quantity
        shopItem[3, 1] = 0;
        shopItem[3, 2] = 0;
        shopItem[3, 3] = 0;
        shopItem[3, 4] = 0;
        
    }

    // Update is called once per frame
    public void Buy(int index)
    {
        /*GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>()
            .currentSelectedGameObject;

        if (coins >= shopItem[2, ButtonRef.GetComponent<ButtonInfo>().ItemID]);
        {
            coins -= shopItem[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            shopItem[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]++;
            CoinsTXT.text = "Coins:" + coins.ToString();
            ButtonRef.GetComponent<ButtonInfo>().QuantityTxt.text = 
                shopItem[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
        }*/
        Instantiate(GameAsset.i.prefab[index],Vector3.zero, Quaternion.identity);
    }

    public void Update()
    {
        
    }
}
