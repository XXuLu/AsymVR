using UnityEngine;
using Photon.Pun;

public class UserNetwork : MonoBehaviourPunCallbacks
{
    public Camera playerCamera;
    public MonoBehaviour[] controlScripts;

    void Start()
    {
        // 如果PhotonView不属于本地玩家，则禁用相机和控制脚本
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