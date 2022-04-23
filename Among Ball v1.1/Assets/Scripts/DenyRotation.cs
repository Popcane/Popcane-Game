using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DenyRotation : MonoBehaviour
{
    Quaternion origRotation;
    Transform mTransform;

    void Awake()
    {
        mTransform = transform;
        origRotation = mTransform.rotation;
    }

    void LateUpdate()
    {
        mTransform.rotation = origRotation;
    }
}
