using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Count_Value : MonoBehaviour
{
    // Start is called before the first frame update

    public static int count = 0;

    public Text textElement;
    void Start()
    {
        int s = 0;
        s = PlayerPrefs.GetInt("score");
        count = s;
    }

    // Update is called once per frame
    void Update()
    {
        textElement.text = count.ToString();
    }
}
