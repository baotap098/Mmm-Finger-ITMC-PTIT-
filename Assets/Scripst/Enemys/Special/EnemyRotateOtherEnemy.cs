using System.Collections.Generic;
using UnityEngine;

public class EnemyRotateOtherEnemy : MonoBehaviour
{

    public float speedRotate; // Speed quay
    [SerializeField]
    private float distance = 2.0f;
    public List<GameObject> listMember;
    public GameObject gameManager;
    // Use this for initialization
    void Start()
    {
        gameManager = GameObject.Find("GameManager");

        GameObject obj;
        Vector3 posIns = transform.position;
        posIns.y = transform.position.y + distance;
        obj = Instantiate(listMember[0], posIns, Quaternion.identity);
        obj.GetComponent<ChildEnemyBoss>().speed = -speedRotate;
        obj.transform.parent = transform;

        posIns.y = transform.position.y;
        posIns.x = transform.position.x + distance;
        obj = Instantiate(listMember[1], posIns, Quaternion.identity);
        obj.GetComponent<ChildEnemyBoss>().speed = -speedRotate;
        obj.transform.parent = transform;

        posIns.y = transform.position.y - distance;
        posIns.x = transform.position.x;
        obj = Instantiate(listMember[2], posIns, Quaternion.identity);
        obj.GetComponent<ChildEnemyBoss>().speed = -speedRotate;
        obj.transform.parent = transform;

        posIns.y = transform.position.y;
        posIns.x = transform.position.x - distance;
        obj = Instantiate(listMember[3], posIns, Quaternion.identity);
        obj.GetComponent<ChildEnemyBoss>().speed = -speedRotate;
        obj.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.GetComponent<GameManager>().GameState == GameState.Playing)
            transform.Rotate(new Vector3(0, 0, speedRotate));
    }
}
