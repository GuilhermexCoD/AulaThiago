using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterVisual : MonoBehaviour
{
    [SerializeField]
    private Mesh _mesh;
    [SerializeField]
    private SkinnedMeshRenderer _skinnedMeshRenderer;
    
    [ContextMenu("AtualizarSkin")]
    private void UpdateMesh()
    {
        _skinnedMeshRenderer.forceMatrixRecalculationPerRender = true;
        _skinnedMeshRenderer.sharedMesh = _mesh;

    }
}
