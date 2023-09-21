using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ParticleColorSynchronizer : MonoBehaviour, IPunObservable
{
    private List<ParticleSystem> particleSystems = new List<ParticleSystem>();

    private void Awake()
    {
        // 获取所有子物体中的粒子系统
        particleSystems.AddRange(GetComponentsInChildren<ParticleSystem>());
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            foreach (var ps in particleSystems)
            {
                // 对于每个粒子系统，发送其开始颜色
                var mainModule = ps.main;
                stream.SendNext(mainModule.startColor.color);
            }
        }
        else
        {
            foreach (var ps in particleSystems)
            {
                // 对于每个粒子系统，接收并设置其开始颜色
                Color receivedColor = (Color)stream.ReceiveNext();
                var mainModule = ps.main;
                mainModule.startColor = receivedColor;
            }
        }
    }
}
