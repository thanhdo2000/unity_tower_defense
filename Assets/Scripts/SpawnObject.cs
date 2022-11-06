using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField]
    GameObject prefabCircle1;
    [SerializeField]
    GameObject prefabCircle2;
    [SerializeField]
    GameObject prefabCircle3;

    public List<GameObject> enemys = new List<GameObject>();
    //   [SerializeField]
    // GameObject prefabBox;
    //spawn control
    const float MinSpawnDelay = 1;
    const float MaxSpawnDelay = 2;
    Timer spawnTimer;
    public GameObject startpoint1;
    public GameObject startpoint2;

    // spawn location support

    const int spawnBorderSize = 100;
    // Start is called before the first frame update
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
            FunctionSpawnObject();
            spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
            spawnTimer.Run();
        }
    }

    void FunctionSpawnObject()
    {
        int locationNumber = Random.Range(0, 2);
        if(locationNumber == 0)
        {
            GameObject objectspawn1;
            int prefabNumber1 = Random.Range(0, 3);
            if (prefabNumber1 == 0)
            {
                objectspawn1 = GameManager.Instance.gameEffectPool.Spawn(prefabCircle1, startpoint1.transform.position, Quaternion.identity).gameObject;
            }
            else if (prefabNumber1 == 1)
            {
                objectspawn1 = GameManager.Instance.gameEffectPool.Spawn(prefabCircle2, startpoint1.transform.position, Quaternion.identity).gameObject;
            }
            else if (prefabNumber1 == 2)
            {
                objectspawn1 = GameManager.Instance.gameEffectPool.Spawn(prefabCircle3, startpoint1.transform.position, Quaternion.identity).gameObject;
            }
        }
        else
        if (locationNumber == 1)
        {
            GameObject objectspawn;

            int prefabNumber = Random.Range(0, 3);
            if (prefabNumber == 0)
            {
                objectspawn = GameManager.Instance.gameEffectPool.Spawn(prefabCircle1, startpoint2.transform.position, Quaternion.identity).gameObject;
            }
            else if (prefabNumber == 1)
            {
                objectspawn = GameManager.Instance.gameEffectPool.Spawn(prefabCircle2, startpoint2.transform.position, Quaternion.identity).gameObject;
            }
            else if (prefabNumber == 2)
            {
                objectspawn = GameManager.Instance.gameEffectPool.Spawn(prefabCircle3, startpoint2.transform.position, Quaternion.identity).gameObject;
            }
        }  
    }
}
