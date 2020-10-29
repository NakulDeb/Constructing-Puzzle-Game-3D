using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1 : MonoBehaviour
{
    public GameObject leg1, leg2, leg3, leg4, dasa1, dasa2, backbon1, backbon2, plate, leg1Target, leg2Target, leg3Target, leg4Target, dasa1Target, dasa2Target, backbon1Target, backbon2Target, plateTarget;
    Vector3 leg1InitialPos, leg2InitialPos, leg3InitialPos, leg4InitialPos, dasa1InitialPos, dasa2InitialPos, backbon1InitialPos, backbon2InitialPos, plateInitialPos;
    private Vector3 mOffset;
    private float mZCoord;

    void Start()
    {
        leg1InitialPos = leg1.transform.position;
        leg2InitialPos = leg2.transform.position;
        leg3InitialPos = leg3.transform.position;
        leg4InitialPos = leg4.transform.position;
        dasa1InitialPos = dasa1.transform.position;
        dasa2InitialPos = dasa2.transform.position;
        backbon1InitialPos = backbon1.transform.position;
        backbon2InitialPos = backbon2.transform.position;
        plateInitialPos = plate.transform.position;
    }
    public void DragLeg1()
    {
        leg1.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    public void DragLeg2()
    {
        leg2.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    public void DragLeg3()
    {
        leg2.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    public void DragLeg4()
    {
        leg4.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    public void DragDasa1()
    {
        dasa1.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    public void DragDasa2()
    {
        dasa2.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    public void DragBackbon1()
    {
        backbon1.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    public void DragBackbon2()
    {
        backbon2.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    public void DragPlate()
    {
        plate.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    //Drop
    public void DropLeg1()
    {
        float Distance = Vector3.Distance(leg1.transform.position, leg1Target.transform.position);
        if (Distance < 50)
        {
            leg1.transform.position = leg1Target.transform.position;
        }
        else
        {
            leg1.transform.position = leg1InitialPos;
        }
    }
    public void DropLeg2()
    {
        float Distance = Vector3.Distance(leg2.transform.position, leg2Target.transform.position);
        if (Distance < 50)
        {
            leg2.transform.position = leg2Target.transform.position;
        }
        else
        {
            leg2.transform.position = leg2InitialPos;
        }
    }
    public void DropLeg3()
    {
        float Distance = Vector3.Distance(leg3.transform.position, leg3Target.transform.position);
        if (Distance < 50)
        {
            leg3.transform.position = leg3Target.transform.position;
        }
        else
        {
            leg3.transform.position = leg3InitialPos;
        }
    }
    public void DropLeg4()
    {
        float Distance = Vector3.Distance(leg4.transform.position, leg4Target.transform.position);
        if (Distance < 50)
        {
            leg4.transform.position = leg4Target.transform.position;
        }
        else
        {
            leg4.transform.position = leg4InitialPos;
        }
    }
    public void DropDasa1()
    {
        float Distance = Vector3.Distance(dasa1.transform.position, dasa1Target.transform.position);
        if (Distance < 50)
        {
            dasa1.transform.position = dasa1Target.transform.position;
        }
        else
        {
            dasa1.transform.position = dasa1InitialPos;
        }
    }
    public void DropDasa2()
    {
        float Distance = Vector3.Distance(dasa2.transform.position, dasa2Target.transform.position);
        if (Distance < 50)
        {
            dasa2.transform.position = dasa2Target.transform.position;
        }
        else
        {
            dasa2.transform.position = dasa2InitialPos;
        }
    }
    public void DropBackbon1()
    {
        float Distance = Vector3.Distance(backbon1.transform.position, backbon1Target.transform.position);
        if (Distance < 50)
        {
            backbon1.transform.position = backbon1Target.transform.position;
        }
        else
        {
            backbon1.transform.position = backbon1InitialPos;
        }
    }
    public void DropBackbon2()
    {
        float Distance = Vector3.Distance(backbon2.transform.position, backbon2Target.transform.position);
        if (Distance < 50)
        {
            backbon2.transform.position = backbon2Target.transform.position;
        }
        else
        {
            backbon2.transform.position = backbon2InitialPos;
        }
    }
    public void DropPlate()
    {
        float Distance = Vector3.Distance(plate.transform.position, plateTarget.transform.position);
        if (Distance < 50)
        {
            plate.transform.position = plateTarget.transform.position;
        }
        else
        {
            plate.transform.position = plateInitialPos;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
