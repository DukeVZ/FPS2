using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Camera cam;

    private Ray ray;
    private RaycastHit hit;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag.Equals("enemy"))
                {
                    hit.collider.GetComponent<enemyMovement1>().health--;
                    Debug.Log(hit.collider.GetComponent<enemyMovement1>().health);

                }
                else
                {

                    
                }
            }
        }
    }
}