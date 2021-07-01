using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHP = 5;
    int currentHP = 0;

    Enemy enemy;

    void OnEnable()
    {
        currentHP = maxHP;
    }

    private void Start()
    {
        enemy = GetComponent<Enemy>();
    }

    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    void ProcessHit()
    {        
        currentHP--;
        if (currentHP <= 0)
        {
            DespawnEnemey();
            enemy.RewardGold();
        }
    }

    void DespawnEnemey()
    {
        gameObject.SetActive(false);
    }
}
