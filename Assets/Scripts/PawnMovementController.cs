using UnityEngine;
using System;

public class PawnMovementController : MonoBehaviour
{
    public float moveSpeed = 10f;

    private bool isMouseDown;
    private Vector3 targetPosition;
    private Camera mainCamera;

    [SerializeField] Pawn pawn;
    private static Pawn selectedPawn;

    public event EventHandler<OnSelectedPawnChangedEventArgs> OnSelectedPawnChanged;
    public class OnSelectedPawnChangedEventArgs : EventArgs 
    {
        public Pawn selectedPawn;
    }


    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        HandleMouseInput();
        MoveTowardTarget();
    }

    private void HandleMouseInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Pawn pawnHit = hit.collider.GetComponent<Pawn>();
                if (pawnHit != null)
                {
                    selectedPawn = pawnHit;
                    isMouseDown = true;
                    SelectedPawn(pawnHit);
                }
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isMouseDown = false;
            SelectedPawn(null);
        }

        if (isMouseDown && selectedPawn == pawn)
        {
            UpdateTargetPosition();
        }
    }

    private void UpdateTargetPosition()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, ~(1 << gameObject.layer)))
        {
            targetPosition = new Vector3(hit.point.x, transform.position.y, hit.point.z);
        }
    }

    private void MoveTowardTarget()
    {
        if (isMouseDown && selectedPawn == pawn)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
    }
    private void SelectedPawn(Pawn pawn)
    {
        OnSelectedPawnChanged?.Invoke(this, new OnSelectedPawnChangedEventArgs
        {
            selectedPawn = pawn
        });
    }
}