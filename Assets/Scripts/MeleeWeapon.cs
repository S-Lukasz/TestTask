using UnityEngine;

public class MeleeWeapon : Weapon
{
    private float _AttackRange;
    private float _AttackRate;

    public float AttackRange => _AttackRange;
    public float AttackRate => _AttackRate;

    public override void Use()
    {
        Debug.Log("Melee weapon used");
    }

    public MeleeWeapon(string name, float damage, float attackRange, float attackRate , Material material, WeaponType type, Mesh mesh, GameObject prefab) 
    : base(name, damage, material, type, mesh, prefab)
    {

    }
}
