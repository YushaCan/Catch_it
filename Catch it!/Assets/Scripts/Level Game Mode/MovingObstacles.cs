using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovingObstacles : MonoBehaviour
{
    [SerializeField]
    private Vector3 finalPos;
    private Vector3 originalPos, currentPos;
    // Start is called before the first frame update
    void Start()
    {
        originalPos = transform.position;
        currentPos = finalPos;
        Move(currentPos);
    }

    private void Move(Vector3 pos)
    {
        transform.DOMove(pos, 1f).OnComplete(() => Move(currentPos));
        currentPos = currentPos == finalPos ? originalPos : finalPos;
    }
}
