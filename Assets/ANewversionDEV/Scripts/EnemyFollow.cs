using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{

    public float speed;
    public float stoppingDistance;
    private Transform target;
    public Transform Positioner;
    // Start is called before the first frame update
    void Start()
    {
        target= GameObject.FindGameObjectWithTag("Ball").GetComponent<Transform>();
    }

    // Update is called once per frame
  
    void FixedUpdate()
    {
        if(Vector2.Distance(transform.position, target.position) < stoppingDistance)
        {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
         else if(Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
         transform.position = Vector2.MoveTowards(transform.position, Positioner.position, speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, Positioner.position, speed * Time.deltaTime);
        }

        
      
    }
}
