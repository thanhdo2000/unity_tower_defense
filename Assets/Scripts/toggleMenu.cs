
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleMenu : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;

    public void OnMouseDown()
    {
        if (Panel.activeInHierarchy == true)
        {
            Panel.SetActive(false);
            Panel1.SetActive(false);
            Panel2.SetActive(false);
            Panel3.SetActive(false);

        }
        else
        {
            Panel1.SetActive(true);
            Panel.SetActive(true);
            Panel2.SetActive(true);
            Panel3.SetActive(true);

        }

    }

    private void Update()
    {
        //  HideIfClickedOutside(Panel);
    }
}