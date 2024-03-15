using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObtenerOpcion : MonoBehaviour
{
    public int selectedIndex;
    public Dropdown dropdown;

    public void OptenerOpcion(){
        selectedIndex = dropdown.value;
    }

}
