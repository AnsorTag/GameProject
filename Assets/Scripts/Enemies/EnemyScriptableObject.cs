using UnityEngine;

[CreateAssetMenu(fileName = "EnemyScriptableObject", menuName = "Scriptable Objects/Enemy")]
public class EnemyScriptableObject : ScriptableObject
{
    // Base stats for enemies
    [SerializeField]
    float moveSpeed;
    public float MoveSpeed {get => moveSpeed; private set => moveSpeed = value;}
    
    [SerializeField]
    float damage;
    public float Damage {get => damage; private set => damage = value;}
    
    [SerializeField]
    float maxHealth;
    public float MaxHealth {get => maxHealth; private set => maxHealth = value;}
}
