using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAction : MonoBehaviour
{
    MoveRandom moveRandom;
    // Start is called before the first frame update
    int health = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
         
        var MyCube = GameObject.FindGameObjectsWithTag("Crep");
        foreach (GameObject mycube in MyCube)
        {
            var distance = Vector3.Distance(this.gameObject.transform.position,
                mycube.transform.position);
            if (distance < 2f)
            {
                float step = 3 * Time.deltaTime;
                Vector2 point = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y);
                mycube.transform.position = Vector2.MoveTowards(mycube.transform.position, point, step);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Crep"))
        {
            Count_Value.count += 1;
            //Debug.Log(health);
            if (health < 5)
            {
                health = health + 1;
            }
            else
            {
                health = 0;
                Debug.Log("scale");
                Vector3 size = transform.localScale;
                size.x = size.x * 1.05f;
                size.y = size.y * 1.05f;
                transform.localScale = size;
            }
        }
        else if (collision.gameObject.CompareTag("FinishTravel"))
        {
            Debug.Log("New Travel");
            //myObject.GetComponent<MyScript>().MyFunction();
            //gameObject.GetComponent<MoverRandomPosition>();
            moveRandom = gameObject.AddComponent<MoveRandom>();
            moveRandom.MoverRandom();
        }
    }
}