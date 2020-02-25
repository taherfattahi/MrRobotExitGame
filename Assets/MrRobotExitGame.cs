using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MrRobotExitGame : MonoBehaviour
{
	
	[SerializeField] Text textComponentStart;
    [SerializeField] Text textComponent;
	[SerializeField] Image imageComponent;
	[SerializeField] State startingState;
		
	private State state;

	public Sprite Img02;
	public Sprite Img03;
	public Sprite Img04;
	public Sprite Img05;
	public Sprite Img06;
	public Sprite Img07;
	public Sprite Img08;
	public Sprite Img09;
	
	private int index = 0;
	private bool anyKeyFlag = true;

	
    // Start is called before the first frame update
    void Start()
    {
		//imageComponent.image = 
		//GetComponent<Image>().sprite = img01;
		//img.sprite = newSprite;
		

		state = startingState;
    }

    // Update is called once per frame
    void Update()
    {

		if(anyKeyFlag){
			if (Input.anyKeyDown)
			{
				anyKeyFlag = false;
				textComponentStart.text = "";
				textComponent.text = state.GetNextStates()[0].GetStateStory();
				imageComponent.sprite = Img02;
				index = 1;
				//Debug.Log("A key or mouse click has been detected");
			}
		}
		
		ManageState();
		
    }
	
	private void ManageState(){
		var nextState = state.GetNextStates();
		
		if(Input.GetKeyDown(KeyCode.Space)){
			switch (index){
				case 0:
					state = nextState[0];
					textComponent.text = state.GetStateStory();
					imageComponent.sprite = Img02;
					break;
				
				case 1:
					state = nextState[1];
					textComponent.text = state.GetStateStory();
					imageComponent.sprite = Img03;
					break;
				case 2:
					state = nextState[2];
					textComponent.text = state.GetStateStory();
					imageComponent.sprite = Img05;
					break;
				
				case 3:
					state = nextState[3];
					textComponent.text = state.GetStateStory();
					imageComponent.sprite = Img05;
					break;
					
				case 4:
					state = nextState[4];
					textComponent.text = state.GetStateStory();
					imageComponent.sprite = Img06;
					break;
					
				case 5:
					state = nextState[5];
					textComponent.text = state.GetStateStory();
					imageComponent.sprite = Img07;
					break;
				
				case 6:
					state = nextState[6];
					textComponent.text = state.GetStateStory();
					imageComponent.sprite = Img08;
					break;
					
				case 7:
					state = nextState[7];
					textComponent.text = state.GetStateStory();
					imageComponent.sprite = Img02;
					break;
					
				case 8:
					state = nextState[8];
					textComponent.text = state.GetStateStory();
					imageComponent.sprite = Img05;
					break;
					
				case 9:
					state = nextState[9];
					textComponent.text = state.GetStateStory();
					imageComponent.sprite = Img09;
					break;
			}
			
			index++;
		}
		
	}
}
