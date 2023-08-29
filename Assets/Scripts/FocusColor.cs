using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViveSR.anipal.Eye;


public class FocusColor : MonoBehaviour
{
    private Renderer objectRenderer;  // 物体的渲染器组件
    private Color originalColor;  // 物体的原始颜色
                                  //public string currentFocus = "";
                                  //public TextMeshProUGUI textMeshPro;

    //FocusNameUI m_FocusNameUI = new FocusNameUI();
    //private static EyeData_v2 eyeData = new EyeData_v2();
    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();  // 获取物体的渲染器组件
        originalColor = objectRenderer.material.color;  // 保存物体的原始颜色

        //textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {

        if (SRanipal_Eye_v2.Focus(GazeIndex.COMBINE, out Ray ray, out FocusInfo focusInfo))
        {
            // 判断射线焦点是否在当前物体上
            if (focusInfo.collider == gameObject.GetComponent<Collider>())
            {
                // 注视到物体，修改颜色
                objectRenderer.material.color = Color.red;
                //currentFocus = focusInfo.collider.gameObject.name;

                //textMeshPro.text = focusInfo.collider.gameObject.name;

            }
            else
            {
                // 未注视到物体，恢复原始颜色
                objectRenderer.material.color = originalColor;
                //textMeshPro.text = string.Empty;
            }
        }
        else return;

    }



    //private static void EyeCallback(ref EyeData_v2 eye_data)
    //{
    //    eyeData = eye_data;
    //}
}

