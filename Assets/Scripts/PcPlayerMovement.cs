using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PcPlayerMovement : MonoBehaviour
{
    public float speed = 5.0f; // 控制移动速度

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // 获取水平轴输入 (A/D or 左/右箭头键)
        float vertical = Input.GetAxis("Vertical"); // 获取垂直轴输入 (W/S or 上/下箭头键)

        Vector3 movement = new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime; // 计算移动向量

        transform.Translate(movement, Space.World); // 在世界空间中移动游戏对象
    }
}
