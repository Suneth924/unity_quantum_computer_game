using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_electron : MonoBehaviour
{
    public Transform ePos;
    public GameObject electronee;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H)) 
        {
            Instantiate(electronee, ePos.position, ePos.rotation);
        }
    }
}
