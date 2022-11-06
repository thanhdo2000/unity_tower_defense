using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCamera : MonoBehaviour
{
    // Start is called before the first frame update

    public VariableJoystick joystick;
    public float speed = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(joystick.Horizontal, joystick.Vertical, 0);
        transform.position = transform.position + direction;
    }
}
