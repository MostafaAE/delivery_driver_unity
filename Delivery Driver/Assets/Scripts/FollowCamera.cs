using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    [SerializeField]
    private GameObject car;
    Vector3 offset = new Vector3(0, 0, -10);
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = car.transform.position + offset;
    }
}
