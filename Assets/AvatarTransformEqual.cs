using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarTransformEqual : MonoBehaviour
{
    public Transform parentTransform;

    private void Update()
    {
        transform.position = parentTransform.position;
    }

}
