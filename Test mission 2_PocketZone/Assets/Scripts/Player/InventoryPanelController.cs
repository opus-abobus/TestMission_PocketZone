using UnityEngine;
using UnityEngine.UI;

public class InventoryPanelController : MonoBehaviour
{
    [SerializeField] private Button _inventoryButton;
    [SerializeField] private GameObject _inventoryPanel;

    private void Start()
    {
        if (_inventoryButton == null)
        {
            Debug.LogAssertion("Inventory button component was null");
        }
        else
        {
            _inventoryButton.onClick.AddListener(OnInventoryButtonClicked);
        }
    }

    private void OnInventoryButtonClicked()
    {
        _inventoryPanel.SetActive(_inventoryPanel.activeInHierarchy == false);
    }
}