using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // [SerializeField] means it can be edited in the editor. Without having to declare the variable as public.
    [SerializeField] private float moveSpeed = 7f;

    private void Update() {

        // Vector2 called inputVector, inizialised as a Vector2.zero.
        Vector2 inputVector = new Vector2(0, 0);

        // Old unity input system
        if (Input.GetKey(KeyCode.W)) {
            inputVector.y += 1;
        } 
        if (Input.GetKey(KeyCode.A)) {
            inputVector.x -= 1;
        } 
        if (Input.GetKey(KeyCode.S)) {
            inputVector.y -= 1;
        } 
        if (Input.GetKey(KeyCode.D)) {
            inputVector.x += 1;
        }

        // Normalizes Vector so that it doesn't go faster when moving in 2 directions.
        inputVector = inputVector.normalized;

        // New Vector3 that uses the inputVector to move on the x and z planes.
        Vector3 moveDir = new Vector3(inputVector.x, 0, inputVector.y);
        // transform.position is the position of the gameobject that has the script attached. * by Time.deltaTime to make the movement fps independent.
        transform.position += moveDir * moveSpeed * Time.deltaTime;

    }

}
