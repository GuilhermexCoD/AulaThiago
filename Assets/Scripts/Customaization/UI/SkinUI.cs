using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;

public class SkinUI : MonoBehaviour
{
    [SerializeField] private CharacterVisualData _skinData;
    [SerializeField] private Image _iconImage;

    [SerializeField] private CharacterVisual _characterVisual;

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

    public void ChangeSkinButton()
    {
        Material[] materials = _skinData.materials;
        //0 - 14
        int materialIndex = Random.Range(0, 15);
        Material material = materials[materialIndex];
        _characterVisual.UpdateCharacterSkin(_skinData.mesh, material);
    }
}
