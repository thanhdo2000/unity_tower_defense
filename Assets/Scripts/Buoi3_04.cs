using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buoi3_04 : MonoBehaviour
{
    public GameObject spawnObjectPrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObject());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator SpawnObject()
    {
        Instantiate(spawnObjectPrefab, transform.position, transform.rotation);
        yield return new WaitForSeconds(10);
        StartCoroutine(SpawnObject());
    }

}
