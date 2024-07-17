using UnityEngine;

[CreateAssetMenu(fileName = "InventoryItemData", menuName = "ScriptableObjects/InventoryItemData")]
public class InventoryItemData : ScriptableObject
{
    [field: SerializeField] public string Name { get; private set; }

    [field: SerializeField, Min(1)] public int MaxStackSize { get; private set; } = 1;

    [field: SerializeField] public Sprite SpriteInSlot { get; private set; }

    [field: SerializeField] public ItemType TypeOfItem { get; private set; }

    public enum ItemType
    {
        Gun, Ammo, Clothes
    }
}