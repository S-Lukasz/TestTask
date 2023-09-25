using UnityEngine;

public enum WeaponType
{
    None,
    Melee,
    Ranged
}

[CreateAssetMenu(fileName = "Weapon", menuName = "GameData/WeaponData")]
public abstract class WeaponData : ScriptableObject
{
    [SerializeField] private string _Name;
    [SerializeField] private float _Damage;

    [Space(5)]
    [SerializeField] private Mesh _Mesh;
    [SerializeField] private Material _Material;

    [Space(5)]
    [SerializeField] private GameObject _WeaponPrefab;
    [SerializeField] private WeaponType _WeaponType;

    public string Name => _Name;
    public float Damage => _Damage;
    public Mesh Mesh => _Mesh;
    public Material Material => _Material;
    public WeaponType Type => _WeaponType;
    public GameObject Prefab => _WeaponPrefab;

    public abstract Weapon Initialize();
}
