using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarInputTransform : MonoBehaviour
{
    //Avatar Transforms
    public Transform MainAvatarTransform;

    //XRRig Transforms
    public Transform XRHead;
    public Vector3 headPositionOffset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MainAvatarTransform.position = Vector3.Lerp(MainAvatarTransform.position, XRHead.position + headPositionOffset, 0.5f);
        MainAvatarTransform.rotation = Quaternion.Lerp(MainAvatarTransform.rotation, XRHead.rotation, 0.5f);
    }
}
