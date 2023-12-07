using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapController : MonoBehaviour
{
    //public GameManager gameManager;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject cross;

    private void OnCollisionEnter2D(Collision2D collision)
	{
		// 当たった相手が"Player"タグを持っていたら
		if (collision.gameObject.tag == "Trap")
		{
            Debug.Log("あたった");
            Vector3 hitPos = collision.contacts[0].point;
            player.SetActive(false);
            Instantiate(cross, hitPos, Quaternion.identity);
            GameManager.instance.GameOver();
        }
    }
}
