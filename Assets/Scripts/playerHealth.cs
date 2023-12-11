using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour
{
    public int maxHealth = 2;
    public int curentHealth;

    // Start is called before the first frame update
    void Start()
    {
        curentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        curentHealth -= amount;
        if (curentHealth <= 0)
        {
            

            SceneManager.LoadScene("Game over");
            
        }
    }
}

