using TMPro;
using UnityEngine;

public class WeaponUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _WeaponName;
    [SerializeField] private TextMeshProUGUI _WeaponInfo;
    
    private const string _InfoText = " - Type: {0}\n - Damage: {1}";

    public void SetData(Weapon weapon)
    {
        _WeaponName.text = weapon.Name;
        _WeaponInfo.text = string.Format(_InfoText, weapon.Type, weapon.Damage);
    }

}
