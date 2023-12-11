using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyMovement1 : MonoBehaviour
{
    public NavMeshAgent badGuy;
    public float squareOfMovement = 50;
    private float xMin;
    private float xMax;
    private float zMin;
    private float zMax;
    private float xPosition;
    private float zPosition;
    private float yPosition;
    public float closeEnough = 2;
    public int health = 3;

    // Start is called before the first frame update
    void Start()
    {
        xMin = -squareOfMovement;
        xMax = squareOfMovement;
        zMin = -squareOfMovement;
        zMax = squareOfMovement;


        newLocation();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Vector3.Distance(transform.position, new Vector3(xPosition, yPosition, zPosition)) <= closeEnough)
        {
            newLocation();
        }

        if(health < 0)
        {
            Destroy(gameObject);
        }
    }

    public void newLocation()
    {
        yPosition = transform.position.y;
        xPosition = Random.Range(xMin, xMax);
        zPosition = Random.Range(zMin, zMax);

        badGuy.SetDestination(new Vector3 (xPosition, yPosition, zPosition));
    }
}
