using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PcPlayerMovement : MonoBehaviour
{
    public float speed = 5.0f; // �����ƶ��ٶ�

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // ��ȡˮƽ������ (A/D or ��/�Ҽ�ͷ��)
        float vertical = Input.GetAxis("Vertical"); // ��ȡ��ֱ������ (W/S or ��/�¼�ͷ��)

        Vector3 movement = new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime; // �����ƶ�����

        transform.Translate(movement, Space.World); // ������ռ����ƶ���Ϸ����
    }
}
