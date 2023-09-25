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

        //Check if target is in range & attack rate

        //Spawn visual effect, set animation, set sound effect, take damage to target etc.
    }

    public MeleeWeapon(string name, float damage, float attackRange, float attackRate , Material material, WeaponType type, Mesh mesh, GameObject prefab) 
    : base(name, damage, material, type, mesh, prefab)
    {
        _AttackRange = attackRange;
        _AttackRate = attackRate;
    }
}
