using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAsset : MonoBehaviour
{
    private static GameAsset _i;

    public static GameAsset i
    {
        get
        {
            if (_i == null)
            {
                _i = Instantiate(Resources.Load("GameAsset") as GameObject).GetComponent<GameAsset>();
            }

            return _i;
        }
    }

    public Item[] item1;
   

    public GameObject[] prefab;

}
