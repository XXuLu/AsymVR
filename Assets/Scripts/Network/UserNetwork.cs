using UnityEngine;
using Photon.Pun;

public class UserNetwork : MonoBehaviourPunCallbacks
{
    public Camera playerCamera;
    public MonoBehaviour[] controlScripts;

    void Start()
    {
        // ���PhotonView�����ڱ�����ң����������Ϳ��ƽű�
        if (!photonView.IsMine)
        {
            playerCamera.enabled = false;

            foreach (var script in controlScripts)
            {
                script.enabled = false;
            }
        }
    }
}