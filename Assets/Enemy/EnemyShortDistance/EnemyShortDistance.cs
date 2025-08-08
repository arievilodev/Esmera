using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShortDistance : MonoBehaviour
{
    // Inicializando a colis�o do inimigo
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica se o objeto colidido � o jogador a partir da tag "Player"
        if (collision.gameObject.CompareTag("Player"))
        {
            // Obt�m o componente PlayerMov, guarda os resultados no objeto player
            Player player = collision.gameObject.GetComponent<Player>();
            // Se o componente PlayerMov n�o for nulo, ou seja, se tiver sido encontrado, ent�o o m�todo TakeDamage � chamado,
            // tirando 10 pontos de vida do jogador */
            if (player != null)
            {
                player.TakeDamage(10);
                player.kBCount = player.kBTime;
                if (collision.transform.position.x <= transform.position.x)
                {
                    player.isKnockRight = true;
                }
                if (collision.transform.position.x > transform.position.x)
                {
                    player.isKnockRight = false;
                }

            }


        }
    }
}
