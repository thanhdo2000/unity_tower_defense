

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setMove : MonoBehaviour
{
    [SerializeField]
    GameObject prefabexplosion;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveToPosition();
    }

    private void MoveToPosition()
    {
        var target = GameObject.FindGameObjectsWithTag("Crep");

        foreach(GameObject mycube in target)
        {
            var distance = Vector3.Distance(this.gameObject.transform.position, mycube.transform.position);
            if(distance < 8f)
            {
                Vector3 direction = mycube.transform.position - transform.position;
                transform.Translate(direction.normalized * Time.deltaTime);
            }
            var distance2 = Vector3.Distance(mycube.transform.position, gameObject.transform.position);

            if (distance2 < 0.6f)
            {
                Destroy(gameObject);
                Destroy(mycube);
                Count_Value.count += 1;
                Instantiate<GameObject>(prefabexplosion, transform.position, Quaternion.identity);
            }
        }       
    }
}
