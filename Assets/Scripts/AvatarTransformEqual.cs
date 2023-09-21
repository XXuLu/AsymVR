using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarTransformEqual : MonoBehaviour
{
    public Transform parentTransform;

    private void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.x = parentTransform.position.x;
        newPosition.y = parentTransform.position.y + 1;
        newPosition.z = parentTransform.position.z;
        transform.position = newPosition;
    }

}
