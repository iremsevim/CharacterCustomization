using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCustomizationPanel : MonoBehaviour
{
    public Transform CustomizableLegItemsCarrier;
    public Transform CustomizableFeetItemsCarrier;
    public Transform CustomizableBodyItemsCarrier;
    public Transform CustomizableHeadItemsCarrier;
    public AllCustomizationItemSO AllCustomizationItemSO;
    public CharacterCustomizationItem CharacterCustomizationItemPrefab;

    private void Awake()
    {
        LoadCustomizableItems();
    }
    public void LoadCustomizableItems()
    {
        LoadCustomizableLegItems();
        LoadCustomizableFeetItems();
        LoadCustomizableBodyItems();
        LoadCustomizableHeadItems();
    }
    protected void LoadCustomizableLegItems()
    {
         foreach (var item in AllCustomizationItemSO.customizableLegSOs)
         {
            var createdLegItem = Instantiate(CharacterCustomizationItemPrefab.gameObject, CustomizableLegItemsCarrier.position, Quaternion.identity, CustomizableLegItemsCarrier).
            TryGetComponent(out CharacterCustomizationItem characterCustomizationItem);
            characterCustomizationItem.SetDataContainer(item);
        }
    }
    protected void LoadCustomizableFeetItems()
    {
        foreach (var item in AllCustomizationItemSO.customizableFeetSOs)
        {
            var createdFeetItem = Instantiate(CharacterCustomizationItemPrefab.gameObject, CustomizableFeetItemsCarrier.position, Quaternion.identity, CustomizableFeetItemsCarrier).
            TryGetComponent(out CharacterCustomizationItem characterCustomizationItem);
            characterCustomizationItem.SetDataContainer(item);
        }
    }
    protected void LoadCustomizableBodyItems()
    {
        foreach (var item in AllCustomizationItemSO.customizableBodySOs)
        {
            var createdBodyItem = Instantiate(CharacterCustomizationItemPrefab.gameObject, CustomizableBodyItemsCarrier.position, Quaternion.identity,CustomizableBodyItemsCarrier).
            TryGetComponent(out CharacterCustomizationItem characterCustomizationItem);
            characterCustomizationItem.SetDataContainer(item);
        }
    }
    protected void LoadCustomizableHeadItems()
    {
        foreach (var item in AllCustomizationItemSO.customizableHeadSOs)
        {
            var createdBodyItem = Instantiate(CharacterCustomizationItemPrefab.gameObject, CustomizableHeadItemsCarrier.position, Quaternion.identity,CustomizableHeadItemsCarrier).
            TryGetComponent(out CharacterCustomizationItem characterCustomizationItem);
            characterCustomizationItem.SetDataContainer(item);
        }
    }
}
