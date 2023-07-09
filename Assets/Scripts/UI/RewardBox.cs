using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;
using System;

public class RewardBox : MonoBehaviour {
    static float currentRewardIndex = 0;
    const int TOTAL_REWARDS = 5;
	[SerializeField] Image progressBarFill;
    [SerializeField] Transform rewardsCheckMarksParent;
    private float startValue;
    private float endValue;
    private float duration;
    private float currentRewardIndex2;
    public ItemUI TargetCoinObject;
    public void WatchAdButtonClick(){
        AdClose();
    }
    private void OnEnable() {
        if(TargetCoinObject!=null){
            if(CheckInt(currentRewardIndex)){
                ActiveTextCoin((int)Math.Floor(currentRewardIndex2+1));
            }
            WatchAdButtonClick();
        }
    }
    private void Start() {
        LoadDulieu(2.4f);
        WatchAdButtonClick();
    }
    public void AdClose(){
        //on ad closed
		if ( true ) {
			//User watched the full AD
			//watchAdButton.interactable = false;
			//currentReward = userRewards [ currentRewardIndex ];
            if(CheckInt(currentRewardIndex)){
                currentRewardIndex += RandomNumber(0.4f,0.7f,2);
                currentRewardIndex2 = currentRewardIndex;
            }else{
                currentRewardIndex = (float)Math.Floor(currentRewardIndex+1);
                currentRewardIndex2 = currentRewardIndex-1;
            }
			float progressValue = (float)currentRewardIndex / TOTAL_REWARDS;

			progressBarFill.DOFillAmount ( progressValue, 1.5f ).OnComplete(
                ()=>{           
                    if(CheckInt(currentRewardIndex)){                       
                       Debug.Log("dang cap nhap"+currentRewardIndex2);
                    }
                }
                )
                .OnUpdate(
                    ()=>{
                        float flagText = (float)Math.Round((progressBarFill.fillAmount*5-(int)currentRewardIndex2),2)*100;
                        
                        UpdateTextCoin((int)Math.Floor(currentRewardIndex2),flagText!=100?flagText+"": "Coin");
                    }
                );
               
			
		} else {
			//User didn't complete the AD
			//watchAdButton.interactable = true;
		}
    }
      void OnGUI()
    {
        //Delete all of the PlayerPrefs settings by pressing this button.
        if (GUI.Button(new Rect(100, 200, 200, 60), "Delete"))
        {
            PlayerPrefs.DeleteAll();
        }
    }
    void RewardUser ( ) {
       
		//watchAdButton.interactable = true;

		//Check Reward type
		//cap nhap ui luu phan thuong


		// UpdateRemainingRewardsTextUI ( );
		// UpdateWatchedADsTextUI ( );

		//MarkRewardAsCheked ( (int)Math.Floor(currentRewardIndex) - 1 );

		
	}

    void MarkRewardAsCheked ( int rewardIndex ) {
        rewardsCheckMarksParent.GetChild ( rewardIndex ).gameObject.SetActive ( true );
    }
    void UpdateTextCoin ( int rewardIndex, string updateNumber ) {
        rewardsCheckMarksParent.GetChild(rewardIndex ).GetComponent<ItemUI>().TextCoin.text = updateNumber;
    }

    void ActiveTextCoin(int rewardIndex){
        if(TargetCoinObject!= null && TargetCoinObject.transform.GetSiblingIndex() != rewardIndex){
            TargetCoinObject.gameObject.GetComponent<ItemUI>().Actived();
        }
        if(rewardIndex>= rewardsCheckMarksParent.childCount){
            LoadDulieu(0);
            return;
        }
        TargetCoinObject = rewardsCheckMarksParent.GetChild(rewardIndex).GetComponent<ItemUI>();
        TargetCoinObject.Activeting();
    }

    public float RandomNumber(float min, float max, int limit){
        return (float)Math.Round(UnityEngine.Random.Range (min, max), limit);
    }

    public bool CheckInt(float myFloat){ 
     
        float decimalPart = myFloat - Mathf.Floor(myFloat);
      
        if(decimalPart == 0){
            return true;
        }else{
            return false;
        }
    }

    public float ReadFloatEdit(float myFloat, float indexDividePart){
        float flag= myFloat / (indexDividePart/TOTAL_REWARDS);
        return flag*100;
    }

    void LoadDulieu(float test){
        int checkSave = (int)Mathf.Floor(test);
        int count = rewardsCheckMarksParent.childCount;
        float progressValue = (float)test / TOTAL_REWARDS;
        progressBarFill.fillAmount = progressValue;
        for(int i = 0; i<count; i++){
            if(i<checkSave){
                rewardsCheckMarksParent.GetChild(i).GetComponent<ItemUI>().Actived();
            }else if(i==checkSave){
                rewardsCheckMarksParent.GetChild(i).GetComponent<ItemUI>().Activeting();
            }else{
                rewardsCheckMarksParent.GetChild(i).GetComponent<ItemUI>().ActiveAwait();
            }
        }
        currentRewardIndex = test;
        TargetCoinObject = rewardsCheckMarksParent.GetChild(checkSave).GetComponent<ItemUI>();
        currentRewardIndex2 = currentRewardIndex;
    }
}