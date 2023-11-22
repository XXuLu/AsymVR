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
        // 如果PhotonView不属于本地玩家，则禁用相机和控制脚本
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