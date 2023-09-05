using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using Photon.Pun;

public class DestroyGazeDot : MonoBehaviour
{
    [SerializeField] float lifeTime = 1.2f;
    PhotonView m_photonView;
    // Start is called before the first frame update
    private void Awake()
    {
        m_photonView = GetComponent<PhotonView>();
    }
    private void Start()
    {
        if (m_photonView.IsMine)
        {
            Invoke("DestroyObject", lifeTime);
        }
    }

    // Update is called once per frame
    void DestroyObject()
    {
        if (m_photonView.IsMine)
        {
            PhotonNetwork.Destroy(this.gameObject);
        }
    }
}
