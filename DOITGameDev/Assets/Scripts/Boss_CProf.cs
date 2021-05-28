using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_CProf : MonoBehaviour
{
    Animator profAnim;
    public GameObject report;
    public GameObject abc;
    public GameObject def;
    public GameObject ghi;
    public GameObject End;
    int randomChoice;
    int PtCount;
    float PtTime;
    float pos;
    bool end = false;
    bool active = true;

    void OnEnable()
    {
        profAnim = gameObject.GetComponent<Animator>();
        StartCoroutine("SetCutScene");
        PtCount = 9;
    }

    private void Update()
    {
        if (PtTime <= 0 && profAnim.GetInteger("CutScene") == 4 && PtCount > 0)
        {
            if (PtCount < 7)
            {
                randomChoice = Random.Range(0, 2);
            }
            else
            {
                randomChoice = 0;
            }
            
            switch (randomChoice)
            {
                case 0:
                    PtTime = 4.5f;
                    ReportPt();
                    break;
                case 1:
                    PtTime = 7.5f;
                    EngPt();
                    break;
            }
            PtCount--;
        }
        
        if (PtCount == 0)
        {
            end = true;
        }

        if (PtTime >= 0)
        {
            PtTime -= Time.deltaTime;
        }

        if (end && PtTime <= 0 && active)
        {
            active = false;
            profAnim.SetBool("isHurt", true);
            StartCoroutine("BossDefeat");
        }
    }

    IEnumerator BossDefeat()
    {
        yield return new WaitForSeconds(2f);
        
        Vector3 initialPosition = transform.position;
        for (float i = 0; i < 4; i += Time.deltaTime)
        {            
            transform.position = Random.insideUnitSphere * 0.05f + initialPosition;
            yield return new WaitForEndOfFrame();
        }

        GetComponent<Transform>().position = initialPosition;

        yield return new WaitForSeconds(1f);
        profAnim.SetBool("isHurt", false);
        profAnim.SetInteger("CutScene", 5);
        yield return new WaitForSeconds(2.5f);
        profAnim.SetInteger("CutScene", 6);
        GetComponent<SpriteRenderer>().flipX = true;
        End.SetActive(true);
    }

    void ReportPt()
    {
        Invoke("Report", 1f);
        Invoke("Report", 2f);
        Invoke("Report", 3f);        
    }

    void EngPt()
    {        
        Invoke("Eng", 1f);
        Invoke("Eng", 2f);
        Invoke("Eng", 3f);
        Invoke("Eng", 4.5f);
        Invoke("Eng", 5.3f);
        Invoke("Eng", 6.1f);
    }

    void Report()
    {
        profAnim.SetBool("isAtk", true);

        randomChoice = Random.Range(1, 3);
        switch (randomChoice)
        {
            case 1:
                Instantiate(report, new Vector3(GetComponent<Transform>().position.x, -0.8f), Quaternion.Euler(0, 0, 0));
                break;
            case 2:
                Instantiate(report, new Vector3(GetComponent<Transform>().position.x, -2.3f), Quaternion.Euler(0, 0, 0));
                break;
        }
        Invoke("SetAtk", 0.5f);
    }

    void SetAtk()
    {
        profAnim.SetBool("isAtk", false);
    }

    void Eng()
    {
        
        randomChoice = Random.Range(0, 3);
        switch (randomChoice)
        {
            case 0:
                pos = 0.4f;
                break;
            case 1:
                pos = -0.8f;
                break;
            case 2:
                pos = -2.3f;
                break;
        }

        switch (Random.Range(0, 3))
        {
            case 0:
                Invoke("EngInst", 0.2f);
                break;
            case 1:
                Invoke("EngInst", 0.2f);
                Invoke("EngInst", 0.4f);
                break;
            case 2:
                Invoke("EngInst", 0.2f);
                Invoke("EngInst", 0.4f);
                Invoke("EngInst", 0.6f);
                break;
        }
        profAnim.SetBool("isQuiz1", true);
        Invoke("SetQuiz2", 0.4f);
        Invoke("SetQuiz", 1f);
    }

    void EngInst()
    {
        switch (Random.Range(0, 3))
        {
            case 0:
                Instantiate(abc, new Vector3(GetComponent<Transform>().position.x, pos), Quaternion.Euler(0, 0, 0));
                break;
            case 1:
                Instantiate(def, new Vector3(GetComponent<Transform>().position.x, pos), Quaternion.Euler(0, 0, 0));
                break;
            case 2:
                Instantiate(ghi, new Vector3(GetComponent<Transform>().position.x, pos), Quaternion.Euler(0, 0, 0));
                break;
        }
    }

    void SetQuiz2()
    {
        profAnim.SetBool("isQuiz2", true);
    }

    void SetQuiz()
    {
        profAnim.SetBool("isQuiz1", false);
        profAnim.SetBool("isQuiz2", false);
    }

    IEnumerator SetCutScene()
    {
        yield return new WaitForSeconds(3f);
        profAnim.SetInteger("CutScene", 1);
        yield return new WaitForSeconds(3f);
        profAnim.SetInteger("CutScene", 2);
        yield return new WaitForSeconds(2f);
        profAnim.SetInteger("CutScene", 3);
        yield return new WaitForSeconds(3f);
        profAnim.SetInteger("CutScene", 4);
    }
}
