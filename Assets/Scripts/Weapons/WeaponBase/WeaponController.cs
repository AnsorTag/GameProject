using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [Header("Weapon stats")]
    public WeaponScriptableObject weaponData;
    float currentCooldown;

    protected PlayerMovement pm;

    protected virtual void Start()
    {
        pm = FindFirstObjectByType<PlayerMovement>();
        currentCooldown = weaponData.CooldownDuriation;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        currentCooldown -= Time.deltaTime;
        if (currentCooldown <= 0f)
        {
            Attack();
        }
    }

    protected virtual void Attack()
    {
        currentCooldown = weaponData.CooldownDuriation;
    }
}
