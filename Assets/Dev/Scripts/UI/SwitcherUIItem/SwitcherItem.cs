using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SwitcherItem : MonoBehaviour
{
    public static Action<SwitcherItem> OnClickedSwitcherItem;
    public TabSwitchPanel TabSwitchPanel;

    public void OnClick()
    {
        OnClickedSwitcherItem?.Invoke(this);
      
    }
}
