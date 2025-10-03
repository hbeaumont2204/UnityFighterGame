using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class InventorySlot : MonoBehaviour, IPointerClickHandler
{
    public InventoryItem myItem { get; set; }
    public SlotTag myTag;

    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            if (InventoryItem.carriedItem == null) return;
            if (myTag != SlotTag.None && InventoryItem.carriedItem.myItem.itemTag != myTag) return;
            SetItem(InventoryItem.carriedItem);
        }
    }

    public void SetItem(InventoryItem item)
    {
        InventoryItem.carriedItem = null;

        item.activeSlot.myItem = null;

        myItem = item;
        myItem.activeSlot = this;
        myItem.transform.SetParent(transform);
        myItem.canvasGroup.blocksRaycasts = true;

        if(myTag != SlotTag.None)
        {
            InventoryItem.Singleton.EquipEquipment(myTag, myItem);
        }
    }
}
