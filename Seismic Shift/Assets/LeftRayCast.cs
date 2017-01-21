using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRayCast : MonoBehaviour {

    public GameObject ObstacleTrigger;

    private float range = 100f;

    Ray LeftDestructRay;
    RaycastHit LeftDestructHit;
    private int destructibleMask;

    void Awake()
    {
        destructibleMask = LayerMask.GetMask("Destructible");
        ObstacleSpawn obstacleSpawn = ObstacleTrigger.GetComponent<ObstacleSpawn>();
    }

    void FixedUpdate()
    {
        Ray();
    }

    void Ray()
    {
        LeftDestructRay.origin = transform.position;
        LeftDestructRay.direction = transform.forward;

        if (Physics.Raycast(LeftDestructRay, out LeftDestructHit, range, destructibleMask))
        {
            Debug.Log("Detected Left Ray");
            ObstacleSpawn.Spawn();
        }
    }
}
