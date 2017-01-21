using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightRayCast : MonoBehaviour {

    public GameObject ObstacleTrigger;

    private float range = 100f;

    Ray RightDestructRay;
    RaycastHit RightDestructHit;
    private int destructibleMask;

    void Awake()
    {
        destructibleMask = LayerMask.GetMask("Destructible");
        ObstacleSpawn obstacleSpawn = ObstacleTrigger.GetComponent<ObstacleSpawn>();
    }

    void Update()
    {
        Ray();
    }

    void Ray()
    {
        RightDestructRay.origin = transform.position;
        RightDestructRay.direction = transform.forward;

        if (Physics.Raycast(RightDestructRay, out RightDestructHit, range, destructibleMask))
        {
            Debug.Log("Detected Right Ray");
            ObstacleSpawn.Spawn();
        }
    }
}
