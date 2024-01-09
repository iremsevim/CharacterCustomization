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

    public void ApplyCustomizationData(CustomizationItemSO customizationItemSO)
    {
       if(customizationItemSO is CustomizableBodySO)
        {
            BodyMeshRenderers.ForEach(x => x.gameObject.SetActive(false));
            BodyMeshRenderers[customizationItemSO.index].SetActive(true);
        }
        if (customizationItemSO is CustomizableFeetSO)
        {
            FeetsMeshRenderers.ForEach(x => x.gameObject.SetActive(false));
            FeetsMeshRenderers[customizationItemSO.index].SetActive(true);
        }
        if (customizationItemSO is CustomizableLegSO)
        {
            LegsMeshRenderers.ForEach(x => x.gameObject.SetActive(false));
            LegsMeshRenderers[customizationItemSO.index].SetActive(true);
        }
        if(customizationItemSO is CustomizableHeadSO)
        {
            HeadMeshRenderers.ForEach(x => x.gameObject.SetActive(false));
            HeadMeshRenderers[customizationItemSO.index].SetActive(true);
        }
    }
}
