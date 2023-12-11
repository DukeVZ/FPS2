using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private playerHealth PlayerHealth;

    private enemyMovement1 EnemyMovement;
    private Transform player;
    public float attackRange = 10f;
    private bool foundPlayer;

    public Material defaultMaterial;
    public Material attackMaterial;
    private Renderer rend;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        PlayerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<playerHealth>();
        EnemyMovement = GetComponent<enemyMovement1>();
        rend = GetComponent<Renderer>();
    }


    // Update is called once per frame
    void Update()
    {

        //lookes for the attack range
        if (Vector3.Distance(transform.position, player.position) <= attackRange)
        {
            rend.sharedMaterial = attackMaterial;
            EnemyMovement.badGuy.SetDestination(player.position);
            foundPlayer = true;
        }
        else if (foundPlayer)
        {
            rend.sharedMaterial = defaultMaterial;
            EnemyMovement.newLocation();
            foundPlayer = false;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerHealth.TakeDamage(1);
        }
    }

}