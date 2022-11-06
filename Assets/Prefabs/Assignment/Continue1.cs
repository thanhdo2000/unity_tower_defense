using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Panel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ContinuePlayerGame()
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
