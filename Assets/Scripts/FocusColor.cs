using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViveSR.anipal.Eye;


public class FocusColor : MonoBehaviour
{
    private Renderer objectRenderer;  // �������Ⱦ�����
    private Color originalColor;  // �����ԭʼ��ɫ
                                  //public string currentFocus = "";
                                  //public TextMeshProUGUI textMeshPro;

    //FocusNameUI m_FocusNameUI = new FocusNameUI();
    //private static EyeData_v2 eyeData = new EyeData_v2();
    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();  // ��ȡ�������Ⱦ�����
        originalColor = objectRenderer.material.color;  // ���������ԭʼ��ɫ

        //textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {

        if (SRanipal_Eye_v2.Focus(GazeIndex.COMBINE, out Ray ray, out FocusInfo focusInfo))
        {
            // �ж����߽����Ƿ��ڵ�ǰ������
            if (focusInfo.collider == gameObject.GetComponent<Collider>())
            {
                // ע�ӵ����壬�޸���ɫ
                objectRenderer.material.color = Color.red;
                //currentFocus = focusInfo.collider.gameObject.name;

                //textMeshPro.text = focusInfo.collider.gameObject.name;

            }
            else
            {
                // δע�ӵ����壬�ָ�ԭʼ��ɫ
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

