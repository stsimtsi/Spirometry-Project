using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UI.Graphic.color;

public class ball : MonoBehaviour {
	
private bool isDead = false;
private Rigidbody2D rb2d;
public float speed;
public float scrollSpeed= -1.5f;
private float power;
private float pos;
private bool reach;
private int height;
private GameObject gameObject;
public string myName;
public string myLast;
public int myHeight;
public int myWeight;
public GameObject particles;
private float nowspeed;
private float wspeed;
Image panel;
Color c;
private bool blink = false;
 private int counter = 0;
 private int blinkSpeed = 10;
 public GameObject dangerText;
 private float previousPositionX;
 private float distancex;
 private float previousPositionY;
 private float distancey;
 private float currentPositionY;
 private float heightScore;
 private float distanceScore;
 private float totalScore;
 public Text scoreText;
 public GameObject score;
 private float timer;
 private bool timeron;
 public GameObject timeoff;
 private bool colliz=true;
 private bool onDanger=false;
 private bool rotating=true;
 public GameObject nmy;
 private Rigidbody2D enemy;
 private float distenemy=300.0f;
 private bool safe=true; // αν ο εχθρός έχει χτυπήσει ή όχι 
 public GameObject secondBackground;
 private Rigidbody2D secBack;
 private Light lt;
 private byte red=255;
 Image shine;
 Color light;
 private bool lightStop=false;
 private float sh;
 public GameObject fence;
 public GameObject Endmenu;
 private bool countLife=true;
 public GameObject restartButton;
 private bool fenceGone=false;
 private bool passed=false;
 private bool stop=false;
 private bool fencePut=false;
	// Use this for initialization
	void Start () {
		
		//GET PREFS 
		gameObject=GameObject.Find("dontDestroy");
	  //myName=gameObject.GetComponent<dontDestroy>().myName1;
	myName=PlayerPrefs.GetString("myName");
	
	//myLast=gameObject.GetComponent<dontDestroy>().myLast1;
	myLast=PlayerPrefs.GetString("myLast");
	
	//myHeight=gameObject.GetComponent<dontDestroy>().myHeight1;
	myHeight=PlayerPrefs.GetInt("height");
	//myHeight=Patient.height;
	//myWeight=gameObject.GetComponent<dontDestroy>().myWeight1;
	myWeight=PlayerPrefs.GetInt("weight");
	
	//HEIGHT FROM PREFS 
	
	if (myHeight<150){
		height=150;
		
		
	}else if(myHeight>=150 && myHeight<170){
		height=200;
	}else{
		height=300;
	}
	  //height=600;
		//height=Mathf.RoundToInt((float)GameData.tartgetValueSpirometer);
		//DIAFORA
		rb2d= GetComponent<Rigidbody2D> ();
		enemy=nmy.GetComponent<Rigidbody2D>();
		wspeed=speed;
		 panel =  GameObject.Find("RedScreen").GetComponent<Image>();
		 shine =  GameObject.Find("Shine").GetComponent<Image>();
		 previousPositionX= transform.position.x;
		  previousPositionY= transform.position.y;
		  heightScore=0;
		  distanceScore=0;
		  timeron=false;
		  secBack=secondBackground.GetComponent<Rigidbody2D>();
		  lt=GetComponent<Light>();
		  
		  
		  //FENCE HEIGHT (edw mporei na vriskei to upsos tou puravlou se kathe arxi gia na ginetai automata se periptwsi allagis)
		  Rigidbody2D rfence=fence.GetComponent<Rigidbody2D>();
		  Vector2 newHeight=rfence.transform.position;
		  newHeight.y=height*2+95;
		  rfence.transform.position=newHeight;
		/*float centerPos=(height+95+248)/2;
		float scaleY=Mathf.Abs(height+95-248);
		Vector2 newCenter=rfence.transform.position;
		Vector2 newScale=rfence.transform.localScale;
		newCenter.y=centerPos;
		newScale.y= scaleY;
		  rfence.transform.position=newCenter;
		  rfence.transform.localScale=newScale;*/
	//Debug.Log("here!"+height);
	
		
	}
	
	// Update is called once per frame
	void Update () {
		//FENCE
		if(fencePut==false && GameData.testStarted){
		height=Mathf.RoundToInt((float)GameData.tartgetValueSpirometer);
		Debug.Log(GameData.tartgetValueSpirometer);
		 Rigidbody2D rfence=fence.GetComponent<Rigidbody2D>();
		  Vector2 newHeight=rfence.transform.position;
		  newHeight.y=height*2+95;
		  rfence.transform.position=newHeight;
		  fencePut=true;
		}
		//TIMER
		// if(timeron==true && timer<=6){
		// timer +=Time.deltaTime;
		// //Debug.Log(timer);
		// if(timer>6 && safe==true && reach==true){
			// timeoff.SetActive(true);
			// secondBackground.SetActive(true);
			
		// }
		
		// }
		// if(timer>6 && reach==false){
			// rb2d.bodyType=RigidbodyType2D.Dynamic;
			// isDead=true;
		// }
		
		//SHINE HHEN REACH TIME
		if(reach==true && isDead==false){
			//red--;
			//secBack.GetComponent<SpriteRenderer>().color=new Color32(red,255,255,100);
			light=shine.color;
			sh=light.a;
			if(sh<1.0f && lightStop==false){
			light.a=light.a+0.03f;
			sh=light.a;
			shine.color=light;
			}
			if(sh>0.8f){
				light.a=0f;
				shine.color=light;
				lightStop=true;
				GameObject.Find("Shine").SetActive(false);
				nmy.SetActive(false);
			}
			
			rb2d.bodyType=RigidbodyType2D.Dynamic;
			rb2d.AddRelativeForce(Vector2.up * 200000*Time.deltaTime);
			if(fenceGone==false){
			GameObject.Find("Fences/fenceHeight/fence").SetActive(false);
			//GameObject.Find("Fences/fence (1)").SetActive(false);
			GameObject.Find("frontGround").SetActive(false);
			fenceGone=true;
			}
		 }
		/*if(timer>6 && secondBackground.GetComponent<backScript>().stopMoving==false){
			secBack.AddRelativeForce(Vector2.left*900000000000000000);
		}
		if(secondBackground.GetComponent<backScript>().stopMoving==true){
			secBack.velocity=Vector2.zero;
		}*/
		
		//GIA TO YPSOS STO SCORE
		currentPositionY=transform.position.y;
		distancey=(currentPositionY-previousPositionY);
		if(distancey>heightScore){
			heightScore=distancey;
			
			
		}
		//Debug.Log(heightScore);
		
		//GIA TO DANGER
		dangerText.SetActive(false);
		
		//GIA TO ANAVOSVIMA PANEL
		if(counter >= blinkSpeed)
     {
         blink = true;
		 if(counter==blinkSpeed*2){
         counter = 0;
		 }
     } 
     else
         blink = false;
     
     counter++;
 
		
		
	
		if (Input.GetKey("space")){
			power++;
			
		}
		
		
		if(isDead==false && reach==false && GameData.testStarted==true){
		/* if(Input.GetKey("right"))
 {
 rb2d.transform.position += transform.right * speed * Time.deltaTime;
 rb2d.transform.position += transform.up * speed * Time.deltaTime;
 //transform.Rotate(Vector3.forward *-100* Time.deltaTime);
 }*/
 transform.Translate(Vector2.up*Time.deltaTime*200);
 rb2d.transform.eulerAngles = new Vector3(0, 0, -90.0f);
 
 Vector2 diff=rb2d.transform.position-enemy.transform.position;
				enemy.transform.position = rb2d.position-diff.normalized*distenemy;
 
 if((Input.GetKey("up") || GameData.predictedPercentageOfTarget!=0)  && stop==false){
	 timeron=true;
	// power=power+10; //XRISIMOPOIEITAI WS DEIGMA
	power=(GameData.predictedPercentageOfTarget/100)*Mathf.RoundToInt((float)GameData.tartgetValueSpirometer);
	// height=500;
	//transform.Translate(Vector3.up*1000*Time.deltaTime, Space.World);
	//rb2d.transform.eulerAngles = new Vector3(0, 0, -25.0f);
	transform.position= new Vector2(transform.position.x,Time.fixedDeltaTime*50*2*power+95);//προσθεσα το Time.deltaTime*100 για το build(opou 95 to upsos puravlou)
	
	}
	if (power>=height){
		stop=true;
		//Debug.Log("kjghkghkdfhgkdhgkdhkfgjhdkfghkdfjghdf"+power);
		if(passed==true){
		GameObject.Find("Fences/fenceHeight/glowPortal").SetActive(true);
		 Vector2 newPortHeight=GameObject.Find("Fences/fenceHeight/glowPortal").transform.position;
		  newPortHeight.y=rb2d.position.y;
		GameObject.Find("Fences/fenceHeight/glowPortal").transform.position=newPortHeight;
		}
	//transform.position=Vector2(power,0);
	 
 }
		}
		/*if (isDead==false && reach==true){
			if(Input.GetKey("r")){
				speed=speed/1.5f;
				
			}else if(Input.GetKey("t")){
				speed=wspeed;
			}
			//ENEMY
			if(timer<6){
				Vector2 diff=rb2d.transform.position-enemy.transform.position;
				enemy.transform.position = rb2d.position-diff.normalized*distenemy;
			}else{
				enemy.bodyType = RigidbodyType2D.Dynamic;
				enemy.AddRelativeForce(Vector2.up*300000*Time.deltaTime);
			}
			
			if(Input.GetKey("up") && safe==true){ //εαν η σύναμη είναι πάνω απο 0 η όποιο νουμερο θέσουμε
			rb2d.gravityScale=10.0f;
				rb2d.mass=10.0f;
				//ακολουθία του εχυρού
				
			//rb2d.transform.position += transform.up * speed * Time.deltaTime;
			//rb2d.transform.position += transform.right * speed * Time.deltaTime;
			rb2d.AddRelativeForce(Vector2.up * speed*Time.deltaTime);
			//rb2d.AddRelativeForce(Vector2.right* speed*Time.deltaTime);
			if(onDanger==false){
			 rb2d.transform.eulerAngles = new Vector3(0, 0, -35.0f);
			 if(distenemy<300.0f){
			 distenemy++;
			 }
			if(rotating){
			 if (Vector3.Distance(rb2d.transform.eulerAngles, new Vector3(0,0,-35.0f)) > 0.01f)
         {
			rb2d.transform.Rotate(0, 0, -Time.deltaTime*10);
		 } else
         {
             rb2d.transform.eulerAngles = new Vector3(0,0,-35.0f);
             rotating = false;
         }
			}
			}
			 rb2d.gravityScale=10.0f;
				rb2d.mass=10.0f;
				//ενα δείγμα για μείωση δυνάμεως αέρα
				speed=speed/1.003f;
				wspeed=wspeed/1.003f;
				if(speed<nowspeed/1.005f){ //εάν η δύναμη είναι μικρότερη απο ότι θα έπρεπε να είναι σύμφωνα με το διάγραμμα εμφανίζεται κίνδυνος
					onDanger=true;
					distenemy=distenemy-3;
					Debug.Log("DANGER");
					dangerText.SetActive(true);
					//rb2d.transform.Rotate(0, 0, -Time.deltaTime*10);
					 //panel.color = UnityEngine.Color.red;
					 if(blink){
					  c= panel.color;
					 c.a=0.3f; 
					 panel.color=c;
					 }
					 else{
						 c= panel.color;
					 c.a=0f; 
					 panel.color=c;
					 }
				}else{ 
					 c= panel.color;
					 c.a=0f; 
					 panel.color=c;
					 onDanger=false;
				}
			//rb2d.AddForce(speed*Time.deltaTime,speed*Time.deltaTime);
			}else if(rb2d.transform.position.y<pos){ //εαν πέφτει να αλλάζει κατεύθυνση
				rb2d.transform.eulerAngles = new Vector3(0, 0, -145.0f);
				particles.SetActive(false);
				timeoff.SetActive(false);
				
				
				//pos=rb2d.transform.position.y;
			}else{ //εάν η δύναμη/ταχύτητα είναι 0 ή κάτω από αυτή που θέσαμε αλλάζει η μάζα και η βαρύτητα ώστε να πέφτει πιο γρήγορα
				//particles.SetActive(false);
				rb2d.gravityScale=55.0f;
				rb2d.mass=100.0f;
			}
		rb2d.bodyType = RigidbodyType2D.Dynamic;
		
		}*/
		if(onDanger==true){
			distenemy=distenemy-3;
					Debug.Log("DANGER");
					dangerText.SetActive(true);
					//rb2d.transform.Rotate(0, 0, -Time.deltaTime*10);
					 //panel.color = UnityEngine.Color.red;
					 if(blink){
					  c= panel.color;
					 c.a=0.3f; 
					 panel.color=c;
					 }
					 else{
						 c= panel.color;
					 c.a=0f; 
					 panel.color=c;
					 }
				}else{ 
					 c= panel.color;
					 c.a=0f; 
					 panel.color=c;
					 onDanger=false;
				}
			
		
	}
	void OnCollisionEnter2D(Collision2D coll){
		
		 if (coll.gameObject.tag == "Ground" ){
		isDead=true;
		onDanger=false;
		rb2d.gravityScale=55.0f;
		rb2d.mass=100.0f;
		particles.SetActive(false);
		GameController.instance.Died();
		distancex=(transform.position.x-previousPositionX);
		if(distancex>distanceScore){
			distanceScore=distancex;
			
		}
		//Debug.Log(distancex);
		if(colliz==true){
		totalScore=distanceScore+heightScore;
		
		//score.SetActive(true);
		}
		scoreText.text="Total Score: "+totalScore;
		rb2d.bodyType = RigidbodyType2D.Dynamic;
		colliz=false;
		
		 Endmenu.SetActive(true);
		 if(PlayerPrefs.GetInt("lifes")<1){
			 restartButton.SetActive(false);
		 }
		 if(countLife==true){
		 PlayerPrefs.SetInt("lifes",PlayerPrefs.GetInt("lifes")-1);
		 countLife=false;
		 }
		
		//-----------------------------------------------------------------------------------------//
        //                              RIGHT                                                      //
        //-----------------------------------------------------------------------------------------//
		if(safe==true && reach==true){
		if (GameData.spirometrisesNumber == 1)
            {
                GameData.result1FEV = GameData.fevValue;

                GameData.result1PEF = GameData.pefValue;

               

                
                Endmenu.transform.GetChild(3).transform.GetChild(0).GetComponent<Text>().text = "FEV: " + GameData.fevValue + " PEF: " + GameData.pefValue;
                //resultScene.transform.GetChild(1).transform.GetChild(2).GetComponent<Text>().text = GameData.messageResultString;
                Endmenu.transform.GetChild(3).transform.GetChild(1).GetComponent<Text>().text = "Μπράβο τα κατάφερες. Πάμε ξανά!! Είσαι έτοιμος; Ξεκίνα με το 3.";
                

               

            }
            else if (GameData.spirometrisesNumber == 2)
            {
                GameData.result2FEV = GameData.fevValue;

                GameData.result2PEF = GameData.pefValue;

                

               
                Endmenu.transform.GetChild(3).transform.GetChild(0).GetComponent<Text>().text = "FEV: " + GameData.fevValue + " PEF: " + GameData.pefValue;
                //resultScene.transform.GetChild(1).transform.GetChild(2).GetComponent<Text>().text = GameData.messageResultString;
                Endmenu.transform.GetChild(3).transform.GetChild(1).GetComponent<Text>().text = "Μπράβο τα κατάφερες. Πάμε ξανά!! Είσαι έτοιμος; Ξεκίνα με το 3.";
                

               
            }

            else if (GameData.spirometrisesNumber == 3)
            {
                GameData.result3FEV = GameData.fevValue;

                GameData.result3PEF = GameData.pefValue;

               




                
              
                Endmenu.transform.GetChild(3).transform.GetChild(0).GetComponent<Text>().text = "FEV: " + GameData.fevValue + " PEF: " + GameData.pefValue;
                //finishScrene.transform.GetChild(1).transform.GetChild(2).GetComponent<Text>().text = GameData.messageResultString;
                Endmenu.transform.GetChild(3).transform.GetChild(1).GetComponent<Text>().text = "Μπράβο τα κατάφερες. Τέλος Παιχνιδιού";
               
                //resultScene.transform.GetChild(1).GetComponent<Animator>().SetBool("finishCounting", true);



                
            }
		}
		//-----------------------------------------------------------------------------------------//
        //                              WRONG- NO REACH                                                    //
        //-----------------------------------------------------------------------------------------//
		else if(reach==false){
			
			if (GameData.spirometrisesNumber == 1)
            {
                GameData.result1FEV = GameData.fevValue;

                GameData.result1PEF = GameData.pefValue;

               

                
                Endmenu.transform.GetChild(3).transform.GetChild(0).GetComponent<Text>().text = "FEV: " + GameData.fevValue + " PEF: " + GameData.pefValue;
                //resultScene.transform.GetChild(1).transform.GetChild(2).GetComponent<Text>().text = GameData.messageResultString;
                Endmenu.transform.GetChild(3).transform.GetChild(1).GetComponent<Text>().text = "Προσπάθησε πάλι και φύσα πιο δυνατά. Πάμε ξανά!! Είσαι έτοιμος;";
                

               

            }
            else if (GameData.spirometrisesNumber == 2)
            {
                GameData.result2FEV = GameData.fevValue;

                GameData.result2PEF = GameData.pefValue;

                

               
                Endmenu.transform.GetChild(3).transform.GetChild(0).GetComponent<Text>().text = "FEV: " + GameData.fevValue + " PEF: " + GameData.pefValue;
                //resultScene.transform.GetChild(1).transform.GetChild(2).GetComponent<Text>().text = GameData.messageResultString;
                Endmenu.transform.GetChild(3).transform.GetChild(1).GetComponent<Text>().text = "Προσπάθησε πάλι και φύσα πιο δυνατά. Πάμε ξανά!! Είσαι έτοιμος;";
                

               
            }

            else if (GameData.spirometrisesNumber == 3)
            {
                GameData.result3FEV = GameData.fevValue;

                GameData.result3PEF = GameData.pefValue;

               




                
              
                Endmenu.transform.GetChild(3).transform.GetChild(0).GetComponent<Text>().text = "FEV: " + GameData.fevValue + " PEF: " + GameData.pefValue;
                //finishScrene.transform.GetChild(1).transform.GetChild(2).GetComponent<Text>().text = GameData.messageResultString;
                Endmenu.transform.GetChild(3).transform.GetChild(1).GetComponent<Text>().text = "Την επόμενη φορά θα τα καταφέρεις καλύτερα. Τέλος Παιχνιδιού";
               
                //resultScene.transform.GetChild(1).GetComponent<Animator>().SetBool("finishCounting", true);



                
            }
			
		}
		//-----------------------------------------------------------------------------------------//
        //                              WRONG- NO SAFE                                                   //
        //-----------------------------------------------------------------------------------------//
		else if(safe==false){
			
			if (GameData.spirometrisesNumber == 1)
            {
                GameData.result1FEV = GameData.fevValue;

                GameData.result1PEF = GameData.pefValue;

               

                
                Endmenu.transform.GetChild(3).transform.GetChild(0).GetComponent<Text>().text = "FEV: " + GameData.fevValue + " PEF: " + GameData.pefValue;
                //resultScene.transform.GetChild(1).transform.GetChild(2).GetComponent<Text>().text = GameData.messageResultString;
                Endmenu.transform.GetChild(3).transform.GetChild(1).GetComponent<Text>().text = "Προσπάθησε πάλι και φύσα πιο δυνατά και συνέχισε για περισσότερη ώρα μέχρι να σου τελειώσει η αναπνοή. Πάμε ξανά!! Είσαι έτοιμος;";
                

               

            }
            else if (GameData.spirometrisesNumber == 2)
            {
                GameData.result2FEV = GameData.fevValue;

                GameData.result2PEF = GameData.pefValue;

                

               
                Endmenu.transform.GetChild(3).transform.GetChild(0).GetComponent<Text>().text = "FEV: " + GameData.fevValue + " PEF: " + GameData.pefValue;
                //resultScene.transform.GetChild(1).transform.GetChild(2).GetComponent<Text>().text = GameData.messageResultString;
                Endmenu.transform.GetChild(3).transform.GetChild(1).GetComponent<Text>().text = "Προσπάθησε πάλι και φύσα πιο δυνατά και συνέχισε για περισσότερη ώρα μέχρι να σου τελειώσει η αναπνοή. Πάμε ξανά!! Είσαι έτοιμος;";
                

               
            }

            else if (GameData.spirometrisesNumber == 3)
            {
                GameData.result3FEV = GameData.fevValue;

                GameData.result3PEF = GameData.pefValue;

               




                
              
                Endmenu.transform.GetChild(3).transform.GetChild(0).GetComponent<Text>().text = "FEV: " + GameData.fevValue + " PEF: " + GameData.pefValue;
                //finishScrene.transform.GetChild(1).transform.GetChild(2).GetComponent<Text>().text = GameData.messageResultString;
                Endmenu.transform.GetChild(3).transform.GetChild(1).GetComponent<Text>().text = "Την επόμενη φορά θα τα καταφέρεις καλύτερα. Τέλος Παιχνιδιού";
               
                //resultScene.transform.GetChild(1).GetComponent<Animator>().SetBool("finishCounting", true);



                
            }
			
		}
		
		////////////////////////////////////////////////////////////////////////////////////////////////////////
		 }
		  if(coll.gameObject.name=="enemy"){
			   isDead=true;
			 enemy.bodyType = RigidbodyType2D.Dynamic;
			 rb2d.bodyType=RigidbodyType2D.Dynamic;
			 
			 enemy.freezeRotation = true;
			 enemy.bodyType=RigidbodyType2D.Kinematic;
				//enemy.AddRelativeForce(Vector2.up*3000000*Time.deltaTime);
				
			 rb2d.transform.eulerAngles = new Vector3(0, 0, -145.0f);
			 rb2d.gravityScale=55.0f;
				rb2d.mass=100.0f;
			 //isDead=true;
			 particles.SetActive(false);
				timeoff.SetActive(false);
			 
			 safe=false;
			 c= panel.color;
					 c.a=0f; 
					 panel.color=c;
					
		 }
		 
		 
	}
	
	void OnTriggerEnter2D(Collider2D trig){
		if(trig.gameObject.tag=="Fence"){
			rb2d.bodyType=RigidbodyType2D.Dynamic;
			rb2d.gravityScale=0;
			//trig.gameObject.GetComponent<Collider2D>().isTrigger=false;
			
			safe=false;
			onDanger=true;
			GameObject.Find("Portal").SetActive(false);
			
		}

		if(trig.gameObject.name=="Portal"){
			secondBackground.SetActive(true);
			reach=true;
		}
		
		if(trig.gameObject.name=="Pass"){
			if(safe==true){
				passed=true;
				
			}
		}
		
		
	}
	
	
	
	void LateUpdate(){
		
		pos=rb2d.transform.position.y;
		nowspeed=wspeed;
		
	}
	
}
