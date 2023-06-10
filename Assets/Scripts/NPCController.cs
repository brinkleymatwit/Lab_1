using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    public float speed = 2.0f;
    private Transform playerTransform;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube")
        {
            GameController.npcScore--;
        }
    }
    // Define AI behavior for the characters
    void Update()
    {
        Vector3 direction = (playerTransform.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;

    }
}