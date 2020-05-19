using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{

    private PlayerMovement player;
    private Vector3 lastPosition;
    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
        lastPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distance = player.transform.position.x - lastPosition.x;
        transform.position = new Vector3(
            transform.position.x + distance,
            transform.position.y,
            transform.position.z
            );
        lastPosition = player.transform.position;
    }
}
