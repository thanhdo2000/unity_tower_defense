using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public VariableJoystick joystick;
    public Transform bigCircle;
    public float radius = 2;
    public float maxRange = 5;
    public float speed = 5;
    private bool isDependent = true;
    private bool isReturning = false;

    private Vector3 direction;

    private void Start()
    {
        transform.position = bigCircle.position + Vector3.right * radius;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            isDependent = false;
        if(isDependent)
        {
            direction = new Vector3(joystick.Horizontal, joystick.Vertical, 0);
            transform.position = bigCircle.position + direction * radius;
            Debug.Log($"horizontal:{joystick.Horizontal}, Verticel:{joystick.Vertical}");
        }
        else
        {
            if(!isReturning)
                transform.Translate(direction * speed * Time.deltaTime);
            float distanceToBig = Vector3.Distance(transform.position, bigCircle.position);
            if (distanceToBig > maxRange)
                isReturning = true;
            if(isReturning)
            {
                Vector3 newDir = (bigCircle.position - transform.position).normalized;
                transform.Translate(newDir * speed * Time.deltaTime);
                if(distanceToBig <radius)
                {
                    isReturning = false;
                    isDependent = true;
                }    
            }

        }

        
    }
}
