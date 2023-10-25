using UnityEngine;

[CreateAssetMenu(fileName = "Character Skin Data", menuName = "ScriptableObjects/Create Skin", order = 1)]
public class CharacterVisualData : ScriptableObject
{
    public string skinName;
    public Sprite icon;
    public Mesh mesh;
    public Material[] materials;
}