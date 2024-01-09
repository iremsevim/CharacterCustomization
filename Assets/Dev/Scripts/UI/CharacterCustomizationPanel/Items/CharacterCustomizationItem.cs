using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCustomizationItem : MonoBehaviour
{
    public static event System.Action<CustomizationItemSO> OnClicked;
    public Image CustomImage;
    private CustomizationItemSO CustomizationItemSO;

    public void SetDataContainer(CustomizationItemSO customizationItemSO)
    {
        CustomizationItemSO = customizationItemSO;
        CustomImage.sprite = customizationItemSO.CustomizationIcon;
    }

    public void OnClick()
    {
        ClickItem();
    }
    private void ClickItem()
    {
        OnClicked?.Invoke(CustomizationItemSO);
    }
}
