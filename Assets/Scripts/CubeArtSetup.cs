using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CubeArtSetup", menuName = "ScriptableObjects/CubeArtSetup", order = 1)]
public class CubeArtSetup : ScriptableObject
{
    [SerializeField] private List<Material> _materials;

    [SerializeField] private Dictionary<string, Material> _materialDict;
    [SerializeField] private List<MaterialEntry> _namedMaterials;
}

[Serializable]
public struct MaterialEntry
{
    public string Id;
    public Material Material;
}