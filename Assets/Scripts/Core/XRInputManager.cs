using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRInputManager : MonoBehaviour
{
    [SerializeField] GameObject xrSimulator;

    /*private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }*/
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            xrSimulator.SetActive(true);
        }
    }
}
