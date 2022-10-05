public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
     private int shotSaw;
   public int totalShotSaw;
   private int enemyKilled;
   public int totalenemyKilled;

   EasyFileSave myFile;

    void Awake()
    {
        if(Instance== null)
        {
            Instance = this;
            DataProcess();
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
  
    // Update is called once per frame
    void Update()
    {
        
    }
    
    public int ShotSaw
    {
      get
      {
        return shotSaw;
      }
      set
      {
        shotSaw = value;
        GameObject.Find("ShootSaw").GetComponent<Text>().text = "ShootSaw=" + shotSaw.ToString();
      }
       
           
    } 
    
     public int EnemyKilled
    {
      get
      {
        return enemyKilled;
      }
      set
      {
        enemyKilled=value;
        GameObject.Find("EnemyKilled").GetComponent<Text>().text = "EnemyKilled=" + enemyKilled.ToString();
      }
    }

      void DataProcess()
      {
        myFile = new EasyFileSave();
        LoadData();
      }

      public void DataSave() 
      {
        totalenemyKilled += enemyKilled;
        totalShotSaw += shotSaw;

        myFile.Add("totalShootSaw",totalShotSaw);
        myFile.Add("totalEnemyKilled",totalenemyKilled);

        myFile.Save();

      }

      public void LoadData() 
      {
        if(myFile.Load())
        {
          totalShotSaw = myFile.GetInt("totalShootSaw");
          totalenemyKilled = myFile.GetInt("totalEnemyKilled");

        }
      }
    }    

