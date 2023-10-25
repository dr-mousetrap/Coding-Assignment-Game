using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    private CharacterInputs _characterInputs;
    private Rigidbody2D _rbody;
    private Vector2 _moveInput;
    [SerializeField] int jumpPower;


    // Start is called before the first frame update
    void Awake()
    {
        _characterInputs = new CharacterInputs();

        _rbody = GetComponent<Rigidbody2D>();
        if (_rbody is null)
            Debug.LogError("Rigidbody2D is NULL!");

    }

    // Update is called once per frame
    void Update()
    {
        if (_characterInputs.Player.Jump.triggered)
        {
            _rbody.AddForce(transform.up * jumpPower);
        }

        _moveInput = _characterInputs.Player.Movement.ReadValue<Vector2>();
        _moveInput.y = 0f;
        _rbody.velocity = _moveInput * _speed;
    }
    
    void OnEnable()
    {
        _characterInputs.Player.Enable();
    }

    void OnDisable()
    {
        _characterInputs.Player.Disable();
    }  
}
// ht t/www.youtube.com/watch?v=coQxf8wpBkM
