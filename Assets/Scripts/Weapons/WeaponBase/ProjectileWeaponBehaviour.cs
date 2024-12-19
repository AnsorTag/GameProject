using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileWeaponBehaviour : MonoBehaviour
{
    protected Vector3 direction;
    public float destroyAfterSeconds;

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

        // Right direction (dirx > 0, diry == 0) - No change needed
    if (dirx > 0 && diry == 0) {
        scale.x = scale.x * 1;  // No flip horizontally
        scale.y = scale.y * 1;  // No flip vertically
    }

    // Left direction (dirx < 0, diry == 0) - No change needed
    else if (dirx < 0 && diry == 0) {
        scale.x = scale.x * -1;  // Flip horizontally
        scale.y = scale.y * -1;  // Flip vertically
    }

    // Up direction (dirx == 0, diry > 0) - No change needed
    else if (dirx == 0 && diry > 0) {
        scale.x = scale.x * -1;  // Flip horizontally
        scale.y = scale.y * 1;   // No flip vertically
    }

    // Down direction (dirx == 0, diry < 0) - No change needed
    else if (dirx == 0 && diry < 0) {
        scale.x = scale.x * 1;   // No flip horizontally
        scale.y = scale.y * -1;  // Flip vertically
    }

    // Diagonal direction: Up-Right (dirx > 0, diry > 0) - Fix this one
    else if (dirx > 0 && diry > 0) {
        scale.x = scale.x * 1;   // No flip horizontally
        scale.y = scale.y * 1;   // No flip vertically
        // Rotation for up-right diagonal
        rotation.z = 0;         // Knife facing up-right
    }

    // Diagonal direction: Up-Left (dirx < 0, diry > 0) - Fix this one
    else if (dirx < 0 && diry > 0) {
        scale.x = scale.x * -1;  // Flip horizontally
        scale.y = scale.y * 1;   // No flip vertically
        // Rotation for up-left diagonal
        rotation.z = 0;        // Knife facing up-left
    }

    // Diagonal direction: Down-Right (dirx > 0, diry < 0) - Fix this one
    else if (dirx > 0 && diry < 0) {
        scale.x = scale.x * 1;   // No flip horizontally
        scale.y = scale.y * -1;  // Flip vertically
        // Rotation for down-right diagonal
        rotation.z = 0;          // Knife facing down-right
    }

    // Diagonal direction: Down-Left (dirx < 0, diry < 0) - Fix this one
    else if (dirx < 0 && diry < 0) {
        scale.x = scale.x * -1;  // Flip horizontally
        scale.y = scale.y * -1;  // Flip vertically
        // Rotation for down-left diagonal
        rotation.z = 0;         // Knife facing down-left
    }

        transform.localScale = scale;
        transform.rotation = Quaternion.Euler(rotation);
    }
}
