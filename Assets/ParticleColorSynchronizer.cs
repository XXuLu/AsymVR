using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ParticleColorSynchronizer : MonoBehaviour, IPunObservable
{
    private List<ParticleSystem> particleSystems = new List<ParticleSystem>();

    private void Awake()
    {
        // ��ȡ�����������е�����ϵͳ
        particleSystems.AddRange(GetComponentsInChildren<ParticleSystem>());
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            foreach (var ps in particleSystems)
            {
                // ����ÿ������ϵͳ�������俪ʼ��ɫ
                var mainModule = ps.main;
                stream.SendNext(mainModule.startColor.color);
            }
        }
        else
        {
            foreach (var ps in particleSystems)
            {
                // ����ÿ������ϵͳ�����ղ������俪ʼ��ɫ
                Color receivedColor = (Color)stream.ReceiveNext();
                var mainModule = ps.main;
                mainModule.startColor = receivedColor;
            }
        }
    }
}
