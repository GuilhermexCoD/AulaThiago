using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterVisual : MonoBehaviour
{
    [SerializeField] private int _meshIndex;
    [SerializeField] private Mesh[] _meshes;

    [SerializeField] private SkinnedMeshRenderer _skinnedMeshRenderer;

    [ContextMenu(nameof(UpdateCharacterMesh))]
    void UpdateCharacterMesh()
    {
        _skinnedMeshRenderer.forceMatrixRecalculationPerRender = true;

        _skinnedMeshRenderer.sharedMesh = GetMeshByIndex(_meshIndex);
    }

    [ContextMenu(nameof(NextMesh))]
    private void NextMesh()
    {
        _meshIndex = GetNextIndex();
        UpdateCharacterMesh();
    }

    private int GetNextIndex()
    {
        int nextIndex;

        int length = _meshes.Length;
        int index = _meshIndex + 1;


        if (index >= length)
            nextIndex = 0;
        else
            nextIndex = index;

        //Outro modo de calcular o proximo valor
        //nextIndex = (_meshIndex + 1) % _meshes.Length;
        return nextIndex;
    }

    [ContextMenu(nameof(PreviewMesh))]
    private void PreviewMesh()
    {
        _meshIndex = GetPreviewIndex();
        UpdateCharacterMesh();
    }

    private int GetPreviewIndex()
    {
        int previewIndex;

        int length = _meshes.Length;
        int index = _meshIndex - 1;


        if (index < 0)
            previewIndex = length - 1;
        else
            previewIndex = index;

        //Outro modo de calcular o valor anterior
        //previewIndex = ((index % length) + length) % length;

        return previewIndex;
    }

    private Mesh GetMeshByIndex(int index)
    {
        return _meshes[index];
    }
}
