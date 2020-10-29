using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController5 : MonoBehaviour
{
    public GameObject[] ob = new GameObject[10];
    public GameObject[] obUse = new GameObject[10];
    Vector3[] obUsePos = new Vector3[10];

    private bool[] obTrue = new bool[10];
    private bool[] layer = new bool[6];

    public float timeLeft = 120f;

    private float secondCounter = 0;
    public bool FinishOrOver = false;
    private float DistanceForDrag = 0.2f;

    public GameManager5 gameManager;


    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            obTrue[i] = false;
        }
        for (int i = 0; i < 6; i++)
        {
            layer[i] = false;
        }
        for (int i = 0; i < 10; i++)
        {
            obUsePos[i] = obUse[i].transform.position;
        }
    }



    void drag()
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                float distance = Vector3.Distance(ob[i].transform.position, obUse[j].transform.position);
                if (distance < DistanceForDrag)
                {
                    obUse[j].transform.position = ob[i].transform.position;
                }
            }
        }
    }


    void chackBackLegLayer()
    {
        layer[0] = true;
        for (int i = 0; i < 2; i++)
        {
            obTrue[i] = false;
            for (int j = 0; j < 2; j++)
            {
                float distance = Vector3.Distance(ob[i].transform.position, obUse[j].transform.position);
                if (distance < DistanceForDrag)
                {
                    obTrue[i] = true;
                    break;
                }
            }
            if (!obTrue[i])
            {
                layer[0] = false;
                break;
            }
        }
    }


    void chackFrontLegLayer()
    {
        layer[1] = true;
        for (int i = 2; i < 4; i++)
        {
            obTrue[i] = false;
            for (int j = 2; j < 4; j++)
            {
                float distance = Vector3.Distance(ob[i].transform.position, obUse[j].transform.position);
                if (distance < DistanceForDrag)
                {
                    obTrue[i] = true;
                    break;
                }
            }
            if (!obTrue[i])
            {
                layer[1] = false;
                break;
            }
        }
    }


    void chackPlateLayer()
    {
        layer[2] = true;
        float distance = Vector3.Distance(ob[4].transform.position, obUse[4].transform.position);
        if (distance < DistanceForDrag)
        {
            obTrue[4] = true;
        }
        else
        {
            layer[2] = false;
        }
    }


    void chackUpBackbonLayer()
    {
        layer[3] = true;
        float distance = Vector3.Distance(ob[5].transform.position, obUse[5].transform.position);
        if (distance < DistanceForDrag)
        {
            obTrue[5] = true;
        }
        else
        {
            layer[3] = false;
        }
    }


    void chackDownBackbonLayer()
    {
        layer[4] = true;
        float distance = Vector3.Distance(ob[6].transform.position, obUse[6].transform.position);
        if (distance < DistanceForDrag)
        {
            obTrue[6] = true;
        }
        else
        {
            layer[4] = false;
        }
    }


    void chackBataLayer()
    {
        layer[5] = true;
        for (int i = 7; i < 10; i++)
        {
            obTrue[i] = false;
            for (int j = 7; j < 10; j++)
            {
                float distance = Vector3.Distance(ob[i].transform.position, obUse[j].transform.position);
                if (distance < DistanceForDrag)
                {
                    obTrue[i] = true;
                    break;
                }
            }
            if (!obTrue[i])
            {
                layer[5] = false;
                break;
            }
        }
    }




    void Update()
    {
        drag();
        chackBackLegLayer();
        chackFrontLegLayer();
        chackPlateLayer();
        chackUpBackbonLayer();
        chackDownBackbonLayer();
        chackBataLayer();


        bool gameComplete = true;
        for (int i = 0; i < 6; i++)
        {
            if (!layer[i])
            {
                gameComplete = false;
            }
        }

        if (gameComplete)
        {
            FinishOrOver = true;
            FindObjectOfType<GameManager5>().EndGame();
        }


        secondCounter += Time.deltaTime;
        if (secondCounter > timeLeft)
        {
            FinishOrOver = false;
            FindObjectOfType<GameManager5>().EndGame();
        }
    }
}
