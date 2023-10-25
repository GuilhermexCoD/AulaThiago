using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterVisual : MonoBehaviour
{
    [SerializeField] private Mesh _mesh;
    [SerializeField] private Material _material;

    [SerializeField] private SkinnedMeshRenderer _skinnedMeshRenderer;

    public void UpdateCharacterSkin(Mesh mesh, Material material)
    {
        _mesh = mesh;
        _material = material;

        _skinnedMeshRenderer.forceMatrixRecalculationPerRender = true;

        _skinnedMeshRenderer.sharedMesh = _mesh;
        _skinnedMeshRenderer.material = _material;
    }
}
