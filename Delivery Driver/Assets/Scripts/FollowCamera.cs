using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // Create new gameobject with SerializeField (don't use public, the reason - https://topdev.vn/blog/tai-sao-nen-dung-serializefield-thay-vi-bien-public/)
    [SerializeField] GameObject thingToFollow;
    [SerializeField] Vector3 cameraPosition = new Vector3 (0,0,-10);
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + cameraPosition;
    }
}
