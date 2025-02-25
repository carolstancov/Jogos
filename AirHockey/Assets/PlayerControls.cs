using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    var pos = transform.position;
    pos.x = mousePos.x;
    pos.y = mousePos.y;
    transform.position = pos;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();     // Inicializa a raquete

    }

    // Update is called once per frame
    void Update()
    {
        var vel = rb2d.velocity;             // Acessa a velocidade da raquete
    if (Input.GetKey(moveUp)) {             // Velocidade da Raquete para ir para cima
        vel.y = speed;
    }
    else if (Input.GetKey(moveDown)) {      // Velocidade da Raquete para ir para cima
        vel.y = -speed;                    
    }
    else {
        vel.y = 0;                          // Velociade para manter a raquete parada
    }
    rb2d.velocity = vel;                    // Atualizada a velocidade da raquete

    var pos = transform.position;           // Acessa a Posição da raquete
    if (pos.y > boundY) {                  
        pos.y = boundY;                     // Corrige a posicao da raquete caso ele ultrapasse o limite superior
    }
    else if (pos.y < -boundY) {
        pos.y = -boundY;                    // Corrige a posicao da raquete caso ele ultrapasse o limite inferior
    }
    transform.position = pos;               // Atualiza a posição da raquete

    }
}
