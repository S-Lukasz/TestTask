using UnityEngine;

[CreateAssetMenu(fileName = "MeleeWeapon", menuName = "GameData/MeleeWeaponData")]
public class MeleeWeaponData : WeaponData
{
    [Space(10)] [Header("Melee")]
    [SerializeField] private float _AttackRange;
    [SerializeField] private float _AttackRate;

    public float AttackRange => _AttackRange;
    public float AttackRate => _AttackRate;

    public override Weapon Initialize()
    {
        return new MeleeWeapon(Name, Damage, AttackRange, AttackRate, Material, Type, Mesh, Prefab);
    }
}
