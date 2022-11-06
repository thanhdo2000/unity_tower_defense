using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCircleRedAroundWhite : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject prefabBigCircle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 1f;
        // float angle = Mathf.Atan2()
        float x1;
        float x2;
        float y1;
        float y2;
        x1 = gameObject.transform.position.x;
        x2 = prefabBigCircle.transform.position.x;
        y1 = gameObject.transform.position.y;
        y2 = prefabBigCircle.transform.position.y;
        float m = (y2 - y1) / (x2 - x1);
        float a;
        float b;
        a = m;
        b = (-m * x1) + y1;

        if (Input.GetKey(KeyCode.W))
        {
            float step = 2 * Time.deltaTime;
            float x_travel = prefabBigCircle.transform.position.x;
            x_travel = x_travel + 100f;
            float y_travel = a * x_travel + b;
            Vector2 point = new Vector2(x_travel, y_travel);
            transform.position = Vector2.MoveTowards(transform.position, point, step);
        }

        if (Input.GetKey(KeyCode.S))
        {
            float step = 2 * Time.deltaTime;
            float x_travel = prefabBigCircle.transform.position.x;
            x_travel = x_travel - 100f;
            float y_travel = a * x_travel + b;
            Vector2 point = new Vector2(x_travel, y_travel);

            transform.position = Vector2.MoveTowards(transform.position, point, step);
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(prefabBigCircle.transform.position, Vector3.forward, 50 * speed * Time.deltaTime);  
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(prefabBigCircle.transform.position, Vector3.back, 50 * speed * Time.deltaTime);
        }
    }
}
