using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseGUN : MonoBehaviour
{
    public GameObject Panel;
    public void OnMouseDown()
    {
        if (Panel.activeInHierarchy == true)
        {
            Panel.SetActive(false);
        }
        else
        {
            Panel.SetActive(true);
        }
    }

    private void Update()
    {
      //  HideIfClickedOutside(Panel);
    }

    private void HideIfClickedOutside(GameObject panel)
    {
        Debug.Log("o kia");
        if (Input.GetMouseButton(0) && panel.activeSelf &&
            !RectTransformUtility.RectangleContainsScreenPoint(
                panel.GetComponent<RectTransform>(),
                Input.mousePosition,
                Camera.main))
        {
            panel.SetActive(false);
        }
    }
}