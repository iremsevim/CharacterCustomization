using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using DG.Tweening;

public class SwitcherItem : MonoBehaviour
{
    public static Action<SwitcherItem> OnClickedSwitcherItem;
    public TabSwitchPanel TabSwitchPanel;
    public Transform SwitcherItemFrame;
    private bool IsSelected;

    private void Start()
    {
        IsSelected = true;
    }
    public void OnClick()
    {
        OnClickedSwitcherItem?.Invoke(this);
        ChangeFrameScale();
    }

    protected void ChangeFrameScale()
    {
        if (!IsSelected) return;
        IsSelected = false;
        
        SwitcherItemFrame.DOScale(SwitcherItemFrame.localScale * 1.11f, 0.05f).OnComplete(() =>
        {
            SwitcherItemFrame.DOScale(SwitcherItemFrame.localScale / 1.11f, 0.05f).OnComplete(()=>
            {
                IsSelected = true;
            });
          
        });
    }
}
