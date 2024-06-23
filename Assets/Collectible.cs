using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public bool isCoins, isSpeedUp;
    float speedDuration = 1f;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            PlayerControl pc = other.GetComponent<PlayerControl>();
            isCoins = true;
            isSpeedUp = true;

            if (isCoins)
            {
              pc.score++;
              Destroy(gameObject);
            }

            if (isSpeedUp)
            {
                pc.moveSpeed *= 1.5f;
                FindFirstObjectByType<PlayerControl>().SpeedUpFunction();          
            }
        }
    }  
}
