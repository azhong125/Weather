using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public GameObject planePreFab;
    public float topPos;
    public float endPos;

    GameObject obj;
    bool isActive;
    float direction;

    void Start()
    {
        isActive = false;
        direction = 0.25f;
    }

    void Update()
    {
        if (isActive && obj.transform.position.y > topPos)
        {
            direction = -0.25f;
        }

        if (isActive && obj.transform.position.y < endPos)
        {
            isActive = false;
            obj.SetActive(false);
            direction = 0.25f;
        }
        if (isActive == false && Input.GetKeyDown(KeyCode.P))
        {
            obj = Instantiate(planePreFab);
            obj.SetActive(true);
            isActive = true;
        }
    }
    private void FixedUpdate()
    {
        if (isActive)
        {
            obj.transform.position += new Vector3(0.5f, direction, 0.25f);
        }
    }
}
