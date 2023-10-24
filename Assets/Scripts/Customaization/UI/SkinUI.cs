using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinUI : MonoBehaviour
{
    [SerializeField] private CharacterVisualData _skinData;
    [SerializeField] private Image _iconImage;

    public void SetSkinData(CharacterVisualData skinData)
    {
        _skinData = skinData;
        UpdateIcon();
    }

    [ContextMenu(nameof(UpdateIcon))]
    private void UpdateIcon()
    {
        _iconImage.sprite = _skinData.icon;
    }
}
