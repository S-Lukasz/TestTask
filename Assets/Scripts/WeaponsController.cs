using System.Collections.Generic;
using UnityEngine;

public class WeaponsController : MonoBehaviour
{
    [SerializeField] private Transform _WeaponParent;

    [Space(10)]
    [SerializeField] private WeaponUI _WeaponUI;
    [SerializeField] private WeaponData[] _AllWeaponData;

    private List<Weapon> _AllWeapons = new List<Weapon>();
    private GameObject _WeaponObject;
    private Weapon _CurrentWeapon;
    private int _WeaponIndex;

    private void Awake()
    {
        // Currently _AllWeaponData is set in the inspector of the class, but we could pull it all at the begining with the use of Resources,
        // example:  _AllWeaponData = Resources.LoadAll<WeaponData>("Weapons/"); -  in this case: 'Weapons/' is the path of the folder 
        // placed in 'Resources' with our weapons data.

        // It's easier way to collect all data when there is a lot of it to manage, - it is used only while developement of the project, not on the final build.

        foreach(var weaponData in _AllWeaponData)
        {
            var weapon = weaponData.Initialize();
            _AllWeapons.Add(weapon);
        }

        if(_AllWeapons.Count == 0)
            return;
        
        _CurrentWeapon = _AllWeapons[0];
        DisplayCurrentWeapon();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0)) UseWeapon();
        else if(Input.GetMouseButtonDown(1)) SetNextWeapon();
    }

    private void UseWeapon()
    {
        if(_CurrentWeapon == null)
            return;

        _CurrentWeapon.Use();
    }

    private void SetNextWeapon()
    {
        _WeaponIndex ++;
        _WeaponIndex = _WeaponIndex < _AllWeapons.Count ? _WeaponIndex : 0;

        _CurrentWeapon = _AllWeapons[_WeaponIndex];
        _WeaponUI.SetData(_CurrentWeapon);

        DisplayCurrentWeapon();
    }

    public void DisplayCurrentWeapon()
    {
        if(_CurrentWeapon == null)
            return;

        if(_WeaponObject != null)
            Destroy(_WeaponObject);

        //Here we could use some data from Weapon class like Material or Mesh, to set it on already existing object instead of instatiating it.
        //Second way to do this is to make object pool of weapons and then set currently selected as active, weapon could be selected by ID.

        //Simple weapon display with instantiate - only for showcase purpose
        var weaponPrefab = _CurrentWeapon.Prefab;
        _WeaponObject = Instantiate(weaponPrefab, _WeaponParent.position, weaponPrefab.transform.localRotation);

        _WeaponObject.transform.SetParent(_WeaponParent);
        _WeaponObject.transform.localPosition = Vector3.zero;
        _WeaponObject.transform.localScale = weaponPrefab.transform.localScale;
        
    }
}
