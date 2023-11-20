using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using ViveSR.anipal.Eye;
public class SpawnManager : MonoBehaviour
{

    [SerializeField]
    GameObject GenericVRPlayerPrefab;

    public SRanipal_Eye_Framework sRanipal_Eye_Framework;


    public Vector3 spawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        bool isVrUser = sRanipal_Eye_Framework.EnableEyeDataCallback;

        if (PhotonNetwork.IsConnectedAndReady && isVrUser == false)
        {
            PhotonNetwork.Instantiate(GenericVRPlayerPrefab.name,spawnPosition,Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
