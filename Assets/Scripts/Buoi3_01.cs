using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buoi3_01 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject squareObj;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            //Vector2 direction = squareObj.transform.position - transform.forward;
            //transform.Translate(direction.normalized * speed * Time.deltaTime);
           
            Vector2 point = new Vector2(squareObj.transform.position.x, squareObj.transform.position.y);
            transform.position = Vector2.MoveTowards(transform.position, point, speed*Time.deltaTime);
        }
    }
}
