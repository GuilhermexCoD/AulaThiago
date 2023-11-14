using Unity.VisualScripting;
using UnityEngine;

public class MaterialUI : MonoBehaviour
{
    public CharacterVisual characterVisual;
    public Material material;

    public void OnToggleValueChanged(bool isOn)
    {
        if (isOn)
        {
            characterVisual.UpdateCharacterMaterial(material);
        }
    }
}
