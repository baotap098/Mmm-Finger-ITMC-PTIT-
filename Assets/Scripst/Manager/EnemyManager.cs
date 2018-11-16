using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public List<GameObject> listEnemy;
    [SerializeField]
    private float speedEmenyMove;

    private void Start()
    {
        //GameObject obj = Instantiate(listEnemy[0], transform.position, Quaternion.identity);
        //obj.GetComponent<MovementEnemy>().speed = 1;
    }
}
