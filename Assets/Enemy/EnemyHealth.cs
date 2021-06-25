using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHP = 5;
    int currentHP = 0;    

    void Start()
    {
        currentHP = maxHP;
    }


    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    void ProcessHit()
    {
        Debug.Log("Enemy Hit");
        currentHP--;
        if (currentHP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
