using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //Здоровье NPC
    public int health = 5;

    //Уровень NPC
    public int level = 1;

    //Скорость NPC
    public float speed = 1.2f;

    public Vector3 newPosition;

     void Start()


    
    {
        print("значение переменной health="+health);
        newPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       

        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}