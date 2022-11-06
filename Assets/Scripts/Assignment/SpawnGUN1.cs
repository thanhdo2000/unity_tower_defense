using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGUN1 : MonoBehaviour
{
    [SerializeField]
    GameObject GUN1;

    public GameObject Panel;
    public Transform GunLocation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FunctionSpawnGUN()
    {
        if(CountCash.count - 300 >= 0)
        {
            Debug.Log("GUN1");
            GameObject GUNspawn1;
            GUNspawn1 = Instantiate<GameObject>(GUN1, GunLocation.position, Quaternion.identity);

            CountCash.count -= 300;
        }
        
            if (Panel.activeInHierarchy == true)
            {
                Panel.SetActive(false);
            }
            else
            {
                Panel.SetActive(true);
            }
        
    }
}
