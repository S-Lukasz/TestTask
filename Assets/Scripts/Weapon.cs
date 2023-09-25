using UnityEngine;

public abstract class Weapon
{
    private string _Name;
    private float _Damage;
    private Mesh _Mesh;
    private Material _Material;
    private WeaponType _WeaponType;
    private GameObject _WeaponPrefab;

    public string Name => _Name;
    public float Damage => _Damage;
    public Mesh Mesh => _Mesh;
    public Material Material => _Material;
    public WeaponType Type => _WeaponType;
    public GameObject Prefab => _WeaponPrefab;
    
    public Weapon(string name, float damage, Material material, WeaponType weaponType, Mesh mesh, GameObject prefab)
    {
        _Name = name;
        _Mesh = mesh;
        _Damage = damage;
        _Material = material;
        _WeaponPrefab = prefab;
        _WeaponType = weaponType;
    }

    public abstract void Use();
}
