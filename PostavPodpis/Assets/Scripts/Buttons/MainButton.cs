using Currency_and_Votes;
using UnityEngine;
using UnityEngine.UI;

public class MainButton : MonoBehaviour
{
    [SerializeField] private Text votesText;
    [SerializeField] private GameObject voter;
    [SerializeField] private Slider votesCountSlider; 
    
     private int votesCount; //for a save, big int because dohya cifr - должен быть биг интеджер, но я пока не придумал, как заставить это работать, буду решать геймдизайном и обнуслением слайдера. 
     
    
     private IEVotable iVotable;
     private SpriteRenderer buttonSprite;
     private Color buttonColor;

     private VotesManager _votesManager;

    
      

    private void Start()
    {
        
        buttonSprite = gameObject.GetComponent<SpriteRenderer>();
        buttonColor = buttonSprite.color;
        _votesManager = FindObjectOfType<VotesManager>().GetComponent<VotesManager>();




    }

    private void Update()
    {
        //Debug.Log(_votesManager.GetVotes());
        
        votesText.text = $"Количество голосов {_votesManager.GetVotes()}"; //кривой код, оч зависит от реализации
        votesCountSlider.value = votesCount;
    }

    private void OnMouseDown()
    {
        buttonSprite.color = Color.gray;
        _votesManager.AddVotes();
    }

    private void OnMouseUp()
    {
        //buttonSprite.color = new Color(238, 106, 66);
        buttonSprite.color = buttonColor;
    }
   
}
