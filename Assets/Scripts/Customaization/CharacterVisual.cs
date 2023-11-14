using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterVisual : MonoBehaviour
{
    [SerializeField] private Mesh _mesh;
    [SerializeField] private Material _material;

    [SerializeField] private SkinnedMeshRenderer _skinnedMeshRenderer;

    public void UpdateCharacterSkin(Mesh mesh)
    {
        _mesh = mesh;
        
        _skinnedMeshRenderer.forceMatrixRecalculationPerRender = true;

        _skinnedMeshRenderer.sharedMesh = _mesh;
    }

    public void UpdateCharacterMaterial(Material material) 
    {
        _material = material;
        _skinnedMeshRenderer.material = _material;
        _skinnedMeshRenderer.forceMatrixRecalculationPerRender = true;
    }
}
