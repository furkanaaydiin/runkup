using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Contollers : MonoBehaviour
{
    [SerializeField] float speed;
    public Rigidbody2D rb;

    public int skor;
    public Text skortext;
    public GameObject gameoverpanel;


private void Start()
{
    Time.timeScale = 1;
}

    void Update()
    {
       
        float MoveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(MoveX * speed,transform.position.y);  
    }
    private void OnTriggerEnter2D(Collider2D col)
     {
        if(col.CompareTag("meteor"))
        {
           Time.timeScale = 0;
           gameoverpanel.SetActive(true);
        }

        if(col.CompareTag("coin"))
        {
           skor++;
           skortext.text = skor.ToString();
           Destroy(col.gameObject);
        }
    }
    public void restart()
    {
        SceneManager.LoadScene(0);
    }
    
    
}    
