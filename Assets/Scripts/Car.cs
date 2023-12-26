using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public GameObject carPreFab;
    public GameObject endCollider;

    GameObject obj;
    bool isActive;
    void Start()
    {
        isActive = false;
    }

    void Update()
    {
        if (isActive && obj.transform.position.z >= endCollider.transform.position.z)
        {
            isActive = false;
            obj.SetActive(false);
        }
        if (isActive == false && Input.GetKeyDown(KeyCode.C))
        {
            obj = Instantiate(carPreFab);
            obj.SetActive(true);
            isActive = true;
        }
    }
    private void FixedUpdate()
    {
        if (isActive)
        {
            obj.transform.position += new Vector3(0, 0, 0.5f);
        }
    }
}
