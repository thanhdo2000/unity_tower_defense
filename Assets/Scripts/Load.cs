using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int s = PlayerPrefs.GetInt("score");
        int health = PlayerPrefs.GetInt("health");
        int cash = PlayerPrefs.GetInt("cash");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
