using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField] private float speed = 1f;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Animator animator;
    [SerializeField] private SeedItem seed;

    private List<Item> items;
    private int selectionIndex;

    private void Update() {
        CheckMovement();
        CheckInteract();
    }

    private void CheckMovement() {
        Vector3 inputVector = new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"),
            0f);

        if (inputVector.magnitude > 0.2f) {
            playerTransform.position += inputVector * (speed * Time.deltaTime);
            UpdateAnim(true, inputVector);
        } else
            UpdateAnim(false, Vector2.zero);
    }

    private void CheckInteract() {
        if (Input.GetButtonDown("Fire1")) {
            RaycastHit2D raycastHit2D = Physics2D.Raycast(
                playerTransform.position,
                Vector2.zero);
            Debug.Log(raycastHit2D.collider);
            raycastHit2D.collider.gameObject.GetComponent<PlantationController>().PlantSeed(seed);
        }
    }

    private void UpdateAnim(bool isMoving, Vector2 movementVector) {
        animator.SetBool("IsMoving", isMoving);
        if (isMoving) {
            animator.SetFloat("MoveX", movementVector.x);
            animator.SetFloat("MoveY", movementVector.y);
        }
    }
}
