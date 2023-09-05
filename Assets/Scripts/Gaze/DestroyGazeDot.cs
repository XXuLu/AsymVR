using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using Photon.Pun;

public class DestroyGazeDot : MonoBehaviour
{
    [SerializeField] float lifeTime = 1.2f;
    [SerializeField] float scaleDownTime = 5f;
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
            StartCoroutine(ScaleDownCoroutine());
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

    private IEnumerator ScaleDownCoroutine()
    {
        Vector3 originalScale = transform.localScale;
        float timePassed = 0f;

        while (timePassed < scaleDownTime)
        {
            timePassed += Time.deltaTime;
            float scaleRatio = 1 - (timePassed / scaleDownTime);
            Vector3 newScale = originalScale * scaleRatio;
            m_photonView.RPC("SyncScaleRPC", RpcTarget.All, newScale);
            yield return null;
        }

        m_photonView.RPC("SyncScaleRPC", RpcTarget.All, Vector3.zero);
    }

    [PunRPC]
    void SyncScaleRPC(Vector3 newScale)
    {
        transform.localScale = newScale;
    }
}
