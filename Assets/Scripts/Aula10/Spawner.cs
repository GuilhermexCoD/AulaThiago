using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public enum InstantiateType
    {
        Clone,
        WithParent,
        WithParentWorldStays,
        PositionRotation,
        PositionRotationParent,
    }

    public GameObject prefab;
    public Transform parent;
    public bool worldPositionStays;
    public Vector3 position;
    public Quaternion rotation;
    public InstantiateType instantiateType;

    void Start()
    {
        switch (instantiateType)
        {
            case InstantiateType.Clone:
                ClonePrefab();
                break;
            case InstantiateType.WithParent:
                ClonePrefabWithParent();
                break;
            case InstantiateType.WithParentWorldStays:
                ClonePrefabWithParentWorldStays();
                break;
            case InstantiateType.PositionRotation:
                ClonePrefabPositionRotation();
                break;
            case InstantiateType.PositionRotationParent:
                ClonePrefabPositionRotationParent();
                break;

            default:
                break;
        }
    }

    //Apenas clona o prefab na posicao estabelecida no prefab.
    public void ClonePrefab()
    {
        GameObject clone = Instantiate(prefab);

        clone.gameObject.name = $"{prefab.name} - {instantiateType}";
    }

    //Clona o prefab filho do parent;
    public void ClonePrefabWithParent()
    {
        GameObject clone = Instantiate(prefab, parent);

        clone.gameObject.name = $"{prefab.name} - {instantiateType}";
    }

    //Clona o prefab filho do parent e se verdadeiro o clone fica em relacao ao mundo, se falso fica em relacao ao parent.
    public void ClonePrefabWithParentWorldStays()
    {
        GameObject clone = Instantiate(prefab, parent, worldPositionStays);

        clone.gameObject.name = $"{prefab.name} - {instantiateType} : {worldPositionStays}";
    }

    //Clona o prefab sem parent na posicao e rotacao passada como parametro em relacao ao mundo.
    public void ClonePrefabPositionRotation()
    {
        GameObject clone = Instantiate(prefab, position, rotation);

        clone.gameObject.name = $"{prefab.name} - {instantiateType}";

    }

    //Clona o prefab com um parent na posicao e rotacao passada como parametro em relacao ao mundo.
    public void ClonePrefabPositionRotationParent()
    {
        GameObject clone = Instantiate(prefab, position, rotation, parent);

        clone.gameObject.name = $"{prefab.name} - {instantiateType}";

    }
}
