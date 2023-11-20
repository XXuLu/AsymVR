using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using ViveSR.anipal.Eye;
using UnityEngine.XR;
public class SpawnManager : MonoBehaviour
{

    [SerializeField] GameObject PcPlayerPrefab;
    [SerializeField] GameObject VrPlayerPrefab;

    //public SRanipal_Eye_Framework sRanipal_Eye_Framework;
    //bool isXREnabled = XRSettings.isDeviceActive;




    public Vector3 spawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        //bool isVrUser = sRanipal_Eye_Framework.EnableEyeDataCallback;

        if (PhotonNetwork.IsConnectedAndReady)
        {
            if(MyGameManager.Instance.IsVRPlayer == true)
            PhotonNetwork.Instantiate(VrPlayerPrefab.name,spawnPosition,Quaternion.identity);
            else
            {
                PhotonNetwork.Instantiate(PcPlayerPrefab.name, spawnPosition, Quaternion.identity);
            }
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
