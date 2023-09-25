using UnityEngine;

public class RangedWeapon : Weapon
{
    private int _MaxAmmo;
    private int _ClipSize;
    private float _FireRate;

    public int MaxAmmo => _MaxAmmo;
    public int ClipSize => _ClipSize;
    public float FireRate => _FireRate;

    public override void Use()
    {
        Debug.Log("Ranged weapon used");

        //Check fire rate & available ammo

        //Use ammo

        //Spawn projectiles, set animation etc.
    }

    public RangedWeapon(string name, float damage, int maxAmmo, int clipSize, float fireRate, Material material, WeaponType type, Mesh mesh, GameObject prefab) 
    : base(name, damage, material, type, mesh, prefab)
    {
        _MaxAmmo = maxAmmo;
        _ClipSize = clipSize;
        _FireRate = fireRate;
    }

}
