using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectVisibility : MonoBehaviour
{
    public GameObject objectToToggle;

    public void ToggleActiveStatusA()
    {
        objectToToggle.SetActive(true);
    }
    public void ToggleActiveStatusF()
    {
        objectToToggle.SetActive(false);
    }

    public void ToggleActiveStatus()
    {
        if (objectToToggle.activeSelf)
        {
            objectToToggle.SetActive(false);
        }
        else
        { 
            objectToToggle.SetActive(true); 
        }
    }
}
