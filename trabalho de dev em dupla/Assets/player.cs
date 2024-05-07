using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 5f; // Velocidade do movimento do jogador

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Obtendo a referência para o Rigidbody2D
    }

    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal"); // Obtendo a entrada do eixo horizontal (A/D, setas esquerda/direita)
        float moveVelocity = moveInput * speed; // Calculando a velocidade de movimento

        // Aplicando o movimento horizontal
        rb.velocity = new Vector2(moveVelocity, rb.velocity.y);

        // Virar o personagem para a direção correta
        if (moveInput > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f); // Virar para a direita
        }
        else if (moveInput < 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f); // Virar para a esquerda
        }
    }
}


