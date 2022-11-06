using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRandom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody2D rigidbody2D = GetComponent<Rigidbody2D>();
        //rigidbody2D.AddForce(new Vector2(1, 0), ForceMode2D.Impulse);
        
    }

    private void Update()
    {
        MoverRandom();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("bumm");
    }

    public void MoverRandom()
    {
        const float MinImpulseForce = 2f;
        const float MaxImpulseForce = 3f;
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        Rigidbody2D rigidbody2D1 = GetComponent<Rigidbody2D>();
        rigidbody2D1.AddForce(direction * magnitude, ForceMode2D.Impulse);
    }
}
