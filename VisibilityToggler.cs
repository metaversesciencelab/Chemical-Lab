using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibilityToggler : MonoBehaviour
{
    public void ToggleVisibility()
    {
        MeshRenderer meshRen = GetComponent<MeshRenderer>();
        bool visibility = meshRen.enabled;

        meshRen.enabled = !visibility;
    }
}
