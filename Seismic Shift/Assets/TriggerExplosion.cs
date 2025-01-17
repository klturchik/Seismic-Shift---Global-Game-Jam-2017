﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExplosion : MonoBehaviour {

    public GameObject prefab;
    public bool right;
    public float power;

	void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            if(right)
            {
                collider.gameObject.GetComponent<Rigidbody>().AddForce((collider.gameObject.transform.position - transform.position - new Vector3(0, 15, 10)) * power, ForceMode.Impulse);
                GameObject obj = (GameObject)Instantiate(prefab, transform.position - new Vector3(0, 0, -10), transform.rotation);
                obj.transform.localScale = new Vector3(5, 5, 5);
            }
            else
            {
                collider.gameObject.GetComponent<Rigidbody>().AddForce((collider.gameObject.transform.position - transform.position - new Vector3(0, 15, -10)) * power, ForceMode.Impulse);
                GameObject obj = (GameObject)Instantiate(prefab, transform.position + new Vector3(0, 0, -10), transform.rotation);
                obj.transform.localScale = new Vector3(5, 5, 5);
            }
            
            Destroy(gameObject);
        }
    }



}
