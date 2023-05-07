using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Range(0, 10)]
    public int health = 10;
    [Range(0, 10)]
    public int speed = 10;
    [Range(0, 10)]
    public int level = 10;
    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print("Здоровье NPS:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
