using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SwitcherItemController : MonoBehaviour
{
    public List<SwitcherItem> AllSwitcherItems;
    public SwitcherItem SelectedSwitcherItem;

    private void OnEnable()
    {
        SwitcherItem.OnClickedSwitcherItem += OnClickedSwitcherItem;
    }
    private void OnDisable()
    {
        SwitcherItem.OnClickedSwitcherItem -= OnClickedSwitcherItem;
    }
    private void OnClickedSwitcherItem(SwitcherItem obj)
    {
        SelectedSwitcherItem = obj;
        LoadSwitcherItemPanel(SelectedSwitcherItem);
       
    }
    private void LoadSwitcherItemPanel(SwitcherItem switcherItem)
    {
        AllSwitcherItems.ForEach(x => x.TabSwitchPanel.gameObject.SetActive(false));
        AllSwitcherItems.Find(x => x == switcherItem).TabSwitchPanel.gameObject.SetActive(true);
    }

    

}
