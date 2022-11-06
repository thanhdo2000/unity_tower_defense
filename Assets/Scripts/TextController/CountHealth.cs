
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountHealth : MonoBehaviour
{
    // Start is called before the first frame update

    public static int count = 100;

    public Text textElement;
    void Start()
    {
        int s = 100;
        s = PlayerPrefs.GetInt("health");
        count = s;
    }

    // Update is called once per frame
    void Update()
    {
        textElement.text = count.ToString();
        if(count < 0)
        {
            QuitGame();
        }
    }

    public void QuitGame()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
        Debug.Log("quit");
        PlayerPrefs.SetInt("score", 0);
        PlayerPrefs.SetInt("health", 100);
        PlayerPrefs.SetInt("cash", 1000);
    }
}
