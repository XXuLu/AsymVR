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
        

        if (SRanipal_Eye_v2.Focus(GazeIndex.COMBINE, out Ray ray, out FocusInfo focusInfo) && focusInfo.collider.gameObject.layer == 12)
        {
            // �ж����߽����Ƿ��ڵ�ǰ������
            
            
                gazePoint = focusInfo.point;
                PhotonNetwork.Instantiate("StudentGazeDot", gazePoint, Quaternion.identity);

            
        }

        }
      
}
