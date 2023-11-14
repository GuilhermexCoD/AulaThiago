using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.UI;

public class SkinMaterialUI : MonoBehaviour
{
    public GameObject materialTogglePrefab;
    
    public Transform materialToggleContainer;
    
    public ToggleGroup materialToggleGroup;

    public CharacterVisualData selectedSkin;

    public CharacterVisual characterVisual;

    private void Awake()
    {
        PopulateSkinMaterial(selectedSkin.materialColors);
    }

    public void SetSelectedSkin(CharacterVisualData skin)
    {
        selectedSkin = skin;
        PopulateSkinMaterial(selectedSkin.materialColors);
    }

    public void PopulateSkinMaterial(Color[] colors)
    {
        for (int i = 0; i < colors.Length; i++)
        {
            GameObject clone = Instantiate(materialTogglePrefab, materialToggleContainer);

            Toggle materialToggle = clone.GetComponent<Toggle>();
            materialToggle.group = materialToggleGroup;
            
            Transform childBackground = materialToggle.transform.GetChild(1);
            Image backgroundImage = childBackground.GetComponent<Image>();

            backgroundImage.color = colors[i];

            MaterialUI materialUI = clone.GetComponent<MaterialUI>();
            materialUI.characterVisual = characterVisual;
            materialUI.material = selectedSkin.materials[i];


            materialToggle.onValueChanged.AddListener(materialUI.OnToggleValueChanged);
        }
    }
}
