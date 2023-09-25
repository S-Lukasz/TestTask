using UnityEngine;

[CreateAssetMenu(fileName = "RangedWeapon", menuName = "GameData/RangedWeaponData")]
public class RangedWeaponData : WeaponData
{
    [Space(10)] [Header("Ranged")]
    [SerializeField] private int _MaxAmmo;
    [SerializeField] private int _ClipSize;
    [SerializeField] private float _FireRate;

    public int MaxAmmo => _MaxAmmo;
    public int ClipSize => _ClipSize;
    public float FireRate => _FireRate;

    public override Weapon Initialize()
    {
        return new RangedWeapon(Name, Damage, MaxAmmo, ClipSize, FireRate, Material, Type, Mesh, Prefab);
    }
}
