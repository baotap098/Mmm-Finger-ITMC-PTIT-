using UnityEngine;

public class ChildEnemyBoss : MonoBehaviour
{
    [HideInInspector]
    public float speed;
    public GameObject gameManager;
    private void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }
    void Update()
    {
        if (gameManager.GetComponent<GameManager>().GameState == GameState.Playing)
            transform.Rotate(new Vector3(0, 0, speed));
    }

}
