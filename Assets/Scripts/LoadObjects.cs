using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LoadObjects : MonoBehaviour
{
    public TMP_InputField iField;

    public GameObject myObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Loadgalgje()
    {

        if (iField.text == "Hoi")
        {
            Debug.Log("Active Self: " + myObject.activeSelf);
            Debug.Log("Active in Hierarchy" + myObject.activeInHierarchy);
        }
    }
}
