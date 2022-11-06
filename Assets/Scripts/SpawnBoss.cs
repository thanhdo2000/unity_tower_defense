using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoss : MonoBehaviour
{
    [SerializeField]
    GameObject prefabCircle;
    // Start is called before the first frame update

    const int spawnBorderSize = 100;

    int minSpawnX;
    int minSpawnY;
    int maxSpawnX;
    int maxSpawnY;
    void Start()
    {
        minSpawnX = spawnBorderSize;
        maxSpawnX = Screen.width - spawnBorderSize;
        minSpawnY = spawnBorderSize;
        maxSpawnY = Screen.height - spawnBorderSize;

        FunctionSpawnBosss();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FunctionSpawnBosss()
    {
        Vector3 location = new Vector3(Random.Range(minSpawnX, maxSpawnX), Random.Range(minSpawnY, maxSpawnY), -Camera.main.transform.position.z);
        Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);

        GameObject objectspawn;

        objectspawn = Instantiate<GameObject>(prefabCircle, worldLocation, Quaternion.identity);
    }
}
