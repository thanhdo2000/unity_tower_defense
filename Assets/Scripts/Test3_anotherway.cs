using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3_anotherway : MonoBehaviour
{
    public float speed;
    public float radiusScan;
    private bool requestNewDestination = true;
    private Vector3 destination;
    private GameObject target;
    void Update()
    {
        if (target == null)
            target = ScanObject();
        if (target == null)
        {
            Patrol();
        }
        else
        {
            MoveToTarget(target);
        }


    }
    private void Patrol()
    {
        if (requestNewDestination)
        {
            destination = new Vector2(Random.Range(-9, 9), Random.Range(-5, 5));
            requestNewDestination = false;
        }
        float distance = Vector2.Distance(transform.position, destination);
        if (distance > 0.1f)
        {
            Vector2 direction = destination - transform.position;
            transform.Translate(direction.normalized * speed * Time.deltaTime);
        }
        if (distance < 0.2f)
        {
            requestNewDestination = true;
        }
    }

    private void MoveToTarget(GameObject target)
    {
        float distance = Vector2.Distance(transform.position, target.transform.position);
        if (distance > 0.1f)
        {
            Vector3 direction = target.transform.position - transform.position;
            transform.Translate(direction.normalized * speed * Time.deltaTime);
        }
        if (distance < 0.2f)
        {
            Destroy(gameObject);
        }

    }

    private GameObject ScanObject()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(new Vector2(transform.position.x, transform.position.y), radiusScan);
        foreach (Collider2D col in colliders)
        {
            if (col.gameObject.tag == "Square")
                return col.gameObject;
        }
        return null;

    }
}
