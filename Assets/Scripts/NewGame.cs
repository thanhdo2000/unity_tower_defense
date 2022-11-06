using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGame : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Panel;
    void Start()
    {
        PlayerPrefs.SetInt("score", 0);
        PlayerPrefs.SetInt("health", 100);
        PlayerPrefs.SetInt("cash", 1000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateNewGame()
    {
        if (Panel.activeInHierarchy == true)
        {
            Panel.SetActive(false);
        }
        else
        {
            Panel.SetActive(true);
        }

        Time.timeScale = 1;

    }
}
