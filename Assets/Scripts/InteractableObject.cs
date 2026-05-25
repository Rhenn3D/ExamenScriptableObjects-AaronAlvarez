using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public ScriptableItems item;
    public SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        spriteRenderer.sprite = item.itemSprite;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        InventoryManager _inventoryScript = FindFirstObjectByType<InventoryManager>().GetComponent<InventoryManager>();
        _inventoryScript.AddItem(item);
        Destroy(gameObject);
    }
}
