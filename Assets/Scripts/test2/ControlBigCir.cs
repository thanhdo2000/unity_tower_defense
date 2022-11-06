using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBigCir : MonoBehaviour
{

    public VariableJoystick joystick;
    public float speed=4;
    // Start is called before the first frame update
    void Start()
    {  
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(joystick.Horizontal, joystick.Vertical, 0);
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
