using UnityEngine;

public class PickableItem : MonoBehaviour
{
    [field: SerializeField] public InventoryItemData ItemData { get; private set; }

    private void Start()
    {
        if (ItemData == null)
        {
            Debug.LogAssertion("ItemData was not set");
            Destroy(this);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}