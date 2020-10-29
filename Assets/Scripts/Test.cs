using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject[] b = new GameObject[14];
    public GameObject[] bUse = new GameObject[14];
    private bool[] bTrue = new bool[14];
    Vector3[] bUsePos = new Vector3[14];

    private float secondCounter = 0;
    private float DistanceForDrag = 0.3f;
    private bool[] layer = new bool[3];

    public GameManager1 gameManager;
    public bool FinishOrOver = false;

    void Start()
    {
        for (int i = 0; i < 14; i++)
        {
            bTrue[i] = false;
        }
        for (int i = 0; i < 3; i++)
        {
            layer[i] = false;
        }
        for (int i = 0; i < 14; i++)
        {
            bUsePos[i] = bUse[i].transform.position;
        }
    }

    //public void DragB1()
    //{
    //    b1.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    Debug.Log(b1.transform.position);
    //}
    //public void DragBlue()
    //{
    //    blue.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //}
    //public void dragred()
    //{
    //    red.transform.position = camera.main.screentoworldpoint(input.mouseposition);
    //}



    //public void DropWhite()
    //{
    //    float Distance = Vector3.Distance(white.transform.position, w.transform.position);
    //    if (Distance <1)
    //    {
    //        w.transform.position = white.transform.position;
    //        Debug.Log("White");
    //    }
    //    else
    //    {
    //        w.transform.position = wp;
    //        Debug.Log("White No");
    //    }
    //}
    //public void DropBlue()
    //{
    //    float Distance = Vector3.Distance(blue.transform.position, b.transform.position);
    //    if (Distance < 1)
    //    {
    //        b.transform.position = blue.transform.position;
    //        Debug.Log("Blue");
    //    }
    //    else
    //    {
    //        b.transform.position = bp;
    //        Debug.Log("Blue No");
    //    }
    //}

    //public void DropRed()
    //{
    //    float Distance = Vector3.Distance(red.transform.position,r.transform.position);
    //    if (Distance < 1)
    //    {
    //       r.transform.position = red.transform.position;
    //        Debug.Log("Red");
    //    }
    //    else
    //    {
    //        r.transform.position = rp;
    //        Debug.Log("No Red");
    //    }
    //}

    // Update is called once per frame

    void drag()
    {
        for (int i = 0; i <= 13; i++)
        {
            for (int j = 0; j <= 13; j++)
            {
                float distance = Vector3.Distance(b[i].transform.position, bUse[j].transform.position);
                if (distance < DistanceForDrag)
                {
                    bUse[j].transform.position = b[i].transform.position;
                }
            }
        }
    }

    void chack1stLayer()
    {
        layer[0] = true;
        for (int i = 0; i < 9; i++)
        {
            bTrue[i] = false;
            for (int j = 0; j < 9; j++)
            {
                float distance = Vector3.Distance(b[i].transform.position, bUse[j].transform.position);
                if (distance < DistanceForDrag)
                {
                    bTrue[i] = true;
                    break;
                }
            }
            if (!bTrue[i])
            {
                layer[0] = false;
                break;
            }
        }
    }


    void chack2ndLayer()
    {
        layer[1] = true;
        for (int i = 9; i < 13; i++)
        {
            bTrue[i] = false;
            for (int j = 9; j < 13; j++)
            {
                float distance = Vector3.Distance(b[i].transform.position, bUse[j].transform.position);
                if (distance < DistanceForDrag)
                {
                    bTrue[i] = true;
                    break;
                }
            }
            if (!bTrue[i])
            {
                layer[1] = false;
                break;
            }
        }
    }

    void chack3rdLayer()
    {
        layer[2] = true;
        float distance = Vector3.Distance(b[13].transform.position, bUse[13].transform.position);
        if (distance < DistanceForDrag)
        {
            bTrue[13] = true;
        }
        else
        {
            layer[2] = false;
        }
    }

    void Update()
    {
        drag();
        chack1stLayer();
        chack2ndLayer();
        chack3rdLayer();






        //float Distance1 = Vector3.Distance(b1.transform.position, b1use.transform.position);
        //if (Distance1 < DistanceForDrag && white.gameObject && w.gameObject && blueC)
        //{
        //    w.transform.position = white.transform.position;
        //    whiteC = true;
        //}
        //else
        //{
        //    whiteC = false;
        //}
        //float Distance2 = Vector3.Distance(blue.transform.position, b.transform.position);
        //if (Distance2 < DistanceForDrag && blue.gameObject && b.gameObject && redC)
        //{
        //    b.transform.position = blue.transform.position;
        //    blueC = true;
        //}
        //else
        //{
        //    blueC = false;
        //}
        //float Distance3 = Vector3.Distance(red.transform.position, r.transform.position);
        //if (Distance3 < DistanceForDrag && red.gameObject && r.gameObject)
        //{
        //    r.transform.position = red.transform.position;
        //    redC = true;
        //}
        //else
        //{
        //    redC = false;
        //}

        bool gameComplete = true;
        for (int i = 0; i < 3; i++)
        {
            if (!layer[i])
            {
                gameComplete = false;
            }
        }
        if (gameComplete)
        {
            FinishOrOver = true;
            FindObjectOfType<GameManager1>().EndGame();
        }

        secondCounter += Time.deltaTime;
        if (secondCounter > 120)
        {
            FinishOrOver = false;
            FindObjectOfType<GameManager1>().EndGame();
        }
    }

}
