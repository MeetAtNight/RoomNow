
using UnityEngine;

[CreateAssetMenu (fileName = "New Item", menuName = "Assets/Item")]
public class Item : ScriptableObject
{
    public string itemID;
    public string itemName;
    public int itemScore;
    public int itemCost;
    public Sprite itemSprite;
}
