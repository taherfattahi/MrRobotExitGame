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
	[SerializeField] InputField iField;

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
			}
		}
		
		ManageState();
		
    }
	
	private void ManageState(){
		var nextState = state.GetNextStates();
		
		if(iField.text != "" && Input.GetKeyDown(KeyCode.Return)) {
		 //Debug.Log("enter  "+  index);
		 
		 if(index == 7 || index == 1){
			if(iField.text != 	"1"){ 
				 index = 8;	
			}else {
				if(index >= 7){
					index = 0;
				}
			}
		 }
			
		switch (index){			
				case 0:
					state = nextState[0];
					textComponent.text = state.GetStateStory();
					imageComponent.sprite = Img02;
					iField.text = "";
					break;		
				case 1:
					state = nextState[1];
					textComponent.text = state.GetStateStory();
					imageComponent.sprite = Img03;
					iField.text = "";
					break;
				case 2:
					state = nextState[2];
					textComponent.text = state.GetStateStory();
					imageComponent.sprite = Img05;
					iField.text = "";
					break;
				
				case 3:
					state = nextState[3];
					textComponent.text = state.GetStateStory();
					imageComponent.sprite = Img05;
					iField.text = "";
					break;
					
				case 4:
					state = nextState[4];
					textComponent.text = state.GetStateStory();
					imageComponent.sprite = Img06;
					iField.text = "";
					break;
					
				case 5:
					state = nextState[5];
					textComponent.text = state.GetStateStory();
					imageComponent.sprite = Img07;
					iField.text = "";
					break;
				
				case 6:
					state = nextState[6];
					textComponent.text = state.GetStateStory();
					imageComponent.sprite = Img08;
					iField.text = "";
					break;
					
				case 7:
					state = nextState[7];
					textComponent.text = state.GetStateStory();
					imageComponent.sprite = Img02;
					iField.text = "";
					break;
					
				case 8:
					state = nextState[8];
					textComponent.text = state.GetStateStory();
					imageComponent.sprite = Img05;
					iField.text = "";
					break;
					
				case 9:
					state = nextState[9];
					textComponent.text = state.GetStateStory();
					imageComponent.sprite = Img09;
					iField.text = "";
					index = -1;
					break;
			}			
			index++;
			iField.Select();
			iField.ActivateInputField();
		
		}
	}
}
