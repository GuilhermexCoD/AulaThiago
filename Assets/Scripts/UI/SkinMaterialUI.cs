using UnityEngine;
using UnityEngine.UI;

public class SkinMaterialUI : MonoBehaviour
{
    public GameObject materialTogglePrefab;
    
    public Transform materialToggleContainer;
    
    public ToggleGroup materialToggleGroup;

    public CharacterVisualData selectedSkin;

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
        }
    }
}
