using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountCash : MonoBehaviour
{
    // Start is called before the first frame update

    public static int count = 1000;

    public Text textElement;
    void Start()
    {
        int s = 1000;
        s = PlayerPrefs.GetInt("cash");
        Debug.Log("cash  " + s);
        count = s;
    }

    // Update is called once per frame
    void Update()
    {
        textElement.text = count.ToString();
    }
}
