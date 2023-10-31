using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinMaterialUI : MonoBehaviour
{
    public GameObject materialTogglePrefab;
    public Transform materialToggleContainer;
    public ToggleGroup materialToggleGroup;

    private void Awake()
    {
        PopulateSkinMaterial();
    }

    public void PopulateSkinMaterial()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject clone = Instantiate(materialTogglePrefab, materialToggleContainer);
            Toggle materialToggle = clone.GetComponent<Toggle>();
            materialToggle.group = materialToggleGroup;
            
            Transform childBackground = materialToggle.transform.GetChild(1);
            Image backgroundImage = childBackground.GetComponent<Image>();

            backgroundImage.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
        }
    }
}
