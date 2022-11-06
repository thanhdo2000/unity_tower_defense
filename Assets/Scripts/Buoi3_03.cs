using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buoi3_03 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject squareObj;
    public float speed;
    private bool allowMoving = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            allowMoving = true;
        }
        if (allowMoving)
        {
            Vector3 direction = squareObj.transform.position - transform.position;
            transform.Translate(direction.normalized * speed * Time.deltaTime);
        }

        float distance = Vector3.Distance(transform.position, squareObj.transform.position);

        //if(distance < 1f)
        //{
         //   Debug.Log("hi");
           // Destroy(this.gameObject);
        //}
    }
}
