using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float smoothing;
    private Vector3 vel;

    // Update is called once per frame
    void Update()
    {
        //Vector3 targetPos = target.position + offset;
        Vector3 targetPos = target.TransformPoint(offset);
        //transform.position = targetPos;
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref vel, smoothing);
        //transform.position = Vector3.Lerp(transform.position, targetPos, smoothing);
        transform.LookAt(target);
    }
}
