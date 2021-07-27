using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHP = 5;
    [Tooltip("Use this to increase the enemy hitpoints after kills")]
    [SerializeField] int difficultyRamp = 1;
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
            maxHP += difficultyRamp;
            enemy.RewardGold();
        }
    }

    void DespawnEnemey()
    {
        gameObject.SetActive(false);
    }
}
