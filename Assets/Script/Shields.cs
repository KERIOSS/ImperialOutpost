using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shields : MonoBehaviour
{
    //public GameObject shield;
    //public GameObject sword;
    public int HP = 5;
    bool shieldOFF;
    void Start()
    {
        shieldOFF = false;
        //CheckShieldHP();
    }

    // Update is called once per frame
    void Update()
	{
		//      CheckShieldHP();

		//      if (shieldOFF == true)
		//{
		//          gameObject.SetActive(false);

		//          Invoke("EnableShield", 5f);

		//      }
		//if (shieldOFF == false)
		//{
		//          gameObject.SetActive(true);
		//}
		if (shieldOFF==true)
		{
            gameObject.SetActive(false);
		}
		else
		{
            gameObject.SetActive(true);
		}

		if (HP <=0)
		{
            OutOfShield();
            Invoke("ShieldBackOn", 5f); 
        }
        
    }

    private void OutOfShield()
    {
        Debug.Log("BrakTarczy");
        shieldOFF = true;
    }

    private void ShieldBackOn()
	{
        Debug.Log("TarczaWraca");
        shieldOFF = false;
        HP = 5;
	}

	//   private void CheckShieldHP()
	//{
	//       if (HP <= 0)
	//       {
	//           shieldOFF = true;
	//           Debug.Log("tarczaOFF");
	//       }
	//   }
	//   private void EnableShield()
	//{
	//       shieldOFF = false;
	//}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            Destroy(collision.gameObject);



        }
        if (collision.gameObject.CompareTag("enemybullet"))
        {
            Destroy(collision.gameObject);
            HP -= 1;
            Debug.Log(HP);

        }
        if (collision.gameObject.CompareTag("ChargeEnemy"))
        {
            Destroy(collision.gameObject);
            HP -= 5;
            Debug.Log(HP);

        }
    }
}
