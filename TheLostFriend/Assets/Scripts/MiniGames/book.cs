using UnityEngine;

public class book : MonoBehaviour
{
    public bool isBook;
    public float myX;
    private bool rightPos;
    public float rayLength;
    bool left, right;
    Vector3 startPos, finishPos;
    bool take;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Ray();

        if (Mathf.Abs(transform.localPosition.x - myX) < 0.05f && !rightPos)
        {
            if (isBook)
            {
                BooksDressesManager.booksCount++;
            }
            else
            {
                BooksDressesManager.dressesCount++;
            }
            rightPos = true;
        }

        if (Mathf.Abs(transform.localPosition.x - myX) > 0.05f && rightPos)
        {
            if (isBook)
            {
                BooksDressesManager.booksCount--;
            }
            else
            {
                BooksDressesManager.dressesCount--;
            }
            rightPos = false;
        }
    }
    private void OnMouseDown()
    {
        if (isBook && !BooksDressesManager.booksComplete)
        {
            if (!take)
            {
                take = true;
                startPos = Input.mousePosition;
            }
        }
        if (!isBook && !BooksDressesManager.dressesComplete)
        {
            if (!take)
            {
                take = true;
                startPos = Input.mousePosition;
            }
        }
    }
    private void OnMouseUp()
    {
        if (isBook && !BooksDressesManager.booksComplete)
        {
            if (take)
                finishPos = Input.mousePosition;
        }

        if (!isBook && !BooksDressesManager.dressesComplete)
        {
            if (take)
                finishPos = Input.mousePosition;
        }
    }
    private void Move()
    {
        if (take)
        {
            if (Input.GetMouseButtonUp(0))
            {
                RaycastHit hit;

                Ray l = new Ray(transform.position, -transform.right);
                Ray r = new Ray(transform.position, transform.right);

                if (finishPos.x > startPos.x && right)
                {
                    transform.Translate(rayLength, 0, 0);

                    if (Physics.Raycast(r, out hit, rayLength))
                    {
                        hit.transform.Translate(-rayLength, 0, 0);
                    }
                }
                else if (finishPos.x < startPos.x && left)
                {
                    transform.Translate(-rayLength, 0, 0);

                    if (Physics.Raycast(l, out hit, rayLength))
                    {
                        hit.transform.Translate(rayLength, 0, 0);
                    }
                }
                //Invoke("StopTake", 1f);
                take = false;
            }
        }
    }
    private void Ray()
    {
        RaycastHit hit;

        Ray l = new Ray(transform.position, -transform.right);
        Ray r = new Ray(transform.position, transform.right);

        if (Physics.Raycast(l, out hit, rayLength))
        {
            left = true;
        }
        else
            left = false;

        if (Physics.Raycast(r, out hit, rayLength))
        {
            right = true;
        }
        else
            right = false;
    }
    void StopTake()
    {
        take = false;
    }
}
