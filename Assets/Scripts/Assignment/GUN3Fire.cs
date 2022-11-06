using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUN3Fire : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject fireGUN;
    const float MinSpawnDelay = 3;
    const float MaxSpawnDelay = 4;
    Timer spawnTimer;
    public GameObject startpoint1;
    void Start()
    {
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
        spawnTimer.Run();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer.Finished)
        {
            FireObject();
            spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
            spawnTimer.Run();
        }
    }

    void FireObject()
    {
        GameObject objectspawn1;
        objectspawn1 = Instantiate<GameObject>(fireGUN, startpoint1.transform.position, Quaternion.identity);
    }
}
