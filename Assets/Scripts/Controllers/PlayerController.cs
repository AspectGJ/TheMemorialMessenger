using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : HumanManager
{
    

    bool islookingRight;
    float horizontal = 0f;
    float speed = 5f;

    public GameObject bulletPref;
    public GameObject GM;


    private bool isShooting = false;
    private bool canShoot = true;

    bool isGun;

    private float shootDelay = 1f; // Delay between shots
    private float lastShootTime;

    Animator anim;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        hp = 5;
        islookingRight = true;
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        // move with horizontal axis
        horizontal = Input.GetAxis("Horizontal");
        horizontal = Mathf.Clamp(horizontal, -1f, 1f);
        //anim.SetFloat("horizontal", horizontal);

        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        anim.SetBool("isMoving", Mathf.Abs(horizontal) > 0.01f);


        

        // if player is looking right and moving left, flip
        if (horizontal < 0 && islookingRight)
        {
            Flip();
        }
        if (horizontal > 0 && !islookingRight)
        {
            Flip();
        }

   
        //get objects in an array with the tag "bullet"
        
        


          


    }


    private void Update()
    {
        //instantiating bullet with spacebar
        if (Input.GetKeyDown(KeyCode.Space) && canShoot)
        {
            Shoot();
            canShoot = false;
        }

        if (!canShoot && Time.time - lastShootTime >= shootDelay)
        {
            canShoot = true;
        }


        if (GM.GetComponent<GameManager>().gun == true)
        {
            isGun = true;
            anim.SetBool("isGun", isGun);
        }
        else
        {
            isGun = false;
            anim.SetBool("isGun", isGun);
        }
    }

    void Flip()
    {
        islookingRight = !islookingRight;
        transform.Rotate(0f, 180f, 0f);
    }

    public void Shoot()
    {
        isShooting = true;
        anim.SetBool("isShooting", isShooting);
        lastShootTime = Time.time;
        Vector3 bulletSpawnPosition = islookingRight ? new Vector3(1.5f, 0.7f, 0) : new Vector3(-1.5f, 0.7f, 0);
        GameObject newBullet = Instantiate(bulletPref, transform.position + bulletSpawnPosition, Quaternion.identity);
        newBullet.GetComponent<BulletController>().speed = islookingRight ? Mathf.Abs(newBullet.GetComponent<BulletController>().speed) : -Mathf.Abs(newBullet.GetComponent<BulletController>().speed);

        StartCoroutine(ResetShootingFlag());
    }

    private IEnumerator ResetShootingFlag()
    {
        yield return new WaitForSeconds(shootDelay);
        isShooting = false;
        anim.SetBool("isShooting", isShooting);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            anim.SetBool("isStabbing", true);

            collision.gameObject.GetComponent<EnemyController>().hp -= 1;
            if (collision.gameObject.GetComponent<EnemyController>().hp <= 0)
            {
                Destroy(gameObject);
            }
        }

        if(collision.gameObject.tag == "Trap")
        {
            hp--;
            if(hp <= 0)
            {
                Destroy(gameObject);
            }
        }

    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            anim.SetBool("isStabbing", false);
        }
    }




}
