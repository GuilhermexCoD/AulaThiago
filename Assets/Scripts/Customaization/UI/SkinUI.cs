using UnityEngine;
using UnityEngine.UI;

public class SkinUI : MonoBehaviour
{
    public CharacterVisualData skinData;
    [SerializeField] private Image _iconImage;

    [SerializeField] private CharacterVisual _characterVisual;

    public void SetSkinData(CharacterVisualData skinData)
    {
        this.skinData = skinData;
        UpdateIcon();
    }

    [ContextMenu(nameof(UpdateIcon))]
    private void UpdateIcon()
    {
        _iconImage.sprite = skinData.icon;
    }

    public void ChangeSkinButton()
    {
        Material[] materials = skinData.materials;
        //0 - 14
        int materialIndex = Random.Range(0, 15);
        Material material = materials[materialIndex];
        _characterVisual.UpdateCharacterSkin(skinData.mesh, material);
    }
}
