using UnityEngine;

[CreateAssetMenu(fileName = "WeaponScriptableObject", menuName = "Scriptable Objects/Weapon")]
public class WeaponScriptableObject : ScriptableObject
{
    [SerializeField]
    GameObject prefab;
    public GameObject Prefab {get => prefab; private set => prefab = value; }
    
    //Base Stats for weapons
    [SerializeField]
    float damage;
    public float Damage {get => damage; private set => damage = value; }
    
    [SerializeField]
    float speed;  
    public float Speed {get => speed; private set => speed = value; }
    
    [SerializeField]
    float cooldownDuriation;
    public float CooldownDuriation {get => cooldownDuriation; private set => cooldownDuriation = value; }
    
    [SerializeField]
    int pierce;
    public int Pierce {get => pierce; private set => pierce = value;}
}
