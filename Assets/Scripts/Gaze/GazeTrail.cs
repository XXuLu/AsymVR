using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViveSR.anipal.Eye;

public class GazeTrail : MonoBehaviour
{
    public float distance = 5f;
    public Vector3 offset = Vector3.zero;

    private void Start()
    {
        Cursor.visible = false;
    }
    // Update is called once per frame
    void Update()
    {
       

        if (SRanipal_Eye_v2.Focus(GazeIndex.COMBINE, out Ray VRray, out FocusInfo  focusInfo) )
        {
            Vector3 newVRPosition = VRray.GetPoint(distance);
            transform.position = newVRPosition + offset;
        }
        else
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 newPosition = ray.GetPoint(distance);
            transform.position = newPosition + offset;
        }
    }
}
