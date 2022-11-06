using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MoveShotGun1 : MonoBehaviour
{
    // Start is called before the first frame update
    float x_position = 0;
    float y_position = 0;

    [SerializeField]
    GameObject prefabexplosion;
    void Start()
    {
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
        float Min_position_x = -16f;
        float Max_position_x = 18f;

        float Min_position_y = -8f;
        float Max_position_y = 10f;
        x_position = Random.Range(Min_position_x, Max_position_x);
        y_position = Random.Range(Min_position_y, Max_position_y);
        Vector3 direction = new Vector3(x_position - transform.position.x, y_position - transform.position.y, 0);
        float speed = 0.25f;
        transform.Translate(direction * speed * Time.deltaTime); 
    }
}
