using System.Collections.Generic;
using UnityEngine;

public class CubeArt : MonoBehaviour
{
    [SerializeField] private List<Material> _materials;
    private Renderer _renderer;

    private void Start()
    {
        Init();
        InvokeRepeating("ChangeMaterial", 1f, 1f);
    }

    private void Init()
    {
        _renderer = GetComponentInChildren<Renderer>();
    }

    private void ChangeMaterial()
    {
        var randomNumber = Random.Range(0, _materials.Count - 1);
        _renderer.material = _materials[randomNumber];
    }
}