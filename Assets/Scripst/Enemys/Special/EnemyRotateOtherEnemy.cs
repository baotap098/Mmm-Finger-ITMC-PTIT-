using System.Collections.Generic;
using UnityEngine;

public class EnemyRotateOtherEnemy : MonoBehaviour
{

    public float speed;
    public List<GameObject> listMember;
    // Use this for initialization
    void Start()
    {
        GameObject obj;
        Vector3 posIns = transform.position;
        posIns.y = transform.position.y + 2;
        obj = Instantiate(listMember[0], posIns, Quaternion.identity);
        obj.GetComponent<ChildEnemyBoss>().speed = -speed;
        obj.transform.parent = transform;

        posIns.y = transform.position.y;
        posIns.x = transform.position.x + 2;
        obj = Instantiate(listMember[1], posIns, Quaternion.identity);
        obj.GetComponent<ChildEnemyBoss>().speed = -speed;
        obj.transform.parent = transform;

        posIns.y = transform.position.y - 2 ;
        posIns.x = transform.position.x;
        obj = Instantiate(listMember[2], posIns, Quaternion.identity);
        obj.GetComponent<ChildEnemyBoss>().speed = -speed;
        obj.transform.parent = transform;

        posIns.y = transform.position.y;
        posIns.x = transform.position.x - 2;
        obj = Instantiate(listMember[3], posIns, Quaternion.identity);
        obj.GetComponent<ChildEnemyBoss>().speed = -speed;
        obj.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, speed));
    }
}
