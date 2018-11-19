using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public List<GameObject> listEnemy;
    [SerializeField]
    private float speedEmenyMove;
    private float widthScreen;
    private float heightScreen;
    private Vector3 posCreate; // Vị trí sẻ xuất hiện enemy. 
    private float timeLast; // Thời gian xuất hiện enemy trước đó.
    [SerializeField]
    private float timeCreate;// Khoảng thời gian cho phép xuất hiện enemy.
    private float distanceH = 5;
    public GameObject gameManager;
    private void Start()
    {
        // tính tọa độ dưới cùng của màn hình
        Vector3 temp = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        widthScreen = temp.x;
        heightScreen = temp.y;

        // vị trí xuất hiện của enemy luôn nằm phía bên trên màn hình.
        posCreate.y = heightScreen + distanceH;
        gameManager = GameObject.Find("GameManager");
    }
    private void Update()
    {
        if (gameManager.GetComponent<GameManager>().GameState == GameState.Playing)
            CreateEnemy();
    }
    void CreateEnemy()
    {
        if (Time.time - timeLast > timeCreate || timeCreate == 0)
        {
            timeLast = Time.time;
            // lấy vị trí ngẫu nhiên của enemy trong danh sách
            // listEnemy.Count: trả về số đối tượng trong danh sách.
            int indexEnemy = Random.Range(0, listEnemy.Count);

            GameObject obj = Instantiate(listEnemy[indexEnemy], posCreate, Quaternion.identity);
            
            // gán tốc độ cho Enemy vừa tạo ra, với điều kiện là phải có Script EnemyController
            obj.GetComponent<EnemyController>().speedMove = speedEmenyMove; 

            // tạo ngẫu nhiên vị trí x mới cho enemy sau
            posCreate.x = Random.Range(-widthScreen, widthScreen);
        }
    }
}
