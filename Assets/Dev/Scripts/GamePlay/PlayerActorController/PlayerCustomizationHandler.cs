using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCustomizationHandler : MonoBehaviour
{
    public List<GameObject> LegsMeshRenderers;
    public List<GameObject> HeadMeshRenderers;
    public List<GameObject> BodyMeshRenderers; 
    public List<GameObject> FeetsMeshRenderers;
    public AllCustomizationItemSO AllCustomizationItemSOs;

    private void OnEnable()
    {
        CharacterCustomizationItem.OnClicked += CharacterCustomizationItemClicked;
    }
    private void OnDisable()
    {
        CharacterCustomizationItem.OnClicked -= CharacterCustomizationItemClicked;
    }

    private void CharacterCustomizationItemClicked(CustomizationItemSO obj)
    {
        ApplyCustomizationData(obj);
    }

    protected void ApplyCustomizationData(CustomizationItemSO customizationItemSO)
    {
        FindCustomItemType(customizationItemSO);
    }
    private void FindCustomItemType(CustomizationItemSO customizationItemSO)
    {
       var customitemfeet= AllCustomizationItemSOs.customizableFeetSOs.Find(x => x.UID == customizationItemSO.UID);  
       var customitembody= AllCustomizationItemSOs.customizableBodySOs.Find(x => x.UID == customizationItemSO.UID);
       var customitemleg= AllCustomizationItemSOs.customizableLegSOs.Find(x => x.UID == customizationItemSO.UID);
       var customitemhead = AllCustomizationItemSOs.customizableHeadSOs.Find(x => x.UID == customizationItemSO.UID);
        if(customitemfeet)
        {
            FeetsMeshRenderers.ForEach(x => x.gameObject.SetActive(false));
            FeetsMeshRenderers[customizationItemSO.index].SetActive(true);
        }
        if(customitembody)
        {
            BodyMeshRenderers.ForEach(x => x.gameObject.SetActive(false));
            BodyMeshRenderers[customizationItemSO.index].SetActive(true);
        }
        if(customitemleg)
        {
            LegsMeshRenderers.ForEach(x => x.gameObject.SetActive(false));
            LegsMeshRenderers[customizationItemSO.index].SetActive(true);
        }
        if(customitemhead)
        {
            HeadMeshRenderers.ForEach(x => x.gameObject.SetActive(false));
            HeadMeshRenderers[customizationItemSO.index].SetActive(true);

        }

    }
}
