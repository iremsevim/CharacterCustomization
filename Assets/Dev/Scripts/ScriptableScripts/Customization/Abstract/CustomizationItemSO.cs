using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor;
using UnityEngine;


public abstract class CustomizationItemSO : ScriptableObject
{
    public string Name;
    public string Description;
    public Sprite CustomizationIcon;
    public int index;

    public string UID;

#if UNITY_EDITOR
    [PropertySpace(SpaceAfter = 10)]
    [Button("Reset ID", Style = ButtonStyle.Box)]
    private void ResetID()
    {
        if (EditorUtility.DisplayDialog("Are you sure?", "You can lost data", "Sure", "Nope!"))
        {
            UID = GUID.Generate().ToString();
            EditorUtility.SetDirty(this);
        }
    }
#endif

}


