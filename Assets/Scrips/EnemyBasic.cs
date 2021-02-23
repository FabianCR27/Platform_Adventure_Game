using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBasic : MonoBehaviour
{
    public float lookRadius = 2f;
    Transform target;


    //wondering
    public float speed;
    public float distance;

    private bool movingRight = true;
    public Transform groundDetection;

    // Start is called before the first frame update
    void Start()
    {
       // target = PlayerManager.instance.player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);

       // RaycastHit groundinfo = Physics.Raycast(groundDetection.position, Vector3.down, distance);
        

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }

}




