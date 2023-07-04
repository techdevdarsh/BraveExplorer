using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public Character character;

    private void Awake()
    {
        currentHealth = maxHealth;
        character = GetComponent<Character>();
    }

    public void ApplyDamage(int damage)
    {
        if(currentHealth >= damage)
        {
            currentHealth -= damage;
            Debug.Log("Current Health:: " + currentHealth);
            Debug.Log("Damage :: " + damage);
        }
    }
}
