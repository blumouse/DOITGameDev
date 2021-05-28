using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage_Player : MonoBehaviour
{
    public static bool isHurt = false;
    public bool isBoss = false;
    Animator playeranim;
    SpriteRenderer playerSprite;
    float hurtTime;
    public GameObject enemyMgr;
    public GameObject gameoverPanel;

    static Transform playerTrans;
    static Rigidbody2D playerRigid;

    private void Awake()
    {
        playerTrans = gameObject.GetComponent<Transform>();
        playerRigid = gameObject.GetComponent<Rigidbody2D>();
        playeranim = GetComponent<Animator>();
        playerSprite = GetComponent<SpriteRenderer>();

        if (!isBoss)
        {
            Invoke("SetRun", 2.5f);
            Invoke("ActiveEnemy", 4.5f);
        }        
    }

    private void OnEnable()
    {
        if (isBoss)
        {
            playeranim.SetBool("isRun", true);
            StartCoroutine("PCutScene");
        }
    }

    private void Update()
    {
        if (hurtTime > 0)
        {
            hurtTime -= Time.deltaTime;
        }

        if (BgStop1.bgStoped)
        {
            playerTrans.position -= new Vector3(5 * Time.deltaTime, 0);
            Invoke("LoadBoss", 5f);
            BgStop1.bgStoped = false;
        }

        if (Lifebox.gameover)
        {
            playeranim.SetBool("isHurt", true);
            Invoke("GOActive", 4f);
        }       
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (hurtTime > 0)
            {
                return;
            }
            StartCoroutine("Player_Hurt");
            GetComponent<Transform>().position += new Vector3(0, 0, 5);
            hurtTime = 3f;
        }

    }

    IEnumerator PCutScene()
    {
        for (float i = 0; i < 9; i += Time.deltaTime * 3)
        {
            playerTrans.position -= new Vector3(Time.deltaTime * 3, 0);
            yield return new WaitForEndOfFrame();
        }
        playeranim.SetBool("isRun", false);
        playerTrans.position = new Vector3(5, -1.65f);
    }

    void GOActive()
    {
        gameoverPanel.SetActive(true);
    }

    void LoadBoss()
    {
        SceneManager.LoadScene("BossStage");
        SceneManager.LoadScene("BossUI", LoadSceneMode.Additive);
        isBoss = true;
    }

    void ActiveEnemy()
    {
        enemyMgr.SetActive(true);
    }

    void SetRun()
    {
        playeranim.SetBool("isRun", true);
    }

    public static void Player_Jump()
    {
        playerRigid.AddForce(new Vector2(0, 700));
    }

    public static void Player_Slide()
    {
        playerTrans.position -= new Vector3(0, 0.5f);
        playerTrans.eulerAngles = new Vector3(0, 0, -90);
    }

    public static void Player_SlideBack()
    {
        playerTrans.position += new Vector3(0, 0.6f);
        playerTrans.eulerAngles = new Vector3(0, 0, 0);
    }


    IEnumerator Player_Hurt()
    {
        isHurt = true;
        for (int i = 0; i < 2; i++)
        {
            Color color = playerSprite.color;
            color.a = 0.4f;
            playerSprite.color = color;
            yield return new WaitForSeconds(0.5f);

            color.a = 1;
            playerSprite.color = color;
            yield return new WaitForSeconds(0.5f);
            isHurt = false;
        }        
    }
}
