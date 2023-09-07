using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    public float playerHealth = 50f;

    public void PlayerTakeDamage(float amount)
    {
        playerHealth -= amount;
        Debug.Log(playerHealth);

        if (playerHealth <= 0f)
        {
            PlayerDie();
        }
    }
    public void PlayerDie()
    {
        Destroy(gameObject);
    }
}
