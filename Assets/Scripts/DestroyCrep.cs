using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCrep : MonoBehaviour
{
    [SerializeField]
    GameObject prefabexplosion;
    Timer destroyTimer;
    //public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        destroyTimer = gameObject.AddComponent<Timer>();
        destroyTimer.Duration = 3;
        destroyTimer.Run();
    }

    // Update is called once per frame
    void Update()
    {

        DestroyOb();

        if (destroyTimer.Finished)
        {
            destroyTimer.Run();
            GameObject dan = GameObject.FindWithTag("dan");
            if (dan != null)
            {
                Instantiate<GameObject>(prefabexplosion,
                    dan.transform.position, Quaternion.identity);
                Destroy(dan);
            }
        }
    }

    private void DestroyOb()
    {
         var target = GameObject.FindGameObjectsWithTag("Crep");

        foreach(GameObject mycube in target)
        {
            var distance = Vector3.Distance(this.gameObject.transform.position, mycube.transform.position);
            if(distance < 5f)
            {
                Vector3 direction = mycube.transform.position - transform.position;
                transform.Translate(direction * Time.deltaTime);
            }
            var distance2 = Vector3.Distance(mycube.transform.position, gameObject.transform.position);

            if (distance2 < 1f)
            {
                Destroy(gameObject);
                Destroy(mycube);
                Count_Value.count += 1;
                CountCash.count += 100;
                Instantiate<GameObject>(prefabexplosion, transform.position, Quaternion.identity);
            }
        }  
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Crep"))
        {
           // audio.Play();
            Instantiate<GameObject>(prefabexplosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
