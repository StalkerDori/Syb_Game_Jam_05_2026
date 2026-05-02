using UnityEngine;

public class MoveLongBlock : MonoBehaviour
{
    public bool vertical, horizontal;
    public float rayLength;
    private bool take;
    private bool right, left, top, bottom;

    Vector3 startPos, finishPos;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckMove();
        Move();
    }
    private void Move()
    {
        if (take)
        {
            if (Input.GetMouseButtonUp(0))
            {
                Vector3 Z = finishPos - startPos;

                if (horizontal)
                {
                    if (finishPos.x > startPos.x && Mathf.Abs(Z.x) > Mathf.Abs(Z.y) && !right)
                    {
                        transform.Translate(rayLength, 0, 0);
                    }
                    else if (finishPos.x < startPos.x && Mathf.Abs(Z.x) > Mathf.Abs(Z.y) && !left)
                    {
                        transform.Translate(-rayLength, 0, 0);
                    }
                }

                if (vertical)
                {
                    if (finishPos.y > startPos.y && Mathf.Abs(Z.y) > Mathf.Abs(Z.x) && !top)
                    {
                        transform.Translate(0, rayLength, 0);
                    }
                    else if (finishPos.y < startPos.y && Mathf.Abs(Z.y) > Mathf.Abs(Z.x) && !bottom)
                    {
                        transform.Translate(0, -rayLength, 0);
                    }
                }
                take = false;
            }
        }
    }
    private void CheckMove()
    {
        Ray rayLeft = new Ray(transform.position, -transform.right);
        Ray rayRight = new Ray(transform.position, transform.right);
        Ray rayTop = new Ray(transform.position, transform.up);
        Ray rayBottom = new Ray(transform.position, -transform.up);

        RaycastHit hit;

        if (Physics.Raycast(rayTop, out hit, rayLength * transform.localScale.y / 1.5f))
        {
            top = true;
        }
        else
        {
            top = false;
        }

        if (Physics.Raycast(rayBottom, out hit, rayLength * transform.localScale.y / 1.5f))
        {
            bottom = true;
        }
        else
        {
            bottom = false;
        }

        if (Physics.Raycast(rayLeft, out hit, rayLength * transform.localScale.x / 1.5f))
        {
            left = true;
        }
        else
        {
            left = false;
        }

        if (Physics.Raycast(rayRight, out hit, rayLength * transform.localScale.x / 1.5f))
        {
            right = true;
        }
        else
        {
            right = false;
        }
    }
    private void OnMouseDown()
    {
        take = true;
        startPos = Input.mousePosition;
    }
    private void OnMouseUp()
    {
        finishPos = Input.mousePosition;
    }
}
