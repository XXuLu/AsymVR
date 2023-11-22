using UnityEngine;
using Photon.Pun;

public class UserNetwork : MonoBehaviourPunCallbacks
{
    public GameObject playerCamera;
    public MonoBehaviour[] controlScripts;

    void Start()
    {
        if (photonView.IsMine)
        {
            playerCamera.SetActive(true);
        }
        // ���PhotonView�����ڱ�����ң����������Ϳ��ƽű�
        else
        {
            playerCamera.SetActive(false);

            foreach (var script in controlScripts)
            {
                script.enabled = false;
            }
        }
    }
}