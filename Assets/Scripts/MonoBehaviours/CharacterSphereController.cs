using System;
using UnityEngine;

public class CharacterSphereController : MonoBehaviour
{
    private Rigidbody rb;
    private InputController inputController;

    private float deltaTime;
    
    private float speed = Data.Speed;
    private float jumpForce = Data.JumpForce;
    private bool isGrounded = true;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        inputController = new InputController();
        deltaTime = Time.deltaTime;
    }

    

    private void Update()
    {
        Movement();
        TryJump();
        ActivationButtonChecking();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
            isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
            isGrounded= false;
    }

    /// <summary>
    /// Логика прыжка.
    /// </summary>
    private void TryJump()
    {
        if (isGrounded != true)
            return;

        if (inputController.GetJumpButton())
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    /// <summary>
    /// Логика движения.
    /// </summary>
    private void Movement()
    {
        Vector3 movement = new Vector3(inputController.GetHorizontal(), 0, inputController.GetVertical());
        rb.AddForce(movement * speed * deltaTime, ForceMode.VelocityChange);
    }

    /// <summary>
    /// Проверка нажатия кнопки активации (E).
    /// </summary>
    private void ActivationButtonChecking()
    {
        if (inputController.IsActivateButtonPressed())
            Observer.ActivateButtonPressed?.Invoke();
    }
}
