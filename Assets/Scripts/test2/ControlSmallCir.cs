using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ControlSmallCir : MonoBehaviour
{
    public VariableJoystick joystick;
    public Transform bigCircle;

    public float radius = 1;

    public float speed = 4;
    public float maxRange = 5;
    private bool isDependent = true;
    private bool isReturn = false;
    public Vector3 direction;
    public AudioSource audio;
    public AudioSource audio2;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = bigCircle.position + Vector3.right * radius; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && isDependent)
        {
            audio.Play();
            isDependent = false;
        }
        if (isDependent)
        {
            gameObject.tag = "Untagged";
            direction = new Vector3(joystick.Horizontal, joystick.Vertical, 0);
            transform.position = bigCircle.position + direction  * radius;
            Debug.Log(transform.position.x + "hi" + transform.position.y);
        }
        else
        {
            gameObject.tag = "Boss";
            if (!isReturn)
            {
                transform.Translate(direction * speed * Time.deltaTime);
            }
            float distance = Vector3.Distance(transform.position, bigCircle.position);
            if (distance > maxRange)
            {
                isReturn = true;
            }

            if (isReturn)
            {
                Vector3 newDirection = (bigCircle.position - transform.position).normalized;
                transform.Translate(newDirection * speed * Time.deltaTime); 

                if(distance < radius)
                {
                    isReturn = false;
                    isDependent = true;
                }
            }
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Crep") && gameObject.tag == "Boss")
        {
             audio2.Play();
        }
    }
}
