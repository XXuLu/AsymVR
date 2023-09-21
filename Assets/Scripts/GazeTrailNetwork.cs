using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GazeTrailNetwork : MonoBehaviourPunCallbacks
{
    GazeTrail gazeTrail;

    private PhotonView _photonView;

    private void Awake()
    {
        _photonView = GetComponent<PhotonView>();
    }



    // Start is called before the first frame update
    void Start()
    {
        gazeTrail = GetComponent<GazeTrail>();
        if (_photonView.IsMine)
        {
            //The player is local
            gazeTrail.enabled = true;

            //Getting the avatar selection data so that the correct avatar model can be instantiated.




          

        }
        else
        {
            //The player is remote
            gazeTrail.enabled = false;


        }
    }
}
