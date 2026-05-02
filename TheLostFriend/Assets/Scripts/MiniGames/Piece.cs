using UnityEngine;

public class Piece : MonoBehaviour
{
    public int pieceNum;
    public float x, y;
    public float rayLength;
    private bool left, right, top, bottom;
    private bool myPlace;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray();
        CheckTruePos();
    }
    private void CheckTruePos()
    {
        if (FindPieces.eleven)
        {
            if (transform.localPosition.x == x && transform.localPosition.y == y && !myPlace)
            {
                PictureManager.countPieces++;
                myPlace = true;
            }
            if (myPlace && transform.localPosition.x != x || transform.localPosition.y != y && myPlace)
            {
                PictureManager.countPieces--;
                myPlace = false;
            }
        }
    }
    private void OnMouseDown()
    {
        if (!PictureManager.winPicture && FindPieces.eleven)
        {
            if (!left)
                transform.Translate(-rayLength, 0, 0);

            if (!right)
                transform.Translate(rayLength, 0, 0);

            if (!bottom)
                transform.Translate(0, -rayLength, 0);

            if (!top)
                transform.Translate(0, rayLength, 0);
        }
    }
    private void Ray()
    {
        RaycastHit hit;

        Ray l = new Ray(transform.position, -transform.right);
        Ray r = new Ray(transform.position, transform.right);
        Ray u = new Ray(transform.position, transform.up);
        Ray d = new Ray(transform.position, -transform.up);

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

        if (Physics.Raycast(u, out hit, rayLength))
        {
            top = true;
        }
        else
            top = false;

        if (Physics.Raycast(d, out hit, rayLength))
        {
            bottom = true;
        }
        else
            bottom = false;
    }
}
