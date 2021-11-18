using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ComboState { 
    NONE,
    PUNCH_1,
    PUNCH_2,
    PUNCH_3,
    KICK_1,
    KICK_2
}

public class PlayerAttack : MonoBehaviour {

    private CharacterAnimation player_Anim;

    private bool activateTimerToReset;

    private float default_Combo_Timer = 0.4f;
    private float current_Combo_Timer;

    private ComboState current_Combo_State;

    void Awake() {
        player_Anim = GetComponentInChildren<CharacterAnimation>();
    }

    void Start() {
        current_Combo_Timer = default_Combo_Timer;
        current_Combo_State = ComboState.NONE;
    }

    // Update is called once per frame
    void Update() {
        ComboAttacks();
        ResetComboState();
    }

    void ComboAttacks() { 

        if(Input.GetKeyDown(KeyCode.Z)) {

            if (current_Combo_State == ComboState.PUNCH_3 ||
                current_Combo_State == ComboState.KICK_1 ||
                current_Combo_State == ComboState.KICK_2)
                return;

            current_Combo_State++;
            activateTimerToReset = true;
            current_Combo_Timer = default_Combo_Timer;

            if(current_Combo_State == ComboState.PUNCH_1) {
                player_Anim.Punch_1();
            }

            if (current_Combo_State == ComboState.PUNCH_2) {
                player_Anim.Punch_2();
            }

            if (current_Combo_State == ComboState.PUNCH_3) {
                player_Anim.Punch_3();
            }

        } // if punch

        if (Input.GetKeyDown(KeyCode.X)) {

            // if the current combo is punch 3 or kick 2
            // return meaning exit because we have no combos to perform
            if (current_Combo_State == ComboState.KICK_2 ||
                current_Combo_State == ComboState.PUNCH_3)
                return;

            // if the current combo state is NONE, or punch1 or punch2
            // then we can set current combo state to kick 1 to chain the combo
            if(current_Combo_State == ComboState.NONE ||
                current_Combo_State == ComboState.PUNCH_1 ||
                current_Combo_State == ComboState.PUNCH_2) {

                current_Combo_State = ComboState.KICK_1;

            } else if(current_Combo_State == ComboState.KICK_1) {
                // move to kick2
                current_Combo_State++;
            }

            activateTimerToReset = true;
            current_Combo_Timer = default_Combo_Timer;

            if(current_Combo_State == ComboState.KICK_1) {
                player_Anim.Kick_1();
            }

            if (current_Combo_State == ComboState.KICK_2) {
                player_Anim.Kick_2();
            }


        } // if kick



    } // combo attacks

    void ResetComboState() { 
    
        if(activateTimerToReset) {

            current_Combo_Timer -= Time.deltaTime;

            if(current_Combo_Timer <= 0f) {

                current_Combo_State = ComboState.NONE;

                activateTimerToReset = false;
                current_Combo_Timer = default_Combo_Timer;

            }

        }

    } // reset combo state

} // class
































