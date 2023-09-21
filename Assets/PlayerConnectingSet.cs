using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerConnectingSet : MonoBehaviourPunCallbacks
{
    [SerializeField] public GameObject LocalXRGameobject;
    [SerializeField] public GameObject MainCameraGameobject;

    private PhotonView photonView;

    private void Awake()
    {
        photonView = GetComponent<PhotonView>();
    }



    // Start is called before the first frame update
    void Start()
    {
        if (photonView.IsMine)
        {
            //The player is local
            LocalXRGameobject.SetActive(true);

            //Getting the avatar selection data so that the correct avatar model can be instantiated.




            MainCameraGameobject.AddComponent<AudioListener>();

        }
        else
        {
            //The player is remote
            LocalXRGameobject.SetActive(false);


        }
    }
}
