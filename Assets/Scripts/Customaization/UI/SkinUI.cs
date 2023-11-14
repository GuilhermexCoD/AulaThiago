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
        _characterVisual.UpdateCharacterSkin(skinData.mesh);
    }
}
