using UnityEngine;

public class ExperienceGems : MonoBehaviour, ICollectable
{
    public int experienceGranted;

    public void Collect()
    {
        PlayerStats player = FindFirstObjectByType<PlayerStats>();
        player.IncreaseExperience(experienceGranted);
        Destroy(gameObject);
    }


}
