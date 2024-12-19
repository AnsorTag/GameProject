using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [Header("Weapon stats")]
    public GameObject prefab;
    public float damage;
    public float speed;
    public float cooldownDuriation;
    float currentCooldown;
    public int pierce;
    protected PlayerMovement pm;

    protected virtual void Start()
    {
        pm = FindFirstObjectByType<PlayerMovement>();
        currentCooldown = cooldownDuriation;
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
        currentCooldown = cooldownDuriation;
    }
}
