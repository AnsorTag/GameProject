using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileWeaponBehaviour : MonoBehaviour
{
    public WeaponScriptableObject weaponData;
    protected Vector3 direction;
    public float destroyAfterSeconds;

    //current stats
    protected float currentDamage;
    protected float currentSpeed;
    protected float currentCooldownDuriation;
    protected int currentPierce;

    void Awake()
    {
        currentDamage = weaponData.Damage;
        currentSpeed = weaponData.Speed;
        currentCooldownDuriation = weaponData.CooldownDuriation;
        currentPierce = weaponData.Pierce;
    }

    protected virtual void Start()
    {
        Destroy(gameObject, destroyAfterSeconds);
    }

    public void DirectionChecker(Vector3 dir)
    {
        direction = dir;

        float dirx = direction.x;
        float diry = direction.y;

        Vector3 scale = transform.localScale;
        Vector3 rotation = transform.rotation.eulerAngles;

    if (dirx > 0 && diry == 0) {
        scale.x = scale.x * 1;  
        scale.y = scale.y * 1;  
    }
    
    else if (dirx < 0 && diry == 0) {
        scale.x = scale.x * -1;  
        scale.y = scale.y * -1;  
    }

    else if (dirx == 0 && diry > 0) {
        scale.x = scale.x * -1; 
        scale.y = scale.y * 1;
    }

    else if (dirx == 0 && diry < 0) {
        scale.x = scale.x * 1;
        scale.y = scale.y * -1;
    }

    else if (dirx > 0 && diry > 0) {
        scale.x = scale.x * 1;
        scale.y = scale.y * 1;
        rotation.z = 0;
    }

    else if (dirx < 0 && diry > 0) {
        scale.x = scale.x * -1;
        scale.y = scale.y * 1;
        rotation.z = 0;
    }

    else if (dirx > 0 && diry < 0) {
        scale.x = scale.x * 1;
        scale.y = scale.y * -1;
        rotation.z = 0;
    }

    else if (dirx < 0 && diry < 0) {
        scale.x = scale.x * -1;
        scale.y = scale.y * -1;
        rotation.z = 0;
    }

        transform.localScale = scale;
        transform.rotation = Quaternion.Euler(rotation);
    }

    protected virtual void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Enemy"))
        {
            EnemyStats enemy = col.GetComponent<EnemyStats>();
            enemy.TakeDamage(currentDamage);
            ReducePierce();
        }
    }

    void ReducePierce()
    {
        currentPierce--;
        if (currentPierce <= 0) { Destroy(gameObject); }
    }
}
