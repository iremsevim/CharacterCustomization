using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 [CreateAssetMenu(fileName = nameof(AllCustomizationItemSO), menuName ="Game/Customization/"+nameof(AllCustomizationItemSO))]
public class AllCustomizationItemSO : ScriptableObject
{
    public List<CustomizableBodySO> customizableBodySOs;
    public List<CustomizableFeetSO> customizableFeetSOs;
    public List<CustomizableHeadSO> customizableHeadSOs;
    public List<CustomizableLegSO> customizableLegSOs;
}
