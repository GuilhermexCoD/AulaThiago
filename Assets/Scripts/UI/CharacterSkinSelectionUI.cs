using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSkinSelectionUI : MonoBehaviour
{
    public SkinUI[] skins;

    public CharacterVisualData selectedSkin;

    public void SkinButtonClicked(int index)
    {
        Debug.Log($"Cliquei no botao com index {index}");
        selectedSkin = skins[index].skinData;
    }
}
