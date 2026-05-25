using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/New Item")]

public class ScriptableItems : ScriptableObject
{
   public string itemName;
   public Sprite itemSprite;
}
