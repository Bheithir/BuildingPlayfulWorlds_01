using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingOpposite : MonoBehaviour
{

    public GameObject AttachPoint;

    private Vector3 StartPos;
    private Vector3 EndPos;
    private Vector3 Temp;
    private float Distance = 2f;
    private float lerpTime = 2;
    private float CurrentlerpTime = 0;

    // Use this for initialization
    void Start()
    {
        StartPos = AttachPoint.transform.position;
        EndPos = AttachPoint.transform.position + Vector3.forward * Distance;
    }

    // Update is called once per frame
    void Update()
    {
        CurrentlerpTime += Time.deltaTime;
        if (CurrentlerpTime >= lerpTime)
        {
            // StartPos = EndPos;
            //EndPos = AttachPoint.transform.position + Vector3.forward * Distance;
            Temp = StartPos;
            StartPos = EndPos;
            EndPos = Temp;
            CurrentlerpTime = 0;
        }

        float Perc = CurrentlerpTime / lerpTime;
        AttachPoint.transform.position = Vector3.Lerp(StartPos, EndPos, Perc);
    }
}
