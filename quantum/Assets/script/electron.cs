using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electron : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Key H press for hadamart operator
        if(Input.GetKeyDown(KeyCode.H))
        {
            GetComponent<Rigidbody>().position = new Vector3(4.66f, 1.36f, 0.038f);
        }
    }
}
