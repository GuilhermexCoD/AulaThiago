using UnityEngine;

[CreateAssetMenu(fileName = "SkinData", menuName = "ScriptableObjects/Skin", order = 1)]
public class CharacterVisualData : ScriptableObject
{
    public string skinName;
    public Sprite icon;
    public Mesh mesh;
    public Material[] materials;
}