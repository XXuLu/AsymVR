using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViveSR.anipal.Eye;

public class VRGaze : MonoBehaviour
{
    private Vector3 gazePoint;
    private void Update()
    {
        

        if (SRanipal_Eye_v2.Focus(GazeIndex.COMBINE, out Ray ray, out FocusInfo focusInfo))
        {
            // 判断射线焦点是否在当前物体上
            if (focusInfo.collider == gameObject.GetComponent<Collider>() && focusInfo.collider.gameObject.layer == 12 )
            {
                gazePoint = focusInfo.point;
                PhotonNetwork.Instantiate("gazeDot", gazePoint, Quaternion.identity);

            }
        }

        }
      
}
