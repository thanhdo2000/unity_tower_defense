using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class save : MonoBehaviour
{
    // Start is called before the first frame update

    public SpawnObject spawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void save1()
    {
        PlayerPrefs.SetInt("score", Count_Value.count);
        PlayerPrefs.SetInt("health", CountHealth.count);
        PlayerPrefs.SetInt("cash", CountCash.count);
    }
}
