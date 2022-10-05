public class MenuScine : MonoBehaviour
{
    public GameObject DataBoard,Data,DataExit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void DataButton1() 
    {
        DataManager.Instance.LoadData();
        DataBoard.transform.GetChild(2).GetComponent<Text>().text = DataManager.Instance.totalShotSaw.ToString();
        DataBoard.transform.GetChild(1).GetComponent<Text>().text = DataManager.Instance.totalenemyKilled.ToString();
        DataBoard.SetActive(true);
        Data.SetActive(false);    
    }
    public void DataExit1() 
    {
       DataBoard.SetActive(false);
       Data.SetActive(true);
    }
}