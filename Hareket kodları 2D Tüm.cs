{
    Rigidbody2D playerx;
    Animator playerA;
     public float movespeed = 1f;
     bool facingRight=true ;
     public float JumpSpeed = 1f,jumpFreqency=1f,nextJumpTime=1f;
     public bool isGraunded = false ;
     public Transform graundCheckPosition;
     public float graundCheckRadius;
     public LayerMask GroundCheckLayer;

    void Start()
    {
        playerx = GetComponent<Rigidbody2D>();
        playerA = GetComponent<Animator>();
    }

    
    void Update()
    {   
        HorizontalMove();
        GraundCheck();
       
        if(playerx.velocity.x < 0 && facingRight)
        {
              FlipFace();
        }
        
        else if (playerx.velocity.x > 0 && !facingRight)
        {
               FlipFace();
        }

        if (Input.GetAxis("Vertical")>0 && isGraunded && (nextJumpTime < Time.timeSinceLevelLoad))
        {
          nextJumpTime = Time.timeSinceLevelLoad + jumpFreqency ;
               Jump();
        }
    }

     void HorizontalMove()
     {
        playerx.velocity = new Vector2(Input.GetAxis("Horizontal") * movespeed , playerx.velocity.y );
        playerA.SetFloat("SpeedAnimation",Mathf.Abs(playerx.velocity.x));
     }
    
     void FlipFace()
      {
        facingRight = !facingRight;
        Vector3 tempLocalScale = transform.localScale;
        tempLocalScale.x *= -1;
        transform.localScale = tempLocalScale;
      }
     void Jump()
     {
       playerx.AddForce(new Vector2(0f,JumpSpeed));
     }

     void GraundCheck()
     {
       isGraunded = Physics2D.OverlapCircle(graundCheckPosition.position,graundCheckRadius,GroundCheckLayer);
       playerA.SetBool("isGroundedAnim",isGraunded);
     }

  

    
}
